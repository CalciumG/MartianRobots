using System;

namespace MartianRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "3 2 N";
            var robot = new Robot(input);

            Console.WriteLine("Program starting");
            Console.WriteLine($"Robot Spawn: {input} {Environment.NewLine}");
            Console.WriteLine(robot.Move("LFFFRR"));
        }
    }
}
