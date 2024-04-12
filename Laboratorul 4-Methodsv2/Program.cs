//Console.WriteLine("Numele meu este Andrei");
//Tipuri de parametri in metode 
/*
using System.Reflection.Metadata;

Method()->fara parametri
Method(string a, int b)-> 2 parametri
Method(float x = 0.0f, decimal y = 3.14d)->parametri optionali
Method (params string[] elemente) ->numar variabil de parametri
*/
//call the method;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

static class Program
{
    static void Main(string[] args)
    {
        //call method
        //PrintName();
        //Add(2, 3);
        //Add(6543, 2131);
        //Add(-50, 12);
        //NU se poare face Add("Alex", "claudia");

        //Console.WriteLine("Please imput your first number");
        //var firtstNumber = ReadFromConsole();
        //Console.WriteLine("Please imput your second number");
        //var secondNumber = ReadFromConsole();

        //Console.WriteLine("Rezultatul este: ");
        //Add(firtstNumber, secondNumber);


        //var result = ReadFromConsole();
        //Console.WriteLine($"The result from console is {result}");
        //DisplayNumbers();
        //DisplayNumbers(4,7);
        //DisplayNumbers(50);
        //DisplayNumbers(end: 110 , start: 95);

        Console.WriteLine(ComputeSum());
        var sum = ComputeSum(1, 45, -8, 12);
        Console.WriteLine(sum);
    }

    static int ReadFromConsole()
    {
        var line = Console.ReadLine();
        bool success = int.TryParse(line, out int result);

        if (success)
        {
            return result;
        }
        else
        {
            Console.WriteLine("Sorry, the input cannot be transformed to a number");
            return result;
        }
        //return result;
    }

    //Declarare new method
    static void PrintName()
    {
        //do something
        Console.WriteLine("Numele meu este Andrei");
    }

    static void Add(int a, int b)
    {
        //int a = 2;
        //int b = 3;
        Console.WriteLine(a + b);
    }

    static void Add(int? a, int? b)
    {
        if (a == null || b == null)
        {
            Console.WriteLine("Either one of the input or both are not numeric values. Please try again.");
            return;
        }
        Console.WriteLine(a + b);
    }

    static void Add(float a, float b)
    {
        Console.WriteLine(a+b);

    }

    static void Add(decimal c, decimal d)
    {
        Console.WriteLine(c + d);

    }


    //Optional Parameters
    static void DisplayNumbers(int start = 0, int end = 100)
    {
        for(int i = start; i <= end; i++)
        {
            Console.Write($"{i}, ");           
        }
        Console.Write("<<<<");
    }
    //Variable number of parameters
    static long ComputeSum(params int[] numbers)
    {
        long sum = 0;
        foreach (int numar in numbers)
        {
           sum +=numar;
            //sum = sum + numar;
            //este acelasi lucru ca ce este mai sus
        }
        return sum;
    }

    //Overloadin Methods

}