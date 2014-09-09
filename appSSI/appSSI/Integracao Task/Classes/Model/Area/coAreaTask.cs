using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class coAreaTask: csModelBaseTask
    {
        private caAreaTask objCaAreaTask;

        private int _cd_area;
        public int cd_area
        {
            get { return _cd_area; }
            set { _cd_area = value; }
        }

        private string _ds_area = "";
        public string ds_area
        {
          get { return _ds_area; }
          set { _ds_area = value; }
        }

        private char _bo_ativo = 'S';
        public char bo_ativo
        {
            get { return _bo_ativo; }
            set { _bo_ativo = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coAreaTask()
        {
            objCaAreaTask = new caAreaTask();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaAreaTask.nmCampoChave;
            objBanco.strTabela = objCaAreaTask.nmTabela;
        }
    }
}
