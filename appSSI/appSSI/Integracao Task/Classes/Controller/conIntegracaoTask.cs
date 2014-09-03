using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conIntegracaoTask : csControllerBase
    {
        private coIntegracaoTask _objCoIntegracaoTask;
        public coIntegracaoTask objCoIntegracaoTask
        {
            get { return _objCoIntegracaoTask; }
            set { _objCoIntegracaoTask = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conIntegracaoTask()
        {
            _objCoIntegracaoTask = new coIntegracaoTask();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoIntegracaoTask.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectIntegracaoTask;
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
            if (!_objCoIntegracaoTask.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirIntegracaoTask;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Alterar
        /// </summary>
        /// <returns></returns>
        public bool Alterar()
        {
            _strMensagemErro = "";

            if (!_objCoIntegracaoTask.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarIntegracaoTask;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Excluir
        /// </summary>
        /// <returns></returns>
        public bool Excluir()
        {
            _strMensagemErro = "";

            if (!_objCoIntegracaoTask.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirIntegracaoTask;
                return false;
            }
            return true;
        }
    }
}
