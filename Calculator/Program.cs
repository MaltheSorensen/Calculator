using System;

class Program
{
    static void Main()
    {
        char choice;
        do
        {
            Console.WriteLine("Indtast det første nummer:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast det andet nummer:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vælg et tegn (+, -, *, /):");
            char oper = Convert.ToChar(Console.ReadLine());

            double result = Double.NaN;

            switch (oper)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Fejl! Du kan ikke dividere med nul..");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Fejl! Prøv igen");
                    return;
            }

            Console.WriteLine($"Resultat: {result}");

            Console.WriteLine("Vil du lave endnu en udregning? (Y/N)");
            choice = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        }
        while (choice == 'Y');
    }
}
