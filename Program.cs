using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Member member1 = new Member(1, "Alfred", "alfredmodey@gmail.com");

            library.RegisterMember(member1);

            Book book1 = new Book("Far From The End", "Lilian Chidiogo Ezejelue", "9789789744220");
            Book book2 = new Book("The Martian", "Andy Weir", "9780804139021");

            library.AddBook(book1);
            library.AddBook(book2);

            library.BorrowBook(1, 1, "9789789744220");
            library.BorrowBook(2, 1, "9780804139021");

            Console.WriteLine("AVAILABLE BOOKS");
            library.DisplayAllbooks();

            Console.WriteLine("REGISTERED MEMBERS");
            library.DisplayAllMembers();

            Console.WriteLine("BORROW TRANSACTIONS");
            library.DisplayAllTransactions();


        }
    }
}
