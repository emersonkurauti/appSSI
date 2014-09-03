using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace appSSI
{
    public class coEmpresas: csModelBase
    {
        private caEmpresas objCaEmpresas;

        private DataTable _dtSisEmp;
        public DataTable dtSisEmp
        {
            get { return _dtSisEmp; }
            set { _dtSisEmp = value; }
        }

        private int _cdEmpresa;

        public int cdEmpresa
        {
            get { return _cdEmpresa; }
            set { _cdEmpresa = value; }
        }
        private string _nmEmpresa = "";

        public string nmEmpresa
        {
            get { return _nmEmpresa; }
            set { _nmEmpresa = value; }
        }
        private string _nmFantasiaEmpresa = "";

        public string nmFantasiaEmpresa
        {
            get { return _nmFantasiaEmpresa; }
            set { _nmFantasiaEmpresa = value; }
        }
        private Int64 _nuCNPJ;

        public Int64 nuCNPJ
        {
            get { return _nuCNPJ; }
            set { _nuCNPJ = value; }
        }
        private string _deLogradouro = "";

        public string deLogradouro
        {
            get { return _deLogradouro; }
            set { _deLogradouro = value; }
        }
        private int _nuNumero;

        public int nuNumero
        {
            get { return _nuNumero; }
            set { _nuNumero = value; }
        }
        private string _deBairro = "";

        public string deBairro
        {
            get { return _deBairro; }
            set { _deBairro = value; }
        }
        private string _deComplemento = "";

        public string deComplemento
        {
            get { return _deComplemento; }
            set { _deComplemento = value; }
        }
        private int _nuCEP;

        public int nuCEP
        {
            get { return _nuCEP; }
            set { _nuCEP = value; }
        }
        private Int64 _nuTelefone;

        public Int64 nuTelefone
        {
            get { return _nuTelefone; }
            set { _nuTelefone = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coEmpresas()
        {
            objCaEmpresas = new caEmpresas();
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
            objBanco.strCampoChave = objCaEmpresas.nmCampoChave;
            objBanco.strTabela = objCaEmpresas.nmTabela;
        }
        
        /// <summary>
        /// Método de inserir sobrescrito para utilizar transação
        /// </summary>
        /// <returns></returns>
        public override bool Inserir()
        {
            conSistemasEmpresas objConSistemasEmpresas = new conSistemasEmpresas();
            caSistemasEmpresas objCaSistemasEmpresas = new caSistemasEmpresas();

            try
            {
                AtualizaObj();
                objBanco.BeginTransaction();

                if (objBanco.Inserir())
                {
                    objConSistemasEmpresas.objCoSistemasEmpresas.cdEmpresa = objBanco.cdChave;

                    for (int i = 0; i < _dtSisEmp.Rows.Count; i++)
                    {
                        objConSistemasEmpresas.objCoSistemasEmpresas.cdSistema = 
                            Convert.ToInt32(_dtSisEmp.Rows[i][objCaSistemasEmpresas.cdSistema].ToString());

                        if (!objConSistemasEmpresas.Inserir())
                        {
                            objBanco.RollbackTransaction();
                            return false;
                        }
                    }

                    _cdEmpresa = objBanco.cdChave;
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
            conSistemasEmpresas objConSistemasEmpresas = new conSistemasEmpresas();
            caSistemasEmpresas objCaSistemasEmpresas = new caSistemasEmpresas();

            try
            {
                AtualizaObj();
                objBanco.BeginTransaction();

                if (objBanco.Alterar())
                {
                    objConSistemasEmpresas.objCoSistemasEmpresas.cdEmpresa = _cdEmpresa;
                    objConSistemasEmpresas.Excluir();

                    for (int i = 0; i < _dtSisEmp.Rows.Count; i++)
                    {
                        objConSistemasEmpresas.objCoSistemasEmpresas.cdSistema =
                            Convert.ToInt32(_dtSisEmp.Rows[i][objCaSistemasEmpresas.cdSistema].ToString());

                        if (!objConSistemasEmpresas.Inserir())
                        {
                            objBanco.RollbackTransaction();
                            return false;
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
            conSistemasEmpresas objConSistemasEmpresas = new conSistemasEmpresas();
            caSistemasEmpresas objCaSistemasEmpresas = new caSistemasEmpresas();

            try
            {
                objBanco.BeginTransaction();

                objConSistemasEmpresas.objCoSistemasEmpresas.cdEmpresa = _cdEmpresa;
                if (objConSistemasEmpresas.Excluir())
                {
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
