namespace ArrayAssignmentQ10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Array1 = new string[7];
            Console.WriteLine("Enter topics");
            for (int i = 0; i < Array1.Length; i++) 
            {
                Array1[i] = Console.ReadLine();
            }
            Console.WriteLine();
            foreach (string String in Array1 )
            {
                if (String.Length > 4)
                {
                    Console.WriteLine(String);
                }
            }
        }
    }
}