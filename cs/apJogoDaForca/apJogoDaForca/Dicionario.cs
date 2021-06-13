// Gabriel Willian Bartmanovicz - 21234
// João Pero Ferreira Barbosa - 21687

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace apJogoDaForca
{
    class Dicionario
    {
        const int inicioPalavra = 0,
                  tamanhoPalavra = 15,
                  inicioDica = inicioPalavra + tamanhoPalavra;

        string palavra;
        string dica;
        bool[] acertou;

        public string Palavra 
        {
            get => palavra;
            set => palavra = value;
        }

        public string Dica 
        { 
            get => dica;
            set => dica = value;
        }

        public bool[] Acertou
        {
            get => acertou;
            set => acertou = value;
        }

        public Dicionario(string palavra, string dica)
        {
            this.Palavra = palavra;
            this.Dica = dica;
        }

        public Dicionario()
        {
            Palavra = " ";
            Dica = " ";
        }

        public void LerDados(StreamReader arq)
        {
            if (!arq.EndOfStream)
            {
                string linha = arq.ReadLine();
                Palavra = linha.Substring(inicioPalavra, tamanhoPalavra).ToUpper();
                Dica = linha.Substring(inicioDica);
                Acertou = new bool[15];
                for (int i = 0; i < acertou.Length; i++)
                    Acertou[i] = false;
            }
        }

        public string FormatoDeArquivo()
        {
            return Palavra.PadRight(tamanhoPalavra, ' ') + // Alinha-os a direita
                   Dica.PadRight(inicioPalavra);
        }
    }
}