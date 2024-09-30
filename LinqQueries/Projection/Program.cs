//Select 
List<string> words = ["an", "apple", "a", "day"];

var query = from word in words
            select word.Substring(0, 1);

query = words.Select(word => word.Substring(0, 1));

foreach (string s in query)
{
    Console.WriteLine(s);
}

//SelectMany
List<string> phrases = ["an apple a day", "the quick brown fox"];

query = from phrase in phrases
            from word in phrase.Split(' ')
            select word;

query = phrases.SelectMany(phrases => phrases.Split(' '));

foreach (string s in query)
{
    Console.WriteLine(s);
}

//Разобраться
//phrases.SelectMany()