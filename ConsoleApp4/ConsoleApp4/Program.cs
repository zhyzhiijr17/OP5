
class Program
{
    // Функція для знаходження найменшого і найбільшого елементів в масиві
    public static (int min, int max) FindMinAndMax(int[] array)
    {
        // Перевірка, чи масив не є порожнім
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Масив не може бути порожнім.");
        }

        // Ініціалізація змінних для зберігання найменшого і найбільшого значень
        int min = array[0];
        int max = array[0];

        // Прохід по масиву для знаходження мінімуму та максимуму
        foreach (int num in array)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }
        }

        // Повернення мінімального та максимального значення
        return (min, max);
    }

    static void Main(string[] args)
    {
        // Приклад масиву
        int[] array = { 5, 3, 8, 1, 9, 2 };

        // Виклик функції для знаходження мінімуму та максимуму
        var (min, max) = FindMinAndMax(array);

        // Виведення результату
        Console.WriteLine($"Найменший елемент: {min}");
        Console.WriteLine($"Найбільший елемент: {max}");
    }
}
