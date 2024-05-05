namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double discriminant = (b*b) - (4*a*c);

            if (discriminant < 0)
            {
                throw new Exception("Akar persamaan kuadrat bukan bilangan real");
            } 

            double x1 = (-b + Math.Sqrt(discriminant)) / (2*a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            return new double[] { x1, x2 };
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            return new double[] { (a * a), (2 * a * b), (b * b) };
        }
    }
}
