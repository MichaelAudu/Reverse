using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)

        {
            bool isNum = false;
            Int64 inputNum;
            string input = "";

            while (isNum == false)
            {
                Console.WriteLine("Please Enter an Integer");
                input = Console.ReadLine();
                // Determine if input is intger. If so, store number in inputNum variable.
                isNum = Int64.TryParse(input, out inputNum);
                Console.Clear();
            }

            // Create character array for integer & reverse array.
            char[] output = input.ToCharArray();
            Array.Reverse(output);
            // Reconvert array to string and display result
            string outText = new string(output);
            Console.WriteLine(outText);
            // Prevent console from closing upon completion
            Console.Read();


        }
    }
}
