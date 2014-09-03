using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conSistemasEmpresas: csControllerBase
    {
        private coSistemasEmpresas _objCoSistemasEmpresas;

        public coSistemasEmpresas objCoSistemasEmpresas
        {
            get { return _objCoSistemasEmpresas; }
            set { _objCoSistemasEmpresas = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conSistemasEmpresas()
        {
            _objCoSistemasEmpresas = new coSistemasEmpresas();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoSistemasEmpresas.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectSistemasEmpresas;
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
            if (!_objCoSistemasEmpresas.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirSistemasEmpresas;
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
            //    _strMensagemErro = csMensagens.msgErroAlterarSistemasEmpresas;
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

            if (!_objCoSistemasEmpresas.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirSistemasEmpresas;
                return false;
            }
            return true;
        }
    }
}
