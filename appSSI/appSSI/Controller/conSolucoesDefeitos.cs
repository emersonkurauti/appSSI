using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conSolucoesDefeitos: csControllerBase
    {
        private bool _flDefeito;
        public bool flDefeito
        {
            get { return _flDefeito; }
            set { _flDefeito = value; }
        }

        private coSolucoesDefeitos _objCoSolucoesDefeitos;
        public coSolucoesDefeitos objCoSolucoesDefeitos
        {
            get { return _objCoSolucoesDefeitos; }
            set { _objCoSolucoesDefeitos = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conSolucoesDefeitos(char TpImagem)
        {
            _objCoSolucoesDefeitos = new coSolucoesDefeitos();
            if (TpImagem == csConstantes.cDefeito)
                _flDefeito = true;
            else
                _flDefeito = false;
        }

        /// <summary>
        /// Define se a consulta vai ser realizada por soluções ou defeitos
        /// </summary>
        public void DefineCampoChave()
        {
            if (_flDefeito)
                objCoSolucoesDefeitos.objCaSolucoesDefeitos.nmCampoChave = "cdDefeito";
            else
                objCoSolucoesDefeitos.objCaSolucoesDefeitos.nmCampoChave = "cdSolucao";
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            DefineCampoChave();

            if (!_objCoSolucoesDefeitos.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectSolucoesDefeitos;
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
            DefineCampoChave();

            if (!_objCoSolucoesDefeitos.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirSolucoesDefeitos;
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

            DefineCampoChave();

            if (!_objCoSolucoesDefeitos.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarSolucoesDefeitos;
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

            DefineCampoChave();

            if (!_objCoSolucoesDefeitos.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirSolucoesDefeitos;
                return false;
            }
            return true;
        }
    }
}
