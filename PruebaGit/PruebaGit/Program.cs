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
            string nom = "Equipo dinamita";
            for(var i = 0; i < 20; i++)
            {
                Console.WriteLine(nom);
            }
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
