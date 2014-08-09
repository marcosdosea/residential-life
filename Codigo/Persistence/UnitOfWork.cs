using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Persistence
{
    /// <summary>
    /// UnitWork é um padrão de projeto que permite trabalhar 
    /// com vários repositórios compartilhando um mesmo contexto
    /// transacional
    /// </summary>
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private residentialbdEntities _context;
        
        private IRepositorioGenerico<tb_acessocondominio> _repAcessoCondominio;
        private IRepositorioGenerico<tb_acessoveiculo> _repAcessoVeiculo;
        private IRepositorioGenerico<tb_administradora> _repAdministradora;
        private IRepositorioGenerico<tb_areapublica> _repAreaPublica;
        private IRepositorioGenerico<tb_atendimento> _repAtendimento;
        private IRepositorioGenerico<tb_bloco> _repBloco;
        private IRepositorioGenerico<tb_comentario> _repComentario;
        private IRepositorioGenerico<tb_condominio> _repCondominio;
        private IRepositorioGenerico<tb_enquete> _repEnquete;
        private IRepositorioGenerico<tb_grupoplanocontas> _repGrupoPlanoContas;
        private IRepositorioGenerico<tb_moradia> _repMoradia;
        private IRepositorioGenerico<tb_movimentacaofinanceira> _repMovimentacaoFinanceira;
        private IRepositorioGenerico<tb_ocorrencia> _repOcorrencia;
        private IRepositorioGenerico<tb_opcoesenquete> _repOpcaoEnquete;
        private IRepositorioGenerico<tb_pessoa> _repPessoa;
        private IRepositorioGenerico<tb_pessoamoradia> _repPessoaMoradia;
        private IRepositorioGenerico<tb_planodeconta> _repPlanoDeConta;
        private IRepositorioGenerico<tb_postagem> _repPostagem;
        private IRepositorioGenerico<tb_reservaambiente> _repReservaAmbiente;
        private IRepositorioGenerico<tb_restricaoacesso> _repRestricaoAcesso;
        private IRepositorioGenerico<tb_setor> _repSetor;
        private IRepositorioGenerico<tb_veiculo> _repVeiculo;
        private IRepositorioGenerico<tb_votoenquete> _repVotoEnquete;
        private IRepositorioGenerico<tb_pontuacao> _repPontuacao;
        private IRepositorioGenerico<tb_pontuacaopessoa> _repPontuacaoPessoa;
        private IRepositorioGenerico<my_aspnet_roles> _repPerfil;

        /// <summary>
        /// Construtor cria contexto transacional
        /// </summary>
        public UnitOfWork()
        {
            _context = new Models.residentialbdEntities();
        }
        
        #region IUnitOfWork Members

        public IRepositorioGenerico<tb_opcoesenquete> RepositorioOpcaoEnquete
        {
            get
            {
                if (_repOpcaoEnquete == null)
                {
                    _repOpcaoEnquete = new RepositorioGenerico<tb_opcoesenquete>(_context);
                }
                return _repOpcaoEnquete;
            }
        }

        public IRepositorioGenerico<tb_acessocondominio> RepositorioAcessoCondominio
        {
            get
            {
                if (_repAcessoCondominio == null)
                {
                    _repAcessoCondominio = new RepositorioGenerico<tb_acessocondominio>(_context);
                }
                return _repAcessoCondominio;
            }
        }

        public IRepositorioGenerico<tb_acessoveiculo> RepositorioAcessoVeiculo
        {
            get
            {
                if (_repAcessoVeiculo == null)
                {
                    _repAcessoVeiculo = new RepositorioGenerico<tb_acessoveiculo>(_context);
                }
                return _repAcessoVeiculo;
            }
        }

        public IRepositorioGenerico<tb_atendimento> RepositorioAtendimento
        {
            get
            {
                if (_repAtendimento == null)
                {
                    _repAtendimento = new RepositorioGenerico<tb_atendimento>(_context);
                }
                return _repAtendimento;
            }
        }

        public IRepositorioGenerico<tb_comentario> RepositorioComentario
        {
            get
            {
                if (_repComentario == null)
                {
                    _repComentario = new RepositorioGenerico<tb_comentario>(_context);
                }
                return _repComentario;
            }
        }

        public IRepositorioGenerico<tb_grupoplanocontas> RepositorioGrupoPlanoContas
        {
            get
            {
                if (_repGrupoPlanoContas == null)
                {
                    _repGrupoPlanoContas = new RepositorioGenerico<tb_grupoplanocontas>(_context);
                }
                return _repGrupoPlanoContas;
            }
        }

        public IRepositorioGenerico<tb_movimentacaofinanceira> RepositorioMovimentacaoFinanceira
        {
            get
            {
                if (_repMovimentacaoFinanceira == null)
                {
                    _repMovimentacaoFinanceira = new RepositorioGenerico<tb_movimentacaofinanceira>(_context);
                }
                return _repMovimentacaoFinanceira;
            }
        }

        public IRepositorioGenerico<tb_pessoamoradia> RepositorioPessoaMoradia
        {
            get
            {
                if (_repPessoaMoradia == null)
                {
                    _repPessoaMoradia = new RepositorioGenerico<tb_pessoamoradia>(_context);
                }
                return _repPessoaMoradia;
            }
        }

        public IRepositorioGenerico<tb_planodeconta> RepositorioPlanoDeConta
        {
            get
            {
                if (_repPlanoDeConta == null)
                {
                    _repPlanoDeConta = new RepositorioGenerico<tb_planodeconta>(_context);
                }
                return _repPlanoDeConta;
            }
        }

        public IRepositorioGenerico<tb_restricaoacesso> RepositorioRestricaoAcesso
        {
            get
            {
                if (_repRestricaoAcesso == null)
                {
                    _repRestricaoAcesso = new RepositorioGenerico<tb_restricaoacesso>(_context);
                }
                return _repRestricaoAcesso;
            }
        }

        public IRepositorioGenerico<tb_setor> RepositorioSetor
        {
            get
            {
                if (_repSetor == null)
                {
                    _repSetor = new RepositorioGenerico<tb_setor>(_context);
                }
                return _repSetor;
            }
        }

        public IRepositorioGenerico<tb_votoenquete> RepositorioVotoEnquete
        {
            get
            {
                if (_repVotoEnquete == null)
                {
                    _repVotoEnquete = new RepositorioGenerico<tb_votoenquete>(_context);
                }
                return _repVotoEnquete;
            }
        }




        /// <summary>
        /// Repositório para manipular dados persistidos de enquetes
        /// </summary>
        public IRepositorioGenerico<tb_enquete> RepositorioEnquete
        {
            get
            {
                if (_repEnquete == null)
                {
                    _repEnquete = new RepositorioGenerico<tb_enquete>(_context);
                }
                return _repEnquete;
            }
        }

        
        /// <summary>
        /// Repositório para manipular dados persistidos de pessoas
        /// </summary>
        public IRepositorioGenerico<tb_pessoa> RepositorioPessoa 
        { 
            get
            {
                if (_repPessoa == null) 
                {
                    _repPessoa = new RepositorioGenerico<tb_pessoa>(_context);
                }
                return _repPessoa;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de condomínios
        /// </summary>
        public IRepositorioGenerico<tb_condominio> RepositorioCondominio
        {
            get
            {
                if (_repCondominio == null)
                {
                    _repCondominio = new RepositorioGenerico<tb_condominio>(_context);
                }
                return _repCondominio;
            }
        }



        /// <summary>
        /// Repositório para manipular dados persistidos de blocos
        /// </summary>
        public IRepositorioGenerico<tb_bloco> RepositorioBloco
        {
            get
            {
                if (_repBloco == null)
                {
                    _repBloco = new RepositorioGenerico<tb_bloco>(_context);
                }
                return _repBloco;
            }
        }

        /// <summary>
        /// Repositório para manipular dados persistidos de áreas públicas
        /// </summary>
        public IRepositorioGenerico<tb_areapublica> RepositorioAreaPublica
        {
            get
            {
                if (_repAreaPublica == null)
                {
                    _repAreaPublica = new RepositorioGenerico<tb_areapublica>(_context);
                }
                return _repAreaPublica;
            }
        }

        /// <summary>
        /// Repositório para manipular dados persistidos de pessoas
        /// </summary>
        public IRepositorioGenerico<tb_moradia> RepositorioMoradia
        {
            get
            {
                if (_repMoradia == null)
                {
                    _repMoradia = new RepositorioGenerico<tb_moradia>(_context);
                }
                return _repMoradia;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de reservas de ambiente
        /// </summary>
        public IRepositorioGenerico<tb_reservaambiente> RepositorioReservaAmbiente
        {
            get
            {
                if (_repReservaAmbiente == null)
                {
                    _repReservaAmbiente = new RepositorioGenerico<tb_reservaambiente>(_context);
                }
                return _repReservaAmbiente;
            }
        }

        /// <summary>
        /// Repositório para manipular dados persistidos de ocorrencia
        /// </summary>
        public IRepositorioGenerico<tb_ocorrencia> RepositorioOcorrencia
        {
            get
            {
                if (_repOcorrencia == null)
                {
                    _repOcorrencia = new RepositorioGenerico<tb_ocorrencia>(_context);
                }
                return _repOcorrencia;
            }
        }

        
        /// <summary>
        /// Repositório para manipular dados persistidos de postagem
        /// </summary>
        public IRepositorioGenerico<tb_postagem> RepositorioPostagem
        {
            get
            {
                if (_repPostagem == null)
                {
                    _repPostagem = new RepositorioGenerico<tb_postagem>(_context);
                }
                return _repPostagem;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de veículo
        /// </summary>
        public IRepositorioGenerico<tb_veiculo> RepositorioVeiculo
        {
            get
            {
                if (_repVeiculo == null)
                {
                    _repVeiculo = new RepositorioGenerico<tb_veiculo>(_context);
                }
                return _repVeiculo;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de administradora
        /// </summary>
        public IRepositorioGenerico<tb_administradora> RepositorioAdministradora
        {
            get
            {
                if (_repAdministradora == null)
                {
                    _repAdministradora = new RepositorioGenerico<tb_administradora>(_context);
                }
                return _repAdministradora;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de veículo
        /// </summary>
        public IRepositorioGenerico<tb_pontuacao> RepositorioPontuacao
        {
            get
            {
                if (_repPontuacao == null)
                {
                    _repPontuacao = new RepositorioGenerico<tb_pontuacao>(_context);
                }
                return _repPontuacao;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de administradora
        /// </summary>
        public IRepositorioGenerico<tb_pontuacaopessoa> RepositorioPontuacaoPessoa
        {
            get
            {
                if (_repPontuacaoPessoa == null)
                {
                    _repPontuacaoPessoa = new RepositorioGenerico<tb_pontuacaopessoa>(_context);
                }
                return _repPontuacaoPessoa;
            }
        }

        /// <summary>
        /// Repositório para manipular dados persistidos de perfil
        /// </summary>
        public IRepositorioGenerico<my_aspnet_roles> RepositorioPerfil
        {
            get
            {
                if (_repPerfil == null)
                {
                    _repPerfil = new RepositorioGenerico<my_aspnet_roles>(_context);
                }
                return _repPerfil;
            }
        }

        /// <summary>
        /// Salva todas as mudanças realizadas no contexto
        /// quando o contexto não for compartilhado
        /// </summary>
        public void Commit(bool shared)
        {
            if (!shared)
                _context.SaveChanges();
        }

        #endregion

        private bool disposed = false;
        /// <summary>
        /// Retira da memória um determinado contexto
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Limpa contexto da memória
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
