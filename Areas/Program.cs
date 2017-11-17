using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Calculando areas de figuras--- \n");
            Console.WriteLine("Prisma rectangular: \n");
            Console.WriteLine("Lados de la base: ");
            float b = int.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            float hr = int.Parse(Console.ReadLine());
            Console.WriteLine("Cono: \n");
            Console.WriteLine("Altura: ");
            float hc = int.Parse(Console.ReadLine());
            Console.WriteLine("Radio: ");
            float r = int.Parse(Console.ReadLine());

            Rectangulo(b,hr);
            Cono(hc,r);
            Console.ReadKey();
        }
        public static void Rectangulo(float b, float h)
        {
            Console.WriteLine("El area del Prisma es: {0}\n",(b*b)*h);
        }

        public static void Cono(float h, float r)
        {
            Console.WriteLine("El area del Cono es: {0}\n", (r * r) * h * 3.1416);
        }
    }
}
