// See https://aka.ms/new-console-template for more information

using ComparableCar;

Car[] myAutos = new Car[5];
myAutos[0] = new Car ( "Rusty", 80, 1 );
myAutos[1] = new Car ( "Mary", 40, 234 );
myAutos[2] = new Car ( "Viper", 40, 34 );
myAutos[3] = new Car ( "Mel", 40, 4 );
myAutos[4] = new Car ( "Chucky", 40, 5 );

foreach ( Car c in myAutos)
{
    Console.WriteLine("{0}, {1}, {2}", c.CarID, c.PetName, c.CurrentSpeed);
}

Array.Sort (myAutos);

Console.WriteLine("------- after sort ------");

foreach (Car c in myAutos)
{
    Console.WriteLine("{0}, {1}, {2}", c.CarID, c.PetName, c.CurrentSpeed);
}

Array.Sort (myAutos, new PetNameComparer());

Console.WriteLine("-------- after PetName sort -----------");
foreach (Car c in myAutos)
{
    Console.WriteLine("{0}, {1}, {2}", c.CarID, c.PetName, c.CurrentSpeed);
}