int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i< array.Length; i++) 
{
    Console.Write(array[i] + " ");
}

Console.WriteLine("\n");

var reverseArray = ReverseArray(array);

for (int i = 0; i < reverseArray.Length; i++)
{
    Console.Write(reverseArray[i] + " ");
}

Console.ReadKey();

static int[] ReverseArray(int[] a)
{
    int index = a.Length - 1;
    int first = 0;

    for (int i = first; i < index; i++)
    {
        int temp = a[index];

        a[index] = a[first];
        a[first] = temp;

        first += 1;
        index -= 1;
    }

    return a;
}