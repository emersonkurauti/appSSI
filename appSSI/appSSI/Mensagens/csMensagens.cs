using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSSI
{
    static class csMensagens
    {
        //CadUsuario
        public const string msgPreencherCredenciais = "Verifique os dados de login.";
        
        //Consultas
        public const string msgSelecionarRegistro = "Selecione um registro.";
        public const string msgErroConsultar = "Valor não encontrado.";
        public const string msgErroValorInvalido = "Valor inválido.";

        //Empresas
        public const string msgErroSelectEmpresa = "Erro ao consultar empresa.";
        public const string msgErroInserirEmpresa = "Erro ao inserir empresa.";
        public const string msgErroAlterarEmpresa = "Erro ao alterar empresa.";
        public const string msgErroExcluirEmpresa = "Não será possível realizar a operação.";

        //Sistemas
        public const string msgErroSelectSistema = "Erro ao consultar sistema.";
        public const string msgErroInserirSistema = "Erro ao inserir sistema.";
        public const string msgErroAlterarSistema = "Erro ao alterar sistema.";
        public const string msgErroExcluirSistema = "Não será possível realizar a operação.";

        //Sistemas Empresas
        public const string msgErroSelectSistemasEmpresas = "Erro ao consultar os sistemas da empresa.";
        public const string msgErroInserirSistemasEmpresas = "Erro ao inserir os sistemas da empresa.";
        public const string msgErroAlterarSistemasEmpresas = "Erro ao alterar os sistemas da empresa.";
        public const string msgErroExcluirSistemasEmpresas = "Não será possível realizar a operação.";
        public const string msgSistemaEmpresaJahAssociado = "Sistema já associado à empresa!";
        public const string msgSistemaEmpresaSelecioneParaRemover = "Selecine o sistema para remover!";

        //Modulos
        public const string msgErroSelectModulo = "Erro ao consultar modulo.";
        public const string msgErroInserirModulo = "Erro ao inserir modulo.";
        public const string msgErroAlterarModulo = "Erro ao alterar modulo.";
        public const string msgErroExcluirModulo = "Não será possível realizar a operação.";

        //Telas
        public const string msgErroSelectTela = "Erro ao consultar tela.";
        public const string msgErroInserirTela = "Erro ao inserir tela.";
        public const string msgErroAlterarTela = "Erro ao alterar tela.";
        public const string msgErroExcluirTela = "Não será possível realizar a operação.";

        //Telas Ações
        public const string msgErroSelectTelasAcoes = "Erro ao consultar as ações da tela.";
        public const string msgErroInserirTelasAcoes = "Erro ao inserir as ações da tela.";
        public const string msgErroAlterarTelasAcoes = "Erro ao alterar as ações da tela.";
        public const string msgErroExcluirTelasAcoes = "Não será possível realizar a operação.";
        public const string msgTelaAcaoJahAssociado = "Ação já associado à tela!";
        public const string msgTelaAcaoSelecioneParaRemover = "Selecine uma ação para remover!";

        //Ações
        public const string msgErroSelectAcoes = "Erro ao consultar ações.";
        public const string msgErroInserirAcoes = "Erro ao inserir ações.";
        public const string msgErroAlterarAcoes = "Erro ao alterar ações.";
        public const string msgErroExcluirAcoes = "Não será possível realizar a operação.";

        //Defeitos das ações das telas
        public const string msgErroSelectDefeitoAcaoTela = "Erro ao consultar defeitos das ações das telas.";
        public const string msgErroInserirDefeitoAcaoTela = "Erro ao inserir defeito da ação da tela.";
        public const string msgErroAlterarDefeitoAcaoTela = "Erro ao alterar defeito da ação da tela.";
        public const string msgErroExcluirDefeitoAcaoTela = "Não será possível realizar a operação.";
        public const string msgDefeitoJahReferenciadoAcaoTela = "Tela/Ação já referêciada para o defeito.";
        public const string msgSelecioneAcaoTela = "Selecione a tela e a ação que gera o defeito para inserir!";

        //Defeitos
        public const string msgErroSelectDefeitos = "Erro ao consultar defeitos.";
        public const string msgErroInserirDefeitos = "Erro ao inserir defeitos.";
        public const string msgErroAlterarDefeitos = "Erro ao alterar defeitos.";
        public const string msgErroExcluirDefeitos = "Não será possível realizar a operação.";
        public const string msgSelecioneDefeito = "Selecione um defeito para inserir!";

        //Soluções
        public const string msgErroSelectSolucoes = "Erro ao consultar soluções.";
        public const string msgErroInserirSolucoes = "Erro ao inserir soluções.";
        public const string msgErroAlterarSolucoes = "Erro ao alterar soluções.";
        public const string msgErroExcluirSolucoes = "Não será possível realizar a operação.";
        public const string msgSelecioneSolucao = "Selecione uma solução para inserir!";

        //Soluções Defeitos
        public const string msgErroSelectSolucoesDefeitos = "Erro ao consultar soluções do defeito.";
        public const string msgErroInserirSolucoesDefeitos = "Erro ao inserir soluções do defeito.";
        public const string msgErroAlterarSolucoesDefeitos = "Erro ao alterar soluções do defeito.";
        public const string msgErroExcluirSolucoesDefeitos = "Não será possível realizar a operação.";
        public const string msgSolucaoJahExisteParaDefeito = "Solução já referênciada ao defeito!";
        public const string msgDefeitoJahExisteParaSolucao = "Defeito já referênciado à solução!";
        public const string msgSelecioneDefeitoParaRemover = "Selecione um defeito para remover!";
        public const string msgSelecioneSolucaoParaRemover = "Selecione uma solução para remover!";

        //Imagens
        public const string msgErroSelectImagens = "Erro ao consultar imagens.";
        public const string msgErroInserirImagens = "Erro ao inserir imagens.";
        public const string msgErroAlterarImagens = "Erro ao alterar imagens.";
        public const string msgErroExcluirImagens = "Não será possível realizar a operação.";

        //Usuários
        public const string msgErroSelectUsuario = "Erro ao consultar usuário.";
        public const string msgErroInserirUsuario = "Erro ao inserir usuário.";
        public const string msgErroAlterarUsuario = "Erro ao alterar usuário.";
        public const string msgErroExcluirUsuario = "Não será possível realizar a operação.";
        public const string msgUsuarioSenhaInvalido = "Usuário/Senha inválido!!!";
        public const string msgUsuarioInativo = "Usuário inativo!";
        public const string msgInformarSenha = "Informe a senha!";
        public const string msgInformarUsuario = "Informe o usuário!";
        public const string msgUsuarioSemPermissao = "Tipo de usuário não possui permissão.";

        //Consultas
        public const string msgErroConsultarDefeitos = "Erro ao consultar o defeito para a tela/ação informado.";

        //Indicadores
        public const string msgErroSelectIndicador = "Erro ao consultar indicador.";
        public const string msgErroInserirIndicador = "Erro ao inserir indicador.";
        public const string msgErroAlterarIndicador = "Erro ao alterar indicador.";
        public const string msgErroExcluirIndicador = "Não será possível realizar a operação.";

        //Parâmetros
        public const string msgErroSelectParametro= "Erro ao consultar parâmetro.";
        public const string msgErroInserirParametro = "Erro ao inserir parâmetro.";
        public const string msgErroAlterarParametro = "Erro ao alterar parâmetro.";
        public const string msgErroExcluirParametro = "Não será possível realizar a operação.";

        //Integração TASK
        public const string msgErroSelectIntegracaoTask = "Erro ao consultar registros no Task.";
        public const string msgErroInserirIntegracaoTask = "Erro ao inserir registros no Task.";
        public const string msgErroAlterarIntegracaoTask = "Erro ao alterar registros no Task.";
        public const string msgErroExcluirIntegracaoTask = "Não será possível realizar a operação.";

        //Area TASK
        public const string msgErroSelectAreaTask = "Erro ao consultar área do Task.";
    }
}
