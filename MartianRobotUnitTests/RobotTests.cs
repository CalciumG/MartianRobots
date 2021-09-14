using Xunit;
using MartianRobots;

namespace MartianRobotUnitTests
{
    public class RobotShould
    {

        [Fact]
        public void TurnLeft()
        {

            Robot robot = new Robot("1 2 N");

            robot.TurnLeft();

            Assert.Equal("W", robot.direction);
        }

        [Fact]
        public void TurnRight()
        {

            Robot robot = new Robot("1 2 N");

            robot.TurnRight();

            Assert.Equal("E", robot.direction);
        }
        
        [Fact]
        public void MoveForward()
        {

            Robot robot = new Robot("1 2 N");

            robot.MoveForward();

            Assert.Equal(3, robot.y);
        }

        [Fact]
        public void Move()
        {
            Robot robot = new Robot("1 2 N");

            robot.Move("LFLFLFLFF", 6, 5);

            Assert.Equal("1 3 N", robot.x + " " + robot.y + " " + robot.direction);
        }
    }
}
