using PlayGround.Day1;
using PlayGround.Day2;

namespace PlayGround
{
    public class Start
    {
        public static void Main(string[] args)
        {
            //Day 1
            SolutionDayOne solutionDayOne = new SolutionDayOne();

            System.Console.WriteLine(solutionDayOne.Part1()); 
            System.Console.WriteLine(solutionDayOne.Part2());

            System.Console.WriteLine("---------------------------------------------------");

            //Day 2
            SolutionDayTwo solutionDayTwo = new SolutionDayTwo();

            System.Console.WriteLine(solutionDayTwo.Part1());
            System.Console.WriteLine(solutionDayTwo.Part2());
        }
    }

}
