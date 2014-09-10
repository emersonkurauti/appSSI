using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conSistemas : csControllerBase
    {
        private coSistemas _objCoSistemas;

        public coSistemas objCoSistemas
        {
            get { return _objCoSistemas; }
            set { _objCoSistemas = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conSistemas()
        {
            _objCoSistemas = new coSistemas();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            if (!_objCoSistemas.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectSistema;
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
            if (!_objCoSistemas.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirSistema;
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
            if (!_objCoSistemas.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarSistema;
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
            if (!_objCoSistemas.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirSistema;
                return false;
            }
            return true;
        }
    }
}
