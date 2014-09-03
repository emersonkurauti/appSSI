using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conTelasAcoes : csControllerBase
    {
        private coTelasAcoes _objCoTelasAcoes;

        public coTelasAcoes objCoTelasAcoes
        {
            get { return _objCoTelasAcoes; }
            set { _objCoTelasAcoes = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conTelasAcoes()
        {
            _objCoTelasAcoes = new coTelasAcoes();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoTelasAcoes.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectTelasAcoes;
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
            if (!_objCoTelasAcoes.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirTelasAcoes;
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
            //if (!_objCoSistemasEmpresas.Alterar())
            //{
            //    _strMensagemErro = csMensagens.msgErroAlterarTelasAcoes;
            //    return false;
            //}
            return true;
        }

        /// <summary>
        /// Excluir
        /// </summary>
        /// <returns></returns>
        public bool Excluir()
        {
            _strMensagemErro = "";

            if (!_objCoTelasAcoes.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirTelasAcoes;
                return false;
            }
            return true;
        }
    }
}
