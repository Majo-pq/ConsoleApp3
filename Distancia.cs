using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Distancia
    {
        protected double d;

        public double D
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }

        }

        public Distancia()
        {
            d = 0;
        }

        public Distancia(double d)
        {
            this.d = d;
        }

        public override string ToString()
        {
            return "D=" + d;
        }
    }
}
