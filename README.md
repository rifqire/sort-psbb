# Sort & PSBB

This C# application have 2 questions to solve: Sort character and PSBB.

## Sort Character

User inputs one line of words and saved into a string. After that, convert the string to lowercase and without any whitespaces.

```csharp
string lowerWords = words.ToLower().Replace(" ", "");
```

After that, check the frequency of each characters

```csharp
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
```

Insert the characters into an array

```csharp
var sortedChars = lowerWords
    .OrderByDescending(c => frequencyMap[c])
    .ThenBy(c => lowerWords.IndexOf(c))
    .ToList()
    .ToArray();
```

Use StringBuilder for both vowels and consonants. Do a for-loop, and check if the characters are a/e/i/o/u then it will append to vowels, and if not it will append to consonants.

```csharp
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
```

## PSBB

User inputs the number of families, as well as the number of members in the family separated by spaces.
The number of members will be turned into an array by splitting them with space as the delimiter, and then converted to integer using Parse method.

```csharp
string[] splittedMembers = familyMembers.Split(' ');
int[] numbers = Array.ConvertAll(splittedMembers, int.Parse);
```

If the number of families is larger than or equal to length of the numbers array, then do a for-each loop. If the total members divided by 4 (bus capacity) remains 0, the minimum bus required is the result of the division. If it has remainders, the minimum bus is the result of division, then add with 1.

```csharp
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
```
