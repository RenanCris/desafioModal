using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioModal
{
    public class Validacao
    {
        private static Dictionary<char, int> LETRA_POSICAO = new Dictionary<char, int>();

        static Validacao() {
            var _alfabeto = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var _contador = 0;

            _alfabeto.ToList().ForEach(x =>
            {
                LETRA_POSICAO.Add(x, _contador++);
            });
        }

        public static int ValidarPalavra(string palavra) {
            
            var _palavraSeparada = palavra.ToCharArray();
           
            var _retorno = 1;

            Regex _r = new Regex(@"([^a])(?=\1+)", RegexOptions.IgnoreCase);
            var _temDuplicado = _r.Matches(palavra);

            if (_temDuplicado.Count > 0)
                return 0;

            int _posicao = 0;

            for (int i = 0; i < _palavraSeparada.Length; i++) {
                int _posicaoAtual = LETRA_POSICAO.Where(l => l.Key == _palavraSeparada[i]).Select(j => j.Value).FirstOrDefault();

                if (_posicao < _posicaoAtual)
                {
                    _posicao = _posicaoAtual;
                }

                if (_posicaoAtual < _posicao)
                {
                    _retorno = 0;
                    break;
                }
            }

            return _retorno;
        }
    }
}
