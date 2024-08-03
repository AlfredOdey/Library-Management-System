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
            Member member2 = new Member(2, "Ese", "odeyalfred0@gmail.com");

            library.RegisterMember(member1);
            library.RegisterMember(member2);

            Book book1 = new Book("Far From The End", "Lilian Chidiogo Ezejelue", "1234");
            Book book2 = new Book("Purple Hibiscus", "Chimamanda Ngozi Adichie", "5678");

            library.AddBook(book1);
            library.AddBook(book2);

            library.BorrowBook(1, 1, "1234");
            library.BorrowBook(2, 2, "5678");

            Console.WriteLine("All books...");
            library.DisplayAllbooks();

            Console.WriteLine("All members...");
            library.DisplayAllMembers();

            Console.WriteLine("All borrow transactions...");
            library.DisplayAllTransactions();

            Console.WriteLine();

        }
    }
}
