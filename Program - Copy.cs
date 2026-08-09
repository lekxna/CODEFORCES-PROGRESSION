using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int k = int.Parse(Console.ReadLine());
            int[] c = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int pairs = 0;
            bool three = false;

            foreach (int x in c)
            {
                if (x >= 3)
                    three = true;

                if (x >= 2)
                    pairs++;
            }

            if (three || pairs >= 2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}