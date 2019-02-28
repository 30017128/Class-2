using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin;
            int num1;
            int num2;
            double dec1;
            float dec2;

            Console.Write("Please enter your name:  ");
            string name = Console.ReadLine();
            Console.Write("Please enter your address: ");
            string address = Console.ReadLine();
            Console.Write("Please enter your email address: ");
            string emailadress = Console.ReadLine();
            Console.Write("Please enter your pin:  ");
            pin =int.Parse(Console.ReadLine());
            Console.Write("Enter a whole number:  ");
            num1 =int.Parse(Console.ReadLine());
            Console.Write("Enter a whole number:  ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter a decimal:  ");
            dec1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a decimal:  ");
            dec2 =float.Parse(Console.ReadLine());



            Console.Write("\nYour name is:  ");
            Console.WriteLine(name);
            Console.Write("your address is:  ");
            Console.WriteLine(address);
            Console.Write("your email address is:  ");
            Console.WriteLine(emailadress);
            Console.Write("your pin is:  ");
            Console.WriteLine(pin);
            Console.Write("Whole Number 1:  ");
            Console.WriteLine(num1);
            Console.Write("Whole Number 2:  ");
            Console.WriteLine(num2);
            Console.Write("Decimal 1:  ");
            Console.WriteLine(dec1);
            Console.Write("Decimal 2:  ");
            Console.WriteLine(dec2);

            


           


            
       
          



            Console.Read();
        }
    }
}
