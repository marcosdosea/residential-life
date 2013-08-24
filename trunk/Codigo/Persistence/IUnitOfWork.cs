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
        IRepositorioGenerico<tb_ocorrencia> RepositorioRegistrarOcorrencia { get; }
    }
}
