// See https://aka.ms/new-console-template for more information
using System.Collections;
using CustomEnumerator;

Console.WriteLine("Hello, World!");
Garage garage = new Garage();
foreach (Car car in garage)
{
    Console.WriteLine("{0} is going {1} MPH", car.PetName, car.CurrentSpeed);
}

Console.WriteLine("-----------");
foreach (Car car in garage.GetTheCars(true))
{
    Console.WriteLine("{0} is going {1} MPH", car.PetName, car.CurrentSpeed);
}

Console.ReadLine();
