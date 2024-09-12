namespace GuessingGame.Domain.Numbers.Base;

public abstract class Number
{
    public int Value { get; protected set; }

    public Number(int value)
    {
        Value = value;
    }

    public bool IsLessThen(Number number)
        => Value < number.Value;

    public bool IsGreaterThen(Number number)
        => Value > number.Value;

    public bool IsEquals(Number number)
        => Value == number.Value;

    public static int ConvertStringToInt32(string? value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Int32.TryParse(value, out int number))
        {
            throw new ArgumentException("Number must be an integer.");
        }
        return number;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
