using Musics;
using System;

namespace sessao1questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtém o código do cliente no input do console
            Console.WriteLine("Digite o código do cliente: ");
            string cod = Console.ReadLine();
            int codCliente;
            while (!Int32.TryParse(cod, out codCliente))
            {
                Console.WriteLine("\nValor inválido! O código deve ser inteiro.");
                Console.WriteLine("Digite o código do cliente: ");
                cod = Console.ReadLine();
            }

            // Invoca o método que cria o cliente e retorna a string com a músicas
            string musicas = ObtemMusicasPorCliente(codCliente);

            // Verifica se retornou algo e imprime o resultado
            if (musicas.Length == 0)
                Console.WriteLine("\nCliente não possui músicas ou não existe.");
            else
                Console.WriteLine("\nMúsicas:\n" + musicas);

            Console.ReadLine();
        }

        static string ObtemMusicasPorCliente(int CodCliente)
        {
            var musicas = PlayList.ListMusicas(CodCliente);
            if(musicas.Count > 0)
                return string.Join(";", musicas);
            return "";
        }
    }
}
