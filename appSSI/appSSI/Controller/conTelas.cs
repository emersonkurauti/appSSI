using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conTelas : csControllerBase
    {
        private coTelas _objCoTelas;
        public coTelas objCoTelas
        {
            get { return _objCoTelas; }
            set { _objCoTelas = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conTelas()
        {
            _objCoTelas = new coTelas();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoTelas.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectTela;
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
            if (!_objCoTelas.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirTela;
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

            if (!_objCoTelas.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarTela;
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

            if (!_objCoTelas.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirTela;
                return false;
            }
            return true;
        }
    }
}
