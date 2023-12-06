using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1.lb2
{
    internal class student
    {
        string name;
        double s;

        public string Name {  get { return name; } set { this.name = value; } }
        public double S { get {  return s; } set {  s = value; } }

        public student(string name, double avM)
        {
            Name = name;    
            this.s = avM;
        }

        public virtual double scholarship()
        {
            return 3000 + 1000 * (s - 5);
        }
    }
}
