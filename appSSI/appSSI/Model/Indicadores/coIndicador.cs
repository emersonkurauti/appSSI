using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appSSI
{
    public class coIndicador : csModelBase
    {
        private caIndicador objCaIndicador;

        private DataTable _dtParametros;
        public DataTable dtParametros
        {
            get { return _dtParametros; }
            set { _dtParametros = value; }
        }

        private int _cdIndicador;
        public int cdIndicador
        {
            get { return _cdIndicador; }
            set { _cdIndicador = value; }
        }

        private int _cdUsuario;
        public int cdUsuario
        {
            get { return _cdUsuario; }
            set { _cdUsuario = value; }
        }

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

        private char _flResultado = ' ';
        public char flResultado
        {
            get { return _flResultado; }
            set { _flResultado = value; }
        }

        private string _deObservacao = "";
        public string deObservacao
        {
            get { return _deObservacao; }
            set { _deObservacao = value; }
        }

        private int _cdOSGerada;
        public int cdOSGerada
        {
            get { return _cdOSGerada; }
            set { _cdOSGerada = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coIndicador()
        {
            objCaIndicador = new caIndicador();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método de inserir sobrescrito para utilizar transação
        /// </summary>
        /// <returns></returns>
        public override bool Inserir()
        {
            conParametros objConParametros = new conParametros();
            caParametros objCaParametros = new caParametros();

            try
            {
                AtualizaObj();
                objBanco.BeginTransaction();

                if (objBanco.Inserir())
                {
                    objConParametros.objCoParametros.cdIndicador = objBanco.cdChave;

                    for (int i = 0; i < _dtParametros.Rows.Count; i++)
                    {
                        objConParametros.objCoParametros.nmParametro =_dtParametros.Rows[i][objCaParametros.nmParametro].ToString();
                        objConParametros.objCoParametros.vlParametro = _dtParametros.Rows[i][objCaParametros.vlParametro].ToString();

                        if (!objConParametros.Inserir())
                        {
                            objBanco.RollbackTransaction();
                            return false;
                        }
                    }

                    _cdIndicador = objBanco.cdChave;
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
            conParametros objConParametros = new conParametros();
            caParametros objCaParametros = new caParametros();

            try
            {
                AtualizaObj();
                objBanco.BeginTransaction();

                if (objBanco.Alterar())
                {
                    objConParametros.objCoParametros.cdIndicador= _cdIndicador;
                    objConParametros.Excluir();

                    for (int i = 0; i < _dtParametros.Rows.Count; i++)
                    {
                        objConParametros.objCoParametros.nmParametro = _dtParametros.Rows[i][objCaParametros.nmParametro].ToString();
                        objConParametros.objCoParametros.vlParametro = _dtParametros.Rows[i][objCaParametros.vlParametro].ToString();

                        if (!objConParametros.Inserir())
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
            conParametros objConParametros = new conParametros();
            caParametros objCaParametros = new caParametros();

            try
            {
                objBanco.BeginTransaction();

                objConParametros.objCoParametros.cdIndicador = _cdIndicador;
                if (objConParametros.Excluir())
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

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaIndicador.nmCampoChave;
            objBanco.strTabela = objCaIndicador.nmTabela;
        }
    }
}
