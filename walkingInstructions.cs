while (true)
{
    ConsoleKeyInfo key = Console.ReadKey(true);

    if (key.Key == ConsoleKey.W) Console.WriteLine("Move Up");
    if (key.Key == ConsoleKey.A) Console.WriteLine("Move Left");
    if (key.Key == ConsoleKey.S) Console.WriteLine("Move Down");
    if (key.Key == ConsoleKey.D) Console.WriteLine("Move Right");
}
