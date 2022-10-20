using System;

namespace RandomSentencesGenerator
{
    class RandomSentencesGenerator
    {
        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
        static void Main(string[] args)
        {
            string[] names = { "Valentin", "Stoyan", "Peter", "Angel", "Todor" };
            string[] places = { "Burgas", "Varna", "Sozopol", "Sofia", "Plovdiv"};
            string[] verbs = { "eats", "plays", "trains", "cooks", "works"};
            string[] nouns = { "computers", "cars", "mansion", "club", "mall"};
            string[] adverbs = { "slowly", "sadly", "early", "annualy", "rarely"};
            string[] details = { "near the univeristy", "at home", "at the beach bar", "in the park", "on the street"};

            Console.WriteLine("Hello this is your first random-generated sentence: ");

            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetail}";

                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one.");

                Console.ReadLine();
            }
        }
    }
}
