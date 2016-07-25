using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord;
using Accord.Math.Integration;

namespace DecisionTree
{
    class Program
    {
        static void Main(string[] args)
        {


            // Define a function H that tells whether two points 
            // are inside a unit circle (a circle of radius one):
            // 
            Func<double, double, double> H =
                (x, y) => (Math.Pow(x,16.5) / (Math.Pow(x,16.5) + Math.Pow(y,16.5)) <= 1) ? 1 : 0;

            // We will check how many points in the square (-1,-1), (-1,+1), 
            // (+1, -1), (+1, +1) fall into the circle defined by function H.
            // 
            double[] from = { -1, -1 };
            double[] to = { +1, +1 };

            int samples = 100000;

            // Integrate it! 
            double area = MonteCarloIntegration.Integrate(x => H(x[0], x[1]), from, to, samples);

            // Output should be approximately 3.14.


        }
    }
}
