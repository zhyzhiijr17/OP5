
class Program
{
    // Функція для підрахунку кількості голосних і приголосних букв
    public static (int vowels, int consonants) CountVowelsAndConsonants(string input)
    {
        // Перетворюємо рядок на нижній регістр для полегшення обробки
        input = input.ToLower();

        // Оголошуємо голосні букви
        char[] vowelsArray = { 'a', 'e', 'i', 'o', 'u', 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' }; // Англійські та українські голосні

        // Ініціалізуємо лічильники для голосних і приголосних
        int vowelsCount = 0;
        int consonantsCount = 0;

        // Проходимо по кожному символу в рядку
        foreach (char c in input)
        {
            // Перевіряємо, чи символ є літерою
            if (char.IsLetter(c))
            {
                // Якщо символ є голосною
                if (Array.Exists(vowelsArray, vowel => vowel == c))
                {
                    vowelsCount++;
                }
                else
                {
                    consonantsCount++;
                }
            }
        }

        // Повертаємо кількість голосних і приголосних
        return (vowelsCount, consonantsCount);
    }

    static void Main(string[] args)
    {
        // Введення рядка користувачем
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        // Виклик функції для підрахунку
        var (vowels, consonants) = CountVowelsAndConsonants(input);

        // Виведення результатів
        Console.WriteLine($"Голосних: {vowels}");
        Console.WriteLine($"Приголосних: {consonants}");
    }
}
