namespace CodilityChallenges.Extenstions;

internal static class ExtensionsForCodingProblems
{
    public static int WordCount(this string str) =>
        str.Split(new char[] { ' ', '.', '?', '!' },
            options: StringSplitOptions.RemoveEmptyEntries).Length;

    public static int HighestPowerOf2ThatDividesN(this int n)
    {
        int a = 0;
        a = (n % 2 == 0) ? 1 + HighestPowerOf2ThatDividesN(n / 2) : a;
        return a;
    }
}
