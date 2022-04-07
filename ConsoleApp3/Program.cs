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

            rowCount = countPicture / rowLenght;
            extraPictures = countPicture % rowLenght;
            Console.WriteLine("рядов заполнено:" + rowCount + " лишних картин: " + extraPictures);
            Console.ReadKey();
        }
    }
}
