using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorVeiculo
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorVeiculo()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorVeiculo(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo veiculo na base de dados
        /// </summary>
        /// <param name="statusOcorrenciaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(VeiculoModel veiculoModel)
        {
            tb_veiculo veiculoModelE = new tb_veiculo();
            Atribuir(veiculoModel, veiculoModelE);
            unitOfWork.RepositorioVeiculo.Inserir(veiculoModelE);
            unitOfWork.Commit(shared);
            return veiculoModelE.IdVeiculo;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="enqueteModel">Dados do modelo</param>
        public void Editar(VeiculoModel veiculoModel)
        {
            tb_veiculo veiculoModelE = new tb_veiculo();
            Atribuir(veiculoModel, veiculoModelE);
            unitOfWork.RepositorioVeiculo.Editar(veiculoModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="statusVeiculoModel">Identificador do veiculo na base de dados</param>
        public void Remover(int idVeiculo)
        {
            unitOfWork.RepositorioVeiculo.Remover(Veiculo => Veiculo.IdVeiculo.Equals(idVeiculo));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<VeiculoModel> GetQuery()
        {
            IQueryable<tb_veiculo> tb_veiculo = unitOfWork.RepositorioVeiculo.GetQueryable();
            var query = from Veiculo in tb_veiculo
                        select new VeiculoModel
                        {
                            IdVeiculo = Veiculo.IdVeiculo,
                            Placa = Veiculo.Placa,
                            Modelo = Veiculo.Modelo,
                            Cor = Veiculo.Cor,
                            Tipo = Veiculo.tb_tipoveiculo.TipoVeiculo
                           
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VeiculoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um veiculo
        /// </summary>
        /// <param name="idStatusOcorrencia">Identificador do veiculo na base de dados</param>
        /// <returns>Veiculo model</returns>
        public VeiculoModel Obter(int idVeiculo)
        {
            IEnumerable<VeiculoModel> veiculoEs = GetQuery().Where(Veiculo => Veiculo.IdVeiculo.Equals(idVeiculo));
            return veiculoEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status Veiculo Model para o Veiculo Entity
        /// </summary>
        /// <param name="statusVeiculoModel">Objeto do modelo</param>
        /// <param name="statusVeiculoE">Entity mapeada da base de dados</param>
        private void Atribuir(VeiculoModel veiculoModel, tb_veiculo veiculoE)
        {
            veiculoE.IdVeiculo = veiculoModel.IdVeiculo;
            veiculoE.Placa = veiculoModel.Placa;
            veiculoE.Modelo = veiculoModel.Modelo;
            veiculoE.Cor = veiculoModel.Cor;
            veiculoE.IdTipoVeiculo = veiculoModel.IdTipoVeiculo;
        }
    }
}
