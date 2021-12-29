/* Counting Sort Algorithm
 * TR
 * Doğrusal sıralama algoritmasıdır.
 * En hızlı algoritmalardan biridir.
 * O(n) time complexity'sine sahiptir.
 * Her değer için bir bucket oluşturur ve her bucket bir sayaç tutar. Daha sonra listedeki bir değerle her karşılaşıldığında, uygun sayaç artırılır.
 
 * EN
 * Linear sorting algorithm.
 * Counting sort is among the fastest sorting algorithms
 * Counting sort algorithm performance is in O(n)
 * Well, counting sort creates a bucket for each value and keeps a counter in each bucket. Then each time a value is encountered in the input collection,  the appropriate counter is incremented.
 * */

int[] array = new int[10]
{
    2, 5, -4, 11, 0, 8, 22, 67, 51, 6
};

Console.WriteLine("\n" + "Original array :");
foreach (int aa in array)
    Console.Write(aa + " ");

int[] sortedArray = new int[array.Length];

// find smallest and largest value
int minVal = array[0];
int maxVal = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < minVal) 
        minVal = array[i];
    else if (array[i] > maxVal)
        maxVal = array[i];
}

// init array of frequencies
int[] counts = new int[maxVal - minVal + 1];

// init the frequencies
for (int i = 0; i < array.Length; i++)
{
    counts[array[i] - minVal]++;
}

// recalculate
counts[0]--;
for (int i = 1; i < counts.Length; i++)
{
    counts[i] = counts[i] + counts[i - 1];
}

// Sort the array
for (int i = array.Length - 1; i >= 0; i--)
{
    sortedArray[counts[array[i] - minVal]--] = array[i];
}

Console.WriteLine("\n" + "Sorted array :");
foreach (int aa in sortedArray)
    Console.Write(aa + " ");
Console.Write("\n");