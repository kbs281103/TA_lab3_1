using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть текстовий рядок (для виходу введіть 'exit'): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            // Підрахунок кількості цифр у тексті
            int digitsCount = CountDigits(input);
            Console.WriteLine($"Кількість цифр у тексті: {digitsCount}");

            // Виведення слів, що починаються з приголосних літер
            Console.WriteLine("Слова, що починаються з приголосних літер:");
            PrintWordsStartingWithConsonants(input);
        }
    }

    static int CountDigits(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                count++;
            }
        }
        return count;
    }

    static void PrintWordsStartingWithConsonants(string input)
    {
        // Регулярний вираз для пошуку слів, що починаються з приголосних літер
        string pattern = @"\b[бвгґджзйклмнпрстфхцчшщБВГҐДЖЗЙКЛМНПРСТФХЦЧШЩ]\w*\b";

        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
