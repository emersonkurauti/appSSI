using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conImagens : csControllerBase
    {
        private coImagens _objCoImagens;
        public coImagens objCoImagens
        {
            get { return _objCoImagens; }
            set { _objCoImagens = value; }
        }

        private coImagensDefeitos _objCoImagensDefeitos;
        public coImagensDefeitos objCoImagensDefeitos
        {
            get { return _objCoImagensDefeitos; }
            set { _objCoImagensDefeitos = value; }
        }

        private coImagensSolucoes _objCoImagensSolucoes;
        public coImagensSolucoes objCoImagensSolucoes
        {
            get { return _objCoImagensSolucoes; }
            set { _objCoImagensSolucoes = value; }
        }

        private char _TpImagem;
        public char tpImagem
        {
            get { return _TpImagem; }
            set { _TpImagem = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conImagens(char TpImg)
        {
            _objCoImagensSolucoes = new coImagensSolucoes();
            _objCoImagensDefeitos = new coImagensDefeitos();
            _TpImagem = TpImg;
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            caImagens objcaImagens = new caImagens();
            _strMensagemErro = "";

            if (_TpImagem.Equals(csConstantes.cDefeito))
            {
                if (!_objCoImagensDefeitos.Select(out _dtDados))
                {
                    _strMensagemErro = csMensagens.msgErroSelectImagens;
                    return false;
                }
            }
            else
                if (!_objCoImagensSolucoes.Select(out _dtDados))
                {
                    _strMensagemErro = csMensagens.msgErroSelectImagens;
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
            if (_TpImagem.Equals(csConstantes.cDefeito))
            {
                if (!_objCoImagensDefeitos.Inserir())
                {
                    _strMensagemErro = csMensagens.msgErroSelectImagens;
                    return false;
                }
            }
            else
                if (!_objCoImagensSolucoes.Inserir())
                {
                    _strMensagemErro = csMensagens.msgErroInserirImagens;
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

            if (_TpImagem.Equals(csConstantes.cDefeito))
            {
                if (!_objCoImagensDefeitos.Alterar())
                {
                    _strMensagemErro = csMensagens.msgErroSelectImagens;
                    return false;
                }
            }
            else
                if (!_objCoImagensSolucoes.Alterar())
                {
                    _strMensagemErro = csMensagens.msgErroAlterarImagens;
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

            if (_TpImagem.Equals(csConstantes.cDefeito))
            {
                if (!_objCoImagensDefeitos.Excluir())
                {
                    _strMensagemErro = csMensagens.msgErroSelectImagens;
                    return false;
                }
            }
            else
                if (!_objCoImagensSolucoes.Excluir())
                {
                    _strMensagemErro = csMensagens.msgErroExcluirImagens;
                    return false;
                }
            return true;
        }
    }
}
