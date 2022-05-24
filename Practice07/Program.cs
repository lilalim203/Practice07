/* Develop a sub-algorithm with a parameter year of type number and returns if the year is a leap year or not
   ; use this routine in the main program.
	- Example: given 2022 => false
	- Example: given 2020 =>  true */

using System;

class Program7
{
    private void isLeapyear(int input_year)
    {
        string isYN = " NOT";

        if (input_year % 4 == 0 & input_year % 100 != 0 || input_year % 400 == 0)
        {

            isYN = "";
        }

        Console.WriteLine("\n" + input_year + " IS" + isYN + " A LEAP YEAR!");
    }

    static void Main(string[] args)
    {
        Program7 p = new Program7();

        string sinput;
        int input;

        Console.Write("Input a year: ");
        sinput = Console.ReadLine();
        input = Convert.ToInt32(sinput);
        p.isLeapyear(input);
    }
}