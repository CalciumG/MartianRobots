using System;
using System.Collections.Generic;

namespace MartianRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");
            Console.Write(Environment.NewLine);

            var spawnCommandPairs = new Dictionary<string, string> {
                { "1 1 E", "RFRFRFRF" },
                { "3 2 N", "FRRFLLFFRRFLL" },
                { "0 3 W", "LLFFFRFLFL" },
            };

            var surface = new Surface(5, 2);

            foreach(var pair in spawnCommandPairs)
            {
                var robot = new Robot(pair.Key);
                var instruction = pair.Value;

                Console.WriteLine($"Robot Spawn: {pair.Key}");
                Console.WriteLine(robot.Move(instruction, surface.SurfaceX, surface.SurfaceY));
            }

            Console.WriteLine("COMPLETE");
        }
    }
}
