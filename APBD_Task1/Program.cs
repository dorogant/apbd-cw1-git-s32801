namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an array of numbers");
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("avg is: " + calculateAverage(arr));
            Console.WriteLine("max is: " + calculateMax(arr));
            Console.WriteLine("min is: " + calculateMin(arr));
        }

        public static double calculateAverage(int[] arr)
        {
            double sum = 0;
            foreach (var v in arr)
            {
                sum += v;
            }
            return sum / arr.Length;
        }
        public static int calculateMax(int[] arr)
        {
            int max = arr[0];
            foreach (var v in arr)
            {
                if (max < v) max = v;
            }
            return max;
        }
        public static int calculateMin(int[] arr)
        {
            int min = arr[0];
            foreach (var v in arr)
            {
                if (min > v) min = v;
            }
            return min;
        }
    }
}