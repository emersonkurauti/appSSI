using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conDefeitos : csControllerBase
    {
        private coDefeitos _objCoDefeitos;
        public coDefeitos objCoDefeitos
        {
            get { return _objCoDefeitos; }
            set { _objCoDefeitos = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conDefeitos()
        {
            _objCoDefeitos = new coDefeitos();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoDefeitos.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectDefeitos;
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
            if (!_objCoDefeitos.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirDefeitos;
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

            if (!_objCoDefeitos.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarDefeitos;
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

            if (!_objCoDefeitos.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirDefeitos;
                return false;
            }
            return true;
        }
    }
}
