using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }

        protected LibraryItem(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public abstract void GetInfo();

    }

    public class Book : LibraryItem
    {
        public string ISBN { get; private set; }
        public Book(string title, string author, string isbn) : base(title, author)
        {
            ISBN = isbn;
        }
        public override void GetInfo()
        {
            Console.WriteLine($" Title: {Title}\n Author: {Author}\n ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
