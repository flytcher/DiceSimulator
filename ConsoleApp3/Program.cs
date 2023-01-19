using System;

class DiceSimulator
{
    static void Main()
    {
        //prompt
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");

        //input, parsing to convert string to int
        int numRolls = int.Parse(Console.ReadLine());

        //array of numbers rolled
        int[] results = new int[13];

        //random object instantiation
        Random rnd = new Random();

        //Dice Rolls
        for (int i = 0; i < numRolls; i++)
        {
            int die1 = rnd.Next(1, 7);
            int die2 = rnd.Next(1, 7);
            int dice = die1 + die2;
            results[dice]++; // this adds one to the corresponding index in the results array
        }

        //prompts
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + ".");

        //printing the histogram
        for (int i = 2; i <= 12; i++)
        {

            Console.Write(i + ": ");
            double percent = (double)results[i] / numRolls * 100;
            int numStars = (int)Math.Round(percent);

            //nested for loop to print an asterisk for each percentage point
            for (int j = 0; j < numStars; j++)
            {
                Console.Write("*");
            }

            //ending prompt
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
