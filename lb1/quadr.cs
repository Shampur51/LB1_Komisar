using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1
{
    internal class quadr
    {
        int s1, s2, s3, s4, ag1, ag2, ag3, ag4;

        public quadr(int s1, int s2, int s3, int s4, int ag1, int ag2, int ag3, int ag4)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;

            this.ag1 = ag1;  
            this.ag2 = ag2;
            this.ag3 = ag3;
            this.ag4 = ag4;
        }

        private void RandS()
        {
            Random R = new Random();

            this.s1 = R.Next(1, 100);
            this.s2 = R.Next(1, 100);
            this.s3 = R.Next(1, 100);
            this.s4 = R.Next(1, 100);
        }

        private void RandAg()
        { 
            Random R = new Random();

            this.ag1 = R.Next(1, 358);
            this.ag2 = R.Next(1, 359 - ag1);
            this.ag3 = R.Next(1, 360 - (ag1 + ag2));
            this.ag4 = 360 - (ag1 + ag2 + ag3);
        }

        public quadr( int ag1, int ag2, int ag3, int ag4)
        {

            if (ag1 == ag3 && ag4 == ag2)
            {
                Random R = new Random();

                this.s1 = R.Next(1, 100);
                this.s3 = this.s1;
                this.s2 = R.Next(1, 100);
                this.s4 = this.s2;
            }

            else
            {
                this.ag1 = ag1;
                this.ag2 = ag2;
                this.ag3 = ag3;
                this.ag4 = ag4;

                RandS();
            }
            
        }

        public quadr()
        {
            RandS();
            RandAg();
        }

        public double S1
        {
            get { return this.s1; }
        }

        public double S2
        {
            get { return this.s2; }
        }

        public double S3
        {
            get { return this.s3; }
        }

        public double S4
        {
            get { return this.s4; }
        }

        public double Ag1
        {
            get { return this.ag1; }
        }

        public double Ag2
        {
            get { return this.ag2; }
        }

        public double Ag3
        {
            get { return this.ag3; }
        }

        public double Ag4
        {
            get { return this.ag4; }
        }

        public bool IsPar()
        {

            if ((ag1 == ag2 && ag3 == ag4) && (s1 == s3 && s2 == s4))
                return true;

            else if (ag1 + ag2 == 180 && ag2 + ag3 == 180 && ag3 + ag4 == 180 && ag1 + ag4 == 180)
                return true;

            double a1 = Math.Sqrt(Math.Pow(s1, 2) + Math.Pow(s2, 2) - (2 * s1 * s2 * Math.Cos(ag2 * Math.PI / 180.0)));
            double a2 = Math.Sqrt(Math.Pow(s3, 2) + Math.Pow(s4, 2) - (2 * s3 * s4 * Math.Cos(ag3 * Math.PI / 180.0)));

            if(a1 == a2)
                return true;

            else
                return false;
        }
    }
}
