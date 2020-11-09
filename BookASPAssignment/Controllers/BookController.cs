using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookASPAssignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using BookASPAssignment.Models.Exceptions;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BookASPAssignment.Controllers
{
    public class BookController : Controller
    {
      /*
       
       Author: Ummer Zaman
      Last Edited: 09 Nov 2020
      Citations: Mostly from the class tutorials.
      Some Help from Birm and Aaron at couple of times
       Used microsoft documentation for linq queries reference */  

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult Create(string id, string title, string authorID, string publicationDate)
        {
            if (Request.Query.Count > 0)
            {
                try
                {
                    CreateBook(id , title, publicationDate, authorID);
                    ViewBag.Message = $"Successfully added book  {title}";
                }
                catch (ValidationException e)
                {
                    ViewBag.ID = id;
                    ViewBag.Title = title;
                    ViewBag.PublicationDate = publicationDate;
                    ViewBag.AuthorID = authorID;
                    
                    ViewBag.Message = "There is a Problem with the Submission. Check Below.";
                    ViewBag.Exception = e;
                    ViewBag.Error = true;
                }
            }
            ViewBag.Authors = AuthorsController.GetAuthors();
           
            return View();
        }

        public IActionResult List(String filter)
        {
            if (filter == "overduedbooks")
            {
                ViewBag.Books = GetOverDueBooks(filter);
                ViewBag.Filter = true;
            }
            else
            {
                ViewBag.Books = GetBooks();
                ViewBag.Filter = false;
            }
           
            return View();
        }

        /**************************************************
         * Citation: Used class Tutorial for Validation 
         * ***********************************************/
        public IActionResult BorrowCreate(string bookID, string checkedOutDate, string returnedDate)
        {
            
            if (Request.Query.Count > 0)
            {

                try
                {
                    BorrowController.CreateBorrow(bookID);

                    ViewBag.Message = $"Borrow Successful for Book {bookID}";

                }
                catch (ValidationException e)
                {
                    ViewBag.CheckedOutDate = checkedOutDate;
                    ViewBag.ReturnedDate = returnedDate;
                    ViewBag.Message = "There is a problem with the Submission.";
                    ViewBag.Exception = e;
                    ViewBag.Error = true;
                }
            }
            return View("Details");
        }
        public static List<Book> GetOverDueBooks(string filter)
        {
            List<Book> results;
            using (LibraryContext context = new LibraryContext())
            {
                List<Book> overdueBooks = context.Borrows.Include(x => x.Book).Where(y => y.DueDate < DateTime.Now).Select(z => z.Book).ToList();
                results = context.Books.Include(x => x.Author).Include(x => x.Borrows).Where(x => overdueBooks.Contains(x)).ToList();
            }
            return results;
        }

        public IActionResult Details(string id)
        {
            try
            {
                ViewBag.Book = GetBookByID(id);
            }
            catch
            {
                Console.WriteLine("details not found");
            }
            return View();
        }

        public IActionResult Extend(string bookID)
        {
            try
            {
                BorrowController.ExtendDueDateForBorrowByID(bookID);
                ViewBag.Message = $"Extension Successfull{bookID}";
            }
            catch(ValidationException e)
            {
                ViewBag.Message = "There is a problem with the Extension.";
                ViewBag.Exception = e;
                ViewBag.Error = true;
            }
            return View("Details");
        }

        public IActionResult Return(string bookID)
        {
            try
            {
                ReturnBookByID(bookID);
                ViewBag.Message = $"Return Succesfull!";

            }
            catch
            {
                ViewBag.Message = $"Problem Occured!";
            }
           return View("Details");
        }

        public IActionResult Delete(string id)
        {
            DeleteBookByID(id);
            ViewBag.Message = $"Book with ID {id} has been deleted!";
            return View("Details");
        }


        public void CreateBook(string id, string title, string publicationDate, string authorID)
        {
            
            ValidationException exception = new ValidationException();

            id = id != null ? id.Trim() : null;
            title = title != null ? title.Trim().ToUpper() : null;
            authorID = authorID != null ? authorID.Trim() : null;

            if (string.IsNullOrWhiteSpace(id))
            {
                exception.ValidationExceptions.Add(new Exception(" ID Not Provided"));
            }
            if (id.Length > 10)
            {
                exception.ValidationExceptions.Add(new Exception("The Book ID Cannot be more than length of 10 !"));
            }

            
            /**********************************************************
            * Will throw Exception if No Title Provided
            * *******************************************************/
            if (string.IsNullOrWhiteSpace(title))
            {
                exception.ValidationExceptions.Add(new Exception("Name Not Provided"));
            }

            /**********************************************************
             * Will throw Exception if Publication Date is in Future
             * *******************************************************/
           if (DateTime.Parse(publicationDate) > DateTime.Now )
            {
                exception.ValidationExceptions.Add(new Exception("Publication Date Cannot be in future!"));
            }

            
            using (LibraryContext context = new LibraryContext())
            {
                
               if(context.Books.Any(x => x.ID == int.Parse(id)))
                {
                    //IF ID Already Exists.
                    exception.ValidationExceptions.Add(new Exception("The ID you Provided already exists!"));
                }
                   //IF TItle Already Exists to the Author.
                if (context.Books.Where(x => x.AuthorID == int.Parse(authorID)).Any(x => x.Title == title.Trim().ToUpper()))
                {
                    exception.ValidationExceptions.Add(new Exception("The Book Title already exists with that Author!"));
                 }
                 // if The Title of the Book exceeds its Charactor Limit!
                if (title.Length > 100)
                {
                    exception.ValidationExceptions.Add(new Exception("The Book Title Cannot be more than 100 Charectors!"));
                }
                


                if (exception.ValidationExceptions.Count > 0)
                {
                    throw exception;
                }
                context.Books.Add(new Book()
                {
                    ID = int.Parse(id),
                    Title = title.Trim().ToUpper(),
                    PublicationDate = DateTime.Parse(publicationDate),
                   
                    AuthorID = int.Parse(authorID)
                }) ;
                context.SaveChanges();
            }
                
            
        }

        public List<Book> GetBooks()
        {
            List<Book> results;
            using (LibraryContext context = new LibraryContext())
            {
                results =  context.Books.Include(y => y.Borrows).Include(x => x.Author).ToList();
            }
          return results;
        }
        // Getting a specific by their IDs
        public Book GetBookByID(string id)
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Books.Where(x => x.ID == int.Parse(id)).Include(x => x.Author).Include(x => x.Borrows).SingleOrDefault();
            }
        }
        //Taking the Method from  the Borrow Controller
        

        public void ReturnBookByID(string bookID)
        {
            BorrowController.ReturnBorrowByID(bookID);
        }

        //Method used to Delete a Book using its ID
        public void DeleteBookByID(string id)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.Books.Remove(GetBookByID(id));
                context.SaveChanges();
            }
        }
     

    }
}

