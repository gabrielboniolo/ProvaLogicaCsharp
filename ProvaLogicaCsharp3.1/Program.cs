namespace ProvaLogicaCsharp3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;

            while(senha!= 2002)
            {
                senha = int.Parse(Console.ReadLine());

                if(senha!= 2002)
                {
                    Console.WriteLine("Senha inválida");
                }
                
            }
            Console.WriteLine("Acesso permitido");
            
        }
    }
}