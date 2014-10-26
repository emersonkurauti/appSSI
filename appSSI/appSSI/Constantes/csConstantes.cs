using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace appSSI
{
    public static class csConstantes
    {
        //Grau mínimo de similaridade
        public const double dblGrauSimilaridade = 0.55f;

        //Imagem Nulla
        public const string imgNull = "~/Imagens/null.png";

        //e-mail para notificações
        public const string emailDestinatario   = "emerson.m.k@hotmail.com";
        public const string emailRemetente      = "emerson.m.k@hotmail.com";
        public const string senhaEmailRemetente = "asd9376552023049";

        //String conexão Task
        public const string strStringConexaoTASK = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.199.200)(PORT=1521))) (CONNECT_DATA=(SERVICE_NAME=orcl))); User Id=taskdesenv; Password=taskdesenv";

        //String conexão SSI
        //public const string strStringConexao = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))) (CONNECT_DATA=(SERVICE_NAME=xe))); User Id=SSI; Password=admin";
        public const string strStringConexao = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS = (PROTOCOL = TCP)(HOST = 187.0.119.243)(PORT = 1521))) (CONNECT_DATA=(SERVER = DEDICATED)(SID = ORCL))); User Id=ssi; Password=admin";

        //Tipos de Imagens
        public const char cDefeito = 'D';
        public const char cSolucao = 'S';

        //Caminho servidor
        //public const string sCaminhoServidor = "C:\\appSSI\\appSSI\\wappSSI";
        public const string sCaminhoServidor = "C:\\inetpub\\wwwroot";

        //Caminho Imagems Defeito Servidor
        public const string sCaminhoImgDefeitoSvr = "../Imagens/Defeitos/";

        //Caminho Imagens Solução Servidor
        public const string sCaminhoImgSolucoesSvr = "../Imagens/Solucoes/";

        //Caminho Imagens
        public const string sCaminhoImgDefeito = sCaminhoServidor + "\\Imagens\\Defeitos\\";
        public const string sCaminhoImgSolucoes = sCaminhoServidor + "\\Imagens\\Solucoes\\";

        //Status cadastro
        public const char sInserindo = 'I';
        public const char sAlterando = 'A';
        public const char sExcluindo = 'E';

        //Condições
        public const int nIgual = 1;
        public const int nDiferente = 2;
        public const int nMaior = 3;
        public const int nMenor = 4;
        public const int nMaiorIgual = 5;
        public const int nMenorIgual = 6;
        public const int nBetween = 7;
        public const int nContem = 8;
        public const int nDentre = 9;
        public const int nExceto = 10;
    }
}
