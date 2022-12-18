// See https://aka.ms/new-console-template for more information
using CodilityChallenges.Extenstions;
using CodilityChallenges.Models;

Random getrandom = new();
int howManyLoopExamples = 10;
string codilityLink = "https://app.codility.com/";
Console.WriteLine($"Console app with solutions to problems I worked on in codility - {codilityLink}");

static string WriteSimpleExampleForWordCount(string s) =>
    $"In the sentence \"{s}\" there are {s.WordCount()} words.";

static string WriteMessageForStringOfAsAndBs(int a, int b) =>
    $"For a={a} and b={b} created string is: {new CreateStringOfABs(a, b).Value}";

static string WriteMessageForParkingBill(string E, string L) =>
    $"Price for parking (entrace: {E}, left: {L}) is ${new Parking(TimeSpan.Parse(E), TimeSpan.Parse(L)).Bill}";

static string WriteMessageForHighestPowerOf2ThatDividesN(int N) =>
    $"Given N={N} the highest power of two that divides it is: {N.HighestPowerOf2ThatDividesN()}";

Console.WriteLine("Simple start:");
Console.WriteLine(WriteSimpleExampleForWordCount("Hello Extension Methods"));
Console.WriteLine("\r\nExercise 5\r\nCoding skills");
Console.WriteLine("\r\nTask: ParkingBill\r\n");
Console.WriteLine(WriteMessageForParkingBill("09:42", "11:42"));
Console.WriteLine(WriteMessageForParkingBill("10:00", "13:21"));
Console.WriteLine("\r\nTask: ParityDegree\r\n");
Console.WriteLine(WriteMessageForHighestPowerOf2ThatDividesN(16));
Console.WriteLine(WriteMessageForHighestPowerOf2ThatDividesN(13));
Console.WriteLine(WriteMessageForHighestPowerOf2ThatDividesN(12));
foreach (var _ in Enumerable.Range(0, howManyLoopExamples))
    Console.WriteLine(WriteMessageForHighestPowerOf2ThatDividesN(getrandom.Next(1, 10000)));
Console.WriteLine("\r\nTask: ThreeLetters\r\n");
Console.WriteLine(WriteMessageForStringOfAsAndBs(1, 4));
Console.WriteLine(WriteMessageForStringOfAsAndBs(4, 1));
try
{
    foreach (var _ in Enumerable.Range(0, howManyLoopExamples))
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
