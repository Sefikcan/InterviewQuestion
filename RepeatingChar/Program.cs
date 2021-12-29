
string input = "Buble Sort, Merge Sort, ...";
char findChar = 'o';

int charCount = 0;

var inputCharArray = input.ToCharArray();

for (int i = 0; i < inputCharArray.Length; i++)
{
    if (inputCharArray[i] == findChar)
    {
        charCount++;
    }
}

Console.WriteLine($"Count of character {findChar} on string:{input} : {charCount}");

Console.ReadKey();