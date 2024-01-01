using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment
{
     class Program
    {
         static void Main(string[] args)
        {
            //    Owner owner = new Owner( 123,"Ankita", 25000 );
            //    owner.ShowOwnerDetails();
            //    Console.ReadLine();

            string name;
            string reverse = "";
            Console.WriteLine("Enter String To Be Reverse");
            name = Console.ReadLine();

            Console.WriteLine("string is : {0}", name);
            int length = name.Length -1;

            while (length >= 0)
            { 
                reverse = reverse + name[length];
                length--;
            }
            Console.WriteLine("reverse : {0}", reverse);
            Console.ReadLine();
        }

    }
}
