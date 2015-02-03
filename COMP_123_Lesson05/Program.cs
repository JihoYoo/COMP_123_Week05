using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] carMakelist = {"Honda", "BMW" , "Mercedes", "Jeep" , "Ford"};

             string[] tempCarMakeList = new string[4];

             Random rnd = new Random();


             int randomCar;

            

             

            // Assign cells from one array to another
             for (int index = 0; index < tempCarMakeList.Length; index ++)
             {
                 randomCar = generateRandomCar(rnd);

                 if (carMakelist[randomCar] != "unavailable")
                 {

                     tempCarMakeList[index] = carMakelist[randomCar];

                    carMakelist[randomCar] = "unavailable";
                 }
             }

                 //string[] carMakelist = new string[10];

                 /* Alternate way to declare and initialize an array
                 string[] carMakelist = new string[6];


                 //carMakelist[5] = "Jaguar";


                 carMakelist[0] = "Honda";
                 carMakelist[1] = "BMW";
                 carMakelist[2] = "Mercedes";
                 carMakelist[3] = "Jeep";
                 carMakelist[4] = "Ford";
                 carMakelist[5] = "Jaguar";
                  */

             Console.WriteLine("++++++++++++++++++++++++++++++++++");
             Console.WriteLine("+    Original    New Car List    +");
             Console.WriteLine("++++++++++++++++++++++++++++++++++");
            // Output the value of the each cell in each array


                 for (int index = 0; index < carMakelist.Length; index++)
                 {
                     Console.WriteLine(carMakelist[index]);

                     
                 }

                 Console.WriteLine("++++++++++++++++++++++++++++++++++");
                 Console.WriteLine("+     New     New Car List       +");
                 Console.WriteLine("++++++++++++++++++++++++++++++++++");

                 for (int index = 0; index < tempCarMakeList.Length; index++)
                 {
                    

                     Console.WriteLine(tempCarMakeList[index]);
                 }



            


            /* Alternate method to loop through (interate across the array)
            int index =0;
            while (index < carMakelist.Length)
            {
                Console.WriteLine(carMakelist[index]);
                index++;
            }
             */

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
        }

        private static int generateRandomCar(Random rnd)
        {
            int randomCar;
                
                randomCar = rnd.Next(5);
            
            Console.WriteLine("My Random car is {0}", randomCar); //Debugging line

            return randomCar;
        }
    }
}
