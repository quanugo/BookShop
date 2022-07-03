using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRN292_Project.Entity
{
    public class Book
    {
        public Book(int bookID, string bookName, string author, string publisher, DateTime publishedDate, double price, string genre, string description, string imagePath)
        {
            BookID = bookID;
            BookName = bookName;
            Author = author;
            Publisher = publisher;
            PublishedDate = publishedDate;
            this.price = price;
            this.genre = genre;
            this.description = description;
            this.imagePath = imagePath;
        }

        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
        public double price { get; set; }
        public string genre { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
    }
}