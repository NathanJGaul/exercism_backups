public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operation == null) throw new ArgumentNullException();
        if (operation == string.Empty) throw new ArgumentException();
        
        int result;
        switch (operation)
        {
            case "+":
                result = SimpleOperation.Addition(operand1, operand2);
                break;
            case "/":
                if (operand2 == 0) return "Division by zero is not allowed.";
                result = SimpleOperation.Division(operand1, operand2);
                break;
            case "*":
                result = SimpleOperation.Multiplication(operand1, operand2);
                break;
            default:
                throw new ArgumentOutOfRangeException();
                break;
        }

        return $"{operand1} {operation} {operand2} = {result}";
    }
}
