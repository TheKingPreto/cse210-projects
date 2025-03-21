using System;

class Program
{
    static void Main()
    {
        var reference = new Reference("John 3:16");
        var scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        var scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.ScriptureReference);
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("\nAll words are hidden. End of practice.");
                break;
            }

            System.Threading.Thread.Sleep(1000); 
        }
    }
}
