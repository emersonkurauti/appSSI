using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class conConsultaDefeitoTelaAcao : csControllerBase
    {
        private coConsultaDefeitoTelaAcao _objCoConsultaDefeitoTelaAcao;
        public coConsultaDefeitoTelaAcao objCoConsultaDefeitoTelaAcao
        {
            get { return _objCoConsultaDefeitoTelaAcao; }
            set { _objCoConsultaDefeitoTelaAcao = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public conConsultaDefeitoTelaAcao()
        {
            _objCoConsultaDefeitoTelaAcao = new coConsultaDefeitoTelaAcao();
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objCoConsultaDefeitoTelaAcao.Select(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroConsultarDefeitos;
                return false;
            }
            return true;
        }

        public bool SelectSolucaoDefeito()
        {
            _strMensagemErro = "";

            if (!_objCoConsultaDefeitoTelaAcao.SelectSolucaoDefeito(out _dtDados))
            {
                _strMensagemErro = csMensagens.msgErroSelectSolucoesDefeitos;
                return false;
            }
            return true;
        }
    }
}
