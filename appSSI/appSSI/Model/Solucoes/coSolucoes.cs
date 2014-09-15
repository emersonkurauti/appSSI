using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace appSSI
{
    public class coSolucoes : csModelBase
    {
        UTF8Encoding encoding = new UTF8Encoding();

        private caSolucoes objCaSolucoes;

        private DataTable _dtImgSolucoes;
        public DataTable dtImgSolucoes
        {
            get { return _dtImgSolucoes; }
            set { _dtImgSolucoes = value; }
        }

        private DataTable _dtSolucoesDefeitos;
        public DataTable dtSolucoesDefeitos
        {
            get { return _dtSolucoesDefeitos; }
            set { _dtSolucoesDefeitos = value; }
        }

        private int _cdSolucao;
        public int cdSolucao
        {
            get { return _cdSolucao; }
            set { _cdSolucao = value; }
        }

        private string _deSolucao = "";
        public string deSolucao
        {
            get { return _deSolucao; }
            set { _deSolucao = value; }
        }

        private char _flNivel = ' ';
        public char flNivel
        {
            get { return _flNivel; }
            set { _flNivel = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coSolucoes()
        {
            objCaSolucoes = new caSolucoes();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaSolucoes.nmCampoChave;
            objBanco.strTabela = objCaSolucoes.nmTabela;
            objBanco.bControlaConxao = false;
        }

        /// <summary>
        /// Método para inserir imagens
        /// </summary>
        /// <returns></returns>
        public bool InserirImagem(bool bAlterar)
        {
            caImagensSolucoes objCaImagensSolucoes = new caImagensSolucoes();
            conImagens objConImagens = new conImagens(csConstantes.cSolucao);

            objConImagens.objCoImagensSolucoes.cdSolucao = _cdSolucao;

            if (bAlterar)
                objConImagens.Excluir();

            string sCaminho = csConstantes.sCaminhoImgSolucoes;
            string sCaminhoImgAntes = "", sNomeAntes = "", sNomeFoto = "", sCaminhoImgDepois = "";

            for (int i = 0; i < _dtImgSolucoes.Rows.Count; i++)
            {
                sCaminhoImgAntes = _dtImgSolucoes.Rows[i][objCaImagensSolucoes.deCaminhoImagem].ToString();
                sNomeAntes = _dtImgSolucoes.Rows[i][objCaImagensSolucoes.blImagem].ToString();

                if (!sCaminhoImgAntes.Equals(sCaminho))
                {
                    sNomeFoto = string.Format("{0:d8}", _cdSolucao) + "-" + i + Path.GetExtension(sNomeAntes);
                    sCaminhoImgAntes += _dtImgSolucoes.Rows[i][objCaImagensSolucoes.blImagem].ToString();
                    sCaminhoImgDepois = sCaminho + "\\" + sNomeFoto;

                    if (File.Exists(sCaminhoImgDepois))
                        File.Delete(sCaminhoImgDepois);

                    File.Copy(sCaminhoImgAntes, sCaminhoImgDepois);
                }
                else
                    sNomeFoto = sNomeAntes;

                objConImagens.objCoImagensSolucoes.deCaminho = sCaminho;
                objConImagens.objCoImagensSolucoes.deImagem = _dtImgSolucoes.Rows[i][objCaImagensSolucoes.deImagem].ToString();
                objConImagens.objCoImagensSolucoes.blImagem = sNomeFoto;

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
            conSolucoesDefeitos objConSolucoesDefeitos = new conSolucoesDefeitos(csConstantes.cSolucao);

            objConSolucoesDefeitos.objCoSolucoesDefeitos.cdSolucao = _cdSolucao;

            if (bAlterar)
                objConSolucoesDefeitos.Excluir();

            for (int i = 0; i < _dtSolucoesDefeitos.Rows.Count; i++)
            {
                objConSolucoesDefeitos.objCoSolucoesDefeitos.cdDefeito = Convert.ToInt32(_dtSolucoesDefeitos.Rows[i][objCaSolucoesDefeitos.cdDefeito].ToString());
                objConSolucoesDefeitos.objCoSolucoesDefeitos.deObservacao = _dtSolucoesDefeitos.Rows[i][objCaSolucoesDefeitos.deObservacao].ToString();

                if (!objConSolucoesDefeitos.Inserir())
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Método de inserir sobrescrito para utilizar transação
        /// </summary>
        /// <returns></returns>
        public override bool Inserir()
        {
            try
            {
                AtualizaObj();
                objBanco.BeginTransaction();

                if (objBanco.Inserir())
                {
                    _cdSolucao = objBanco.cdChave;

                    if (!InserirImagem(false))
                    {
                        objBanco.RollbackTransaction();
                        return false;
                    }

                    if (!InserirSolucaoDefeito(false))
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
            conImagens objConImagens = new conImagens(csConstantes.cSolucao);
            caImagensSolucoes objCaImagensSolucoes = new caImagensSolucoes();

            try
            {
                objBanco.BeginTransaction();
                objConImagens.objCoImagensSolucoes.cdSolucao = _cdSolucao;
                
                if (objConImagens.Excluir())
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
            catch
            {
                objBanco.RollbackTransaction();
                return false;
            }
        }
    }
}
