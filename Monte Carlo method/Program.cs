using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo_method
{
    class Program
    {
        // Initializing rand() 
        static Random rand = new Random();
        static void Main(string[] args)
        {            
            MonteCarlo(10000);            
            int un = 11;           
            MultiplicativeMethod(un);

                  Console.ReadKey();
        }
        static void  MonteCarlo(int v1)
        {
            int INTERVAL = v1;
            double rand_x, rand_y, origin_dist, pi;
            int circle_points = 0, square_points = 0;            
            
            // Total Random numbers generated = possible x 
            // values * possible y values 
            for (int i = 0; i < (INTERVAL * INTERVAL); i++)
            {
                //Console.WriteLine(randX + " = "+randY);
                // Randomly generated x and y values 
                rand_x = (double)rand.Next((INTERVAL + 1)) / INTERVAL;
                rand_y = (double)rand.Next(INTERVAL + 1) / INTERVAL;
                
                // Distance between (x, y) from the origin 
                origin_dist = rand_x * rand_x + rand_y * rand_y;
                
                // Checking if (x, y) lies inside the define 
                // circle with R=1 
                if (origin_dist <= 1)
                {
                    circle_points++;
                }
                
                // Total number of points generated 
                square_points++;
              
                // estimated pi after this iteration 
                pi = (4 * circle_points) / square_points;
                
                // For visual understanding (Optional)                 
                Console.WriteLine("Number: " + i + " -> Random X: " + rand_x + " Random X: " + rand_y + " Circle Point: " + circle_points + " Square Point: " + square_points + " PI: " + pi);
              
                // Pausing estimation for first 10 values (Optional) 
                if (i < 20)
                {
                    Console.ReadKey();
                }
                Console.WriteLine("\nFinal Estimation of Pi = " + pi + "\n");
            }
        }


        public static double MultiplicativeMethod(double v1)//Multiplicative Method
        {
            
            //k= 9, b = 5, и0 = 11, M = 12.
            int m = 12, /*un = 11,*/ c = 5, b = 9;
            double rn;
            for (double i = 1; i <= 10; i++)
            {
                double temp = (b * v1 + c) / Math.Abs(m);
                v1 = Math.Round(temp, 2);
                //double[] value = new double[10];
                rn = v1 / m;
                double v2 = Math.Round(rn, 3);
                Console.WriteLine(v1 +" -> "+ v2);
                //value[v2];

            }
            return v1;
        }

        public static int RandomNumberGenerators(int value)
        {
            int[] a = new int[value];
            double x1 = 0, x2 = 1;
            for (int i = 0; i < value; i++) // input value
            {
                a[i] = rand.Next(0, 2);
            }

            for (int i = 0; i < value; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < value; i++)
            {
                if (a[i] == 1)
                {
                    x1 = (x1 + x2) / 2;
                }
                else
                {
                    x2 = (x1 + x2) / 2;                    
                }

                Console.WriteLine("[" + x1 + "; " + x2 + "]");
            }

            return 0;
        }
    }
}
