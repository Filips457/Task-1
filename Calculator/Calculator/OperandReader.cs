namespace Calculator;

public class OperandReader
{
    public double GetOperand()
    {
        return double.Parse(Console.ReadLine());
    }

    public Func<double, double, double> GetOperator()
    {
        char key = Console.ReadKey().KeyChar;
        Console.WriteLine();

        return GetOperator(key);
    }

    private Func<double, double, double> GetOperator(char operatorCh) =>
        operatorCh switch
        {
            '+' => (a, b) => a + b,
            '-' => (a, b) => a - b,
            '*' => (a, b) => a * b,
            '/' => (a, b) =>
            {
                if (b == 0) throw new DivideByZeroException("Деление на ноль!");
                return a / b;
            },
            _ => throw new ArgumentException("Не найден оператор!")
        };
}