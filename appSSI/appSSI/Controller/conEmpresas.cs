using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appSSI
{
    public class conEmpresas : csControllerBase
    {
        private coEmpresas _objCoEmpresas;
        public coEmpresas objCoEmpresas
        {
            get { return _objCoEmpresas; }
            set { _objCoEmpresas = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conEmpresas()
        {
            _objCoEmpresas = new coEmpresas();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoEmpresas.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectEmpresa;
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
            if (!_objCoEmpresas.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirEmpresa;
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

            if (!_objCoEmpresas.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarEmpresa;
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

            if (!_objCoEmpresas.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirEmpresa;
                return false;
            }
            return true;
        }
    }
}
