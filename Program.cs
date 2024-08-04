using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Console.Write("Enter name: ");
            string memberName = Console.ReadLine();
            Console.Write("Enter email address: ");
            string emailAddy = Console.ReadLine();
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine();

            Member member1 = new Member(1, memberName, emailAddy);

            library.RegisterMember(member1);

            Book book1 = new Book("Far From The End", "Lilian Chidiogo Ezejelue", "9789789744220");
            Book book2 = new Book("The Martian", "Andy Weir", "9780804139021");

            library.AddBook(book1);
            library.AddBook(book2);

            library.BorrowBook(1, 1, "9789789744220");
            library.BorrowBook(2, 1, "9780804139021");

            if (!string.IsNullOrEmpty(memberName) && !string.IsNullOrEmpty(emailAddy))
            {
                Console.WriteLine($"Welcome, {memberName}");
                Console.WriteLine();
                Console.WriteLine("AVAILABLE BOOKS");
                library.DisplayAllbooks();
                Console.WriteLine("REGISTERED MEMBERS");
                library.DisplayAllMembers();
                Console.WriteLine("BORROW TRANSACTIONS");
                library.DisplayAllTransactions();
            }
            else
            {
                Console.WriteLine("You have to enter your name and email address.");
                Console.WriteLine();
            }


        }
    }
}
