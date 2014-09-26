using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class coConsSolNaoSol : csModelBase
    {
        private string _DescDefeitoPesq;

        public string descDefeitoPesq
        {
            get { return _DescDefeitoPesq; }
            set { _DescDefeitoPesq = value; }
        }
        private int _cdSistema;

        public int cdSistema
        {
            get { return _cdSistema; }
            set { _cdSistema = value; }
        }
        private string _nmSistema;

        public string nmSistema
        {
            get { return _nmSistema; }
            set { _nmSistema = value; }
        }
        private int _cdModulo;

        public int cdModulo
        {
            get { return _cdModulo; }
            set { _cdModulo = value; }
        }
        private string _nmModulo;

        public string nmModulo
        {
            get { return _nmModulo; }
            set { _nmModulo = value; }
        }
        private int _cdTela;

        public int cdTela
        {
            get { return _cdTela; }
            set { _cdTela = value; }
        }
        private string _nmTela;

        public string nmTela
        {
            get { return _nmTela; }
            set { _nmTela = value; }
        }
        private int _cdAcao;

        public int cdAcao
        {
            get { return _cdAcao; }
            set { _cdAcao = value; }
        }
        private string _deAcao;

        public string deAcao
        {
            get { return _deAcao; }
            set { _deAcao = value; }
        }
        private int _cdEmpresa;

        public int cdEmpresa
        {
            get { return _cdEmpresa; }
            set { _cdEmpresa = value; }
        }
        private string _nmEmpresa;

        public string nmEmpresa
        {
            get { return _nmEmpresa; }
            set { _nmEmpresa = value; }
        }
        private char _flResultado;

        public char flResultado
        {
            get { return _flResultado; }
            set { _flResultado = value; }
        }
        private string _deSolucao;

        public string deSolucao
        {
            get { return _deSolucao; }
            set { _deSolucao = value; }
        }
        private DateTime _dtConsulta;

        public DateTime dtConsulta
        {
            get { return _dtConsulta; }
            set { _dtConsulta = value; }
        }
        private int _pcdSistema;

        public int pcdSistema
        {
            get { return _pcdSistema; }
            set { _pcdSistema = value; }
        }
        private int _pcdModulo;

        public int pcdModulo
        {
            get { return _pcdModulo; }
            set { _pcdModulo = value; }
        }
        private int _pcdTela;

        public int pcdTela
        {
            get { return _pcdTela; }
            set { _pcdTela = value; }
        }
        private int _pcdAcao;

        public int pcdAcao
        {
            get { return _pcdAcao; }
            set { _pcdAcao = value; }
        }
        private int _pcdEmpresa;

        public int pcdEmpresa
        {
            get { return _pcdEmpresa; }
            set { _pcdEmpresa = value; }
        }
        private DateTime _pdtIni;

        public DateTime pdtIni
        {
            get { return _pdtIni; }
            set { _pdtIni = value; }
        }
        private DateTime _pdtFim;

        public DateTime pdtFim
        {
            get { return _pdtFim; }
            set { _pdtFim = value; }
        }
    }
}
