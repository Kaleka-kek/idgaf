using System;

namespace _5
{
    class Program
    {
            static int Counter;
            static Random rand = new Random();
            static int Interval = 100; 
            static char AsciiCharacter
            {
                get
                {
                    int t = rand.Next(10);
                    if (t <= 2)
                        return (char)('0' + rand.Next(10));
                    else if (t <= 4)
                        return (char)('a' + rand.Next(27));
                    else if (t <= 6)
                        return (char)('A' + rand.Next(27));
                    else
                        return (char)(rand.Next(32, 255));
                }
            }
            static void Main()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.CursorVisible = false;
                int width, height;
                int[] y;
                Initialize(out width, out height, out y);
                while (true)
                {
                    Counter = Counter + 1;
                    UpdateAllColumns(width, height, y);
                    if (Counter > (3 * Interval))
                        Counter = 0;
                }
            }
            private static void UpdateAllColumns(int width, int height, int[] y)
            {
                int x;
                if (Counter < Interval)
                {
                    for (x = 0; x < width; ++x)
                    {
                        if (x == 1)
                            Console.ForegroundColor = ConsoleColor.White;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x, y[x]);
                        Console.Write(AsciiCharacter);

                        if (x % 10 == 9)
                            Console.ForegroundColor = ConsoleColor.White;
                        else
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        int temp = y[x] - 2;
                        Console.SetCursorPosition(x, inScreenYPosition(temp, height));
                        Console.Write(AsciiCharacter);

                        int temp1 = y[x] - 20;
                        Console.SetCursorPosition(x, inScreenYPosition(temp1, height));
                        Console.Write(' ');
                        y[x] = inScreenYPosition(y[x] + 1, height);

                    }
                }                
            }
            public static int inScreenYPosition(int yPosition, int height)
            {
                if (yPosition < 0)
                    return yPosition + height;
                else if (yPosition < height)
                    return yPosition;
                else
                    return 0;

            }
            private static void Initialize(out int width, out int height, out int[] y)
            {
                height = Console.WindowHeight;
                width = Console.WindowWidth - 1;
                y = new int[width];
                Console.Clear();
                for (int x = 0; x < width; ++x)
                {
                    y[x] = rand.Next(height);
                }
            }
        }
    }