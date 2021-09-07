using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MartianRobots
{
    public class Robot
    {
        public int x;
        public int y;
        public string direction;

        public Robot(string location)
        {
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];

            //string locationWithoutWhiteSpace = String.Concat(location.Where(c => !Char.IsWhiteSpace(c)));
            //Console.WriteLine(locationWithoutWhiteSpace);

            //x = locationWithoutWhiteSpace[0];
            //y = locationWithoutWhiteSpace[1];
            //direction = locationWithoutWhiteSpace[2].ToString();

        }

        public void TurnLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
            }
        }

        public void TurnRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
            }
        }

        public void MoveForward()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public string Move(string command)
        {
            char[] instructions = command.ToCharArray();
            var builder = new StringBuilder();

            foreach (var item in instructions)
            {
                switch (item)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'F':
                        MoveForward();
                        break;
                }

            }
            return $"Instructions: {command} {Environment.NewLine}Result = {x.ToString()}, {y.ToString()}, {direction}";
        }
    }
}
