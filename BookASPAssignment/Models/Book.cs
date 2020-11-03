using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookASPAssignment.Models
{
    public class Book
    {
        private int _id;
        public int ID => _id;

        private string _title;
        public string Title => _title;

        private string _author;
        public string Author => _author;

        private DateTime _publicationDate;
        public DateTime PublicationDate => _publicationDate;

        private DateTime _checkedOutDate;
        public DateTime CheckedOutDate => _checkedOutDate;

        public DateTime DueDate { get; set; }

        public DateTime? ReturnedDate { get; set; }


        public Book(int id, string title, string author, DateTime publicationDate, DateTime checkedOutDate)
        {
            _id = id;
            _title = title;
            _author = author;
            _publicationDate = publicationDate;
            _checkedOutDate = checkedOutDate;
            DueDate = CheckedOutDate.AddDays(14);
            ReturnedDate = null;
        }
    }
}
