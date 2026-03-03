namespace Strings_Price_Austin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input a character
            Console.Write("Enter a single character: ");
            char myChar = Console.ReadKey().KeyChar;

            // Determine if it is a letter
            bool isLetter = Char.IsLetter(myChar);

            // Print result (with newline at beginning)
            Console.WriteLine("\n" + myChar + " is a letter: " + isLetter);

            // Ask user to input a string of words
            Console.Write("\nEnter a string of words: ");
            string string1 = Console.ReadLine();

            // Ask user to input a word to search for
            Console.Write("Enter a word to search for: ");
            string string2 = Console.ReadLine();

            // Check if string1 contains string2
            bool containsWord = string1.Contains(string2);

            // Print result
            Console.WriteLine(string2 + " exists in \"" + string1 + "\": " + containsWord);
        }
    }
}
