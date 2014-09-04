using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appRelatorios
{
    public class conRelatorio: csControllerBase
    {
        private coRelatorios _objCoRelatorios;
        public coRelatorios objCoRelatorios
        {
            get { return _objCoRelatorios; }
            set { _objCoRelatorios = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conRelatorio()
        {
            _objCoRelatorios = new coRelatorios();
        }

        /// <summary>
        /// Gerar o relatório
        /// </summary>
        /// <returns></returns>
        public bool GerarRelatorio()
        {
            _strMensagemErro = "";

            if (!_objCoRelatorios.GerarRelatorio(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroGerarRelatorio;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoRelatorios.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectRelatorio;
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
            if (!_objCoRelatorios.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirRelatorio;
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

            if (!_objCoRelatorios.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarRelatorio;
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

            if (!_objCoRelatorios.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirRelatorio;
                return false;
            }
            return true;
        }
    }
}
