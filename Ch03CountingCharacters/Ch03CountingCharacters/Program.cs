string sample = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

Dictionary<char, int> charCounts = new Dictionary<char, int>();  // new() or []

foreach (char character in sample.ToCharArray())
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

foreach (KeyValuePair<char, int> pair in charCounts)
{
    Console.WriteLine(pair.Key + ": " + pair.Value);
}
