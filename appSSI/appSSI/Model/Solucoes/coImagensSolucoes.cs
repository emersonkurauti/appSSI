using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class coImagensSolucoes : coImagens
    {
        public caImagensSolucoes objCaImagensSolucoes;

        private int _cdSolucao;
        public int cdSolucao
        {
            get { return _cdSolucao; }
            set { _cdSolucao = value; }
        }

        /// <summary>
        /// Método de exclusão sobrescrito para algumas particularidades
        /// </summary>
        /// <returns></returns>
        public override bool Excluir()
        {
            try
            {
                AtualizaObj();
                objBanco.strCampoChave = objCaImagensSolucoes.cdSolucao;
                return objBanco.Excluir();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();

            objCaImagensSolucoes = new caImagensSolucoes();
            objBanco.bControlaConxao = false;
            objBanco.strCampoChave = objCaImagensSolucoes.nmCampoChave;
            objBanco.strTabela = objCaImagensSolucoes.nmTabela;
        }
    }
}
