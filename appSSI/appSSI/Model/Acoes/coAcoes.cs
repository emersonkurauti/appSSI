using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class coAcoes : csModelBase
    {
        private caAcoes objCaAcoes;

        private int _cdAcao;
        public int cdAcao
        {
            get { return _cdAcao; }
            set { _cdAcao = value; }
        }

        private string _deAcao = "";
        public string deAcao
        {
          get { return _deAcao; }
          set { _deAcao = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coAcoes()
        {
            objCaAcoes = new caAcoes();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Sobrescrito para retornar a chave
        /// </summary>
        /// <returns></returns>
        public override bool Inserir()
        {
            if (base.Inserir())
            {
                _cdAcao = objBanco.cdChave;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaAcoes.nmCampoChave;
            objBanco.strTabela = objCaAcoes.nmTabela;
        }
    }
}
