// using System.Text;
// public class Sort
// {
//   public void SeparateVowels(string words)
//   {
//     string lowerWords = words.ToLower().Replace(" ", "");
//     StringBuilder vowels = new StringBuilder();
//     StringBuilder consonants = new StringBuilder();
//     for (int i = 0; i < lowerWords.Length; i++)
//     {
//       if (lowerWords[i] == 'a' || lowerWords[i] == 'e' || lowerWords[i] == 'i' || lowerWords[i] == 'o' || lowerWords[i] == 'u')
//       {
//         vowels.Append(lowerWords[i]);
//         continue;
//       }
//       else
//       {
//         consonants.Append(lowerWords[i]);
//         continue;
//       }
//     }
//     Console.WriteLine("\nVowel characters:\n" + vowels);
//     Console.WriteLine("Consonant characters:\n" + consonants);
//   }
// }