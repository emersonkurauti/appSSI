using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class coImagensDefeitos : coImagens
    {
        public caImagensDefeitos objCaImagensDefeitos;

        private int _cdDefeito;
        public int cdDefeito
        {
            get { return _cdDefeito; }
            set { _cdDefeito = value; }
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
                objBanco.strCampoChave = objCaImagensDefeitos.cdDefeito;
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

            objCaImagensDefeitos = new caImagensDefeitos();
            objBanco.bControlaConxao = false;
            objBanco.strCampoChave = objCaImagensDefeitos.nmCampoChave;
            objBanco.strTabela = objCaImagensDefeitos.nmTabela;
        }
    }
}
