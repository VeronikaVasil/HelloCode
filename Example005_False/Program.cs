Console.WriteLine("Input name user: ");
string username = Console.ReadLine()!;

if (username.ToLower() == "masha")
{
    Console.WriteLine("URA, this is the Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
