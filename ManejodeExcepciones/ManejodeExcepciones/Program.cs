using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejodeExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;


            try
            {
                Console.Write("Coloque un segundo numero: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("valor al cuadrado: " + (Math.Pow(x, 2)));
                Console.ReadKey();
            }
            catch (FormatException e )
            {
                Console.WriteLine("Mensaje de error :" + e.Message);
                Console.ReadKey();
            }
            finally
            {

            }
        }
    }
}
