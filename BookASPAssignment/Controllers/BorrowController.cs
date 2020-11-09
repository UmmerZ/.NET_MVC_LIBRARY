using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookASPAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
namespace BookASPAssignment.Controllers
{ 
    public class BorrowController : Controller
{

    public IActionResult Index()
    {
        return RedirectToAction("List");
    }
    public IActionResult Create(string bookID, string checkedOutDate, string returnedDate)
        {
            try
            {
                CreateBorrow(bookID);
                ViewBag.SuccessfulCreation = true;
                ViewBag.Status = $"Successfully added book ID {bookID}";
            }
            catch (Exception e)
            {
                ViewBag.SuccessfulCreation = false;
                ViewBag.Status = $"An error occured. {e.Message}";
            }


            return View();
    }

        public static void ExtendDueDateForBorrowByID(string bookID)
        {
            using (LibraryContext context = new LibraryContext())
            {

                Borrow extendBorrow = context.Borrows.Where(x => x.BookID == int.Parse(bookID)).SingleOrDefault();
                extendBorrow.ExtentionCount++;
                extendBorrow.DueDate = extendBorrow.DueDate.AddDays(7);
                context.SaveChanges();
            }
        }
    public static void ReturnBorrowByID(string bookID)
    {
            using (LibraryContext context = new LibraryContext())
            {
                Borrow returnBorrow = context.Borrows.Where(x => x.BookID == int.Parse(bookID)).SingleOrDefault();
                returnBorrow.ReturnedDate = DateTime.Today;            context.SaveChanges();
            }
                
    }

    public static void CreateBorrow(string bookID)
    {
        using (LibraryContext context = new LibraryContext())
        {

                if (context.Borrows.Any(x => x.BookID != int.Parse(bookID)))
                {
                    context.Borrows.Add(new Borrow()
                    {
                        BookID = int.Parse(bookID),
                        CheckedOutDate = DateTime.Today.AddDays(0),
                      
                        DueDate = DateTime.Today.AddDays(14)
                    });
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Book  already Borrowed!");
                }

            }
    }
//        public static Borrow GetBorrowByID(string bookID)
//        { 
//            using (LibraryContext context = new LibraryContext())
//            {
//                return context.Borrows.Where(x => x.BookID == int.Parse(bookID)).SingleOrDefault();
//            }
            
//        }
}
}
