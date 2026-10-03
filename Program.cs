using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ders_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result;
            number1 = 70;
            number2 = 90;
            char not = 'a';
            string name = "Mahmut Eren Demir";
            result = (number1 + number2) / 2;
            Console.WriteLine("The result: {2}, numbers: {0} and {1}, grade: {3}, name: {4}", number1, number2, result, not, name);
            Console.WriteLine($"The result: {result}, numbers: {number1}, {number2}, grade: {not}, name: {name}");
        }
    }
}

