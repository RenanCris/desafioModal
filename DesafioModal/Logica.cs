using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioModal
{
    public class Logica
    {
        private static SortedDictionary<string, int> DICIONARIO = new SortedDictionary<string, int>();
        private static int CODE = 1;

        static Logica() {
            for (uint tamanho = 1; tamanho <= 5; ++tamanho)
            {
                Enumerador("", tamanho);
            }
        }

        private static void Enumerador(string s, uint tamanho)
        {
            if (s.Length == tamanho)
            {
                DICIONARIO[s] = CODE++;
                return;
            }

            char _ultimaLetra;

            if (string.IsNullOrEmpty(s))
            {
                _ultimaLetra = 'a';
            }
            else
            {
                _ultimaLetra = (char)(s[s.Length - 1] + 1);
            }

            for (char c = _ultimaLetra; c <= 'z'; ++c)
            {
                Enumerador(s + c, tamanho);
            }
        }

        public static int GetPosicaoPalavra(string palavra) {
            return DICIONARIO[palavra];
        }

    }
}
