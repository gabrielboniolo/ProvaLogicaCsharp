namespace ProvaLogicaCsharp3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, dentro, fora;
            dentro = 0;
            fora= 0;
            n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] >= 10 && numeros[i] <= 29)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }

            }

            Console.WriteLine("{0} in", dentro);
            Console.WriteLine("{0} out", fora);
        }
    }
}
