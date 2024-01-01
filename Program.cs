using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment
{
    class Owner
    {
        public int OwnerID;
        public string OwnerName;
        public double TotalProfit;

        double TaxDeduction = 0.1;
        double NetProfit;

        public Owner(int ownerID, string ownerName, double totalProfit)
        {
            this.OwnerID = ownerID;
            this.OwnerName = ownerName;
            this.TotalProfit = totalProfit;

        }

        void CalculateProfit()
        {
          if (TotalProfit >= 30000)
            {
               NetProfit = TotalProfit - (TaxDeduction * TotalProfit);
                Console.WriteLine("Your total profit is: {0}", NetProfit);
            }
           else
            {
                Console.WriteLine("Your total profit is: {0}", TotalProfit);
            }
        
        }  
        public void ShowOwnerDetails()
        {
            Console.WriteLine("OwnerID is : {0}", this.OwnerID);
            Console.WriteLine("OwnerName is : {0}", this.OwnerName);
            this.CalculateProfit();
       
        }


    }
}   
