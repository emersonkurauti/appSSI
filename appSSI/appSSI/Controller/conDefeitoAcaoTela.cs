using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conDefeitoAcaoTela : csControllerBase
    {
        private coDefeitoAcaoTela _objCoDefeitoAcaoTela;
        public coDefeitoAcaoTela objCoDefeitoAcaoTela
        {
            get { return _objCoDefeitoAcaoTela; }
            set { _objCoDefeitoAcaoTela = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conDefeitoAcaoTela()
        {
            _objCoDefeitoAcaoTela = new coDefeitoAcaoTela();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoDefeitoAcaoTela.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectDefeitoAcaoTela;
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
            if (!_objCoDefeitoAcaoTela.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirDefeitoAcaoTela;
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
            if (!_objCoDefeitoAcaoTela.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarDefeitoAcaoTela;
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

            if (!_objCoDefeitoAcaoTela.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirDefeitoAcaoTela;
                return false;
            }
            return true;
        }
    }
}
