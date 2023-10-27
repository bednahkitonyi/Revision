namespace ArrayassignmentQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept an array of integers and print only the even numbers in it

            int[] num = new int[5];
            Console.WriteLine("Please enter numbers");

            for(int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());// fetching the numbers from the end user
            }
            Console.WriteLine();
            Console.WriteLine("The even numbers in array num are");
            for (int i=0; i < num.Length; i++)
            {
                if (num[i]%2 == 0)
                {
                    Console.WriteLine( num[i]);
                }
            }
        }
    }
}