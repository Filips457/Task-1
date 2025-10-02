namespace Calculator;

public class Calculator
{
    private double firstOperand;
    private double secondOperand;
    private Func<double, double, double> calculateDelegate;

    private void GetOperator(char operatorCh)
    {
        switch (operatorCh)
        {
            case '+':
                calculateDelegate = (a, b) => a + b;
                break;
            case '-':
                calculateDelegate = (a, b) => a - b;
                break;
            case '*':
                calculateDelegate = (a, b) => a * b;
                break;
            case '/':
                calculateDelegate = (a, b) => a / b;
                break;
            default:
                throw new ArgumentException("Не найден оператор!");
        }
        Console.WriteLine(operatorCh);
    }

    public double Calculate()
    {
        Console.Write("Введите первый операнд: ");
        firstOperand = double.Parse(Console.ReadLine());

        Console.Write("Введите оператор: ");
        GetOperator(Console.ReadKey(true).KeyChar);

        Console.Write("Введите второй операнд: ");
        secondOperand = double.Parse(Console.ReadLine());

        return calculateDelegate(firstOperand, secondOperand);
    }
}