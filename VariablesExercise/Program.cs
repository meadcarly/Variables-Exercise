namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myGoal = "to become proficient at CSharp";

            int timeFrameWeeks = 9;

            char grade = 'A';

            bool amISucceeding = true;

            double timeSpent = 30.5;

            decimal totalCost = 7000.00m;
            
            Console.WriteLine($"My goal is {myGoal} in {timeFrameWeeks} weeks and to get an {grade}. If this comes {amISucceeding}, then the ${totalCost} will be worth it. So far, I have {timeSpent} hours in.");

        }
    }
}
