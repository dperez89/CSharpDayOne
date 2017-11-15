using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            float hoursWorked;
            float hourlyRate;
            float totalPay;
            Console.WriteLine("Please enter the number of hours worked:");
            hoursWorked = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the pay rate:");
            hourlyRate = float.Parse(Console.ReadLine());
            totalPay = hoursWorked * hourlyRate;
            Console.WriteLine("Your total pay is $" + totalPay + "!");
            Console.ReadKey();
        }
    }
}
