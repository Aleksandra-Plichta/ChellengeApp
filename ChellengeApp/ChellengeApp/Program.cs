// zadanie domowe dzień 4

using System.ComponentModel.Design;

var name = "Magda";
var sex = "female";
var age = 29;

if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "male" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}