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
