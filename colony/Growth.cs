using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace colony
{
    class Growth
    {
        int a, b, c, d;

        public Growth(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        /// <summary>
        /// Return a*x^2 + b*x + c
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public long Quadratic(int x)
        {
            return a * x * x + b * x + c;
        }

        /// <summary>
        /// Return a*x + b
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Linear(int x)
        {
            return a * x + b;
        }

        /// <summary>
        /// Return a*x^3+b*x^2+c*x+d
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public long Cubic(int x)
        {
            return a * x * x * x + b * x * x + c * x + d;
        }
    }
}
