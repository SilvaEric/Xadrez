using tabuleiro;
using xadrez;
namespace Xadrez_console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos.toPosicao());
        }
    }
}