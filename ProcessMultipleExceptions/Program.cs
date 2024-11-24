using ProcessMultipleExceptions;
using System;

Car myCar = new Car("Rusty", 90);
myCar.CrankTunes(true);
try
{
    // Вызвать исключение выхода за пределы диапазона аргумента .
    myCar.Accelerate(10);
}

catch (CarIsDeadException e)
when (e.ErrorTimeStamp.DayOfWeek == DayOfWeek.Sunday)
{
    //try {
    //FileStream fs = File.Open("carErrors.txt", FileMode.Open);
    //}
    //catch (Exception e2)
    //{
    //    throw new CarIsDeadException(e.CauseOfError, e.ErrorTimeStamp, e.Message, e2);
    //}
    Console.WriteLine("Catching car is dead");

    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    myCar.CrankTunes(false);
}
Console.ReadLine();