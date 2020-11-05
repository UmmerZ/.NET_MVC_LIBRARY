//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using BookASPAssignment.Models;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.VisualBasic;

//namespace BookASPAssignment.Controllers
//{
//    public class BookController : Controller
//    {
//        public IActionResult Index()
//        {
//            return RedirectToAction("List");
//        }

//        public IActionResult Create(string id, string title, string author, string publicationDate, string checkedOutDate)
//        {
//            if (id != null && title != null && author != null && publicationDate != null && checkedOutDate != null)
//            {
//                try
//                {
//                    CreateBook(id, title, author, publicationDate, checkedOutDate);
//                    ViewBag.SuccessfulCreation = true;
//                    ViewBag.Status = $"Successfully added book ID {id}";
//                }
//                catch (Exception e)
//                {
//                    ViewBag.SuccessfulCreation = false;
//                    ViewBag.Status = $"An error occured. {e.Message}";
//                }
//            }

//            return View();
//        }

//        public IActionResult List()
//        {
//            ViewBag.Books = Books;
//            return View();
//        }

//        public IActionResult Details(string id)
//        {
//            try
//            {
//                ViewBag.Book = GetBookByID(id);
//            }
//            catch
//            {

//            }
//            return View();
//        }

//        public IActionResult Extend(string id)
//        {
//            ExtendDueDateByID(id);
//            return RedirectToAction("Details", new Dictionary<string, string>() { { "id", id } });
//        }

//        public IActionResult Return(string id)
//        {
//            ReturnBookByID(id);
//            return RedirectToAction("Details", new Dictionary<string, string>() { { "id", id } });
//        }

//        public IActionResult Delete(string id)
//        {
//            DeleteBookByID(id);
//            return RedirectToAction("List");
//        }

//        public static List<Book> Books = new List<Book>()
//        {

//            new Book(1, "Test Book", "Test Author", new DateTime(1990, 01, 01), new DateTime(2020, 10, 28)),
//            new Book(2, "Another Book", "Test Author", new DateTime(1990, 03, 03), new DateTime(2020, 10, 20))

//        };

//        public void CreateBook(string id, string title, string author, string publicationDate, string checkedOutDate)
//        {
//            int parsedID = int.Parse(id);

//            if (!Books.Exists(x => x.ID == parsedID))
//            {
//                Books.Add(new Book(parsedID, title.Trim(), author.Trim(), DateTime.Parse(publicationDate), DateTime.Parse(checkedOutDate)));
//            }
//            else
//            {
//                throw new Exception("That Book ID already exists!");
//            }
//        }

//        public Book GetBookByID(string id)
//        {
//            return Books.Where(x => x.ID == int.Parse(id)).Single();
//        }

//        public void ExtendDueDateByID(string id)
//        {
//            GetBookByID(id).DueDate = GetBookByID(id).DueDate.AddDays(7);
//        }

//        public void ReturnBookByID(string id)
//        {
//            GetBookByID(id).ReturnedDate = DateTime.Today;
//        }

//        public void DeleteBookByID(string id)
//        {
//            Books.Remove(GetBookByID(id));
//        }


//    }
//}

