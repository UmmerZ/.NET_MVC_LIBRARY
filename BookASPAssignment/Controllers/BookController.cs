using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookASPAssignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

namespace BookASPAssignment.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        //public IActionResult Create(string id, string title, string author, string publicationDate, string checkedOutDate)
        //{
        //    if (id != null && title != null && author != null && publicationDate != null && checkedOutDate != null)
        //    {
        //        try
        //        {
        //            CreateBook(id, title, author, publicationDate, checkedOutDate);
        //            ViewBag.SuccessfulCreation = true;
        //            ViewBag.Status = $"Successfully added book ID {id}";
        //        }
        //        catch (Exception e)
        //        {
        //            ViewBag.SuccessfulCreation = false;
        //            ViewBag.Status = $"An error occured. {e.Message}";
        //        }
        //    }

        //    return View();
        //}

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

            }
            return View();
        }

        public IActionResult Extend(string bookID)
        {
            ExtendDueDateForBookByID(bookID);
            return RedirectToAction("Details", new Dictionary<string, string>() { { "bookID", bookID } });
        }

        public IActionResult Return(string id)
        {
            ReturnBookByID(id);
            return RedirectToAction("Details", new Dictionary<string, string>() { { "id", id } });
        }

        public IActionResult Delete(string id)
        {
            DeleteBookByID(id);
            return RedirectToAction("List");
        }

        List<Book> Books = new List<Book>();

        public void CreateBook()
        {
            Books.Add(new Book());
        }

       public List<Book> GetBooks()
        {
            List<Book> results;
            using (LibraryContext context = new LibraryContext())
            {
                results = context.Books.ToList();
            }
            return results;
        }
        public Book GetBookByID(string id)
        {
            return Books.Where(x => x.ID == int.Parse(id)).Single();
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
            Books.Remove(GetBookByID(id));
        }


    }
}

