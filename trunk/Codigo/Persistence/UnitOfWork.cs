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
        private IRepositorioGenerico<tb_pessoa> _repPessoa;
        private IRepositorioGenerico<tb_condominio> _repCondominio;
        private IRepositorioGenerico<tb_bloco> _repBloco;
        private IRepositorioGenerico<tb_areapublica> _repAreaPublica;
        private IRepositorioGenerico<tb_reservaambiente> _repReservaAmbiente;
        private IRepositorioGenerico<tb_moradia> _repMoradia;
        private IRepositorioGenerico<tb_enquete> _repEnquete;
        private IRepositorioGenerico<tb_ocorrencia> _repOcorrencia;
        private IRepositorioGenerico<tb_statusenquete> _repStatusEnquete; 
        private IRepositorioGenerico<tb_statusareapublica> _repStatusAreaPublica;
        private IRepositorioGenerico<tb_statuspagamento> _repStatusPagamento;
        private IRepositorioGenerico<tb_statusocorrencia> _repStatusOcorrencia;
        private IRepositorioGenerico<tb_tipoocorrencia> _repTipoOcorrencia;
        private IRepositorioGenerico<tb_postagem> _repPostagem;
        private IRepositorioGenerico<tb_opcoesenquete> _repOpcaoEnquete;
        private IRepositorioGenerico<tb_votoenquete> _repVotoEnquete;
        private IRepositorioGenerico<tb_veiculo> _repVeiculo;
        private IRepositorioGenerico<tb_tipoveiculo> _repTipoVeiculo;
        private IRepositorioGenerico<tb_tipoplanodeconta> _repTipoPlanoDeConta;
        private IRepositorioGenerico<tb_statusmovimentacaofinanceira> _repStatusMovimentacaoFinanceira;
        private IRepositorioGenerico<tb_planodeconta> _repPlanoDeConta;
        private IRepositorioGenerico<tb_tipomoradia> _repTipoMoradia;
        private IRepositorioGenerico<tb_movimentacaofinanceira> _repMovimentacaoFinanceira;
        private IRepositorioGenerico<tb_administradora> _repAdministradora;

        /// <summary>
        /// Construtor cria contexto transacional
        /// </summary>
        public UnitOfWork()
        {
            _context = new Models.residentialbdEntities();
        }
        
        #region IUnitOfWork Members


        /// <summary>
        /// Repositório para manipular dados persistidos de status de enquetes
        /// </summary>
        public IRepositorioGenerico<tb_statusenquete> RepositorioStatusEnquete
        {
            get
            {
                if (_repStatusEnquete == null)
                {
                    _repStatusEnquete = new RepositorioGenerico<tb_statusenquete>(_context);
                }
                return _repStatusEnquete;
            }
        }

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
        /// Repositório para manipular dados persistidos de tipo de moradia
        /// </summary>
        public IRepositorioGenerico<tb_tipomoradia> RepositorioTipoMoradia
        {
            get
            {
                if (_repTipoMoradia == null)
                {
                    _repTipoMoradia = new RepositorioGenerico<tb_tipomoradia>(_context);
                }
                return _repTipoMoradia;
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
        /// Repositório para manipular dados persistidos de status áreas públicas
        /// </summary>
        public IRepositorioGenerico<tb_statusareapublica> RepositorioStatusAreaPublica
        {
            get
            {
                if (_repStatusAreaPublica == null)
                {
                    _repStatusAreaPublica = new RepositorioGenerico<tb_statusareapublica>(_context);
                }
                return _repStatusAreaPublica;
            }
        }

        /// <summary>
        /// Repositório para manipular dados persistidos de status pagamento
        /// </summary>
        public IRepositorioGenerico<tb_statuspagamento> RepositorioStatusPagamento
        {
            get
            {
                if (_repStatusPagamento == null)
                {
                    _repStatusPagamento = new RepositorioGenerico<tb_statuspagamento>(_context);
                }
                return _repStatusPagamento;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de tipo ocorrencia
        /// </summary>
        public IRepositorioGenerico<tb_tipoocorrencia> RepositorioTipoOcorrencia
        {
            get
            {
                if (_repTipoOcorrencia == null)
                {
                    _repTipoOcorrencia = new RepositorioGenerico<tb_tipoocorrencia>(_context);
                }
                return _repTipoOcorrencia;
            }
        }

        /// <summary>
        /// Repositório para manipular dados persistidos de status ocorrencia
        /// </summary>
        public IRepositorioGenerico<tb_statusocorrencia> RepositorioStatusOcorrencia
        {
            get
            {
                if (_repStatusOcorrencia == null)
                {
                    _repStatusOcorrencia = new RepositorioGenerico<tb_statusocorrencia>(_context);
                }
                return _repStatusOcorrencia;
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
        /// Repositório para manipular dados persistidos de tipo de veículo
        /// </summary>
        public IRepositorioGenerico<tb_tipoveiculo> RepositorioTipoVeiculo
        {
            get
            {
                if (_repTipoVeiculo == null)
                {
                    _repTipoVeiculo = new RepositorioGenerico<tb_tipoveiculo>(_context);
                }
                return _repTipoVeiculo;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de tipo de plano de conta
        /// </summary>
        public IRepositorioGenerico<tb_tipoplanodeconta> RepositorioTipoPlanoDeConta
        {
            get
            {
                if (_repTipoPlanoDeConta == null)
                {
                    _repTipoPlanoDeConta = new RepositorioGenerico<tb_tipoplanodeconta>(_context);
                }
                return _repTipoPlanoDeConta;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de plano de conta
        /// </summary>
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


        /// <summary>
        /// Repositório para manipular dados persistidos de status de movimentação financeira
        /// </summary>
        public IRepositorioGenerico<tb_statusmovimentacaofinanceira> RepositorioStatusMovimentacaoFinanceira
        {
            get
            {
                if (_repStatusMovimentacaoFinanceira == null)
                {
                    _repStatusMovimentacaoFinanceira = new RepositorioGenerico<tb_statusmovimentacaofinanceira>(_context);
                }
                return _repStatusMovimentacaoFinanceira;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos  de movimentação financeira
        /// </summary>
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


        /// <summary>
        /// Repositório para manipular dados persistidos de status de administradora
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
