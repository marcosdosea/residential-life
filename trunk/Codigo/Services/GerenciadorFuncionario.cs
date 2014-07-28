using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorFuncionario
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorFuncionario()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorFuncionario(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="funcionarioModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(FuncionarioModel funcionarioModel)
        {
            tb_funcionario funcionarioE = new tb_funcionario();
            Atribuir(funcionarioModel, funcionarioE);
            unitOfWork.RepositorioFuncionario.Inserir(funcionarioE);
            unitOfWork.Commit(shared);
            return funcionarioE.IdFuncionario;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="funcionarioModel"></param>
        public void Editar(FuncionarioModel funcionarioModel)
        {
            tb_funcionario funcionarioE = new tb_funcionario();
            Atribuir(funcionarioModel, funcionarioE);
            unitOfWork.RepositorioFuncionario.Editar(funcionarioE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idFuncionario"> </param>
        public void Remover(int idFuncionario)
        {
            unitOfWork.RepositorioFuncionario.Remover(funcionario => funcionario.IdFuncionario == idFuncionario);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados da entidade como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<FuncionarioModel> GetQuery()
        {
            IQueryable<tb_funcionario> tb_funcionario = unitOfWork.RepositorioFuncionario.GetQueryable();
            var query = from funcionario in tb_funcionario
                        select new FuncionarioModel
                        {
                            IdFuncionario = funcionario.IdFuncionario,
                            IdPessoa = funcionario.IdPessoa,
                            IdSetor = funcionario.IdSetor,
                            Ocupacao = funcionario.Ocupacao,
                            Frequencia = funcionario.Frequencia,
                            HorarioPermitido = funcionario.HorarioPermitido,
                            Pontuacao = funcionario.Pontuacao,

                            NomePessoa = funcionario.tb_pessoa.Nome,
                            NomeSetor = funcionario.tb_setor.Nome

                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FuncionarioModel> ObterTodos()
        {
            return GetQuery();
        }


        /// <summary>
        /// Obtém um funcionario
        /// </summary>
        /// <param name="idFuncionario">Identificador da entidade na base de dados</param>
        /// <returns>FuncionarioModel</returns>
        public FuncionarioModel Obter(int idFuncionario)
        {
            IEnumerable<FuncionarioModel> funcionarioE = GetQuery().Where(f => f.IdFuncionario == idFuncionario);
            return funcionarioE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados da Entidade Model para a Entidade Entity
        /// </summary>
        /// <param name="funcionarioModel">Objeto do modelo</param>
        /// <param name="funcionarioE">Entity mapeada da base de dados</param>
        private void Atribuir(FuncionarioModel funcionarioModel, tb_funcionario funcionarioE)
        {
            funcionarioE.IdFuncionario = funcionarioModel.IdFuncionario;
            funcionarioE.IdPessoa = funcionarioModel.IdPessoa;
            funcionarioE.IdSetor = funcionarioModel.IdSetor;
            funcionarioE.Frequencia = funcionarioModel.Frequencia;
            funcionarioE.HorarioPermitido = funcionarioModel.HorarioPermitido;
            funcionarioE.Pontuacao = funcionarioModel.Pontuacao;
            funcionarioE.Ocupacao = funcionarioModel.Ocupacao;
        }
    }
}
