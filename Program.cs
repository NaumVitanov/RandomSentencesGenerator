using System;

namespace RandomSentencesGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10] { "Ivan", "Georgi", "Valentin", "Ivelina", "Naum", "Petko", "Azima", "Bogdan", "Sasho", "Mitko" };
            string[] cities = new string[10] { "Plovdiv", "Sofia", "Stara Zagora", "Pleven", "Calapica", "Varna", "Grutkovo", "Madan", "Gigen", "Smolqn" };
            string[] adverbs = new string[10] { "seriously", "impatiently", "loudly", "oddly", "loosley", "safely", "stupidly", "nicely", "colorfully", "dreadfully" };
            string[] verbs = new string[10] { "eats", "fights", "talks to", "runs at", "shouts at", "bakes", "jumps over", "breaks", "makes", "screams at" };
            string[] nouns = new string[10] { "air", "food", "a friend", "a judge", "dirt", "a student", "an animal", "a chair", "a cup", "a computer" };
            string[] details = new string[10] {"at home" , "at work" , "in the park" , "on the toilet" , "in bed" , "on the floor"
                , "on the ceiling" , "in the basement" ,"in the kichen" , "on the computer"};

            Console.WriteLine("To terminate the progrem press [q].To generate a random sentence press any other key.");

            while ((Console.ReadKey().Key) != ConsoleKey.Q)
            {
                Console.WriteLine();
                Console.WriteLine($"{GetRandomWord(names)} from {GetRandomWord(cities)} {GetRandomWord(adverbs)} {GetRandomWord(verbs)} {GetRandomWord(nouns)} {GetRandomWord(details)}");
            }
        }

        public static string GetRandomWord(string[] array)
        {
            Random random = new Random();            
            return array[random.Next(1, 10)];
        }                               
    }
}
