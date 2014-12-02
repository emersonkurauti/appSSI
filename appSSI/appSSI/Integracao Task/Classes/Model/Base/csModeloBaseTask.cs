using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Banco;
using System.Reflection;
using System.Data;

namespace appSSI
{
    public class csModelBaseTask
    {
        /// <summary>
        /// Objeto de conxão com banco
        /// </summary>
        public csBancoTask objBanco = csBancoTask.Instance;

        public string strFiltro = "";

        /// <summary>
        /// Método para limpar os atributos do modelo
        /// </summary>
        public void LimparAtributos()
        {
            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (var property in properties)
            {
                string name = property.Name;
                object temp = this.GetType().GetProperty(property.Name).GetValue(this, null);

                if (temp is string)
                    this.GetType().GetProperty(property.Name).SetValue(this, "", null);
                else
                    if (temp is char)
                        this.GetType().GetProperty(property.Name).SetValue(this, ' ', null);
                    else
                        if ((temp is int) || (temp is Int64) || (temp is float) || (temp is decimal))
                            this.GetType().GetProperty(property.Name).SetValue(this, 0, null);
                        else
                            if (temp is DateTime)
                                this.GetType().GetProperty(property.Name).SetValue(this, null, null);
                            else
                                if (temp is bool)
                                    this.GetType().GetProperty(property.Name).SetValue(this, false, null);
                                else
                                    if(temp is byte[])
                                        this.GetType().GetProperty(property.Name).SetValue(this, null, null);
            }
        }

        /// <summary>
        /// Retorna a estrutura do datatable
        /// </summary>
        /// <returns></returns>
        public virtual DataTable RetornaEstruturaDT()
        {
            DataTable dt = new DataTable();
            DataColumn dc;

            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (var property in properties)
            {
                object temp = this.GetType().GetProperty(property.Name).GetValue(this, null);

                if (temp != null)
                {
                    dc = new DataColumn();
                    dc.DataType = temp.GetType();
                    dc.ColumnName = property.Name;

                    if (property.Name.Substring(0, 3).Equals("CC_"))
                        dc.MaxLength = 10000;

                    dt.Columns.Add(dc);
                }
            }

            return dt;
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <param name="dtDados"></param>
        /// <returns></returns>
        public virtual bool Select(out DataTable dtDados)
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
        /// Inserir
        /// </summary>
        /// <returns></returns>
        public virtual bool Inserir()
        {
            try
            {
                AtualizaObj();
                return objBanco.Inserir();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Alterar
        /// </summary>
        /// <returns></returns>
        public virtual bool Alterar()
        {
            try
            {
                AtualizaObj();
                return objBanco.Alterar();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Excluir
        /// </summary>
        /// <returns></returns>
        public virtual bool Excluir()
        {
            try
            {
                AtualizaObj();
                return objBanco.Excluir();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Método para ser sobrescrito
        /// </summary>
        public virtual void AtualizaObj()
        {
            objBanco.obj = this;
            objBanco.bGerarChave = true;
            objBanco.bControlaConxao = true;
        }
    }
}
