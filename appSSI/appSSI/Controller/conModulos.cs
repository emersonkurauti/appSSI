using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conModulos : csControllerBase
    {
        private coModulos _objCoModulos;
        public coModulos objCoModulos
        {
            get { return _objCoModulos; }
            set { _objCoModulos = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conModulos()
        {
            _objCoModulos = new coModulos();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoModulos.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectModulo;
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
            if (!_objCoModulos.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirModulo;
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

            if (!_objCoModulos.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarModulo;
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

            if (!_objCoModulos.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirModulo;
                return false;
            }
            return true;
        }
    }
}
