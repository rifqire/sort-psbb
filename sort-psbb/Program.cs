using System.Text;

// Question No. 1: Sort Character
Console.WriteLine("Question 1: Sort Character");
Console.WriteLine("Input one line of words:");
string? words = Console.ReadLine();

// Check if the string is empty
if (string.IsNullOrEmpty(words))
{
    Console.WriteLine("Input cannot be empty");
}
else
{
    // Make the string to lowercase and without whitespaces
    string lowerWords = words.ToLower().Replace(" ", "");

    // Check frequency of each characters
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

    // Insert the characters to array
    var sortedChars = lowerWords
        .OrderByDescending(c => frequencyMap[c])
        .ThenBy(c => lowerWords.IndexOf(c))
        .ToList()
        .ToArray();

    // String builder to append characters 
    StringBuilder vowels = new StringBuilder();
    StringBuilder consonants = new StringBuilder();
    for (int i = 0; i < sortedChars.Length; i++)
    {
        if (
            sortedChars[i] == 'a'
            || sortedChars[i] == 'e'
            || sortedChars[i] == 'i'
            || sortedChars[i] == 'o'
            || sortedChars[i] == 'u'
        )
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

// Question No. 2: PSBB
// Input number of families
Console.WriteLine("\nQuestion 2: PSBB");
Console.WriteLine("Input the number of families:");
int? familyTotal = Convert.ToInt32(Console.ReadLine());

// Input string of family members separated by space
Console.WriteLine("Input the number members in the family (separated in spaces):");
string? familyMembers = Console.ReadLine();
string[] splittedMembers = familyMembers.Split(' ');
int[] numbers = Array.ConvertAll(splittedMembers, int.Parse);

// Check if input is equal with the family count
if (numbers.Length < familyTotal)
{
    Console.WriteLine("Input must be equal with count of family.");
}
else
{
    int totalMembers = 0;
    int minimumBus = 0;
    foreach (var n in numbers)
    {
        totalMembers += n;
    }
    if (totalMembers % 4 == 0) {
        minimumBus = totalMembers / 4;
    }
    else
    {
        minimumBus = totalMembers / 4 + 1;
    }
    Console.WriteLine($"Minimum bus required is: {minimumBus}");
}

