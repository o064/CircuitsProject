using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitsProject
{
    public class Data
    {
        public double c1;
        public double c2;
        public double pow1;
        public double pow2;
        public string Csol;
        public int State;
        public double final;



        public Data(double c1, double c2, double pow1, double pow2, int state, string csol, double final)
        {
            this.c1 = c1;
            this.c2 = c2;
            this.pow1 = pow1;
            this.pow2 = pow2;
            Csol = csol;
            State = state;
            this.final = final;
        }
    }
}
