namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] train = { 1, 8, 6, 7, 3, 4, 5, 9, 2 };
            Console.WriteLine("Original: [{0}]", string.Join(", ", train));
            InsertionSort(train);
            Console.WriteLine("Sorted: [{0}]", string.Join(", ", train));
        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int currentIndex = i;
                while (currentIndex > 0 && arr[currentIndex - 1] > arr[currentIndex])
                {
                    int temp = arr[currentIndex];
                    arr[currentIndex] = arr[currentIndex - 1];
                    arr[currentIndex - 1] = temp;
                    currentIndex -= 1;
                }
            }    
        }
    }
}
