namespace ProvaLogicaCsharp2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco, total;
            string[] pedido = Console.ReadLine().Split(' ');
            codigo = int.Parse(pedido[0]);
            quantidade= int.Parse(pedido[1]);
            if(codigo==1)
            {
                preco = 4.00;
                total = preco * quantidade;
                Console.WriteLine("Total = R$ {0}", total.ToString("F2"));
            }
            else if(codigo==2) {
                preco = 4.50;
                total = preco * quantidade;
                Console.WriteLine("Total = R$ {0}", total.ToString("F2"));
            }
            else if(codigo==3) 
            {
                preco = 5.00;
                total = preco * quantidade;
                Console.WriteLine("Total = R$ {0}", total.ToString("F2"));
            }
            else if(codigo==4) {
                preco = 2.00;
                total = preco * quantidade;
                Console.WriteLine("Total = R$ {0}", total.ToString("F2"));
            }
            else if(codigo==5) {
                preco = 1.50;
                total = preco * quantidade;
                Console.WriteLine("Total = R$ {0}", total.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Código Inválido! São aceitos apenas os códigos de 1 a 5.");
            }

        }
    }
}