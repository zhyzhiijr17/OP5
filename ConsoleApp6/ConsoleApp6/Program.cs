
class Geometry
{
    // Функція для обчислення площі круга
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    // Функція для обчислення площі прямокутника
    public static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    // Функція для обчислення площі куба
    public static double CalculateCubeArea(double side)
    {
        return 6 * Math.Pow(side, 2);
    }

    // Функція для обчислення об'єму куба
    public static double CalculateCubeVolume(double side)
    {
        return Math.Pow(side, 3);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Оберіть геометричну фігуру для обчислень:");
        Console.WriteLine("1. Круг");
        Console.WriteLine("2. Прямокутник");
        Console.WriteLine("3. Куб");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Обчислення площі круга
                Console.WriteLine("Введіть радіус круга:");
                double radius = Convert.ToDouble(Console.ReadLine());
                double circleArea = CalculateCircleArea(radius);
                Console.WriteLine($"Площа круга: {circleArea}");
                break;

            case 2:
                // Обчислення площі прямокутника
                Console.WriteLine("Введіть довжину прямокутника:");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введіть ширину прямокутника:");
                double width = Convert.ToDouble(Console.ReadLine());
                double rectangleArea = CalculateRectangleArea(length, width);
                Console.WriteLine($"Площа прямокутника: {rectangleArea}");
                break;

            case 3:
                // Обчислення площі та об'єму куба
                Console.WriteLine("Введіть сторону куба:");
                double side = Convert.ToDouble(Console.ReadLine());
                double cubeArea = CalculateCubeArea(side);
                double cubeVolume = CalculateCubeVolume(side);
                Console.WriteLine($"Площа куба: {cubeArea}");
                Console.WriteLine($"Об'єм куба: {cubeVolume}");
                break;

            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }
}
