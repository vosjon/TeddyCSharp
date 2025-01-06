using System.Text;

Console.WriteLine("Hello, World!");
Console.WriteLine("This is a program.");


// Video 2: Variables

string billGates = "Praise the great leader... BILL GATES";
Console.WriteLine(billGates);

int numberOfBillGates = 1;
Console.WriteLine(numberOfBillGates);

var name = "Jon";
var age = 37;
Console.WriteLine($"My name is {name} and my age is {age}.");

// Video 3: Data Types

var name2 = "Jon";

var jeffBezosNetworth = 19600000000;

var charchar = 'c';

// Video 4: Strings

// CRUD - Create Read Update Delete

//Create
string petFish = "puffer fish";

//Concatenation
petFish = "porcupine " + petFish;

//Template Literal
Console.WriteLine($"I AM BUYING {petFish}. YOU CANNOT STOP ME!");

Console.WriteLine(petFish);

//READ
// To read you use Console.Writeline();

//UPDATE
string newPetFish = petFish.Replace("porcupine", "blue dot");
Console.WriteLine(newPetFish);

//DELETE
//String Builder
StringBuilder newCurstacean = new StringBuilder();
newCurstacean.Append("fiddler crab");
Console.WriteLine(newCurstacean);
newCurstacean.Remove(0, 8);
Console.WriteLine(newCurstacean);