using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    
    public class BorrowTransaction
    {
        public int TransactionId { get; private set; }
        public Member Borrower { get; private set; }
        public Book BorrowedBook { get; private set; }
        public DateTime BorrowDate { get; private set; }

        public BorrowTransaction(int transactionId, Member borrower, Book borrowedBook)
        {
            TransactionId = transactionId;
            Borrower = borrower;
            BorrowedBook = borrowedBook;
            BorrowDate = DateTime.Now;
        }

        public void DisplayTransactionInfo()
        {
            Console.WriteLine($" Transaction ID: {TransactionId}\n Book: {BorrowedBook.Title}\n Borrower: {Borrower.Name}\n Borrow Date: {BorrowDate}");
            Console.WriteLine();
        }
    }
    
}
