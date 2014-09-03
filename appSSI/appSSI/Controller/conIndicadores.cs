using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conIndicadores : csControllerBase
    {
        private coIndicador _objCoIndicador;
        public coIndicador objCoIndicador
        {
            get { return _objCoIndicador; }
            set { _objCoIndicador = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conIndicadores()
        {
            _objCoIndicador = new coIndicador();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoIndicador.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectIndicador;
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
            if (!_objCoIndicador.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirIndicador;
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

            if (!_objCoIndicador.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarIndicador;
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

            if (!_objCoIndicador.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirIndicador;
                return false;
            }
            return true;
        }
    }
}
