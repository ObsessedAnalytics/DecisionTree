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

            double secondPick = 0.0668;
            double thirdPick = 0.92725;
            double secondPickCount = 0;
            double thirdPickCount = 0;
            double n = 10;
            Random rand = new Random();

            for(int i = 0; i < n; i++)
            {
                /*
                double rand1 = BoxMuller(rand);
                if(rand1 < secondPick)
                {
                    secondPickCount++;
                }
                else if(rand1 > thirdPick)
                { 
                     thirdPickCount++;
                }
                */
                Console.WriteLine(BoxMuller(rand));
            }

            secondPickCount = secondPickCount / n;
            thirdPickCount = thirdPickCount / n;

            Console.WriteLine("Second pick probability: {0}", secondPickCount);
            Console.WriteLine("Third pick probability: {0}", thirdPickCount);
            Console.ReadLine();


        }

        static double BoxMuller(Random rand)
        {
            uint u = GetUint();
            return (u + 1.0) * (1/(Math.Pow(2,32) + 2));
        }

        static uint GetUint()
        {
            uint m_z = 36969 * (m_z & 65535) + (m_z >> 16);
            uint m_w = 18000 * (m_w & 65535) + (m_w >> 16);
            return (m_z << 16) + m_w;
        }
    }
}
