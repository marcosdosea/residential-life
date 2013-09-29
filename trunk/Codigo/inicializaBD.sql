INSERT INTO `tb_statusenquete` (`IdStatusEnquete`, `StatusEnquete`) VALUES
(1, 'Ativa'),
(2, 'Congelada'),
(3, 'Finalizada');

insert into tb_statusareapublica(IdStatusAreaPublica,StatusAreaPublica)values
(1,'Disponível'),
(2,'Indisponível');

insert into tb_statuspagamento(IdStatusPagamento, StatusPagamento)
values
(1,"Pago"),
(2,"Não Pago");


insert into tb_statusocorrencia(IdStatusOcorrencia,StatusOcorrencia)
values(1,'Em análise'),
(2,'Resolvida');

insert into tb_tipoocorrencia(IdTipoOcorrencia,TipoOcorrencia)
values(1,'Barulho'),
(2,'Vizinho'),
(3,'Sujeira');

insert into tb_tipoveiculo(IdTipoVeiculo,TipoVeiculo)
values(1,'Moto'),
(2,'Carro'),
(3,'Caminhão');

