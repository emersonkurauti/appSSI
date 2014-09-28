using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appSSI
{
    public class coDefeitoAcaoTela : csModelBase
    {
        private caDefeitoAcaoTela objCaDefeitoAcaoTela;

        private int _cdAcao;
        public int cdAcao
        {
            get { return _cdAcao; }
            set { _cdAcao = value; }
        }

        private int _cdTela;
        public int cdTela
        {
          get { return _cdTela; }
          set { _cdTela = value; }
        }

        private int _cdDefeito;
        public int cdDefeito
        {
          get { return _cdDefeito; }
          set { _cdDefeito = value; }
        }

        private string _CC_deAcao = "";
        public string CC_deAcao
        {
            get { return _CC_deAcao; }
            set { _CC_deAcao = value; }
        }

        private string _CC_deTela = "";
        public string CC_deTela
        {
            get { return _CC_deTela; }
            set { _CC_deTela = value; }
        }

        private string _CC_deDefeito = "";
        public string CC_deDefeito
        {
            get { return _CC_deDefeito; }
            set { _CC_deDefeito = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coDefeitoAcaoTela()
        {
            objCaDefeitoAcaoTela = new caDefeitoAcaoTela();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método sobrescrito para preencher as descrições da Tela, Ação e do Defeito
        /// </summary>
        /// <param name="dtDados"></param>
        /// <returns></returns>
        public override bool Select(out System.Data.DataTable dtDados)
        {
            conTelas objconTelas = new conTelas();
            caTelas objcaTelas = new caTelas();

            conAcoes objconAcoes = new conAcoes();
            caAcoes objcaAcoes = new caAcoes();

            conDefeitos objconDefeitos = new conDefeitos();
            caDefeitos objcaDefeitos = new caDefeitos();

            if (base.Select(out dtDados))
            {
                dtDados.Columns[objCaDefeitoAcaoTela.CC_deTela].ReadOnly = false;
                dtDados.Columns[objCaDefeitoAcaoTela.CC_deTela].MaxLength = 100;

                dtDados.Columns[objCaDefeitoAcaoTela.CC_deAcao].ReadOnly = false;
                dtDados.Columns[objCaDefeitoAcaoTela.CC_deAcao].MaxLength = 100;

                dtDados.Columns[objCaDefeitoAcaoTela.CC_deDefeito].ReadOnly = false;
                dtDados.Columns[objCaDefeitoAcaoTela.CC_deDefeito].MaxLength = 100;

                foreach (DataRow dr in dtDados.Rows)
                {
                    objconTelas.objCoTelas.LimparAtributos();
                    objconTelas.objCoTelas.strFiltro = " Where cdTela = " + dr[objCaDefeitoAcaoTela.cdTela].ToString();

                    if (objconTelas.Select())
                        dr[objCaDefeitoAcaoTela.CC_deTela] = objconTelas.dtDados.Rows[0][objcaTelas.nmTela].ToString();
                    
                    objconAcoes.objCoAcoes.LimparAtributos();
                    objconAcoes.objCoAcoes.strFiltro = " Where cdAcao = " + dr[objCaDefeitoAcaoTela.cdAcao].ToString();

                    if (objconAcoes.Select())
                        dr[objCaDefeitoAcaoTela.CC_deAcao] = objconAcoes.dtDados.Rows[0][objcaAcoes.deAcao].ToString();

                    objconDefeitos.objCoDefeitos.LimparAtributos();
                    objconDefeitos.objCoDefeitos.cdDefeito = Convert.ToInt32(dr[objCaDefeitoAcaoTela.cdDefeito].ToString());

                    if (objconDefeitos.Select())
                        dr[objCaDefeitoAcaoTela.CC_deDefeito] = objconDefeitos.dtDados.Rows[0][objcaDefeitos.deDefeito].ToString();
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
            objBanco.strCampoChave = objCaDefeitoAcaoTela.nmCampoChave;
            objBanco.strTabela = objCaDefeitoAcaoTela.nmTabela;
        }
    }
}
