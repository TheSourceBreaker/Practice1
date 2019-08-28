using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static private int width_of_window = 3;
        static private int height_of_window = 6;
        

        static private int Wood()
        {
            int length = (width_of_window + height_of_window) *2;
            int result = Wood();
            return result;
        }
        static private int Glass()
        {
            int area = width_of_window * height_of_window;
            int result = Glass();
            return result;
        }
        



        static void Main(string[] args)
        {
            Wood();
            Glass();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
