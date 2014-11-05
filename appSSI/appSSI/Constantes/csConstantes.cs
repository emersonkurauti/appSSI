using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace appSSI
{
    public class csConstantes
    {
        //Tipos de Usuário
        public const char cCliente       = 'C';
        public const char cDesenvolvedor = 'D';
        public const char cSuporte       = 'S';
        public const char cGestor        = 'G';

        //Tipos de Imagens
        public const char cDefeito = 'D';
        public const char cSolucao = 'S';

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
