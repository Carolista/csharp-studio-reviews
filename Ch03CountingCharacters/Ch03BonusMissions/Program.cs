Console.WriteLine("Please enter some text: ");
string sample = Console.ReadLine();

Dictionary<char, int> charCounts = new Dictionary<char, int>();  // new() or []

string alpha = "abcdefghijklmnopqrstuvwxyz";

foreach (char c in sample.ToCharArray())
{
    char character = c.ToString().ToLower()[0];

    if (alpha.Contains(character))
    {
        if (charCounts.ContainsKey(character))
        {
            charCounts[character]++;
        }
        else 
        {
            charCounts.Add(character, 1);
        }
    }
}

foreach (KeyValuePair<char, int> pair in charCounts)
{
    Console.WriteLine(pair.Key + ": " + pair.Value);
}