namespace ProvaLogicaCsharp1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peca1, peca2;
            int codpeca1, qtdpeca1, codpeca2, qtdpeca2;
            double valorpeca1, valorpeca2, total;
            peca1 = Console.ReadLine().Split(' ');
            peca2 = Console.ReadLine().Split(' ');
            codpeca1 = int.Parse(peca1[0]);
            qtdpeca1 = int.Parse(peca1[1]);
            valorpeca1 = double.Parse(peca1[2]);
            codpeca2 = int.Parse(peca2[0]);
            qtdpeca2 = int.Parse(peca2[1])  ;
            valorpeca2 = double.Parse(peca2[2]);
            total = ((double)qtdpeca1*valorpeca1) + ((double)qtdpeca2*valorpeca2);
            Console.WriteLine("TOTAL A PAGAR: R$ {0}", total.ToString("F2"));
            
        }
    }
}