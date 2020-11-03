using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookASPAssignment.Models
{
    public class Book
    {
        public int ID { get; }

        public string Title { get; }

        public DateTime PublicationDate { get;  }

        public DateTime CheckedOutDate { get;  }

        public DateTime DueDate { get; set; }

        public DateTime ReturnedDate { get; set; }
        
        public string Author { get; }

        public  Book( int _id, string _title, DateTime _publicatondate, DateTime _checkedoutdate)
        {
            ID = _id;
            Title = _title;
            PublicationDate = _publicatondate;
            CheckedOutDate = _publicatondate.AddDays(14);
        }
    }
}
