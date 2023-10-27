namespace ArraysassignmentQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[] Numbers = new int[6];
            Console.WriteLine("Please enter numbers");
          for(int i = 0; i < Numbers.Length; i++)// accepting numbers from the end user
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
          for(int i = 0;i < Numbers.Length;i++)//finding the sum of numbers
            {
                sum += Numbers[i];
            }
            Console.WriteLine($"The sum of number in the array is {sum}");
        }
    }
}