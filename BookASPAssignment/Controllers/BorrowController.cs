using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookASPAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
using BookASPAssignment.Models.Exceptions;

namespace BookASPAssignment.Controllers
{ 
    public class BorrowController : Controller
{

    public IActionResult Index()
    {
        return RedirectToAction("List");
    }
    

        public static void ExtendDueDateForBorrowByID(string bookID)
        {
            using (LibraryContext context = new LibraryContext())
            {
                ValidationException exception = new ValidationException();



                Borrow extendBorrow = context.Borrows.Where(x => x.BookID == int.Parse(bookID)).SingleOrDefault();
                // will not let Books to Extend more # times
                if(extendBorrow.ExtentionCount >= 3)
                {
                    exception.ValidationExceptions.Add(new Exception("You can Extend  only 3 times!"));
                }
                // Will throw Exception if Extension tried on Overdue books
                if (extendBorrow.DueDate < DateTime.Now)
                {
                    exception.ValidationExceptions.Add(new Exception("Sorry! Cannot extend OverDue Books!"));
                }
               
                if (exception.ValidationExceptions.Count > 0)
                {
                    throw exception;
                }

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
                ValidationException exception = new ValidationException();

                

                if (context.Borrows.Any(x => x.BookID != int.Parse(bookID)))
                {

                    
                    context.Borrows.Add(new Borrow()
                    {
                        BookID = int.Parse(bookID),
                        CheckedOutDate = DateTime.Today,
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
      
    
    }
}
