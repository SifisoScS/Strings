// Verbatim string literal starts with @ symbol
string path = @"C:\Users\Sifiso\Documents";

// Verbatim string ignores escape sequences
string escapedString = @"This is a verbatim string with escape sequences: \n \t \\";

// Verbatim string allows multi-line strings without escape characters
string multiLineString = @"This is a 
multi-line 
verbatim string";

// Multi-line verbatim string (a simple poem)
string poem = @"Roses are red,
Violets are blue,
C# is great,
And so are you!";

// Verbatim string with quotes
string verbatimWithQuotes = @"Coding is today's literacy. It is the alphabet of the future.” - Sifiso Cyprian Shezi";

// Displaying verbatim strings
Console.WriteLine("Path: " + path);
Console.WriteLine("Escaped String: " + escapedString);
Console.WriteLine("Multi-line String: " + multiLineString);
Console.WriteLine("Poem: " + poem);
Console.WriteLine("Verbatim with Quotes: " + verbatimWithQuotes);