using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace appSSI
{
    public class coSistemas: csModelBase
    {
        private caSistemas objCaSistemas;

        private int _cdSistema;
        public int cdSistema
        {
            get { return _cdSistema; }
            set { _cdSistema = value; }
        }

        private string _nmSistema = "";
        public string nmSistema
        {
            get { return _nmSistema; }
            set { _nmSistema = value; }
        }

        private string _taskProjeto = "";
        public string taskProjeto
        {
            get { return _taskProjeto; }
            set { _taskProjeto = value; }
        }

        private string _taskArea = "";
        public string taskArea
        {
            get { return _taskArea; }
            set { _taskArea = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coSistemas()
        {
            objCaSistemas = new caSistemas();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Sobrescrito para retornar a chave
        /// </summary>
        /// <returns></returns>
        public override bool Inserir()
        {
            if (base.Inserir())
            {
                _cdSistema = objBanco.cdChave;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaSistemas.nmCampoChave;
            objBanco.strTabela = objCaSistemas.nmTabela;
        }
    }
}
