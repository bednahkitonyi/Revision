namespace ArrayAssigmentQ8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept a string as input and print the count of vowels in it. 
            string Text = string.Empty;
            Text = Console.ReadLine();
            int vowelcount = 0;
            foreach(char c in Text)// Calculating the number of vowels 
            {
                if (c =='a'||c=='e'||c=='i'||c=='o'||c=='u')
                {
                    vowelcount++;
                }
                else if(c =='A'||c=='E'||c=='I'|| c=='U')
                {
                    vowelcount++;
                }
            }

            Console.WriteLine($"The count of vowels in the given is {vowelcount}");
        }
    }
}