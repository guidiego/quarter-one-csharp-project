using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contributor c = new Contributor();

            Console.WriteLine("Insira o nome do contribuidor:");
            c.name = Console.ReadLine();

            Console.WriteLine("Insira o CPF do coitado:");
            c.cpf = Console.ReadLine();

            Console.WriteLine("Insira a renda anual do benino!");
            c.annualIncome = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de dependentes:");
            c.dependents = Convert.ToInt16(Console.ReadLine());

            Console.Write("--------\nName: {0}\nIncomes: {1}\n--------\n", c.name, c.CalculateTax());
            Console.ReadKey();
        }
    }
}
