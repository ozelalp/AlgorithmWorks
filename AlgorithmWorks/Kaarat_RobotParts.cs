using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgorithmWorks
{
    public static class Kaarat_RobotParts
    {
        public static void PrintAvailableRobots()
        {
            string[] robotParts = new string[]
            {
                "robot1_partA", "robot1_partB", "robot2_partA", "robot2_partB", "robot2_partC",
                "robot3_partA", "robot3_partD", "robot4_partA", "robot4_partB"
            };

            var robotsAndParts = CreateRobotPartsDictionary(robotParts);
            string partsList = "partA,partB";
            var availableRobots = FindAvailableRobots(robotsAndParts, partsList);
            if (availableRobots.Count > 0)
            {
                Console.WriteLine("Available Robots: " + string.Join(", ", availableRobots));
            }
            else
            {
                Console.WriteLine("No robots found with the specified parts.");
            }
        }

        public static List<string> FindAvailableRobots(Dictionary<string, List<string>> robotsAndParts, string partsList)
        {
            var availableRobots = new List<string>();
            var partListArray = partsList.Split(',');
            var find = false;

            foreach (var robot in robotsAndParts)
            {
                foreach (var part in partListArray)
                {
                    if (!robot.Value.Contains(part))
                    {
                        find = false;
                        break;
                    }
                }

                if (find)
                {
                    availableRobots.Add(robot.Key);
                }
            }

            return availableRobots;
        }

        private static Dictionary<string, List<string>> CreateRobotPartsDictionary(string[] robotParts)
        {
            var robotPartsDict = new Dictionary<string, List<string>>();

            foreach (var part in robotParts)
            {
                var robotAndPart = part.Split('_');

                if (robotPartsDict.TryGetValue(robotAndPart[0], out List<string> partList))
                {
                    partList.Add(robotAndPart[1]);
                }
                else
                {
                    robotPartsDict[robotAndPart[0]] = new List<string> { robotAndPart[1] };
                }
            }

            return robotPartsDict;
        }
    }
}
