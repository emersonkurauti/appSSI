using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace appSSI
{
    public class caEmpresas
    {
        public string nmTabela
        {
            get { return "EMPRESAS"; }
        }

        public string nmCampoChave
        {
            get { return "cdEmpresa"; }
        }

        public string cdEmpresa
        {
            get { return "cdEmpresa"; }
        }

        public string nmEmpresa
        {
            get { return "nmEmpresa"; }
        }

        public string nmFantasiaEmpresa
        {
            get { return "nmFantasiaEmpresa"; }
        }

        public string nuCNPJ
        {
            get { return "nuCNPJ"; }
        }

        public string deLogradouro
        {
            get { return "deLogradouro"; }
        }

        public string nuNumero
        {
            get { return "nuNumero"; }
        }

        public string deBairro
        {
            get { return "deBairro"; }
        }

        public string deComplemento
        {
            get { return "deComplemento"; }
        }

        public string nuCEP
        {
            get { return "nuCEP"; }
        }

        public string nuTelefone
        {
            get { return "nuTelefone"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdEmpresa + "," +
                nmEmpresa + "," +
                nmFantasiaEmpresa + "," +
                nuCNPJ + "," +
                deLogradouro + "," +
                nuNumero + "," +
                deBairro + "," +
                deComplemento + "," +
                nuCEP + "," +
                nuTelefone;

            strNome = "Código, Nome, Nome Fantasia, CNPJ, Logradouro, Nº, Bairro, Complemento, CEP, Telefone";

            strVisivel = "0,1,1,1,0,0,0,0,1,1";
        }
    }
}
