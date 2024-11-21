using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y: ");
            int y = int.Parse(Console.ReadLine());

            int soma = x + y;

            Console.WriteLine(soma);
            Console.ReadKey();

        }
    }
}
