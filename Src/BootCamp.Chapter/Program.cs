using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; 
            int age;
            double weight, height, BMI;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = int.Parse((Console.ReadLine()));
            Console.Write("Enter your weight in (kg): ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your height in (cm): ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm");
            BMI = (weight/height/height) * 10000;
            Console.WriteLine($"{name}, BMI is {BMI}");


            Console.Write("\nEnter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = int.Parse((Console.ReadLine()));
            Console.Write("Enter your weight in (kg): ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your height in (cm): ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm");

            BMI = (weight/height/height) * 10000;
            Console.WriteLine($"{name} BMI is {BMI}");
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey();
        }
    }
}
