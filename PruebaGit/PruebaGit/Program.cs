using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Awesome");
            Console.WriteLine("Awesome 2");
            var contador = 0;
            while (contador <=100)
            {
                Console.WriteLine(System.DateTime.Now.ToString("HH:mm:ss"));
                contador++;
            }
            Console.Read();
        }
    }
}
