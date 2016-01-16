using System;

class houseDraw
{
    static void Main(string[] args)
    {
        // input

        int n = int.Parse(Console.ReadLine());
        int width = 2 * (n - 1);
        int height = 2 * (n + 2);
        int baseHeight = n + 2;
        int windowheight = n / 2;
        int windowwidth = n - 3;

        int startsTop = n - 1;
        Console.WriteLine("{0}*{0}", new string('.', startsTop));

        for (int i = 0; i < startsTop; i++)
        {
            string firstDots = new string('.', n-2-i);
            string middleDots = new string('.', i*2 + 1);
           
            Console.WriteLine("{0}*{1}*{0}", firstDots, middleDots);
        }

        Console.WriteLine("{0}", new string ('*', n*2-1));

        int wall = n / 4;

        for (int i = 0; i < wall; i++)
        {
            Console.WriteLine("*{0}*", new string('.', (n * 2) - 3));
        }

        int window = n / 2;

        for (int i = 0; i < window; i++)
        {

            string firstDots = new string('.', n / 2);
            string middleDots = new string('*', n - 3);

            // Console.Write("*{0}", new string('.', n / 2));

            Console.WriteLine("*{0}{1}{0}*", firstDots, middleDots);
        }

        int wallDown = n / 4;

        for (int i = 0; i < wallDown; i++)
        {
            Console.WriteLine("*{0}*", new string('.', (n * 2) - 3));
        }

        Console.WriteLine("{0}", new string('*', n * 2 - 1));

        // upper roof

        // roof

        // lower roof

        // body



    }
}

