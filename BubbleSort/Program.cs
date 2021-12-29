/* Bubble Sort Algorithm
 * TR
 * En popüler sıralama algoritmalarından biri olmasına rağmen, performans olarak kötüdür.
 * O(n^2) time complexity'sine sahiptir.  Dizinin boyutu büyüdükçe, bu diziyi sıralamak için geçen süre boyutun karesi şeklinde artacaktır.
 * Bu algoritma yerine quick sort ve merge sort algoritmaları kullanılır.
 * Bu algoritmanın performansının yavaş olmasının nedeni, dizinin her bir elemanını diğeriyle karşılaştırılıp, yer değiştirme işleminin yapılmasıdır.
 
 * EN
 * It's kind of weird that one of the most popular sorting algorithms is also one of the worst-performing sorting algorithms
 * Bubble sort's average-case performance is in O(n^2), which means as the size array grows, the time it takes to sort that array increases quadratically
 * Due to this reason, bubble sort is not used in production code, instead quick sort and merge sort are preferred over it.
 * The reason for the slow performance of this algorithm is an excessive comparison and swapping since it compares each element of array to another and swaps if it is on the right side.
 * */


BubleSort(new int[] { 800, 11, 50, 771, 649, 770, 240, 9 });


static void BubleSort(int[] numbers)
{
    int temp;

    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < numbers.Length - 1; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                temp = numbers[j + 1];
                numbers[j + 1] = numbers[j];
                numbers[j] = temp;
            }
        }
    }

    for (int i = 0; i < numbers.Length; i++)
        Console.Write(numbers[i] + " ");
    Console.ReadKey();
}