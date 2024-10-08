using System;

class CurrencyConverter
{
    // Функція для конвертації суми з однієї валюти в іншу
    public static decimal ConvertCurrency(decimal amount, decimal exchangeRate)
    {
        return amount * exchangeRate;
    }

    static void Main(string[] args)
    {
        // Введення суми та курсу користувачем
        Console.WriteLine("Enter the amount in the original currency:");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the exchange rate:");
        decimal exchangeRate = Convert.ToDecimal(Console.ReadLine());

        // Конвертація суми
        decimal convertedAmount = ConvertCurrency(amount, exchangeRate);

        // Виведення результату
        Console.WriteLine($"Converted amount: {convertedAmount}");
    }
}
