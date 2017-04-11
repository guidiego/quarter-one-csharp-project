using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Informe o nome do produto");
            p.Name = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n---- INFO ----\nProduct:{0}\nPrice:{1}\nSellPrice:{2}\n--------------\n", p.Name, p.Price, p.GetSellPrice());
            Console.ReadKey();
        }
    }
}
