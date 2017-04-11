using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> ls = callInterface(new List<Candidate>());
            int[] count = divideCandidates(ls);

            Console.WriteLine("--- DADINEOS ---");
            Console.WriteLine("Os cabloco tem a idade média de {0:0.00}: ", getAgeAverage(ls));
            Console.WriteLine("O numero de candidatos é: Homens({0}) | Mulheres({1}) ", count[0], count[1]);
            Console.WriteLine("O numero de maiores de idade e com exp são: {0}", getExpNMajorityPersons(ls));
            Console.Read();
        }

        static List<Candidate> callInterface(List<Candidate> ls)
        {
            Candidate c = new Candidate();

            Console.WriteLine("Informe o numero do participante:");
            c.number = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Quantas as primaveras que o ser ja viveu:");
            c.age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Se for cabra macho informe 'm' se for mina informe 'f': ");
            c.getSex();

            Console.WriteLine("Esse ser tem experience:");
            c.getExperience();

            ls.Add(c);
            Console.WriteLine("Deseja adicionar mais residentes? (sim para continuar ou qualquer coisa para sair)");

            if (Console.ReadLine().ToLower() == "sim")
                ls = callInterface(ls);

            return ls;
        }

        static int getExpNMajorityPersons(List<Candidate> ls)
        {
            var total = 0;

            foreach(var item in ls)
            {
                if (item.hasExperience && item.age >= 18)
                {
                    total++;
                }
            }

            return total;
        }

        static int[] divideCandidates(List<Candidate> ls)
        {
            var sex = new int[2];
            sex[0] = sex[1] = 0;

            foreach(var item in ls)
            {
                if (item.sex == "m")
                {
                    sex[0]++;
                } else
                {
                    sex[1]++;
                }
            }

            return sex;
        }

        static decimal getAgeAverage(List<Candidate> ls)
        {
            if (ls.Count == 0) {
                return 0;
            }

            var total = 0;

            foreach (var item in ls)
            {
                total += item.age;
            }

            return (decimal)(total / ls.Count);
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               