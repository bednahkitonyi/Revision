namespace ArrayAssignmentQ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept an array of integers and print the number of occurrences of a given number in it. For example, if the array is 1,2,1,4 and input number is 1, then print 2 as the output 
            int count=0;
            int[] numbers = new int[6];



            int[] array = new int[6];
            Console.WriteLine("Please enter numbers");
            for(int  i = 0; i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<array.Length;i++)// storing the array
            {
                Console.WriteLine(array[i]);
            }
           
           
            Console.Write("Enter number to check occurrence  :  ");
            int number = Convert.ToInt32(Console.ReadLine());

            int occurrences = array.Count(x => x == number);
            Console.WriteLine("Occurrence of {0} in the given array is {1}", number, occurrences); // find the number of the given number appeared in the array
            Console.ReadKey();

            

        }
    }
}