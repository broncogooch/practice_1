using static System.Runtime.InteropServices.JavaScript.JSType;
using practice_1;
using System.Diagnostics.CodeAnalysis;
using System;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        //initializing variables
        int NumOfRolls = 0;
        int DiceResult = 0;
        dice Dice = new dice();
        int[] RollsArray = {0,0,0,0,0,0,0,0,0,0,0};
        string FinalOutput = "";


        //interact with user for number of rolls
        Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");
        NumOfRolls = int.Parse(Console.ReadLine());
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = " + NumOfRolls);

        //calculate array of dice rolls
        for (int i = 1; i <= NumOfRolls; i++)
        {
            DiceResult = Dice.RollDice();
            //This if statement sorts the dice result into the array
            if (DiceResult == 2)
            {
                RollsArray[0] = RollsArray[0] + 1;
            }
            else if (DiceResult == 3)
            {
                RollsArray[1] = RollsArray[1] + 1;
            }
            else if (DiceResult == 4)
            {
                RollsArray[2] = RollsArray[2] + 1;
            }
            else if (DiceResult == 5)
            {
                RollsArray[3] = RollsArray[3] + 1;
            }
            else if (DiceResult == 6)
            {
                RollsArray[4] = RollsArray[4] + 1;
            }
            else if (DiceResult == 7)
            {
                RollsArray[5] = RollsArray[5] + 1;
            }
            else if (DiceResult == 8)
            {
                RollsArray[6] = RollsArray[6] + 1;
            }
            else if (DiceResult == 9)
            {
                RollsArray[7] = RollsArray[7] + 1;
            }
            else if (DiceResult == 10)
            {
                RollsArray[8] = RollsArray[8] + 1;
            }
            else if (DiceResult == 11)
            {
                RollsArray[9] = RollsArray[9] + 1;
            }
            else if (DiceResult == 12)
            {
                RollsArray[10] = RollsArray[10] + 1;
            }
        }

        //This calculates the asterisks to be sent as the output
        for (int i = 0; i < RollsArray.Length; i++)
        {
            //This gets what percent each of the numbers was rolled
            float percent = (float)RollsArray[i] / NumOfRolls;
            int scaledPercent = (int)(percent * 100);
            string astOutput = "";
            
            //This adds each of the asterisks needed to the string astOutput
            for (int j = 0; j < scaledPercent; j++)
            {
                astOutput = astOutput + "*";
            }
            
            //Each iteration adds to the FinalOutput string, which has all the information that needs to be written
            FinalOutput = FinalOutput + (i + 2) + ": " + astOutput + "\n";
        }
        //This writes the final messages and the asterisks to the user
        Console.WriteLine(FinalOutput);
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!\r\n");
    }
}