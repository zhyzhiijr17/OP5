

class Program
{
    static void Main()
    {
        double operand1 = 10;
        double operand2 = 5;
        string operation = "+"; // Може бути "+", "-", "*", "/"

        double result = Calculate(operand1, operand2, operation);
        Console.WriteLine("Результат: " + result);
    }

    static double Calculate(double operand1, double operand2, string operation)
    {
        switch (operation)
        {
            case "+":
                return operand1 + operand2;
            case "-":
                return operand1 - operand2;
            case "*":
                return operand1 * operand2;
            case "/":
                if (operand2 != 0)
                    return operand1 / operand2;
                else
                    throw new DivideByZeroException("Ділення на нуль неможливе.");
            default:
                throw new InvalidOperationException("Невідома операція.");
        }
    }
}
