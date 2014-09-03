using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caImagens
    {
        public string nmTabela
        {
            get { return "IMAGENS"; }
        }

        //public string nmCampoChave
        //{
        //    get { return "cdImagem"; }
        //}

        public string cdImagem
        {
            get { return "cdImagem"; }
        }

        public string cdDefeito
        {
            get { return "cdDefeito"; }
        }

        public string cdSolucao
        {
            get { return "cdSolucao"; }
        }

        public string deImagem
        {
            get { return "deImagem"; }
        }

        public string blImagem
        {
            get { return "blImagem"; }
        }

        public string deCaminhoImagem
        {
            get { return "deCaminho"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdImagem + "," + cdDefeito + "," + cdSolucao + "," + deImagem + "," + blImagem;

            strNome = "Código, Código Defeito, Código Solução, Descrição Imagem, Imagem";

            strVisivel = "0,0,0,1,0";
        }
    }
}
