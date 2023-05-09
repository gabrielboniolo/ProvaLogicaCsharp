namespace ProvaLogicaCsharp1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, pi, area;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A= {0}", area.ToString("F4"));

        }
    }
}