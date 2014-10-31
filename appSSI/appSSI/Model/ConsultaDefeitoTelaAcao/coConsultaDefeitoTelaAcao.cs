using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LibrarySimetric;

namespace appSSI
{
    public class coConsultaDefeitoTelaAcao : csModelBase
    {
        private caConsultaDefeitoTelaAcao objCaConsultaDefeitoTelaAcao;

        private int _cdUsuario;
        public int cdUsuario
        {
            get { return _cdUsuario; }
            set { _cdUsuario = value; }
        }

        private int _cdEmpresa;
        public int cdEmpresa
        {
            get { return _cdEmpresa; }
            set { _cdEmpresa = value; }
        }

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

        private int _cdDefeito;
        public int cdDefeito
        {
            get { return _cdDefeito; }
            set { _cdDefeito = value; }
        }

        private string _deDesricao = "";
        public string deDesricao
        {
            get { return _deDesricao; }
            set { _deDesricao = value; }
        }

        private char _flTpUsuario;
        public char flTpUsuario
        {
            get { return _flTpUsuario; }
            set { _flTpUsuario = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coConsultaDefeitoTelaAcao()
        {
            objCaConsultaDefeitoTelaAcao = new caConsultaDefeitoTelaAcao();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaConsultaDefeitoTelaAcao.nmCampoChave;
            objBanco.strTabela = objCaConsultaDefeitoTelaAcao.nmTabela;
        }

        /// <summary>
        /// Método para realizar o select dos defeitos
        /// </summary>
        /// <param name="dtDados"></param>
        /// <returns></returns>
        public override bool Select(out DataTable dtDados)
        {
            DataTable dtTemp = new DataTable();

            string strConsulta = "Select Distinct 0.0 as score, TD.cdDefeito, D.deDefeito " +
                                 "  From Telas_Defeitos TD " +
                                 " Inner join Defeitos D on D.cdDefeito = TD.cdDefeito ";

            if (_cdAcao != 0 && _cdTela != 0)
                strConsulta += " Where TD.cdAcao = " + _cdAcao.ToString() +
                               "   And TD.cdTela = " + _cdTela.ToString();

            try
            {
                dtTemp = objBanco.RetornaDT(strConsulta);

                dtTemp.Columns[objCaConsultaDefeitoTelaAcao.score].ReadOnly = false;

                for (int i = 0; i < dtTemp.Rows.Count; i++)
                    dtTemp.Rows[i][objCaConsultaDefeitoTelaAcao.score] = CalculaScore(_deDesricao.ToLower(), dtTemp.Rows[i][objCaConsultaDefeitoTelaAcao.deDefeito].ToString().ToLower());

                if (_deDesricao.Trim() != "")
                {
                    for (int i = 0; i < dtTemp.Rows.Count; i++)
                    {
                        if (Convert.ToDouble(dtTemp.Rows[i][objCaConsultaDefeitoTelaAcao.score].ToString()) < appSSI.Properties.Settings.Default.grauSimilaridade)
                        {
                            dtTemp.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }

                if (dtTemp.Rows.Count > 1)
                {
                    dtTemp.DefaultView.Sort = " score desc";
                    dtDados = dtTemp.DefaultView.ToTable();
                }
                else
                    dtDados = dtTemp;

                return true;
            }
            catch 
            {
                dtDados = null;
                return false;
            }
        }

        /// <summary>
        /// Carregar as solucoes do defeito para o website
        /// </summary>
        /// <param name="dtDados"></param>
        public bool SelectSolucaoDefeito(out DataTable dtDados)
        {
            string strConsulta = "Select S.cdSolucao, S.deSolucao, NVL(SL.qtd,0) as qtd " +
                                 "  From Solucoes_Defeitos SD " +
                                 " Inner join Solucoes S on S.cdSolucao = SD.cdSolucao " +
                                 "  Left join (Select count(1) as qtd, cdSolucao " +
                                 "               from Indicadores " +
                                 "              where flResultado = 'S'" +
                                 "              group by cdSolucao) SL on SL.cdSolucao = S.cdSolucao" +
                                 " Where SD.cdDefeito = " + _cdDefeito.ToString();

            if (_flTpUsuario == 'C')
                strConsulta += " and flNivel = " + "'" + _flTpUsuario + "'";

            strConsulta += " order by  NVL(SL.qtd,0) desc ";

            try
            {
               dtDados = objBanco.RetornaDT(strConsulta);
               return true;
            }
            catch
            {
                dtDados = null;
                return false;
            }
        }

        /// <summary>
        /// Calcula o Score da similaridade do defeito informado com o retornado
        /// </summary>
        /// <param name="strDefeitoDigitado"></param>
        /// <param name="strDefeitoGravado"></param>
        /// <returns></returns>
        public float CalculaScore(string strDefeitoDigitado, string strDefeitoGravado)
        {
            MongeElkan objMongeElkan = new MongeElkan();
            float score = 0.0f;

            try
            {
                score = objMongeElkan.getSimilarityMongeElkan(strDefeitoGravado, strDefeitoDigitado);
            }
            catch
            {
                score = 0.0f;
            }

            return score;
        }
    }
}
