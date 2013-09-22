using System;
using Persistence;
using Models;


namespace Persistence
{
    public interface IUnitOfWork
    {
        void Commit(bool shared);
        IRepositorioGenerico<tb_pessoa> RepositorioPessoa { get; }
        IRepositorioGenerico<tb_condominio> RepositorioCondominio { get; }
        IRepositorioGenerico<tb_bloco> RepositorioBloco { get; }
        IRepositorioGenerico<tb_areapublica> RepositorioAreaPublica { get; }
        IRepositorioGenerico<tb_moradia> RepositorioMoradia { get; }
        IRepositorioGenerico<tb_reservaambiente> RepositorioReservaAmbiente { get; }
        IRepositorioGenerico<tb_enquete> RepositorioEnquete { get; }        
        IRepositorioGenerico<tb_ocorrencia> RepositorioOcorrencia { get; }
        IRepositorioGenerico<tb_statusenquete> RepositorioStatusEnquete{ get; }
        IRepositorioGenerico<tb_statusareapublica> RepositorioStatusAreaPublica { get; }
        IRepositorioGenerico<tb_statuspagamento> RepositorioStatusPagamento { get; }
        IRepositorioGenerico<tb_statusocorrencia> RepositorioStatusOcorrencia { get; }
        IRepositorioGenerico<tb_tipoocorrencia> RepositorioTipoOcorrencia { get; }
        IRepositorioGenerico<tb_postagem> RepositorioPostagem { get; }
        IRepositorioGenerico<tb_veiculo> RepositorioVeiculo { get; }
        IRepositorioGenerico<tb_tipoveiculo> RepositorioTipoVeiculo { get; }
    }
}
