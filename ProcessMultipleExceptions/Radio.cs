using System;

namespace ProcessMultipleExceptions;

public class Radio
{
    public void TurnOn(bool on)
    {
        Console.WriteLine(on ? "Jamming.. . " : "Quiet t i m e . . .");
    }

}
