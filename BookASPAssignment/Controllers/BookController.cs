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

namespace BookASPAssignment.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult Create(string id, string title, string authorID, string publicationDate)
        {
            if (id != null && title != null && authorID != null && publicationDate != null)
            {
                try
                {
                    CreateBook(id , title, publicationDate, authorID);
                    ViewBag.SuccessfulCreation = true;
                    ViewBag.Status = $"Successfully added book ID {id}";
                }
                catch (Exception e)
                {
                    ViewBag.SuccessfulCreation = false;
                    ViewBag.Status = $"An error occured. {e.Message}";
                }
            }
            ViewBag.Authors = AuthorsController.GetAuthors();
           
            return View();
        }

        public IActionResult List()
        {
              ViewBag.Books = GetBooks();
              return View();
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
            ExtendDueDateForBookByID(bookID);
            return RedirectToAction("Details", new Dictionary<string, string>() { { "bookID", bookID } });
        }

        public IActionResult Return(string bookID)
        {
            ReturnBookByID(bookID);
            return RedirectToAction("Details", new Dictionary<string, string>() { { "BookId", bookID } });
        }

        public IActionResult Delete(string id)
        {
            DeleteBookByID(id);
            return RedirectToAction("List");
        }

        public IActionResult Borrow(string bookID, string checkedOutDate, string returnedDate)
        {
            BorrowController.CreateBorrow(  bookID);
            return RedirectToAction("Details", new Dictionary<string, string>() { { "BookId", bookID } });
           
        }

        public void CreateBook(string id, string title, string publicationDate, string authorID)
        {
            int parsedID = 0;

            id = id != null ? id.Trim() : null;
            title = title != null ? title.Trim() : null;
            authorID = authorID != null ? authorID.Trim() : null;

            //ValidationException exception = new ValidationException();
            using (LibraryContext context = new LibraryContext())
            {
                context.Books.Add(new Book()
                {
                    ID = int.Parse(id),
                    Title = title,
                    PublicationDate = DateTime.Parse(publicationDate),
                   
                    AuthorID = int.Parse(authorID)
                }) ;
                context.SaveChanges();
            }
                
            
        }
        public List<Borrow> GetOverDueBooks()
        {
            List<Borrow> results;
            using (LibraryContext context = new LibraryContext())
            {
                DateTime today = DateTime.Now;
                results = context.Borrows.Where(x => x.DueDate > today).ToList();
            }
            return results;
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
        public Book GetBookByID(string id)
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Books.Where(x => x.ID == int.Parse(id)).Include(x => x.Author).Include(x => x.Borrows).SingleOrDefault();
            }
        }

        public void ExtendDueDateForBookByID(string bookID)
        {
            BorrowController.ExtendDueDateForBorrowByID(bookID);
        }

        public void ReturnBookByID(string bookID)
        {
            BorrowController.ReturnBorrowByID(bookID);
        }

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

