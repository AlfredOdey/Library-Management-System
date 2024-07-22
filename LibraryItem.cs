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
        public abstract string Title { get; set; }
        public abstract string Author { get; set; }
        public abstract void GetInfo();

    }

    public class Book : LibraryItem
    {
        public override string Title { get; set; }
        public override string Author { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Title: Far From The End\nAuthor: Lilian Chidiogo Ezejelue");
        }
    }
}
