using System;
using Persistence;
using Models;


namespace Persistence
{
    public interface IUnitOfWork
    {
        void Commit(bool shared);
        IRepositorioGenerico<tb_acessocondominio> RepositorioAcessoCondominio { get; }
        IRepositorioGenerico<tb_acessoveiculo> RepositorioAcessoVeiculo { get; }
        IRepositorioGenerico<tb_administradora> RepositorioAdministradora { get; }
        IRepositorioGenerico<tb_areapublica> RepositorioAreaPublica { get; }
        IRepositorioGenerico<tb_atendimento> RepositorioAtendimento { get; }
        IRepositorioGenerico<tb_bloco> RepositorioBloco { get; }
        IRepositorioGenerico<tb_comentario> RepositorioComentario { get; }
        IRepositorioGenerico<tb_condominio> RepositorioCondominio { get; }
        IRepositorioGenerico<tb_enquete> RepositorioEnquete { get; }
        IRepositorioGenerico<tb_funcionario> RepositorioFuncionario { get; }
        IRepositorioGenerico<tb_grupoplanocontas> RepositorioGrupoPlanoContas { get; }
        IRepositorioGenerico<tb_moradia> RepositorioMoradia { get; }
        IRepositorioGenerico<tb_movimentacaofinanceira> RepositorioMovimentacaoFinanceira { get; }
        IRepositorioGenerico<tb_ocorrencia> RepositorioOcorrencia { get; }
        IRepositorioGenerico<tb_opcoesenquete> RepositorioOpcaoEnquete { get; }
        IRepositorioGenerico<tb_pessoa> RepositorioPessoa { get; }
        IRepositorioGenerico<tb_pessoamoradia> RepositorioPessoaMoradia { get; }
        IRepositorioGenerico<tb_planodeconta> RepositorioPlanoDeConta { get; }
        IRepositorioGenerico<tb_postagem> RepositorioPostagem { get; }
        IRepositorioGenerico<tb_publicacaomural> RepositorioPublicacaoMural { get; }
        IRepositorioGenerico<tb_reservaambiente> RepositorioReservaAmbiente { get; }
        IRepositorioGenerico<tb_restricaoacesso> RepositorioRestricaoAcesso { get; }
        IRepositorioGenerico<tb_setor> RepositorioSetor { get; }
        IRepositorioGenerico<tb_veiculo> RepositorioVeiculo { get; }
        IRepositorioGenerico<tb_votoenquete> RepositorioVotoEnquete { get; }
        
    }
}
