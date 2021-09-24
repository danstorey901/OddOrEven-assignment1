using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach() - Simplest way to process each item in a collection. 

            //For these numbers, programmatically find the highest and lowest numbers in this list.


            int[] nbrs = { 

            754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

            187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

            460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

            690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

            435, 643, 809, 874, 906, 620, 328, 369, 426, 561

        };

            //var highest = 0;
            //var lowest = 1000;
            //foreach (var nbr in nbrs)
            //{
            //    if (nbr > highest)
            //    {
            //        highest = nbr;
            //    }
            //    if (nbr < lowest)
            //    {
            //        lowest = nbr;
            //    }


            //}

            //Console.WriteLine($"Highest is {highest}; lowest is {lowest}");

            //Come up with the highest number possible using 4 out of the 5 numbers and the lowest number possible using 4 out the 5 numbers

            int[] nbrs2 = { 3023, 8760, 1112, 8232, 8107 };
            var largest = 0;
            var smallest = 9000;
            var sum = 0;

            foreach (var n in nbrs2)
            {
                if (n > largest) largest = n;
                if (n < smallest) smallest = n;
                sum = sum + n;
            }
            var max = sum - smallest;
            var min = sum - largest;

            Console.WriteLine($"Largest is {max}, smallest is {min}");

            //// print all int 1-25

            ////Elyse's Example

            //for (var i = 1; i <= 25; i++)
            //    if (i == 25)
            //        Console.Write($"25");
            //    else Console.Write($"{i}, ");

            //// my example
            //for (var i = 1; i <= 25; i++)
            //    Console.Write($" {i};");

            ////Gregs example
            //var comma = "";
            //for (int idx = 1; idx <= 25; idx++)
            //{
            //    Console.Write($"{comma} {idx}");
            //    comma = ",";
            //}



            // // for(;;) statement - add up all the numbers from 1-50(inclusive) but only if they are evenly divisible by 5 or 7)
            //var total = 0;
            // for(var idx = 1; idx <= 50; idx++)
            // {
            //     if (idx % 5 == 0 || idx % 7 == 0)
            //     {
            //         total = total + idx;
            //     }

            // }
            // Console.WriteLine($"Total is {total}");


            // for(;;) statement - add up all the numbers from 1-50(inclusive) but only if they are evenly divisible by 5 or 7) - REFACTORED

            //var total = 0;
            //for (var idx = 1; idx <= 50; idx++)
            //{
            //    if (idx % 5 == 0)
            //    {
            //        total = total + idx;
            //        continue;
            //    }

            //    if(idx % 7 == 0)
            //    {
            //        total = total + idx;
            //    }

            //}
            //Console.WriteLine($"Total is {total}");




            //for(var idx = 0; idx < 5; idx++)
            //{

            //Console.WriteLine("Enter an integer:  ");
            //var answer = Console.ReadLine();
            //var value = Convert.ToInt32(answer);


            //if (value % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //} else
            //{
            //    Console.WriteLine("The number is odd");
            //}

            //}

            //{ 
            ////index incrementer
            //for(var i=0;i<10;i++)
            //        Console.WriteLine($"i = {i}");
            //}
        }
        // for(;;) - a loop - using an index to iterate through a collection is a very common construct. To abbreviat the code, a for loop was created.
        // 3 segments seperated by a semicolon: 1; Code done once before loop begins. 2; Code condition to continue the loop. 3; Code done after each loop.
        // 1 only happens once. 2. middle piece, boolean condition, after body then 3. then back to 2 to check if true. when 2 is false the loop is over
        /* 1: Initialization is done once at start | 2: If condition is true, body executes | 3: Code in body is executed | 4: Executes after body | 5: IF CONDITION IS TRUE, body executes

         E.G.  for(var idx=0; idx<10; idx++)
                    Console.WriteLine($"i={i}"); */
    }

    
}

