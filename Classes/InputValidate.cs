using System;

public static class InputValidate
{
    public static float ReadFloatNumber(string input)
    {
        if (float.TryParse(input, out float result))
        {
            return result;
        }
        throw new FormatException("Invalid float number");
    }

    public static string ReadString(string input)
    {
        return input.Trim();
    }
}
