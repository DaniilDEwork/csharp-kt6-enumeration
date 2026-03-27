using System;

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Cyan,
    Magenta
}

enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Дни недели");
        PrintDay(DayOfWeek.Monday);
        PrintDay(DayOfWeek.Wednesday);
        PrintDay(DayOfWeek.Sunday);

        Console.WriteLine();
        Console.WriteLine("2. Цвета и их HEX-коды");
        Console.WriteLine("Red = " + GetHexCode(Color.Red));
        Console.WriteLine("Green = " + GetHexCode(Color.Green));
        Console.WriteLine("Blue = " + GetHexCode(Color.Blue));
        Console.WriteLine("Yellow = " + GetHexCode(Color.Yellow));
        Console.WriteLine("Cyan = " + GetHexCode(Color.Cyan));
        Console.WriteLine("Magenta = " + GetHexCode(Color.Magenta));

        Console.WriteLine();
        Console.WriteLine("3. Арифметические операции");
        Console.WriteLine("10 + 5 = " + Calculate(10, 5, Operation.Add));
        Console.WriteLine("10 - 5 = " + Calculate(10, 5, Operation.Subtract));
        Console.WriteLine("10 * 5 = " + Calculate(10, 5, Operation.Multiply));
        Console.WriteLine("10 / 5 = " + Calculate(10, 5, Operation.Divide));

        Console.ReadLine();
    }

    static void PrintDay(DayOfWeek day)
    {
        switch (day)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Понедельник");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Вторник");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Среда");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Четверг");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Пятница");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Суббота");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Воскресенье");
                break;
        }
    }

    static string GetHexCode(Color color)
    {
        switch (color)
        {
            case Color.Red:
                return "#FF0000";
            case Color.Green:
                return "#00FF00";
            case Color.Blue:
                return "#0000FF";
            case Color.Yellow:
                return "#FFFF00";
            case Color.Cyan:
                return "#00FFFF";
            case Color.Magenta:
                return "#FF00FF";
            default:
                return "#000000";
        }
    }

    static double Calculate(double a, double b, Operation operation)
    {
        switch (operation)
        {
            case Operation.Add:
                return a + b;
            case Operation.Subtract:
                return a - b;
            case Operation.Multiply:
                return a * b;
            case Operation.Divide:
                return a / b;
            default:
                return 0;
        }
    }
}