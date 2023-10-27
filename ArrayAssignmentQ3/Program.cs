namespace ArrayAssignmentQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept an array of integers and print the product of odd numbers in it 

            int[] Numbers = new int[5];
            Console.WriteLine("Please the numbers");

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());// getting numbers from the keyboard

            }
            Console.WriteLine();
            Console.WriteLine("The odd numbers in an array of numbers are ");
            for (int i = 0;i < Numbers.Length;i++)
            {
                if (Numbers[i]%2 == 1)
                {
                    Console.WriteLine(Numbers[i]);
                }
            }
        }
    }
}