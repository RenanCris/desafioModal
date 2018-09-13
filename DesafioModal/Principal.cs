using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioModal
{
    class Principal
    {

        static void Main(string[] args)
        {
            try {
                string _linha;

                using (StreamReader sr = new StreamReader("in.txt"))
                {
                    while ((_linha = sr.ReadLine()) != null)
                    {
                        var imprimir = Validacao.ValidarPalavra(_linha) == 1 ? Logica.GetPosicaoPalavra(_linha) : 0;
                        Console.WriteLine("palavra: {0}  -  posição: {1}", _linha, imprimir);
                    }
                }

                Console.Write("\nFinal da Aplicação, click enter para encerrar");
            }
            catch {
                Console.Write("\nAlgum Erro Inesperado");
            }

            Console.ReadKey();
        }
    }
}
