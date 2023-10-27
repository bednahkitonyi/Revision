namespace ArrayAssignmentQ7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept a string and a character as input and check how many times the given character is occurring in the string. For example, if the input string is "This is a string" and the input character is "i", then print 3
            string? Text = string.Empty;
            Console.WriteLine("Please enter the string");
            Text = Console.ReadLine();

            for(int i=0;i<Text.Length;i++)
            {
                Console.WriteLine(Text[i]);
            }
            
            Console.WriteLine();

            Console.WriteLine("Enter the character to see how many time it occurs");//fetching the character from the end user
            char ch = Convert.ToChar(Console.ReadLine());

            int occurence = Text.Count(x => x == ch);
            Console.WriteLine("Occurrence of {0} in the given string is {1}", ch, occurence);
           
        }
    }
}