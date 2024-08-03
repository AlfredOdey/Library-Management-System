
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{

    public abstract class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}\nEmail:{Email}");
        }
    }
    public class Member : Person
    {
        public int MemberId { get; private set; }
        public Member(int memberId, string name, string email) : base(name, email)
        {
            MemberId = memberId;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($" Member ID: {MemberId}\n Name: {Name}\n Email: {Email}");
            Console.WriteLine();
        }
    }
     
}
