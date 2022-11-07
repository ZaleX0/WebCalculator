using WebCalculator.Models;

namespace WebCalculator.Services;

public class CalculatorService
{
    public Calculator Calculate(Calculator calculator)
    {
        calculator.Result = calculator.Operation switch
        {
            Operation.Addition       => calculator.Number1 + calculator.Number2,
            Operation.Subtraction    => calculator.Number1 - calculator.Number2,
            Operation.Multiplication => calculator.Number1 * calculator.Number2,
            Operation.Division       => calculator.Number1 / calculator.Number2,
            _ => 0
        };
        return calculator;
    }
}
