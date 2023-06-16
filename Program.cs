using System;

namespace EstudoTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int escolhaNumero = 0;
                int quantidadedevezes = 0;
                int resultadotabuada = 0;
                Console.WriteLine("insira um numero entre 1 e 9");
                escolhaNumero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ate quantos multiplicadores? o normal é ate 10, nao exceda 50. insira o valor");
                quantidadedevezes = Convert.ToInt32(Console.ReadLine());

                if (0 > quantidadedevezes|| quantidadedevezes > 50)
                {
                    Console.WriteLine("Digite apenas numeros de 0 a 50");
                    Console.WriteLine("Pressione qualquer tecla para sair");
                    Console.ReadKey();
                }
                if (0>escolhaNumero|| escolhaNumero > 9)
                {
                    Console.WriteLine("Digite apenas numeros de 1 a 9");
                    Console.WriteLine("Pressione qualquer tecla para sair");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"A tabuada de {escolhaNumero} é = ");
                    
                    for(int multiplicador =1; multiplicador <=quantidadedevezes; multiplicador++)
                    {
                        
                        resultadotabuada = escolhaNumero * multiplicador;
                        Console.WriteLine($"{escolhaNumero}x{multiplicador}={resultadotabuada}");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Pressione qualquer tecla para sair ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            // 
        } 
    }
}
