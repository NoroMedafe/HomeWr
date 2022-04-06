using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowLenght = 3;
            int countPicture = 52;
            int rowCount;
            int extraPictures;

            rowCount = 52 / 3;
            extraPictures = 52 % 3;
            Console.WriteLine("рядов заполнено:" + rowCount + " лишних картин: " + extraPictures);
            Console.ReadKey();
        }
    }
}
