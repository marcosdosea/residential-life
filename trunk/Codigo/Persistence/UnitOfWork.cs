using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Persistence;

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

        /// <summary>
        /// Construtor cria contexto transacional
        /// </summary>
        public UnitOfWork()
        {
            _context = new Models.residentialbdEntities();
        }
        
        #region IUnitOfWork Members

        
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
        /// Repositório para manipular dados persistidos de pessoas
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
        /// Repositório para manipular dados persistidos de pessoas
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
        /// Repositório para manipular dados persistidos de pessoas
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
