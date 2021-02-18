using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2

    {
        static void Main(string[] args)
        {
            int NumeroUno = 0; int NumeroDos = 0; int suma = 0;

            Console.Write("digite el PRIMER numero ");
            NumeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite el SEGUNDO numero");
            NumeroDos = Convert.ToInt32(Console.ReadLine());
            suma = NumeroUno + NumeroDos;

            Console.WriteLine($"La suma de los numeros es {suma}");
            Console.ReadKey();

        }
    }

}
