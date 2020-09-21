using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmupark
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto lada = new Auto("piros", "Lada 2112", 11);
            Auto trabant = new Auto("zöld", "Trabant 1.1", 8);

            lada.Tankol(20);
            trabant.Tankol(20);

            lada.Megy(0);
            trabant.Megy(0);

            lada.Allapot();
            trabant.Allapot();

            Console.Write("Mennyit megy a lada? ");
            int km = int.Parse(Console.ReadLine());
            lada.Megy(km);
            lada.Allapot();

            Console.Write("Mennyit megy a trabant? ");
            int km1 = int.Parse(Console.ReadLine());
            lada.Megy(km1);
            lada.Allapot();


            Console.ReadKey();
        }
    }
}
