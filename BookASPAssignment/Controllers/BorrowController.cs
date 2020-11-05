using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookASPAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualBasic;

namespace BookASPAssignment.Controllers
{
    public class BorrowController : Controller
    {
        List<Borrow> Borrows = new List<Borrow>();
        public IActionResult Index()
        {
             return RedirectToAction("List");
        }
        public static void ExtendDueDateForBorrowByID(string bookID)
        {
            using LibraryContext context = new LibraryContext();
            Borrow savedObject = context.Borrows.Where(x => x.BookID == int.Parse(bookID)).LastOrDefault();
            savedObject.DueDate = savedObject.DueDate.AddDays(7);
        }
        public static void ReturnBorrowByID(string bookID)
        {
            using LibraryContext context = new LibraryContext();
            Borrow savedObject = context.Borrows.Where(x => x.BookID == int.Parse(bookID)).LastOrDefault();
            savedObject.ReturnedDate = DateTime.Today;
        }
        
        public void CreateBorrow(string id)
        {
            int parsedID = int.Parse(id);

            if (!Borrows.Exists(x => x.Book.ID == parsedID))
            {

                Borrow borrow = new Borrow()
                {
                    CheckedOutDate = DateTime.Today,
                    DueDate = DateTime.Now.AddDays(14)
                };
            } 
            else
            {
                throw new Exception("That Book ID already exists!");
            }
        }
    }
}
