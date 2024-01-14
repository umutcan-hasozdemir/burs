using System;

namespace or096
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] burslar = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

            int b = 0;

            foreach (double x in burslar)
            {
                if (x < 500)
                {
                    burslar[b] += burslar[b] * 0.1 + 50;

                }

                Console.WriteLine(burslar[b]);

                b++;
            }
        }
    }
}
