// If the user just enters out of this, it'll be null
// The ? denotes that this is a nullable type
string? CharName = Console.ReadLine();
string? CompanyName = Console.ReadLine();

// Picking a random age just for ease here
Random random = new Random();
int CharAge = random.Next();

// We'll use string concatenation and interpolated strings here to make use of only 1 console statement
// \n is an escape character that represents a new line
Console.WriteLine($"There was once a man named {CharName}." +
    $"\nHis dad Mike is a co-founder of {CompanyName} and his mother is dead so we don't talk about her." +
    $"\nJohn does his homework." +
    $"\nHere is {CharName} (pov: you are blind)." +
    $"\nSee, he's a cool guy, isn't he?" +
    $"\nHe's not {CharAge}, is he?" +
    $"\nHis true age is {CharAge + random.Next()}." +
    $"\nAnd that's how you tell a story in C#.");