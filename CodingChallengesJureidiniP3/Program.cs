﻿using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            Console.WriteLine("Welcome to my Coding Challenge program. There will be a variety of different challenges you will have to choose from.\n(Provide a number. There are 28 challenges total currently. If you do not provide a number, the program crashes.)");
            Console.WriteLine("Note:Challenges do not exist for 18,19,20.");

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

            if (programChooserint == 10)
            {
                //Challenge 10 - return the user-input phrase with the word "Something" before it
                Console.WriteLine("Talk :)");

                var words10 = Console.ReadLine();

                Console.WriteLine(giveMeSomething(words10));  
            }

            if(programChooserint == 11)
            {
                bool Boolean11 = true;
                //Challenge 11 - return a boolean value as opposite of itself
                Console.WriteLine("Please type True if you want your boolean true. Type False if you want your boolean false.");

                var BooleanDecider = Console.ReadLine();
                if (BooleanDecider == "true")
                {
                    Boolean11 = true;
                }
                else if (BooleanDecider == "false") 
                {
                    Boolean11 = false;
                }
                else
                {
                    Console.WriteLine("You must have mispelt something. Try again.");
                }

                Console.WriteLine("Guess what! Your boolean's being returned as " + Reverse(Boolean11) + " anyways.");

            }

            if(programChooserint == 12)
            {
                //Challenge 12 - Write a function that converts hours into seconds.
                Console.WriteLine("Please provide the hours you want to convert.");

                var hoursToConvert = Console.ReadLine();
                int hoursToConvertint = int.Parse(hoursToConvert);

                Console.WriteLine("There are " + ConvertHours(hoursToConvertint) + " seconds in " + hoursToConvert + " hours.");

            }

            if (programChooserint == 13)
            {
                // Challenge 13 - n amount of sides in a polygon to return the total sum of internal angles.

                Console.WriteLine("Hello! Please input the amount of sides in your polygon.");
                var amountOfSides = Console.ReadLine();
                int amountOfSidesint = int.Parse(amountOfSides);

                if (amountOfSidesint <= 2) {
                    Console.WriteLine("Please input a number higher than 2.");
                }
                else
                {

                    Console.WriteLine("In a polygon with " + amountOfSides + ", the total sum of internal angles is " + SumPolygon(amountOfSidesint) + ".");
                }
            }

            if (programChooserint == 14)
            {
                // Challenge 14 - A student learning C# was trying to make a function. His code should concatenate a passed string name with string "Edabit" and store it in a variable called result. He needs your help to fix this code.
                Console.WriteLine("Enter your name :)");
                var name = Console.ReadLine();

                var result = (nameString(name));

                Console.WriteLine(result);
            }

            if(programChooserint == 15)
            {
                //Challenge 15 -
                bool Boolean15 = false;
                bool Boolean16 = false;

                Console.WriteLine("Hello! Help determine whether both bools are true.");

                Console.WriteLine("Please type true or false, lowercase only.");
                var BooleanRead = Console.ReadLine();
                if (BooleanRead == "true")
                { Boolean15 = true; }
                else if (BooleanRead == "false") { Boolean15 = false; }
                else { Console.WriteLine("That didn't work. Try again."); }

                Console.WriteLine("Great, type true or false once more.");
                var BooleanRead2 = Console.ReadLine();
                if (BooleanRead2 == "true") { Boolean16 = true; }
                else if (BooleanRead == "false") { Boolean16 = false; }
                else { Console.WriteLine("That didn't work. Try again."); }

                Console.WriteLine("And (" + Boolean15 + ", " + Boolean16 + ") --> " + AndFunction(Boolean15, Boolean16));


            }

            if (programChooserint == 16)
            {
                //challenge 16 count basketball points. funnction points(7,5) should count (3-pointers, 2-pointers) so (7,5) should be 29

                Console.WriteLine("Hello! Please tell us how many 2-point shots were made.");

                var number1 = Console.ReadLine();
                int number1int = int.Parse(number1);

                Console.WriteLine("Please tell us how many 3-point shots were made.");

                var number2 = Console.ReadLine();
                int number2int = int.Parse(number2);

                Console.WriteLine("points(" + number1 + ", " + number2 + ") --> " + Points(number1int, number2int));
            }

            if (programChooserint == 17)
            {
                // challenge 17 find the perimeter of a rectangle

                Console.WriteLine("Hello! Please provide the width of a rectangle to help find the perimeter.");

                var number1 = Console.ReadLine();
                int number1int = int.Parse(number1);

                Console.WriteLine("Excellent. Please provide the height.");

                var number2 = Console.ReadLine();
                int number2int = int.Parse(number2);

                Console.WriteLine("FindPerimeter(" + number1 + ", " + number2 + ") --> " + FindPerimeter(number1int, number2int));
            }

            if (programChooserint == 21)
            {
                //Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.
                Console.WriteLine("Hello! Give us a number for the corresponding month.");

                var number21 = Console.ReadLine();
                int number21int = int.Parse(number21);


                Console.WriteLine("Challenge 21 MonthName(" + number21int + ") is: " + MonthName(number21int));
            }

            if (programChooserint == 22){
                //From an array, return the minimum value and max value. Ex: [1,3,600,20] --> [1,600]
                int[] array1 = [];
                bool responses = true;
                int Counter = 0;

                Console.WriteLine("This is a function to sort and provide the smallest and largest number from an array.");
                Console.WriteLine("Give us numbers for an array!");

                Console.WriteLine("How many numbers do you want to sort?");
                var number22a = Console.ReadLine();
                int maxArraynum = int.Parse(number22a);

                while (responses == true){
                    Console.WriteLine("One number at a time, please.");
                    var number22 = Console.ReadLine();
                    int number21int = int.Parse(number22);
                    array1[Counter] = number21int;
                    Counter += 1;
                    if (Counter == maxArraynum)
                    {
                        responses = false;
                    }
                }

                Console.WriteLine("FindMinMax(" + string.Join(",", array1) + ") --> [" + MinMax(array1) + "]");
            }

            if (programChooserint == 23)
            {
                //out of an array, add the sum of all of their absolute values together.
                bool responses = true;
                int Counter2 = 0;

                Console.WriteLine("This is a function to add the absolute value of all numbers in an array.");
                Console.WriteLine("Give us numbers for an array!");

                Console.WriteLine("How many numbers do you want to sort?");
                var number23a = Console.ReadLine();
                int maxArraynum = int.Parse(number23a);
                int[] array1 = new int[maxArraynum];
                
                while (responses == true)
                {
                    Console.WriteLine("Is this number negative? (Y/N)");
                    var number23neg = Console.ReadLine();

                    Console.WriteLine("Type your number.");
                    var number23 = Console.ReadLine();
                    int number23int = int.Parse(number23);
                    if (number23neg.ToUpper() == "Y")
                    {
                        number23int = number23int * -1;
                    }
                    array1[Counter2] = number23int;
                    Counter2 += 1;
                    if (Counter2 == maxArraynum)
                    {
                        responses = false;
                    }
                }
                Console.WriteLine(getAbsSum(array1));
            }

            if(programChooserint == 24)
            {
                Console.WriteLine("In Challenge 24, we will be calculating an exponent.");
                Console.WriteLine("Give us the base number");

                var number24 = Console.ReadLine();
                int number24int = int.Parse(number24);

                Console.WriteLine("to the power of?..");
                var number24exp = Console.ReadLine();
                int number24expint = int.Parse(number24exp);

                Console.WriteLine("CalculateExponent(" + number24 + ", " + number24exp + ") --> " + CalculateExponent(number24int, number24expint));
            }

            if (programChooserint == 25)
            {
                //Create a function to multiply all of the values in an array by the amount of values in the given array.
                //Ex Array length = 3, so [1,4,2] would be [3, 12, 6]
                int[] ints = [1, 4, 2];

                foreach (int i in MultiplyByLength(ints)){
                    Console.WriteLine();
                }

                Console.WriteLine("FindMinMax(" + string.Join(",", ints) + ") --> [" + string.Join(",", MultiplyByLength(ints)) + "]");
            }

            if(programChooserint == 26)
            {
                //

                Console.WriteLine("First String");
                var str26 = Console.ReadLine();
                
                Console.WriteLine("Second String");
                var words26 = Console.ReadLine();

                Console.WriteLine("HammingDistance(" + str26 + "," + words26 + ") --> " + HammingDistance(str26,words26));
            }

            if(programChooserint == 27)
            {
                Console.WriteLine("Please provide a first and last name.");
                var str27 = Console.ReadLine();
                Console.WriteLine("NameShuffle(" + str27 + ") --> " + NameShuffle(str27));

            }

            if(programChooserint == 28)
            {
                int[] array2 = [ 0, 0 ];

                Console.WriteLine("Please provide two numbers. We will return the lowest.");

                Console.WriteLine("First Num");
                var firstnum= Console.ReadLine();
                int firstnumint = int.Parse(firstnum);
                array2[0] = firstnumint;

                Console.WriteLine("Second Num");
                var secondnum = Console.ReadLine();
                int secondnumint = int.Parse(secondnum);
                array2[1] = secondnumint;


                Console.WriteLine("smallerNum(" + firstnum + ", " + secondnum + ") --> " + smallerNum(array2));

            }

            if(programChooserint == 29)
            {
                Console.WriteLine("This is a factorial function. Please provide a number");
                var Num = Console.ReadLine();
                int Num1 = int.Parse(Num);
                
                Console.WriteLine("Factorial(" + Num1 + ") --> "+ Factorial(Num1));
            }
            /*
            if(programChooserint == 30)
            {

            }*/


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
    /*
    public static int CountVowels(string Word)
    {
        Word = Word.ToLower();
        string[] Letters = Word.Split(Word);
        var vowels = new HashSet<char>('a', 'e', 'i', 'o', 'u');

        int counter = 0;
        foreach (vowels.Contains(sentence[i])
        {
            counter++;
        }
    }*/

    public static int Factorial(int Num)
    {
        int nn = Num;

        for (int i = 1; i < Num; i++)
        {
            nn = (nn * i);
        }

        return nn;
    }

    public static int smallerNum(int[] arr)
    {
        Array.Sort(arr);
        int Min = arr.ElementAtOrDefault(0);
        int Max = arr.ElementAtOrDefault(1);

        //int[] MinMaxArr = [Min, Max];

        return Min;
    }

    public static string NameShuffle(string Names)
    {
        string[] List = Names.Split(' ');

        string Firstn = List[0];
        string Lastn = List[1];

        //string[] FinalList = { Lastn, Firstn };

        string fullname = Lastn + " " + Firstn;

        return fullname;
    }

    public static int HammingDistance(string s, string t)
    {

        if (s.Length != t.Length)
        {
            throw new Exception("Strings must be equal length");
        }

        int distance =
            s.ToCharArray()
            .Zip(t.ToCharArray(), (c1, c2) => new { c1, c2 })
            .Count(m => m.c1 != m.c2);

        return distance;
    }

    public static Array MultiplyByLength(int[] arr)
    {
        //multiply by arr.Length
        /*int len = arr.Length;
        int counter = 0;
        while (counter != len){
            arr[counter] = arr[counter] * len;
            counter++;
        }

        string result = arr
        return (result);*/

        int length = arr.Length;

        for(int i = 0; i < length; i++)
        {
            arr[i] *= arr.Length;
        }

        return arr;
    }
    public static double CalculateExponent(int Num, int Exp)
    {
        double pow = Math.Pow(Num, Exp);
        return pow;
    }

    public static int getAbsSum(int[] arr)
    {
        int AbsSum = 0;
        int counter = 0;
        while (counter != arr.Length)
        {
            AbsSum = AbsSum + Math.Abs(arr[counter]);
            counter++;
        }
        return AbsSum;
    }

    public static string MinMax(int[] arr){
        Array.Sort(arr);
        int MaxInt = arr.Length - 1;
        int Min = arr.ElementAtOrDefault(0);
        int Max = arr.ElementAtOrDefault(MaxInt);

        int [] MinMaxArr = [Min, Max];

        return (Min + "," + Max);
    }

    public static string MonthName(int Number21)
    {
        string[] months = { "Janurary", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        Number21 = Number21 - 1;

        return months[Number21];
    }


    public static float FindPerimeter(int width, int height)
    {
        return (width * 2) + (height * 2);
    }

    public static int Points(int twopointers, int threepointers)
    {
        return ((threepointers * 3) + (twopointers * 2));
    }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    public static int Convert(int number)
    {
        return number * 60;
    }

    public static int ConvertHours(int number)
    {
        return number * 3600;
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

    public static float SumPolygon(float number1)
    {
        return (number1 - 2) * 180;
    }

    public static bool lessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }

    public static bool isEqual(int number1, int number2)
    {
        return number1 == number2;
    }

    public static string giveMeSomething(string words10)
    {
        var Smthn = " Something ";

        return Smthn + words10;

    }

    public static string nameString(string words10)
    {
        var Edabit = "Edabit";

        return words10 + Edabit;

    }

    public static bool Reverse(bool Boolean11)
    {
        if (Boolean11)
        {
            return false;
        }
        else {
            return true;
        }
    }

    public static bool AndFunction(bool Boolean15, bool Boolean16)
    {
        if (Boolean15 && Boolean16)
        {
            return true;
        }
        else 
        { 
            return false; 
        }
    }
}