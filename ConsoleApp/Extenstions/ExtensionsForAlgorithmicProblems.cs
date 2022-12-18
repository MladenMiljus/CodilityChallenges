namespace CodilityChallenges.Extenstions;

internal static class ExtensionsForAlgorithmicProblems
{
    public static int FirstNonRepeatingMember(this int[] array)
    {
        Dictionary<int, int> hashTable = new();
        foreach (var item in array)
        {
            if (hashTable.ContainsKey(item))
            {
                hashTable[item] += 1;
            }
            else hashTable.Add(item, 1);
        }
        int result;
        try
        {
            result = hashTable.First(x => x.Value == 1).Key;
        }
        catch (Exception)
        {
            result = -1;
        }
        return result;
    }
}
