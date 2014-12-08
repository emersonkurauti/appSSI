using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Reflection;

namespace appSSI
{
    public class coDefeitos : csModelBase
    {
        UTF8Encoding encoding = new UTF8Encoding();

        private caDefeitos objCaDefeitos;

        private DataTable _dtImgDefeitos;
        public DataTable dtImgDefeitos
        {
            get { return _dtImgDefeitos; }
            set { _dtImgDefeitos = value; }
        }

        private DataTable _dtSolucoesDefeitos;
        public DataTable dtSolucoesDefeitos
        {
            get { return _dtSolucoesDefeitos; }
            set { _dtSolucoesDefeitos = value; }
        }

        private DataTable _dtDefeitosAcoesTelas;
        public DataTable dtDefeitosAcoesTelas
        {
            get { return _dtDefeitosAcoesTelas; }
            set { _dtDefeitosAcoesTelas = value; }
        }

        private int _cdDefeito;
        public int cdDefeito
        {
            get { return _cdDefeito; }
            set { _cdDefeito = value; }
        }

        private string _deDefeito = "";
        public string deDefeito
        {
            get { return _deDefeito; }
            set { _deDefeito = value; }
        }

        private char _flEstagio = ' ';
        public char flEstagio
        {
            get { return _flEstagio; }
            set { _flEstagio = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coDefeitos()
        {
            objCaDefeitos = new caDefeitos();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaDefeitos.nmCampoChave;
            objBanco.strTabela = objCaDefeitos.nmTabela;
            objBanco.bControlaConxao = false;
        }

        /// <summary>
        /// Método para inserir imagens
        /// </summary>
        /// <returns></returns>
        public bool InserirImagem(bool bAlterar, string sCaminho = "")
        {
            caImagensDefeitos objCaImagensDefeitos = new caImagensDefeitos();
            conImagens objConImagens = new conImagens(csConstantes.cDefeito);

            objConImagens.objCoImagensDefeitos.cdDefeito = _cdDefeito;

            if (bAlterar)
                objConImagens.Excluir();

            if (sCaminho == "")
                sCaminho = appSSI.Properties.Settings.Default.sCaminhoDefeitos;

            string sCaminhoImgAntes = "", sNomeAntes = "", sNomeFoto = "", sCaminhoImgDepois = "";

            for (int i = 0; i < _dtImgDefeitos.Rows.Count; i++)
            {
                sCaminhoImgAntes = _dtImgDefeitos.Rows[i][objCaImagensDefeitos.deCaminhoImagem].ToString();
                sNomeAntes = _dtImgDefeitos.Rows[i][objCaImagensDefeitos.blImagem].ToString();

                if (!sCaminhoImgAntes.Equals(sCaminho))
                {
                    sNomeFoto = string.Format("{0:d8}", _cdDefeito) + "-" + i + Path.GetExtension(sNomeAntes);
                    sCaminhoImgAntes += _dtImgDefeitos.Rows[i][objCaImagensDefeitos.blImagem].ToString();
                    sCaminhoImgDepois = sCaminho + "\\" + sNomeFoto;

                    if (File.Exists(sCaminhoImgDepois))
                        File.Delete(sCaminhoImgDepois);

                    File.Copy(sCaminhoImgAntes, sCaminhoImgDepois);
                }
                else
                    sNomeFoto = sNomeAntes;

                objConImagens.objCoImagensDefeitos.deCaminho = sCaminho;
                objConImagens.objCoImagensDefeitos.deImagem = _dtImgDefeitos.Rows[i][objCaImagensDefeitos.deImagem].ToString();
                objConImagens.objCoImagensDefeitos.blImagem = sNomeFoto;

                if (!objConImagens.Inserir())
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Método para inserir soluções do defeito
        /// </summary>
        /// <param name="bAlterar"></param>
        /// <returns></returns>
        public bool InserirSolucaoDefeito(bool bAlterar)
        {
            caSolucoesDefeitos objCaSolucoesDefeitos = new caSolucoesDefeitos();
            conSolucoesDefeitos objConSolucoesDefeitos = new conSolucoesDefeitos(csConstantes.cDefeito);

            objConSolucoesDefeitos.objCoSolucoesDefeitos.cdDefeito = _cdDefeito;

            if (bAlterar)
                objConSolucoesDefeitos.Excluir();

            for (int i = 0; i < _dtSolucoesDefeitos.Rows.Count; i++)
            {
                objConSolucoesDefeitos.objCoSolucoesDefeitos.cdSolucao = Convert.ToInt32(_dtSolucoesDefeitos.Rows[i][objCaSolucoesDefeitos.cdSolucao].ToString());
                objConSolucoesDefeitos.objCoSolucoesDefeitos.deObservacao = _dtSolucoesDefeitos.Rows[i][objCaSolucoesDefeitos.deObservacao].ToString();

                if (!objConSolucoesDefeitos.Inserir())
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Método para insrir as ações das telas que provocam o defeito
        /// </summary>
        /// <param name="bAlterar"></param>
        /// <returns></returns>
        public bool InserirDefeitoAcoesTelas(bool bAlterar)
        {
            caDefeitoAcaoTela objCaDefeitoAcaoTela = new caDefeitoAcaoTela();
            conDefeitoAcaoTela objConDefeitoAcaoTela = new conDefeitoAcaoTela();

            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdDefeito = _cdDefeito;

            if (bAlterar)
                objConDefeitoAcaoTela.Excluir();

            for (int i = 0; i < _dtDefeitosAcoesTelas.Rows.Count; i++)
            {
                objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdTela = Convert.ToInt32(_dtDefeitosAcoesTelas.Rows[i][objCaDefeitoAcaoTela.cdTela].ToString());
                objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdAcao = Convert.ToInt32(_dtDefeitosAcoesTelas.Rows[i][objCaDefeitoAcaoTela.cdAcao].ToString());

                if (!objConDefeitoAcaoTela.Inserir())
                    return false;
            }

            return true;
        }
        
        /// <summary>
        /// Método de inserir sobrescrito para utilizar transação
        /// </summary>
        /// <returns></returns>
        public override bool Inserir(string sCaminho = "")
        {
            try
            {
                AtualizaObj();
                objBanco.BeginTransaction();

                if (objBanco.Inserir())
                {
                    _cdDefeito = objBanco.cdChave;

                    if (!InserirImagem(false, sCaminho))
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }

                    if (!InserirSolucaoDefeito(false))
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }

                    if(!InserirDefeitoAcoesTelas(false))
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }

                    objBanco.CommitTransaction();
                    return true;
                }
                else
                {
                    objBanco.RollbackTransaction();
                    return false;
                }
            }
            catch
            {
                objBanco.RollbackTransaction();
                return false;
            }
        }

        /// <summary>
        /// Método de alterar sobrescrito para utilizar transação
        /// </summary>
        /// <returns></returns>
        public override bool Alterar()
        {
            conImagens objConImagens = new conImagens(csConstantes.cDefeito);
            caImagensDefeitos objCaImagensDefeitos = new caImagensDefeitos();

            try
            {
                AtualizaObj();
                objBanco.BeginTransaction();

                if (objBanco.Alterar())
                {
                    if (!InserirImagem(true))
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }

                    if (!InserirSolucaoDefeito(true))
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }

                    if(!InserirDefeitoAcoesTelas(true))
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }

                    objBanco.CommitTransaction();
                    return true;
                }
                else
                {
                    objBanco.RollbackTransaction();
                    return false;
                }
            }
            catch
            {
                objBanco.RollbackTransaction();
                return false;
            }
        }

        /// <summary>
        /// Método de excluir sobrescrito para utilizar transação
        /// </summary>
        /// <returns></returns>
        public override bool Excluir()
        {
            conImagens objConImagens = new conImagens(csConstantes.cDefeito);
            caImagensDefeitos objCaImagensDefeitos = new caImagensDefeitos();

            conSolucoesDefeitos objConSolucoesDefeitos = new conSolucoesDefeitos(csConstantes.cDefeito);
            caSolucoesDefeitos objCaSolucoesDefeitos = new caSolucoesDefeitos();

            conDefeitoAcaoTela objConDefeitoAcaoTela = new conDefeitoAcaoTela();
            caDefeitoAcaoTela objCaDefeitoAcaoTela = new caDefeitoAcaoTela();

            try
            {
                objBanco.BeginTransaction();
                objConImagens.objCoImagensDefeitos.cdDefeito = _cdDefeito;
                objConSolucoesDefeitos.objCoSolucoesDefeitos.cdDefeito = _cdDefeito;
                objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdDefeito = _cdDefeito;
                
                if (objConImagens.Excluir())
                {
                    if (objConSolucoesDefeitos.Excluir())
                    {
                        if (objConDefeitoAcaoTela.Excluir())
                        {
                            AtualizaObj();
                            if (!objBanco.Excluir())
                            {
                                objBanco.RollbackTransaction();
                                return false;
                            }

                            objBanco.CommitTransaction();
                            return true;
                        }
                        else
                        {
                            objBanco.RollbackTransaction();
                            return false;
                        }
                    }
                    else
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }
                }
                else
                {
                    objBanco.RollbackTransaction();
                    return false;
                }
            }
            catch
            {
                objBanco.RollbackTransaction();
                return false;
            }
        }
    }
}
