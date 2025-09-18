// See https://aka.ms/new-console-template for more information
//string greeting = "Hello, World!";

//string myName = "John Rowley";

//int age = 63;

//Console.WriteLine(greeting);

//Console.WriteLine($"{greeting} Dorset Calling");
//Console.WriteLine($"Your name is {myName} and you are {age} years old");



using oop_2025_c_0918.Models;

//string SuperHeroName_1 = "Peter Parker";
//string SuperHeroName_2 = "Tony Stark";
//string SuperHeroName_3 = "Bruce Banner";

//string SuperHeroAlias_1 = "Spiderman";
//string SuperHeroAlias_2 = "Iron Man";
//string SuperHeroAlias_3 = "The Hulk";

//Console.WriteLine($"{SuperHeroName_1}:{SuperHeroAlias_1}");
//Console.WriteLine($"{SuperHeroName_2}:{SuperHeroAlias_1}");
//Console.WriteLine($"{SuperHeroName_3}:{SuperHeroAlias_3}");

SuperHero superHero1 = new SuperHero();
superHero1.Name = "Peter Parker";
superHero1.Alias = "Spiderman";
superHero1.SpecialSkill = "Web Slinging";

SuperHero superHero2 = new();
superHero2.Name = "Tony Stark";
superHero2.Alias = "Iron Man";
superHero2.SpecialSkill = "Flying";

SuperHero superHero3 = new() { Name = "Bruce Banner", Alias = "The Hulk", SpecialSkill="Strength" };

Console.WriteLine($"Hero: {superHero1.Name}:{superHero1.Alias}");
Console.WriteLine($"Hero: {superHero2.Name}:{superHero2.Alias}");
Console.WriteLine($"Hero: {superHero3.Name}:{superHero3.Alias}");

Console.WriteLine(superHero1);
Console.WriteLine(superHero2);
Console.WriteLine(superHero3);