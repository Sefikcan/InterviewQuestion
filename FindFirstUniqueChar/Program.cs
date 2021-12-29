
string input = "simplest";


static char FindFirstNonRepeatingChar(string input)
{
    var rpt = new HashSet<char>();

    List<char> nonRepeatingChar = new List<char>();
    for (int i = 0; i < input.ToCharArray().Length; i++)
    {
        char letter = input.ElementAt(i);
        if (rpt.Contains(letter))
        {
            continue;
        }

        if (nonRepeatingChar.Contains(letter))
        {
            nonRepeatingChar.Remove((char)letter);
            rpt.Add(letter);
        }
        else
        {
            nonRepeatingChar.Add(letter);
        }
    }
    return nonRepeatingChar.First();
}

var nonRepeatingChar = FindFirstNonRepeatingChar(input);

Console.WriteLine($"Val:{nonRepeatingChar}");

Console.ReadKey();