using System;
using Xunit;
using MartianRobots;

namespace MartianRobotUnitTests
{
    public class RobotShould
    {

        // [SetUp]
        // does x unit have setup like Nunit?

        [Fact]
        public void TurnLeft()
        {

            Robot robot = new Robot("1 2 N");

            robot.TurnLeft();

            Console.WriteLine(robot.direction);
            Assert.Equal("W", robot.direction);
        }

        [Fact]
        public void TurnRight()
        {

            Robot robot = new Robot("1 2 N");

            robot.TurnRight();

            Console.WriteLine(robot.direction);
            Assert.Equal("E", robot.direction);
        }
        
        [Fact]
        public void MoveForward()
        {

            Robot robot = new Robot("1 2 N");

            robot.MoveForward();

            Console.WriteLine(robot);
            Assert.Equal(3, robot.y);
        }

        [Fact]
        public void Move()
        {
            Robot robot = new Robot("1 2 N");

            robot.Move("LFLFLFLFF");

            Assert.Equal("1 3 N", robot.x + " " + robot.y + " " + robot.direction);
        }
    }
}
