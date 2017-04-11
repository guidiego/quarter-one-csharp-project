using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEx4
{
    class Candidate
    {
        public int number { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public bool hasExperience { get; set; }

        public void getSex()
        {
            Console.Write("(m/f) >");
            var v = Console.ReadLine();
            if (v != "m" && v != "f") {
                getSex();
            } else {
                this.sex = v;
            }
        }


        public void getExperience()
        {
            Console.Write("(s/n) >");
            var v = Console.ReadLine();
            if (v != "s" && v != "n")
            {
                getExperience();
            }
            else
            {
                this.hasExperience = v == "s" ? true : false;
            }
        }
    }

}
