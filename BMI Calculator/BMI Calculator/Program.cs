using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Disclaimer: This calculator is not suitable if you are under the age of 18, are pregnant, or have an eating disorder (in which case you should consult your GP).");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        Console.Write("Enter your weight in kilograms: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your height in metres: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double BMIAnswer = BMIFormula(weight, height);
        Console.WriteLine("Your BMI is: " + BMIAnswer);
        if (BMIAnswer < 18.5) { 
            Console.WriteLine("You are in the underweight range.");
        } else if (BMIAnswer >= 18.5 && BMIAnswer <= 24.9) {
            Console.WriteLine("You are in the healthy weight range.");
        } else if (BMIAnswer >= 24.9 && BMIAnswer <= 29.9) {
            Console.WriteLine("You are in the overweight range.");
        } else if (BMIAnswer >= 30) {
            Console.WriteLine("You are in the obese range.");
        }
    }

    public static double BMIFormula(double weight, double height) {
        double BMI = weight / (height * height);
        return BMI;
    }
}

