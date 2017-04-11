using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Resident> ls = callInterface(new List<Resident>());
            
            Console.WriteLine("--- DADINEOS ---");
            Console.WriteLine("Média se salario é R$ {0}", getSalaryMedia(ls));
            Console.WriteLine("Média de filhos é {0}", getSonAgeMedia(ls));
            Console.WriteLine("Maior salario da galeris é {0}", getTopSalary(ls));
            Console.Read();
        }

        static List<Resident> callInterface(List<Resident> ls)
        {
            Resident r = new Resident();

            Console.WriteLine("Informe o salario do ser:");
            r.salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o numero de pestinhas que ele tem:");
            r.numberOfSons = Convert.ToInt16(Console.ReadLine());

            ls.Add(r);
            Console.WriteLine("Deseja adicionar mais residentes? (sim para continuar ou qualquer coisa para sair)");

            if (Console.ReadLine().ToLower() == "sim")
                ls = callInterface(ls);

            return ls;
        }

        static decimal getSalaryMedia(List<Resident> rList)
        {
            decimal salaryTotal = 0;

            foreach (Resident r in rList)
            {
                salaryTotal += r.salary;
            }

            if (rList.Count == 0)
            {
                return 0;
            }

            return (decimal)(salaryTotal / rList.Count);
        }

        static decimal getSonAgeMedia(List<Resident> rList)
        {
            int sonTotal = 0;

            foreach (Resident r in rList)
            {
                sonTotal += r.numberOfSons;
            }


            if (rList.Count == 0)
            {
                return 0;
            }

            return (decimal)(sonTotal / rList.Count);
        }

        static decimal getTopSalary(List<Resident> rList)
        {
            decimal majorSalary = -1;

            foreach (Resident r in rList)
            {
                if (majorSalary < r.salary)
                {
                    majorSalary = r.salary;
                }
            }

            return majorSalary;
        }
    }
}
