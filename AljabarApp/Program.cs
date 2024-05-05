using System;

namespace AljabarApp
{
    class Program
    {
        static void Main(String[] args)
        {
            double[] persamaan = { 1, -3, -10 };
            Console.WriteLine($"Mencari akar persamaan kuadrat dari {persamaan[0]}x^2 {persamaan[1]}x {persamaan[2]}");
            double[] akar = AljabarLibraries.Aljabar.AkarPersamaanKuadrat(persamaan);
            Console.WriteLine($"Akar persamaan kuadrat: {akar[0]} dan {akar[1]}");

            double[] persamaanLinear = { 2, -3 };
            double[] hasilKuadrat = AljabarLibraries.Aljabar.HasilKuadrat(persamaanLinear);
            Console.WriteLine($"\nMencari hasil kuadrat dari persamaan {persamaanLinear[0]}x {persamaanLinear[1]}");
            Console.WriteLine($"Hasil kuadrat: {hasilKuadrat[0]}x^2 + {hasilKuadrat[1]}x + {hasilKuadrat[2]}");
        }
    }
}