using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appSSI
{
    public class coSolucoesDefeitos: csModelBase
    {
        public caSolucoesDefeitos objCaSolucoesDefeitos = new caSolucoesDefeitos();

        private int _cdDefeito;
        public int cdDefeito
        {
            get { return _cdDefeito; }
            set { _cdDefeito = value; }
        }

        private int _cdSolucao;
        public int cdSolucao
        {
            get { return _cdSolucao; }
            set { _cdSolucao = value; }
        }

        private string _CC_deSolucao = "";
        public string CC_deSolucao
        {
            get { return _CC_deSolucao; }
            set { _CC_deSolucao = value; }
        }

        private string _CC_deDefeito = "";
        public string CC_deDefeito
        {
            get { return _CC_deDefeito; }
            set { _CC_deDefeito = value; }
        }

        private string _deObservacao = "";
        public string deObservacao
        {
            get { return _deObservacao; }
            set { _deObservacao = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coSolucoesDefeitos()
        {
            //objCaSolucoesDefeitos = new caSolucoesDefeitos();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método sobrescrito para preencher as descrições do defeito/solução
        /// </summary>
        /// <param name="dtDados"></param>
        /// <returns></returns>
        public override bool Select(out System.Data.DataTable dtDados)
        {
            conSolucoes objconSolucoes = new conSolucoes();
            caSolucoes objcaSolucoes = new caSolucoes();

            conDefeitos objconDefeitos = new conDefeitos();
            caDefeitos objcaDefeitos = new caDefeitos();

            if (base.Select(out dtDados))
            {
                if (_cdSolucao != 0) //Caso seja uma solução, pesquisar por defeitos
                {
                    dtDados.Columns[objCaSolucoesDefeitos.CC_deDefeito].ReadOnly = false;
                    dtDados.Columns[objCaSolucoesDefeitos.CC_deDefeito].MaxLength = 10000;

                    foreach (DataRow dr in dtDados.Rows)
                    {
                        objconDefeitos.objCoDefeitos.LimparAtributos();
                        objconDefeitos.objCoDefeitos.cdDefeito = Convert.ToInt32(dr[objCaSolucoesDefeitos.cdDefeito].ToString());

                        if (objconDefeitos.Select())
                            dr[objCaSolucoesDefeitos.CC_deDefeito] = objconDefeitos.dtDados.Rows[0][objcaDefeitos.deDefeito].ToString();
                    }
                }
                else
                {
                    dtDados.Columns[objCaSolucoesDefeitos.CC_deSolucao].ReadOnly = false;
                    dtDados.Columns[objCaSolucoesDefeitos.CC_deSolucao].MaxLength = 10000;

                    foreach (DataRow dr in dtDados.Rows)
                    {
                        objconSolucoes.objCoSolucoes.LimparAtributos();
                        objconSolucoes.objCoSolucoes.cdSolucao = Convert.ToInt32(dr[objCaSolucoesDefeitos.cdSolucao].ToString());

                        if (objconSolucoes.Select())
                            dr[objCaSolucoesDefeitos.CC_deSolucao] = objconSolucoes.dtDados.Rows[0][objcaSolucoes.deSolucao].ToString();
                    }
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
            objBanco.strCampoChave = objCaSolucoesDefeitos.nmCampoChave;
            objBanco.strTabela = objCaSolucoesDefeitos.nmTabela;
        }
    }
}
