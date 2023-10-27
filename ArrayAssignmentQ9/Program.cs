namespace ArrayAssignmentQ9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept a string as input and print the count of alphabets in it. 
            string Text = string.Empty;
            Console.WriteLine("Please enter string");
            Text = Console.ReadLine();
            int Alphabetcout = 0;
            foreach(char c in Text)
            {
                if(c>='a'&& c<='z')
                {
                    Alphabetcout++;
                }
                else if(c>='A'&& c<='Z')
                {
                    Alphabetcout++;
                }
            }
            Console.WriteLine($"The count of alphabets in the given strin is {Alphabetcout}");

        }
    }
}