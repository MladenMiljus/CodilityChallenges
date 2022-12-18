// See https://aka.ms/new-console-template for more information
using CodilityChallenges.Extenstions;
using CodilityChallenges.Models;

Random getrandom = new();
string codilityLink = "https://app.codility.com/";
Console.WriteLine($"Console app with solutions to problems I worked on in codility - {codilityLink}");

static string WriteMessageForStringOfAsAndBs(int a, int b) =>
    $"For a={a} and b={b} created string is: {new CreateStringOfABs(a, b).Value}";

static string WriteMessageForHighestPowerOf2ThatDividesN(int N) =>
    $"Given N={N} the highest power of two that divides it is: {N.HighestPowerOf2ThatDividesN()}";

Console.WriteLine("Hello Extension Methods".WordCount());
Console.WriteLine(WriteMessageForStringOfAsAndBs(1, 4));
Console.WriteLine(WriteMessageForStringOfAsAndBs(4, 1));
try
{
    foreach (var _ in Enumerable.Range(0, 10))
        try
        {
            Console.WriteLine(WriteMessageForStringOfAsAndBs(getrandom.Next(1, 100), getrandom.Next(1, 100)));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            continue;
        }     
    Console.WriteLine(WriteMessageForStringOfAsAndBs(1, 5));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine(WriteMessageForHighestPowerOf2ThatDividesN(16));
Console.WriteLine(WriteMessageForHighestPowerOf2ThatDividesN(13));
Console.WriteLine(WriteMessageForHighestPowerOf2ThatDividesN(12));
foreach (var _ in Enumerable.Range(0, 10))
    Console.WriteLine(WriteMessageForHighestPowerOf2ThatDividesN(getrandom.Next(1, 10000)));
