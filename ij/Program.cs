Console.Clear();

int xa = 50, ya = 0,
    xb = 0, yb = 40,
    xc = 100, yc = 40;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("S");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("S");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("S");

int x = xa, y =ya;

int i = 0;

while (i < 10000)
{
    int what = new Random().Next(0,3);

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("0");
    i ++;
}

Console.SetCursorPosition(0, 42);