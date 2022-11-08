# Web Calculator
1. User inputs two numbers and chooses one of four operations (+, -, *, /)
2. The [Calculator](Models/Calculator.cs) model is sent to the [CalculatorController](Controllers/CalculatorController.cs)
3. Then it is processed by the [CalculatorService](Services/CalculatorService.cs)
4. Based on the [Operation](Models/Operation.cs) enum in the model, it uses correct method
5. After calculation, the result is saved to the `Result` property in [Calculator](Models/Calculator.cs)
    - In case of dividing by zero the `DivideByZeroException` is cought and the error message is saved to the nullable `ErrorMessage` Property in [Calculator](Models/Calculator.cs)
6. Then the [CalculatorService](Services/CalculatorService.cs) returns [Calculator](Models/Calculator.cs) with the values in the `Result` and/or the `ErrorMessage` properties
7. [CalculatorController](Controllers/CalculatorController.cs) returns the View, in which, if the `ErrorMessage` is null it shows the `Result`, else it shows the `ErrorMessage`
