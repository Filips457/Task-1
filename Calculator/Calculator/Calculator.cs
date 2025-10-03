namespace Calculator;

public class Calculator
{
    private double firstOperand;
    private double secondOperand;
    private Func<double, double, double> calculateDelegate;
    OperandReader operandReader = new();

    public double Calculate()
    {
        firstOperand = operandReader.GetOperand("Введите первый операнд: ");

        calculateDelegate = operandReader.GetOperator("Введите оператор: ");

        secondOperand = operandReader.GetOperand("Введите второй операнд: ");

        return calculateDelegate(firstOperand, secondOperand);
    }
}