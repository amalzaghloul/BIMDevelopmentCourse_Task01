using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Data Types

            //// As a structural engineer 
            ////Calculate the total weight of steel beams  


            //Console.WriteLine("please Calculate the total weight of steel beams");
            //double length = 5.2;
            //double weight = 7.2;
            //double totalWeight = length * weight;

            //Console.WriteLine(totalWeight);

            //Console.WriteLine("------------------------------------");




            //// As an Architectural Engineer
            ////indicate if a room is accessible to disable individuals.

            //bool accessibleForDisabledPeople = true;
            //Console.WriteLine(accessibleForDisabledPeople);
            //Console.ReadLine();


            //Console.WriteLine("------------------------------------");


            //// As an MEP engineer 
            ////assign unique codes to electrical panels  

            //char panel01 = 'A';
            //char panel02 = 'x';
            //Console.WriteLine("please give codes to electrical panels ");
            //Console.WriteLine(panel02);
            //Console.ReadLine();


            //Console.WriteLine("------------------------------------");
            #endregion

            #region Operators

            // As a structural engineer 
            //Determine the column's capacity load 

            int Fcu = 25;
            int fy = 360;
            
            double columnWidth = 250;
        
            double columnDepth = 600;
            double Ac = columnDepth * columnWidth;
            double As = 0.01 * Ac;
            Console.WriteLine("please calculate the PU");
            Console.WriteLine(0.35 * Ac * Fcu + 0.67 * As * fy);
            Console.ReadLine();


            Console.WriteLine("------------------------------------");


            // As an Architectural Engineer
            //estimate the cost of materials .

            int costEPG_m = 1000;
            double arae = 12.6;
            Console.WriteLine("please calculate the total cost");
            double totalCost = costEPG_m * arae;
            Console.WriteLine(totalCost);


            Console.ReadLine();


            Console.WriteLine("------------------------------------");


            // As an MEP engineer 
            //Design an electrical circuit for a room  

            int numOfBulbs = 3;
            int powerConsump_ = 60;
            Console.WriteLine("please calculate the total power consumption ");
            int totalPowerConsump_ = numOfBulbs * powerConsump_;
            Console.WriteLine(totalPowerConsump_);
           
            Console.ReadLine();


            Console.WriteLine("------------------------------------");
            // e
            #endregion








        }
    }
}
