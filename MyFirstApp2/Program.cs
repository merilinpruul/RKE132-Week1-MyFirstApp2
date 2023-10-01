//This is a comment to my code

//rakendus küsib kasutajal sisestada tema nimi
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string - sõne
string username = Console.ReadLine();

Console.WriteLine("Hello" + ", " + username + "!");

//string interpolation
Console.WriteLine($"Hello, {username} !");
