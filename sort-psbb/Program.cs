using System.Text;

Console.WriteLine("Input one line of words:");

string words = Console.ReadLine();

if (string.IsNullOrEmpty(words))
{
    Console.WriteLine("Input cannot be empty");
}
else
{
    string lowerWords = words.ToLower().Replace(" ", "");

    var frequencyMap = new Dictionary<char, int>();
    foreach (char c in lowerWords)
    {
        if (frequencyMap.ContainsKey(c))
        {
            frequencyMap[c]++;
        }
        else
        {
            frequencyMap[c] = 1;
        }
    }

    var sortedChars = lowerWords
    .OrderByDescending(c => frequencyMap[c]) // Sort by frequency (descending)
    .ThenBy(c => lowerWords.IndexOf(c))           // Then by original order (for same frequency)
    .ToList().ToArray();

    StringBuilder vowels = new StringBuilder();
    StringBuilder consonants = new StringBuilder();
    for (int i = 0; i < sortedChars.Length; i++)
    {
        if (sortedChars[i] == 'a' || sortedChars[i] == 'e' || sortedChars[i] == 'i' || sortedChars[i] == 'o' || sortedChars[i] == 'u')
        {
            vowels.Append(sortedChars[i]);
            continue;
        }
        else
        {
            consonants.Append(sortedChars[i]);
            continue;
        }
    }
    Console.WriteLine("\nVowel characters:\n" + vowels);
    Console.WriteLine("Consonant characters:\n" + consonants);
}