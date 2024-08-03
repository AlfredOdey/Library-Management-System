using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    
    public class Library
    {
        private List<Book> books;
        private List<Member> members;
        private List<BorrowTransaction> transactions;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
            transactions = new List<BorrowTransaction>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RegisterMember(Member member)
        {
            members.Add(member);
        }

        public void BorrowBook(int transactionId, int memberId, string isbn)
        {

            Member member = members.Find(m => m.MemberId == memberId);
            Book book = books.Find(b => b.ISBN == isbn);

            BorrowTransaction transaction = new BorrowTransaction(transactionId, member, book);
            transactions.Add(transaction);
        }
        public void DisplayAllbooks()
        {
            foreach (var book in books)
            {
                book.GetInfo();
            }
        }
        public void DisplayAllMembers()
        {
            foreach (var member in members)
            {
                member.DisplayInfo();
            }
        }
        public void DisplayAllTransactions()
        {
            foreach (var  transaction in transactions)
            {
                transaction.DisplayTransactionInfo();
            }
        }
    }
    
}
