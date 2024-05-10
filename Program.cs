﻿// // See https://aka.ms/new-console-template for more information
// string greeting = @"Welcome to Thrown For a Loop
// Your one-stop shop for used sporting equipment";

// Console.WriteLine(greeting);
// Console.WriteLine("Please choose an option:");


// string response = Console.ReadLine();
// Console.WriteLine(@$"You chose: {response}. 
// Thank you for your input!");


string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

Console.WriteLine(@"Products:
1. Football
2. Hockey Stick
3. Boomerang
4. Frisbee
5. Golf Putter");
Console.WriteLine("Please enter a product number: ");

int response = int.parse(Console.ReadLine().Trim());
//.trim() returns a string. 
// int.parse is the same in C# as JS with one important diff. 

while (response > 5 || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

Console.WriteLine($"You chose: {response}");
