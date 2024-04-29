using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russia
{
    public class Moscow
    {
        public int Population {  get; set; }

        public Moscow(int Population) 
        {
            this.Population = Population;
        }
    }

    public class Ekaterinburg
    {
        public int Population { get; set; }

        public Ekaterinburg(int Population)
        {
            this.Population = Population;
        }
    }
}
