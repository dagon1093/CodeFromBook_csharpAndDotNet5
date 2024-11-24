using System;

namespace ProcessMultipleExceptions;

class Car
{
    // Константа для представления максимальной скорости,
    public const int MaxSpeed = 100;
    // Свойства автомобиля.
    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = "";
    // He вышел ли автомобиль из строя?
    private bool _carIsDead;
    // В автомобиле имеется радиоприемник,
    private readonly Radio _theMusicBox = new();
    // Конструкторы,
    public Car() { }
    public Car(string name, int speed)
    {
        CurrentSpeed = speed;
        PetName = name;
    }
    public void CrankTunes(bool state)
    {
        // Делегировать запрос внутреннему объекту.
        _theMusicBox.TurnOn(state);
    }
    // Проверить, не перегрелся ли автомобиль,
    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            Console.WriteLine("{0} is out of order...", PetName);
        }
        else
        {
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException( nameof(delta), "Speed must be grater than zero" );
            }
            CurrentSpeed += delta;
            if (CurrentSpeed >= MaxSpeed)
            {
                CurrentSpeed = 0;
                _carIsDead = true;
                throw new CarIsDeadException("You have a lead foot", DateTime.Now, $"{PetName} has overheated!")
                {
                    HelpLink = "https://www.google.com",
                    Data = {
                        { "TimeStamp", $"The car exploded at { DateTime . Now } " } ,
                        { "Cause", "You have a lead foot." }
                        }

                };
            }

            Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);

        }
    }
}

