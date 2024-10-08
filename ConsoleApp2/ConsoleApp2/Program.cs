

class Program
{
    static void Main()
    {
        int number = 29; // Число для перевірки
        bool isPrime = IsPrime(number);
        Console.WriteLine($"Число {number} є простим? {isPrime}");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false; // Простими є числа більше за 1
        if (number == 2) return true;  // 2 — єдине парне просте число
        if (number % 2 == 0) return false; // Всі парні числа, крім 2, не є простими

        // Перевіряємо ділення тільки до квадратного кореня з числа
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false; // Якщо знайшли дільник, то число не є простим
        }

        return true; // Якщо дільників не знайшли, число є простим
    }
}
