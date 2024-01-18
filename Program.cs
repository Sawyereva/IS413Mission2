using System.Threading.Tasks;
using CSharpFun;
internal class Program
{
    private static void Main(string[] args)
    {

        int[] rollcounts = new int[11];
        System.Console.WriteLine("How many times would you like to roll the dice?");
        string temp = System.Console.ReadLine();
        int times = int.Parse(temp);

        rollcounts = Class1.Roller(times);

        double percent = 0;
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each  *  represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + times);
        for (int i = 2; i < 13; i++)
        {
            percent = rollcounts[i-2] * 100 / times;
            string output = "";
            for (int iInner = 0; iInner < percent; iInner++)
            {
                output = output + "*";
            }
            System.Console.WriteLine(i + ":\t" + output);
            }
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    
}