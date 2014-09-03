using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appRelatorios
{
    public class conTipoParametro: csControllerBase
    {
        private coTipoParametro _objCoTipoParametro;
        public coTipoParametro objCoTipoParametro
        {
            get { return _objCoTipoParametro; }
            set { _objCoTipoParametro = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conTipoParametro()
        {
            _objCoTipoParametro = new coTipoParametro();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoTipoParametro.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectTipoParam;
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
            if (!_objCoTipoParametro.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirTipoParam;
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

            if (!_objCoTipoParametro.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarTipoParam;
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

            if (!_objCoTipoParametro.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirTipoParam;
                return false;
            }
            return true;
        }
    }
}
