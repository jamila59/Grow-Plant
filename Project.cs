using System;
using System.Collections.Generic;

namespace Grow.Plant
{
    class Project 
    {
        public static void Main()
        {
            Plant outPlant = new Plant(1, "Content", 1);
            Console.WriteLine(outPlant.Mood());
            Console.WriteLine("My water level is:");
            Console.WriteLine(outPlant.IncreaseWater());
            Console.WriteLine("My glucose level is:");
            Console.WriteLine(outPlant.IncreaseGlucose());
            // Console.WriteLine(outPlant.IncreaseWater());


        }
    }
}
