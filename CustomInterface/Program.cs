Console.WriteLine("* * * First look at Interfaces * * *");CloneableExample();static void CloneableExample()
{
    // Все эти классы поддерживают интерфейс ICloneable.
    string myStr = "Hello";
    OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
    // Следовательно, все они могут быть переданы методу,
    // принимающему параметр типа ICloneable.
    CloneMe(myStr);
    CloneMe(unixOS);
}static void CloneMe(ICloneable c){
    // Клонировать то, что получено, и вывести имя.
    object theClone = c.Clone();
    Console.WriteLine("Your clone is a: {0}",
        theClone.GetType().Name);}