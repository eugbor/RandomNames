using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myArr = new List<string>
            {
             "Вика",
            "Саша",
            "Костя",
            "Маша",
            "Никита",
            "Диана",
            "Даша",
            "Лёша",
            "Влад Быков",
            "Влад Волков",
            };
            Random rand = new Random();
            for (int i = myArr.Count; i > 0; i--)
            {
                int flag = rand.Next(myArr.Count);
                Console.WriteLine(myArr[flag]);
                myArr.RemoveAt(flag);
            }
            Console.ReadKey();
        }
    }
}
