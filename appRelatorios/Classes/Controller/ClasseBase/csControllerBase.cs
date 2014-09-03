using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appRelatorios
{
    public class csControllerBase
    {
        protected string _strMensagemErro;

        public string strMensagemErro
        {
            get { return _strMensagemErro; }
            set { _strMensagemErro = value; }
        }
        protected DataTable _dtDados;

        public DataTable dtDados
        {
            get { return _dtDados; }
            set { _dtDados = value; }
        }
    }
}
