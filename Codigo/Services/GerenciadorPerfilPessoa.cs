using Models;
using Persistence;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class GerenciadorPerfilPessoa
    {
        /*
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPerfilPessoa()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorPerfilPessoa(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /*
        public void InserirPerfilPessoa(PerfilPessoaModel perfilPessoa)
        {
            tb_pessoa _tb_pessoa = unitOfWork.RepositorioPessoa.ObterEntidade(p => p.IdPessoa == perfilPessoa.IdPessoa);
            my_aspnet_roles _perfil = unitOfWork.RepositorioPerfil.ObterEntidade(p => p.id == perfilPessoa.IdPerfil);
            _tb_pessoa.my_aspnet_roles.Add(_perfil);
            unitOfWork.Commit(shared);
        }

        
        public void RemoverPerfilPessoa(PerfilPessoaModel perfilPessoa)
        {
            tb_pessoa _tb_pessoa = unitOfWork.RepositorioPessoa.ObterEntidade(p => p.IdPessoa == perfilPessoa.IdPessoa);
            my_aspnet_roles _perfil = unitOfWork.RepositorioPerfil.ObterEntidade(p => p.id == perfilPessoa.IdPerfil);
            _tb_pessoa.my_aspnet_roles.Remove(_perfil);
            unitOfWork.Commit(shared);
        }

        
        public IEnumerable<my_aspnet_roles> ObterPerfisPorPessoa(int idPessoa)
        {
            tb_pessoa _tb_pessoa = unitOfWork.RepositorioPessoa.ObterEntidade(p => p.IdPessoa.Equals(idPessoa));
            var query = from perfil in _tb_pessoa.my_aspnet_roles
                        select new my_aspnet_roles
                        {
                            id = perfil.id,
                            name = perfil.name
                        };
            return query;
        }

        public IEnumerable<tb_pessoa> ObterPessoasPorPerfil(int idPerfil)
        {
            my_aspnet_roles _tb_perfil = unitOfWork.RepositorioPerfil.ObterEntidade(p => p.id.Equals(idPerfil));
            var query = from pessoa in _tb_perfil.tb_pessoa
                        select new tb_pessoa
                        {
                            IdPessoa = pessoa.IdPessoa,
                            CPF = pessoa.CPF,
                            Nome = pessoa.Nome,
                            RG = pessoa.RG
                        };
            return query;
        } */
    }
}
