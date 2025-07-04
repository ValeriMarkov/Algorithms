namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] train = { 1, 8, 6, 7, 3, 4, 5, 9, 2 };
            Console.WriteLine("Original: [{0}]", string.Join(", ", train));
            BubbleSort(train);
            Console.WriteLine("Sorted: [{0}]", string.Join(", ", train));
        }

        public static void BubbleSort(int[] arr)
        {
            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;

                for (int i  = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] >  arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        hasSwapped = true;
                    }
                }
            }
        }
    }
}
