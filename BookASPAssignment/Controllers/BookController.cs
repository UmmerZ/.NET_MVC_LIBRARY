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
            Debug.WriteLine("ACTION - Index Action");
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            Debug.WriteLine("ACTION - List Action");
            ViewBag.Books = Books;
            return View();
        }
        public IActionResult Create(int _id, string _title, DateTime _publicatondate, DateTime _checkedoutdate)
        {
            
                Debug.WriteLine("ACTION - Index Action");
                CreateBook(_id, _title.Trim(), _publicatondate, _checkedoutdate);
                return RedirectToAction("List");
          
            

        }
        public static List<Book> Books = new List<Book>();
        public void CreateBook(int _id, string _title, DateTime _publicatondate, DateTime _checkedoutdate)
        {
            Books.Add(new Book(_id, _title, _publicatondate, _checkedoutdate)
        );
            
            Console.WriteLine($"You have successfully checked out /*book.booktitle*/ until /*DueDate*/.");
        }
      

        public Book GetBookByID(int _id)
    {
        return Books.Where(x => x.ID == _id).SingleOrDefault();
    }
        /****************************************************************
        Below code  Borrowed from .https://docs.microsoft.com/en-us/dotnet/api/system.datetime.adddays?view=netcore-3.1
        *****************************************************************/
        public DateTime  ExtendDueDateForBookByID()
        {
            DateTime today = DateTime.Now;
               DateTime  DueDate = today.AddDays(7);
            return DueDate;
            
            
        }

        //    public void ReturnBookByID()
        //{

        //}
        //    //public void DeleteBookByID(int _id)
        //    //{
        //    //    Books.Remove(new Book()
        //    //    {
        //    //        ID = _id
        //    //    }
        //    //        ); ;
        //    //}


    }
}

