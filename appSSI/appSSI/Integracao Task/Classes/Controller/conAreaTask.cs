using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conAreaTask: csControllerBase
    {
        private coAreaTask _objCoAreaTask;
        public coAreaTask objCoAreaTask
        {
            get { return _objCoAreaTask; }
            set { _objCoAreaTask = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conAreaTask()
        {
            _objCoAreaTask = new coAreaTask();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoAreaTask.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectAreaTask;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Inserir
        /// </summary>
        /// <returns></returns>
        public bool Inserir()
        {
            _strMensagemErro = "Operação não autorizada";
            return false;
        }

        /// <summary>
        /// Alterar
        /// </summary>
        /// <returns></returns>
        public bool Alterar()
        {
            _strMensagemErro = "Operação não autorizada";
            return false;
        }

        /// <summary>
        /// Excluir
        /// </summary>
        /// <returns></returns>
        public bool Excluir()
        {
            _strMensagemErro = "Operação não autorizada";
            return false;
        }
    }
}
