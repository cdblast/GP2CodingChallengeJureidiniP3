﻿using System;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Coding Challenge program. There will be a variety of different functions you will have to choose from. Please pick one. (Provide a number. There are 7 challenges total currently.)");
        /*
        
        var programChooser = Console.ReadLine();
        int programChooserint = int.Parse(programChooserint);

            if (programChooserint == 1) {
                put all of challenge 1 in here :3
                };

        for uhhhhh. failsafe?
        this should be fine i think
            else {
                Console.WriteLine("That didn't work. Please provide a numerical value from 1-7 in order to jump to that challenge.");

                
        */

        // Challenge 1 - Increment of 1
        Console.WriteLine("Today we are gonna use the number adder function called Sum. Please input two numbers for us to add.\n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Great! Type one more number.");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Sum(number1int, number2int);

        Console.WriteLine("The sum of the number : " + number1 + " and the number: " + number2 + " is equal to: " + Sum(number1int, number2int));

        //challenge 2 - minutes converter
        Console.WriteLine("This program converts Minutes to Seconds. Please input Minutes.");

        var minutesToConvert = Console.ReadLine();
        int minutesToConvertint = int.Parse(minutesToConvert);

        Convert(minutesToConvertint);

        Console.WriteLine("In " + minutesToConvert + " amount of minutes, there are " + Convert(minutesToConvertint) + " amount of seconnds.");

        //challenge 3 - increment counter
        Console.WriteLine("Provide a number.");

        var challenge2Number = Console.ReadLine();
        int challenge2Numberint = int.Parse(challenge2Number);
         
        Console.WriteLine("The given number " + challenge2Number + " with an increment of 1 is " + PlusOne (challenge2Numberint));

        //Challenge 4 - what is the power of a voltage * current ?
        Console.WriteLine("Provide a voltage.");

        var Voltage = Console.ReadLine();
        int Voltageint = int.Parse(Voltage);

        Console.WriteLine("Now provide a current.");

        var Current = Console.ReadLine();
        int Currentint = int.Parse(Current);

        Console.WriteLine("The power will be " + Multiplier (Currentint, Voltageint));

        //Challenge 5 - how many days old are you?
        Console.WriteLine("Please provide an age to calculate.");

        var Age = Console.ReadLine();
        int Ageint = int.Parse(Age);

        Console.WriteLine("Someone " + Age + " years old is " + CalcAge(Ageint) + " days old.");

        //Challenge 6 - calculate a triangle's area

        Console.WriteLine("Provide the base, then height to calculate the area of a triangle.");

        var triBase = Console.ReadLine();
        int triBaseint = int.Parse(triBase);

        Console.WriteLine("Great! now provide the height.");

        var triHeight = Console.ReadLine();
        int triHeightint = int.Parse(triHeight);

        Console.WriteLine("The area of a triangle with a base of " + triBase + " and height of " + triHeight + " is " + triArea(triBaseint, triHeightint));

        //Challenge 7 - Is a number equal to or less than 0?

        Console.WriteLine("Please provide a number to check is equal or less than 0.");

        var lessThanZero = Console.ReadLine();
        int lessThanZeroint = int.Parse(lessThanZero);

        Console.WriteLine("The number provided is equal to or less than 0: " + lessThanOrEqualToZero(lessThanZeroint));
    }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    public static int Convert(int number)
    {
        return number * 60;
    }
    public static int PlusOne(int number)
    {
        return number + 1;
    }
    public static int Multiplier(int number1, int number2)
    {
        return number1 * number2;
    }
    public static int CalcAge(int number) 
    {
        return number * 365;
    }

    public static float triArea(float number1, int number2)
    {
        return (number1 * number2) / 2;
    }

    public static bool lessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }

}