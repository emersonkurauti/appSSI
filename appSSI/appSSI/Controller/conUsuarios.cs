using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace appSSI
{
    public class conUsuarios : csControllerBase
    {
        private coUsuarios _objCoUsuarios;

        public coUsuarios objCoUsuarios
        {
            get { return _objCoUsuarios; }
            set { _objCoUsuarios = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conUsuarios()
        {
            _objCoUsuarios = new coUsuarios();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoUsuarios.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectUsuario;
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
            _strMensagemErro = "";

            if (!_objCoUsuarios.Inserir())
            {
                _strMensagemErro = csMensagens.msgErroInserirUsuario;
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

            if (!_objCoUsuarios.Alterar())
            {
                _strMensagemErro = csMensagens.msgErroAlterarUsuario;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ecluir
        /// </summary>
        /// <returns></returns>
        public bool Excluir()
        {
            _strMensagemErro = "";

            if (!_objCoUsuarios.Excluir())
            {
                _strMensagemErro = csMensagens.msgErroExcluirUsuario;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida credenciais
        /// </summary>
        public void ValidarUsuario()
        {
            _strMensagemErro = "";
            caUsuarios objCaUsuarios = new caUsuarios();

            if (_objCoUsuarios.deLogin != "")
            {
                if (_objCoUsuarios.deSenha != "")
                {
                    if (!Select())
                        return;

                    if (_dtDados.Rows.Count == 0)
                        _strMensagemErro = csMensagens.msgUsuarioSenhaInvalido;
                    else
                    {
                        if (_dtDados.Rows[0][objCaUsuarios.flAtivo].ToString() == "N")
                            _strMensagemErro = csMensagens.msgUsuarioInativo;

                        _objCoUsuarios.flAtivo = _dtDados.Rows[0][objCaUsuarios.flAtivo].ToString()[0];
                        _objCoUsuarios.flTpUsuario = _dtDados.Rows[0][objCaUsuarios.flTpUsuario].ToString()[0];
                    }
                }
                else
                    _strMensagemErro = csMensagens.msgInformarSenha;
            }
            else
                _strMensagemErro = csMensagens.msgInformarUsuario;
        }

        /// <summary>
        /// Retorna o objeto de usuário para informações no Menu
        /// </summary>
        /// <param name="dtUsuario"></param>
        /// <returns></returns>
        public coUsuarios RetornaObjUsuario(DataTable dtUsuario)
        {
            return _objCoUsuarios.RetornaObjUsuario(dtUsuario);
        }
    }
}
