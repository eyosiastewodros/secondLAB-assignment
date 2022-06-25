// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("welcome to our grade system");
Console.WriteLine("Enter the number of students");
int n = int.Parse(Console.ReadLine());


int[] Grade = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter your Grade for Student " + (i + 1));

    Grade[i] = int.Parse(Console.ReadLine());
    if (Grade[i] > 100 || Grade[i] < 0)
    {
        Console.WriteLine("No such grade!please Renter!:");
        Grade[i] = int.Parse(Console.ReadLine());
    }

    {
        if (Grade[i] > 89)
        {
            Console.WriteLine(" Your Grade is 'A'");
        }
        else if (Grade[i] > 79)
        {
            Console.WriteLine(" Your Grade is 'B'");
        }
        else if (Grade[i] > 69)
        {
            Console.WriteLine(" Your Grade is 'C'");
        }
        else if (Grade[i] > 59)
        {
            Console.WriteLine(" Your Grade is 'D'");
        }
        else
        {
            Console.WriteLine(" Your Grade is 'F'");
        }
    }
}