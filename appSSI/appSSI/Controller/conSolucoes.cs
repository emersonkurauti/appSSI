using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conSolucoes : csControllerBase
    {
        private coSolucoes _objCoSolucoes;
        public coSolucoes objCoSolucoes
        {
            get { return _objCoSolucoes; }
            set { _objCoSolucoes = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conSolucoes()
        {
            _objCoSolucoes = new coSolucoes();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoSolucoes.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectSolucoes;
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
            if (!_objCoSolucoes.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirSolucoes;
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

            if (!_objCoSolucoes.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarSolucoes;
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

            if (!_objCoSolucoes.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirSolucoes;
                return false;
            }
            return true;
        }
    }
}
