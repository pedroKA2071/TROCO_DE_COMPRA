using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TROCO_DE_COMPRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  troco, total, troco_restante;

            Console.WriteLine("qual o valor total da compra ?");

            total = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(" qual o valor que ira pagar ? ");

            troco = int.Parse(Console.ReadLine());

            troco_restante = troco - total;
           

            if (total > troco)
            {

                Console.WriteLine("Não e possivel pagar");
            } else
            {
                Console.WriteLine("e possivel pagar e seu troco e de " + troco_restante);

            }

               

               
           




            Console.ReadKey();  

        }
    }
}
