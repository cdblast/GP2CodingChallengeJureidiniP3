using System;
using System.ComponentModel.Design;
using System.Net.Security;

class Challenges
{
    public static void Main(string[] args)
    {
#pragma warning disable CS8604 // Possible null reference argument.
        var keepLoop = true;

        while (keepLoop)
        {
            //Console.WriteLine("Would you like to run a challenge?");

            //var keepLoopAsk = Console.ReadLine();
            //bool keepLoop 
            //to-do: please ask for keepLoop at the end to continue running loop or to end program!!!

            Console.WriteLine("Welcome to my Coding Challenge program. There will be a variety of different challenges you will have to choose from.\n(Provide a number. There are 9 challenges total currently. If you do not provide a number, the program crashes.)");

            var programChooser = Console.ReadLine();
            int programChooserint = int.Parse(programChooser)!;

            if (programChooserint == 1)
            {
                // Challenge 1 - Increment of 1
                Console.WriteLine("Today we are gonna use the number adder function called Sum. Please input two numbers for us to add.\n");

                var number1 = Console.ReadLine();
                int number1int = int.Parse(number1);

                Console.WriteLine("Great! Type one more number.");

                var number2 = Console.ReadLine();
                int number2int = int.Parse(number2);

                Sum(number1int, number2int);

                Console.WriteLine("The sum of the number : " + number1 + " and the number: " + number2 + " is equal to: " + Sum(number1int, number2int));
            }
            if (programChooserint == 2)
            {
                //challenge 2 - minutes converter
                Console.WriteLine("This program converts Minutes to Seconds. Please input Minutes.");

                var minutesToConvert = Console.ReadLine();
                int minutesToConvertint = int.Parse(minutesToConvert);

                Convert(minutesToConvertint);

                Console.WriteLine("In " + minutesToConvert + " amount of minutes, there are " + Convert(minutesToConvertint) + " amount of seconds.");


            }

            if (programChooserint == 3)
            {

                //challenge 3 - increment counter
                Console.WriteLine("Provide a number.");

                var challenge2Number = Console.ReadLine();
                int challenge2Numberint = int.Parse(challenge2Number);

                Console.WriteLine("The given number " + challenge2Number + " with an increment of 1 is " + PlusOne(challenge2Numberint));

            }

            if (programChooserint == 4)
            {

                //Challenge 4 - what is the power of a voltage * current ?
                Console.WriteLine("Provide a voltage.");

                var Voltage = Console.ReadLine();
                int Voltageint = int.Parse(Voltage);

                Console.WriteLine("Now provide a current.");

                var Current = Console.ReadLine();
                int Currentint = int.Parse(Current);

                Console.WriteLine("The power will be " + Multiplier(Currentint, Voltageint));

            }


            if (programChooserint == 5)
            {

                //Challenge 5 - how many days old are you?
                Console.WriteLine("Please provide an age to calculate.");

                var Age = Console.ReadLine();
                int Ageint = int.Parse(Age);

                Console.WriteLine("Someone " + Age + " years old is " + CalcAge(Ageint) + " days old.");

            }


            if (programChooserint == 6)
            {

                //Challenge 6 - calculate a triangle's area

                Console.WriteLine("Provide the base, then height to calculate the area of a triangle.");

                var triBase = Console.ReadLine();
                int triBaseint = int.Parse(triBase);

                Console.WriteLine("Great! now provide the height.");

                var triHeight = Console.ReadLine();
                int triHeightint = int.Parse(triHeight);

                Console.WriteLine("The area of a triangle with a base of " + triBase + " and height of " + triHeight + " is " + triArea(triBaseint, triHeightint));

            }


            if (programChooserint == 7)
            {

                //Challenge 7 - Is a number equal to or less than 0?

                Console.WriteLine("Please provide a number to check is equal or less than 0.");

                var lessThanZero = Console.ReadLine();
                int lessThanZeroint = int.Parse(lessThanZero);

                Console.WriteLine("The number provided is equal to or less than 0: " + lessThanOrEqualToZero(lessThanZeroint));
            }

            if (programChooserint == 8)
            {
                //Challenge 8 - Is the sum of two numbers is greater or less than 100?
                Console.WriteLine("Please provide 2 numbers to find if the sum is less than 100.");

                var number1 = Console.ReadLine();
                int number1int = int.Parse(number1);

                Console.WriteLine("Great! Type one more number.");

                var number2 = Console.ReadLine();
                int number2int = int.Parse(number2);

                Sum(number1int, number2int);

                if (Sum(number1int, number2int) < 100)
                {
                    Console.WriteLine("The sum of the number : " + number1 + " and the number: " + number2 + " is " + Sum(number1int, number2int) + ", which is less than 100.");
                }

                else
                {
                    Console.WriteLine("The sum of the number : " + number1 + " and the number: " + number2 + " is " + Sum(number1int, number2int) + ", which is NOT less than 100.");

                }
            }

            if (programChooserint == 9)
            {
                //Challenge 9 - Are two user-inputs equal to eachother?
                Console.WriteLine("Please provide 2 numbers to check if they are equivalent to eachother.");

                var number1 = Console.ReadLine();
                int number1int = int.Parse(number1);

                Console.WriteLine("Great! Type one more number.");

                var number2 = Console.ReadLine();
                int number2int = int.Parse(number2);
                
                //isEqual(number1int, number2int);
                
                if (isEqual(number1int, number2int))
                {
                    Console.WriteLine("Both numbers are equivalent.");
                }
                else
                {
                    Console.WriteLine("The numbers " + number1 + " and " + number2 + " are not equivalent to eachother.");
                }

            }

            // try stackoverflow.com/questions/35871069 "tryParse" to provide a failsafe and warn the user? i don't wnat the program to crash immediately when a numerical value isn't provided :(

            //for uhhhhh. user warning?
            //this should be fine i think
            else
            {
                Console.WriteLine("----\n This program will repeat now. Think about your actions. If you are done, close the window. \n ----");
            }


        }

#pragma warning restore CS8604 // Possible null reference argument.
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

    public static bool isEqual(int number1, int number2)
    {
        return number1 == number2;
    }
}