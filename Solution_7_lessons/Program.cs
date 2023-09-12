
static void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
}


Console.WriteLine("Enter numbers separated by commas");
string[] numbers = Console.ReadLine().Split(new char[] { ',' });
int[] array = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    array[i] = int.Parse(numbers[i]);
}
BubbleSort(array);
Console.WriteLine("\r\nSorted array: ");
foreach (int value in array)
{
    Console.Write($"{value} ");
}

Console.ReadLine();

