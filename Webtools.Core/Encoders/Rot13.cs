namespace WebTools.Core.Encoders;

public static class Rot13
{
    /// <summary>
    /// Performs the ROT13 character rotation.
    /// Taken from: https://thedeveloperblog.com/rot13
    /// (refactored).
    /// </summary>
    public static string Transform(string value)
    {
        var array = value.ToCharArray();
        for (var i = 0; i < array.Length; i++)
        {
            var number = (int)array[i];

            switch (number)
            {
                case >= 'a' and <= 'z' when number > 'm':
                    number -= 13;
                    break;
                case >= 'a' and <= 'z':
                    number += 13;
                    break;
                case >= 'A' and <= 'Z' when number > 'M':
                    number -= 13;
                    break;
                case >= 'A' and <= 'Z':
                    number += 13;
                    break;
            }
            array[i] = (char)number;
        }
        return new string(array);
    }
}