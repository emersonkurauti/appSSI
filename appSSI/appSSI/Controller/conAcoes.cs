using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conAcoes : csControllerBase
    {
        private coAcoes _objCoAcoes;
        public coAcoes objCoAcoes
        {
            get { return _objCoAcoes; }
            set { _objCoAcoes = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conAcoes()
        {
            _objCoAcoes = new coAcoes();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoAcoes.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectAcoes;
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
            if (!_objCoAcoes.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirAcoes;
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

            if (!_objCoAcoes.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarAcoes;
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

            if (!_objCoAcoes.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirAcoes;
                return false;
            }
            return true;
        }
    }
}
