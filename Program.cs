using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < 40; i++)
            {
                list.Add(rnd.Next(-100, 101));
                Console.Write($"{list[i]}; ");
            }

            int paros = 0;
            for (int i = 0; i < 40; i++) if (list[i] % 2 == 0) paros++;
            Console.WriteLine($"\n{paros} páros szám van");
            Console.ReadKey();
        }
    }
}
