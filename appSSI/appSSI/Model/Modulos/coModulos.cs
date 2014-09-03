using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appSSI
{
    public class coModulos : csModelBase
    {
        private caModulos objCaModulos;

        private int _cdModulo;
        public int cdModulo
        {
            get { return _cdModulo; }
            set { _cdModulo = value; }
        }

        private int _cdSistema;
        public int cdSistema
        {
          get { return _cdSistema; }
          set { _cdSistema = value; }
        }

        private string _nmModulo = "";
        public string nmModulo
        {
            get { return _nmModulo; }
            set { _nmModulo = value; }
        }

        private string _taskModulo = "";
        public string taskModulo
        {
            get { return _taskModulo; }
            set { _taskModulo = value; }
        }

        #region Campos Calculado

        private string _CC_nmSistema;

        public string CC_nmSistema
        {
            get { return _CC_nmSistema; }
            set { _CC_nmSistema = value; }
        }

        #endregion

        /// <summary>
        /// Construtor
        /// </summary>
        public coModulos()
        {
            objCaModulos = new caModulos();
            objBanco.obj = this;
            objBanco.strCampoChave = objCaModulos.nmCampoChave;
            objBanco.strTabela = objCaModulos.nmTabela;
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaModulos.nmCampoChave;
            objBanco.strTabela = objCaModulos.nmTabela;
        }

        /// <summary>
        /// Sobrescrito para retornar a chave
        /// </summary>
        /// <returns></returns>
        public override bool Inserir()
        {
            if (base.Inserir())
            {
                _cdModulo = objBanco.cdChave;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método sobrescrito por conta do campo calculado
        /// </summary>
        /// <param name="dtDados"></param>
        /// <returns></returns>
        public override bool Select(out DataTable dtDados)
        {
            conSistemas objconSistemas = new conSistemas();
            caSistemas objcaSistemas = new caSistemas();

            if (base.Select(out dtDados))
            {
                dtDados.Columns[objCaModulos.CC_nmSistema].ReadOnly = false;
                dtDados.Columns[objCaModulos.CC_nmSistema].MaxLength = 100;

                foreach (DataRow dr in dtDados.Rows)
                {
                    objconSistemas.objCoSistemas.LimparAtributos();
                    objconSistemas.objCoSistemas.cdSistema = Convert.ToInt32(dr[objCaModulos.cdSistema].ToString());

                    if (objconSistemas.Select())
                        dr[objCaModulos.CC_nmSistema] = objconSistemas.dtDados.Rows[0][objcaSistemas.nmSistema].ToString();
                }
            }
            else
                return false;

            return true;
        }
    }
}
