using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class coSlucoesConsultasTempoCadastrado : csModelBase
    {
        private int _cdSistema;

        public int cdSistema
        {
            get { return _cdSistema; }
            set { _cdSistema = value; }
        }
        private int _cdModulo;

        public int cdModulo
        {
            get { return _cdModulo; }
            set { _cdModulo = value; }
        }
        private int _cdTela;

        public int cdTela
        {
            get { return _cdTela; }
            set { _cdTela = value; }
        }
        private int _cdAcao;

        public int cdAcao
        {
            get { return _cdAcao; }
            set { _cdAcao = value; }
        }
        private string _nmSistema;

        public string nmSistema
        {
            get { return _nmSistema; }
            set { _nmSistema = value; }
        }
        private string _nmModulo;

        public string nmModulo
        {
            get { return _nmModulo; }
            set { _nmModulo = value; }
        }
        private string _nmTela;

        public string nmTela
        {
            get { return _nmTela; }
            set { _nmTela = value; }
        }
        private string _deAcao;

        public string deAcao
        {
            get { return _deAcao; }
            set { _deAcao = value; }
        }
        private string _deSolucao;

        public string deSolucao
        {
            get { return _deSolucao; }
            set { _deSolucao = value; }
        }
        private char _flNivel;

        public char flNivel
        {
            get { return _flNivel; }
            set { _flNivel = value; }
        }
        private int _qtd;

        public int qtd
        {
            get { return _qtd; }
            set { _qtd = value; }
        }
        private string _pcdSistema;

        public string pcdSistema
        {
            get { return _pcdSistema; }
            set { _pcdSistema = value; }
        }
        private string _pcdModulo;

        public string pcdModulo
        {
            get { return _pcdModulo; }
            set { _pcdModulo = value; }
        }
        private string _pcdTela;

        public string pcdTela
        {
            get { return _pcdTela; }
            set { _pcdTela = value; }
        }
        private string _pcdAcao;

        public string pcdAcao
        {
            get { return _pcdAcao; }
            set { _pcdAcao = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coSlucoesConsultasTempoCadastrado()
        {
            AtualizaObj();
            LimparAtributos();
        }
    }
}
