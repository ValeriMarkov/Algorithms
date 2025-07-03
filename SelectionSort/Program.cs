namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] train = { 1, 8, 6, 7, 3, 4, 5, 9, 2 };
            Console.WriteLine("Original: [{0}]", string.Join(", ", train));
            SelectionSort(train);
            Console.WriteLine("Sorted: [{0}]", string.Join(", ", train));
        }

        public static void SelectionSort(int[] arr)
        {
            int min_index;

            for (int i = 0; i < arr.Length; i++)
            {
                min_index = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                }

                int temp = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = temp;
            }
        }
    }
}