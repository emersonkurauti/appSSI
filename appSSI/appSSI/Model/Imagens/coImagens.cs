using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appSSI
{
    public class coImagens : csModelBase
    {
        public caImagens objCaImagens;

        private int _cdImagem;
        public int cdImagem
        {
            get { return _cdImagem; }
            set { _cdImagem = value; }
        }

        //private int _cdDefeito;
        //public int cdDefeito
        //{
        //    get { return _cdDefeito; }
        //    set { _cdDefeito = value; }
        //}

        //private int _cdSolucao;
        //public int cdSolucao
        //{
        //    get { return _cdSolucao; }
        //    set { _cdSolucao = value; }
        //}

        private string _deImagem = "";
        public string deImagem
        {
            get { return _deImagem; }
            set { _deImagem = value; }
        }

        private string _blImagem = "";
        public string blImagem
        {
            get { return _blImagem; }
            set { _blImagem = value; }
        }

        private string _deCaminho = "";
        public string deCaminho
        {
            get { return _deCaminho; }
            set { _deCaminho = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coImagens()
        {
            objCaImagens = new caImagens();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <param name="dtDados"></param>
        /// <returns></returns>
        public override bool Select(out DataTable dtDados)
        {
            try
            {
                AtualizaObj();
                objBanco.strFiltro = strFiltro;
                dtDados = objBanco.Select();

                return true;
            }
            catch
            {
                dtDados = null;
                return false;
            }
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        //public override void AtualizaObj()
        //{
        //    base.AtualizaObj();
        //    objBanco.bControlaConxao = false;
        //    objBanco.strCampoChave = objCaImagens.nmCampoChave;
        //    objBanco.strTabela = objCaImagens.nmTabela;
        //}
    }
}
