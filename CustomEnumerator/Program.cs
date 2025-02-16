using CustomEnumerator;

Garage carLot =  new Garage();

foreach(Car c in carLot)
{
    Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
}