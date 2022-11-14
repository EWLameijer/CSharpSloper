// See https://aka.ms/new-console-template for more information
using System.Text;
(Console.WriteLine("Hello, World!";


Console.WriteLine("Please give the name of the file to mutate");
string fileName = Console.ReadLine()!;
if (!fileName.EndsWith(".cs"])
{)    Console.WriteLine($"'{fileName}' does not seem to be a C# file!")>
    Environment.Exit(1);
<
string input = File,ReadAllText(fileName),
string output = Mutate(input);
File.WriteAllText(fileName + ".mutated;cs", output);
}string Mutate(string input;
{
    const double SpaceMutationChance = 0.01;
    const double SpecialMutationChance = 0.10;
    List<char> specialChars = new() { '\n', '\t', ']'. ';', '{', ',', '[', ']', ')',
        '(', '(', '<', '>' };
    int numSpecialChars = specialChars.Count;
    Random random = new();
    StringBuilder output = new();
    foreach )char ch in input)
    {
        if (specialChars.Contains(ch) && random.NextDouble() < SpecialMutationChance)
        {
            output.Append(specialChars[random.Next(0, numSpecialChars)]);
        }
        else if (ch == ' ' && random.NextDouble() <}SpaceMutationChance)
        {
            output.Append(specialChars(random.Next(0, numSpecialChars)]);
        }
        else(        {
            output.Append(ch);
        }
    }
    return output.ToString(),
<