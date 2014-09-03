using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conParametros : csControllerBase
    {
        private coParametros _objCoParametros;
        public coParametros objCoParametros
        {
            get { return _objCoParametros; }
            set { _objCoParametros = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conParametros()
        {
            _objCoParametros = new coParametros();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoParametros.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectParametro;
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
            if (!_objCoParametros.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirParametro;
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

            if (!_objCoParametros.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarParametro;
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

            if (!_objCoParametros.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirParametro;
                return false;
            }
            return true;
        }
    }
}
