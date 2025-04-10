namespace N8__YP__Task_6_08._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество вершин многоугольника (n): ");
            int n = int.Parse(Console.ReadLine());

            double[] x = new double[n];
            double[] y = new double[n];

            Console.WriteLine("Введите координаты вершин:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Вершина {i + 1}: ");
                string[] coords = Console.ReadLine().Split(' ');
                x[i] = double.Parse(coords[0]);
                y[i] = double.Parse(coords[1]);
            }

            double area = PolygonArea(x, y, n);
            Console.WriteLine($"Площадь многоугольника: {area:F2}");
        }

        static double PolygonArea(double[] x, double[] y, int n)
        {
            double area = 0;
            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n; // Следующая вершина (циклически)
                area += x[i] * y[j] - y[i] * x[j];
            }
            return Math.Abs(area) / 2.0;
        }
    }
}
