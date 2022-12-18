using System.Text;

namespace CodilityChallenges.Models;

/// <summary>
/// Return a string which contains A letters "a" and B letters "b",
/// with no three consecutive letters being the same.
/// </summary>
internal class CreateStringOfABs
{
    /// <summary>
    /// Value of created string
    /// </summary>
    public string Value;

    /// <summary><inheritdoc cref="CreateStringOfABs" path="/summary"/></summary>
    /// <param name="a">Integer number of a's</param>
    /// <param name="b">Integer number of b's</param>
    internal CreateStringOfABs(int a, int b)
    {
        Value = FormatString(a, b, new StringBuilder());
    }

    private string FormatString(int a, int b, StringBuilder result)
    {
        var stringLength = result.Length;
        if (stringLength == 0 && (b > 3 * a + 1 || a > 3 * b + 1)) throw new ArgumentException($"Not possible to construct such a string for values a:{a} and b:{b}");
        else if (a > b && b != 0)
        {
            result.Append("aab");
            FormatString(a - 2, b - 1, result);
        }
        else if (b > a && a != 0)
        {
            result.Append("bba");
            FormatString(a - 1, b - 2, result);
        }
        else if (b > a && b > 1)
        {
            result.Append("bb");
            FormatString(a, b - 2, result);
        }
        else if (b > a && b == 1)
        {
            result.Append('b');
            FormatString(a, b - 1, result);
        }
        else if (a > b && a > 1)
        {
            result.Append("aa");
            FormatString(a - 2, b, result);
        }
        else if (a > b && a == 1)
        {
            result.Append('a');
            FormatString(a - 1, b, result);
        }
        else if (a == b && a != 0)
        {
            result.Append("ab");
            FormatString(a - 1, b - 1, result);
        }
        return result.ToString();
    }

}
