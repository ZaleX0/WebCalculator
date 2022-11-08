using WebCalculator.Models;

namespace WebCalculator.Services;

public class CalculatorService
{
    public Calculator Calculate(Calculator calculator)
    {
        calculator.Result = calculator.Operation switch
        {
            Operation.Addition       => Add(calculator),
            Operation.Subtraction    => Substract(calculator),
            Operation.Multiplication => Multiply(calculator),
            Operation.Division       => Divide(calculator),
            _ => 0
        };
        return calculator;
    }

    private decimal Add(Calculator calculator)
    {
        return calculator.Number1 + calculator.Number2;
    }

    private decimal Substract(Calculator calculator)
    {
        return calculator.Number1 - calculator.Number2;
    }

    private decimal Multiply(Calculator calculator)
    {
        return calculator.Number1 * calculator.Number2;
    }

    private decimal Divide(Calculator calculator)
    {
        try
        {
            return calculator.Number1 / calculator.Number2;
        }
        catch (DivideByZeroException e)
        {
            calculator.ErrorMessage = e.Message;
            return 0;
        }
    }
}
