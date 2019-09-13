using System;

namespace History
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInt = 0;
            int resultInt = AddAll(testInt);
            Console.WriteLine(resultInt);
            Console.ReadKey();
        }
        private static int AddAll(int j)
        {
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine($"Step {i}");
                j = AddInt(j);
            }
            return j;
        }

        private static int AddInt(int add)
        {
            if (add == 10)
            {
                return add + 25;
            }
            return ++add;
        }
    }
}
