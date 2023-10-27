namespace ArrayAssignmentQ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept a string as input and reverse it and print it. For example, if the input string is "og" then print "go" 
            string? Text;
            Console.WriteLine("Please enter string");
            Text = Console.ReadLine();
            string? ReverseText = string.Empty;
            for(int i = Text.Length-1; i >= 0; i--)
            {
                ReverseText += Text[i];
            }
            Console.WriteLine($"The reverse string is {ReverseText}");
        }
    }
}