
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1.lb2
{
    internal class magistr: student
    {
        string speciality;
        double m;

        public string Speciality { get { return this.speciality; } set { this.speciality = value; } }
        public double M { get { return this.m; } set { this.m = value; } }

        public magistr (string name, double avM, string special, double mval) :base (name, avM)
        {
            this.speciality = special;
            m = mval;
        }

        public override double scholarship()
        {   
            return 3000 + 1000 * (S - 5) + m;
        }

    }
}
