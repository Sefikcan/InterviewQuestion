

var numbers = new int[]
{
    1,1,2,2,3,4,5, 99,11,44, 11,22,33,14
};

Console.WriteLine(RemoveDuplicateItem(numbers));

Console.ReadKey();

static int[] RemoveDuplicateItem(int[] numbers)
{
    Array.Sort(numbers);
    int[] result = new int[numbers.Length];
    int previous = numbers[0];
    result[0] = previous;

    for (int i = 1; i < numbers.Length; i++)
    {
        int temp = numbers[i];
        if (previous != temp)
        {
            result[i] = temp;
        }
        previous = temp;
    }

    return result;
}