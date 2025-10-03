namespace Calculator;

public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();
        do
        {
            try
            {
                var res = calculator.Calculate();
                Console.WriteLine($"Результат: {res}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка деления на ноль: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine("Нажмите 'y', чтобы ещё раз воспользоваться калькулятором.");
            Console.WriteLine("Нажмите любую другую клавишу для выхода.");
        } while (Console.ReadKey(true).Key == ConsoleKey.Y);
    }
}