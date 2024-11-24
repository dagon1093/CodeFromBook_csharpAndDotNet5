using InterfaceHierarchy;
using System;

Console.WriteLine("Fun with interfaces");
// Вызвать на уровне объекта.
Bitmaplmage myBitmap = new Bitmaplmage();
myBitmap.Draw();
myBitmap.DrawInBoundingBox(10, 10, 100, 150);
myBitmap.DrawUpsideDown();
// Получить IAdvancedDraw явным образом.
if (myBitmap is IAdvancedDraw iAdvDraw) 
{
    iAdvDraw.DrawUpsideDown();
    Console.WriteLine($"Time to draw: {iAdvDraw.TimeToDraw()}");
}


Console.WriteLine($"Time to draw: {myBitmap.TimeToDraw()}");
Console.WriteLine($"Time to draw: {((IDrawable)myBitmap).TimeToDraw()}");
Console.WriteLine($"Time to draw: {((IAdvancedDraw)myBitmap).TimeToDraw()}");
Console.ReadLine();