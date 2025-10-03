namespace Calculator;

public class Calculator
{
    private double firstOperand;
    private double secondOperand;
    private Func<double, double, double> calculateDelegate;
    OperandReader operandReader = new();

    public double Calculate()
    {
        Console.Write("Введите первый операнд: ");
        firstOperand = operandReader.GetOperand();

        Console.Write("Введите оператор: ");
        calculateDelegate = operandReader.GetOperator();

        Console.Write("Введите второй операнд: ");
        secondOperand = operandReader.GetOperand();

        return calculateDelegate(firstOperand, secondOperand);
    }
}