using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appSSI
{
    public class coTelasAcoes : csModelBase
    {
        private caTelasAcoes objCaTelasAcoes;

        private int _cdTela;
        public int cdTela
        {
            get { return _cdTela; }
            set { _cdTela = value; }
        }

        private int _cdAcao;
        public int cdAcao
        {
            get { return _cdAcao; }
            set { _cdAcao = value; }
        }

        private string _CC_deAcao = "";
        public string CC_deAcao
        {
            get { return _CC_deAcao; }
            set { _CC_deAcao = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coTelasAcoes()
        {
            objCaTelasAcoes = new caTelasAcoes();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método sobrescrito por conta do campo calculado
        /// </summary>
        /// <param name="dtDados"></param>
        /// <returns></returns>
        public override bool Select(out DataTable dtDados)
        {
            conAcoes objconAcoes = new conAcoes();
            caAcoes objcaAcoes = new caAcoes();

            if (base.Select(out dtDados))
            {
                dtDados.Columns[objCaTelasAcoes.CC_deAcao].ReadOnly = false;
                dtDados.Columns[objCaTelasAcoes.CC_deAcao].MaxLength = 100;

                foreach (DataRow dr in dtDados.Rows)
                {
                    objconAcoes.objCoAcoes.LimparAtributos();
                    objconAcoes.objCoAcoes.cdAcao = Convert.ToInt32(dr[objCaTelasAcoes.cdAcao].ToString());

                    if (objconAcoes.Select())
                        dr[objCaTelasAcoes.CC_deAcao] = objconAcoes.dtDados.Rows[0][objcaAcoes.deAcao].ToString();
                }
            }
            else
                return false;

            return true;
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.bGerarChave = false;
            objBanco.bControlaConxao = false;
            objBanco.strCampoChave = objCaTelasAcoes.nmCampoChave;
            objBanco.strTabela = objCaTelasAcoes.nmTabela;
            objBanco.strChaveEstrangeira = objCaTelasAcoes.nmChaveEstrangeira;
        }
    }
}
