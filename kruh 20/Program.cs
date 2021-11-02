using System;

namespace kruh_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double prumer = 0;
            double polomer;
            double vypocetobsahu;
            double vypocetobvodu;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("obvod a obsah kruhu");
                Console.Write("zadej polomer:");
                double.TryParse(Console.ReadLine(), out polomer);
                if (polomer <= 0)
                {
                    Console.Write("zadej prumer:");
                    double.TryParse(Console.ReadLine(), out prumer);
                }
                else
                {
                    vypocetobvodu = 2 * 3.14 * polomer;
                    Console.WriteLine($"obdesah je {vypocetobvodu}");
                    vypocetobsahu = 3.14 * (polomer * polomer);
                    Console.WriteLine($"obsah je {vypocetobsahu}");
                }
                if (polomer > 0)
                {
                    double.TryParse(Console.ReadLine(), out prumer);
                }
                else
                {
                    vypocetobvodu = 3.14 * prumer;
                    Console.WriteLine($"obsah je {vypocetobvodu}");
                    vypocetobsahu = 3.14 * (prumer * prumer) / 4;
                    Console.WriteLine($"obsah je {vypocetobsahu}");
                }

                Console.ReadLine();
            }
        }
    }
}
