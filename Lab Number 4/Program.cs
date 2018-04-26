using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Learn your squares and cubes!");






            //int num, squ, cub;

            //num = 1;

            //squ = num * num;

            //cub = num * num;

            bool usercontinue = true;

            while (usercontinue == true)

            {

                Console.WriteLine("Enter an integer");

                double x = (double.Parse(Console.ReadLine()));

                // Console.WriteLine ("Number " + i + " Square  " + i * i + " Cubed " + i * i * i);


                Console.Write($"{"number",-10}");
                Console.Write($"{"sqr"}".PadRight(10));
                Console.WriteLine($"{"Cube"}".PadRight(10));


                Console.Write($"{"=====",-10}");
                Console.Write($"{"=====",-10}");
                Console.WriteLine($"{"=====",-10}");










                for (int i = 1; i <= x; i++)
                {

                    int number = i;
                    int sqr = i * i;
                    int cube = i * i * i;

                    Console.Write($"{number,-10}");

                    Console.Write($"{sqr,-10}");
                    Console.WriteLine($"{cube,-10}");
                }


                Console.WriteLine("Do you want to continue? (y/n)");
                 string input = Console.ReadLine();

                if (input.ToLower() == "n")
                {
                    usercontinue = false;
                    Console.WriteLine(" Bye!");
                }








            }


            }
    }
}
