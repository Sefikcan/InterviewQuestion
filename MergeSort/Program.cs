/* Merge Sort Algorithm
 * TR
 * Böl ve yönet algoritmasıdır.
 * Problem daha küçük problemlere bölünür, burada her küçük problem, kendisi dışındaki daha büyük problemin tüm özelliklerini korur.
 * Orjinal problemi çözmek için her parça ayrı ayrı çözülür, daha sonra parçalar birleştirilir.
 * O(n*log(n)) time complexity'sine sahiptir.
 
 * EN
 * The merge sort algorithm is a divide and conquers algorithm
 * In the divide and conquer paradigm, a problem is broken into smaller problems where each small problem still retains all the properties of the larger problem -- except its size.
 * To solve the original problem, each piece is solved individually; then the pieces are merged back together.
 * it has O(n*log(n)) time complexity.
 * */

int[] numbers = { 87, 57, 370, 110, 90, 610, 02, 710, 140, 203, 150 };
Console.WriteLine($"Arrays before sorting:");
numbers.ToList().ForEach(x => Console.Write($"{x} "));

MergeSort(numbers, 0, numbers.Length - 1);

Console.Write("\n");

Console.WriteLine($"Arrays after sorting:");
numbers.ToList().ForEach(x => Console.Write($"{x} "));

Console.ReadKey();

static void MergeSort(int[] numbers, int start, int end)
{
    int mid = (start + end) / 2;
    if (start < end)
    {
        MergeSort(numbers, start, mid);
        MergeSort(numbers, mid + 1, end);
    }

    int i = 0, first = start, last = mid + 1;
    int[] tmp = new int[end - start + 1];
    while (first <= mid && last <= end) 
    { 
        tmp[i++] = numbers[first] < numbers[last] ? numbers[first++] : numbers[last++]; 
    } 
    while (first <= mid) 
    { 
        tmp[i++] = numbers[first++]; 
    }
    while (last <= end) 
    { 
        tmp[i++] = numbers[last++]; 
    }
    i = 0;
    while (start <= end) 
    {
        numbers[start++] = tmp[i++]; 
    }
}