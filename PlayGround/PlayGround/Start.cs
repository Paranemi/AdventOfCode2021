using PlayGround.Day1;
using PlayGround.Day2;
using PlayGround.Day3;

namespace PlayGround
{
    public class Start
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Day 1---------------------------------------------------");

            //Day 1
            SolutionDayOne solutionDayOne = new SolutionDayOne();

            System.Console.WriteLine(solutionDayOne.Part1()); 
            System.Console.WriteLine(solutionDayOne.Part2());

            System.Console.WriteLine("Day 2---------------------------------------------------");

            //Day 2
            SolutionDayTwo solutionDayTwo = new SolutionDayTwo();

            System.Console.WriteLine(solutionDayTwo.Part1());
            System.Console.WriteLine(solutionDayTwo.Part2());

            System.Console.WriteLine("Day 3---------------------------------------------------");

            //Day 3
            SolutionDayThree solutionDayThree = new SolutionDayThree();

            System.Console.WriteLine(solutionDayThree.Part1());
            System.Console.WriteLine(solutionDayThree.Part2());
        }
    }

}
