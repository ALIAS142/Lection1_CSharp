
Console.WriteLine("Enter user name: ");
string username = Console.ReadLine();

if (username.ToLower() == "mary")
{
    Console.WriteLine("Hey!!! Mary, How are you???");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}