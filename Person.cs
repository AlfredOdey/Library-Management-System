
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
        private string Email { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name:\nEmail:");
        }

        public class Member : Person
        {
            private string name;
            private string email;

            public override void DisplayInfo()
            {
                Console.WriteLine("Name: Alfred\nEmail: alfredmodey@gmail.com");
            }
        }
    }
    
}
