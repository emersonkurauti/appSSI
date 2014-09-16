using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appSSI
{
    public class coTelas : csModelBase
    {
        private caTelas objCaTelas;

        private DataTable _dtTelasAcoes;
        public DataTable dtTelasAcoes
        {
            get { return _dtTelasAcoes; }
            set { _dtTelasAcoes = value; }
        }

        private int _cdTela;
        public int cdTela
        {
            get { return _cdTela; }
            set { _cdTela = value; }
        }

        private int _cdModulo;
        public int cdModulo
        {
          get { return _cdModulo; }
          set { _cdModulo = value; }
        }

        private string _nmTela = "";
        public string nmTela
        {
            get { return _nmTela; }
            set { _nmTela = value; }
        }

        #region Campos Calculado

        private string _CC_nmModulo;

        public string CC_nmModulo
        {
            get { return _CC_nmModulo; }
            set { _CC_nmModulo = value; }
        }

        #endregion

        /// <summary>
        /// Construtor
        /// </summary>
        public coTelas()
        {
            objCaTelas = new caTelas();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.bControlaConxao = false;
            objBanco.strCampoChave = objCaTelas.nmCampoChave;
            objBanco.strTabela = objCaTelas.nmTabela;
        }

        /// <summary>
        /// Método sobrescrito por conta do campo calculado
        /// </summary>
        /// <param name="dtDados"></param>
        /// <returns></returns>
        public override bool Select(out DataTable dtDados)
        {
            conModulos objconModulos = new conModulos();
            caModulos objcaModulos = new caModulos();

            if (base.Select(out dtDados))
            {
                dtDados.Columns[objCaTelas.CC_nmModulo].ReadOnly = false;
                dtDados.Columns[objCaTelas.CC_nmModulo].MaxLength = 100;

                foreach (DataRow dr in dtDados.Rows)
                {
                    objconModulos.objCoModulos.LimparAtributos();
                    objconModulos.objCoModulos.cdModulo = Convert.ToInt32(dr[objCaTelas.cdModulo].ToString());

                    if (objconModulos.Select())
                        dr[objCaTelas.CC_nmModulo] = objconModulos.dtDados.Rows[0][objcaModulos.nmModulo].ToString();
                }
            }
            else
                return false;

            return true;
        }

        /// <summary>
        /// Método de inserir sobrescrito para utilizar transação
        /// </summary>
        /// <returns></returns>
        public override bool Inserir()
        {
            conTelasAcoes objConTelasAcoes = new conTelasAcoes();
            caTelasAcoes objCaTelasAcoes = new caTelasAcoes();

            try
            {
                AtualizaObj();
                objBanco.BeginTransaction();

                if (objBanco.Inserir())
                {
                    objConTelasAcoes.objCoTelasAcoes.cdTela = objBanco.cdChave;

                    for (int i = 0; i < _dtTelasAcoes.Rows.Count; i++)
                    {
                        objConTelasAcoes.objCoTelasAcoes.cdAcao =
                            Convert.ToInt32(_dtTelasAcoes.Rows[i][objCaTelasAcoes.cdAcao].ToString());

                        if (!objConTelasAcoes.Inserir())
                        {
                            objBanco.RollbackTransaction();
                            return false;
                        }
                    }

                    _cdTela = objBanco.cdChave;
                    objBanco.CommitTransaction();
                    return true;
                }
                else
                {
                    objBanco.RollbackTransaction();
                    return false;
                }
            }
            catch
            {
                objBanco.RollbackTransaction();
                return false;
            }
        }

        /// <summary>
        /// Método de alterar sobrescrito para utilizar transação
        /// </summary>
        /// <returns></returns>
        public override bool Alterar()
        {
            conTelasAcoes objConTelasAcoes = new conTelasAcoes();
            caTelasAcoes objCaTelasAcoes = new caTelasAcoes();

            conDefeitoAcaoTela objconDefeitoAcaoTela = new conDefeitoAcaoTela();
            caDefeitoAcaoTela objcaDefeitoAcaoTela = new caDefeitoAcaoTela();

            DataTable dtTelasAcoesIntermediaria = objConTelasAcoes.objCoTelasAcoes.RetornaEstruturaDT();
            bool bAchou;

            try
            {
                AtualizaObj();
                objBanco.BeginTransaction();

                if (objBanco.Alterar())
                {
                    objConTelasAcoes.objCoTelasAcoes.cdTela = _cdTela;
                    objconDefeitoAcaoTela.objCoDefeitoAcaoTela.cdTela = _cdTela;

                    //consulta as ações da tela
                    if (!objConTelasAcoes.Select())
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }

                    //Faz o merge
                    for (int i = 0; i < objConTelasAcoes.dtDados.Rows.Count; i++)
                    {
                        bAchou = false;

                        for (int k = 0; k < _dtTelasAcoes.Rows.Count; k++)
                        {
                            if (_dtTelasAcoes.Rows[k][objCaTelasAcoes.cdAcao].ToString() ==
                                objConTelasAcoes.dtDados.Rows[i][objCaTelasAcoes.cdAcao].ToString())
                                bAchou = true;
                        }

                        //Foi removido por tela
                        if (!bAchou)
                        {
                            //verifica se nao está associado a um defeito
                            objconDefeitoAcaoTela.objCoDefeitoAcaoTela.cdAcao = Convert.ToInt32(objConTelasAcoes.dtDados.Rows[i][objCaTelasAcoes.cdAcao].ToString());

                            if (!objconDefeitoAcaoTela.Select())
                            {
                                objBanco.RollbackTransaction();
                                return false;
                            }

                            //Se não achou remove
                            if (objconDefeitoAcaoTela.dtDados.Rows.Count == 0)
                            {
                                objConTelasAcoes.objCoTelasAcoes.cdAcao = Convert.ToInt32(objConTelasAcoes.dtDados.Rows[i][objCaTelasAcoes.cdAcao].ToString());

                                if (!objConTelasAcoes.Excluir())
                                {
                                    objBanco.RollbackTransaction();
                                    return false;
                                }
                            }
                        }
                    }

                    //Faz o merge inverso
                    for (int i = 0; i < _dtTelasAcoes.Rows.Count; i++)
                    {
                        bAchou = false;

                        for (int k = 0; k < objConTelasAcoes.dtDados.Rows.Count; k++)
                        {
                            if (_dtTelasAcoes.Rows[i][objCaTelasAcoes.cdAcao].ToString() ==
                                objConTelasAcoes.dtDados.Rows[k][objCaTelasAcoes.cdAcao].ToString())
                                bAchou = true;
                        }

                        //Foi inserido por tela
                        if (!bAchou)
                        {
                            objConTelasAcoes.objCoTelasAcoes.cdAcao = Convert.ToInt32(_dtTelasAcoes.Rows[i][objCaTelasAcoes.cdAcao].ToString());

                            if (!objConTelasAcoes.Inserir())
                            {
                                objBanco.RollbackTransaction();
                                return false;
                            }
                        }
                    }

                    objBanco.CommitTransaction();
                    return true;
                }
                else
                {
                    objBanco.RollbackTransaction();
                    return false;
                }
            }
            catch
            {
                objBanco.RollbackTransaction();
                return false;
            }
        }

        /// <summary>
        /// Método de excluir sobrescrito para utilizar transação
        /// </summary>
        /// <returns></returns>
        public override bool Excluir()
        {
            conTelasAcoes objConTelasAcoes = new conTelasAcoes();
            caTelasAcoes objCaTelasAcoes = new caTelasAcoes();

            try
            {
                objBanco.BeginTransaction();

                objConTelasAcoes.objCoTelasAcoes.cdTela = _cdTela;
                if (objConTelasAcoes.Excluir())
                {
                    objConTelasAcoes.objCoTelasAcoes.cdTela = _cdTela;

                    AtualizaObj();
                    if (!objBanco.Excluir())
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }

                    objBanco.CommitTransaction();
                    return true;
                }
                else
                {
                    objBanco.RollbackTransaction();
                    return false;
                }
            }
            catch
            {
                objBanco.RollbackTransaction();
                return false;
            }
        }
    }
}
