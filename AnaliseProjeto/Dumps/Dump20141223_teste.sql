CREATE DATABASE  IF NOT EXISTS `residentialbd` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `residentialbd`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: residentialbd
-- ------------------------------------------------------
-- Server version	5.5.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `my_aspnet_applications`
--

DROP TABLE IF EXISTS `my_aspnet_applications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_applications` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(256) DEFAULT NULL,
  `description` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_applications`
--

LOCK TABLES `my_aspnet_applications` WRITE;
/*!40000 ALTER TABLE `my_aspnet_applications` DISABLE KEYS */;
INSERT INTO `my_aspnet_applications` VALUES (1,'/','MySQLSession');
/*!40000 ALTER TABLE `my_aspnet_applications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_membership`
--

DROP TABLE IF EXISTS `my_aspnet_membership`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_membership` (
  `userId` int(11) NOT NULL DEFAULT '0',
  `Email` varchar(128) DEFAULT NULL,
  `Comment` varchar(255) DEFAULT NULL,
  `Password` varchar(128) NOT NULL,
  `PasswordKey` char(32) DEFAULT NULL,
  `PasswordFormat` tinyint(4) DEFAULT NULL,
  `PasswordQuestion` varchar(255) DEFAULT NULL,
  `PasswordAnswer` varchar(255) DEFAULT NULL,
  `IsApproved` tinyint(1) DEFAULT NULL,
  `LastActivityDate` datetime DEFAULT NULL,
  `LastLoginDate` datetime DEFAULT NULL,
  `LastPasswordChangedDate` datetime DEFAULT NULL,
  `CreationDate` datetime DEFAULT NULL,
  `IsLockedOut` tinyint(1) DEFAULT NULL,
  `LastLockedOutDate` datetime DEFAULT NULL,
  `FailedPasswordAttemptCount` int(10) unsigned DEFAULT NULL,
  `FailedPasswordAttemptWindowStart` datetime DEFAULT NULL,
  `FailedPasswordAnswerAttemptCount` int(10) unsigned DEFAULT NULL,
  `FailedPasswordAnswerAttemptWindowStart` datetime DEFAULT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='2';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_membership`
--

LOCK TABLES `my_aspnet_membership` WRITE;
/*!40000 ALTER TABLE `my_aspnet_membership` DISABLE KEYS */;
INSERT INTO `my_aspnet_membership` VALUES (5,'admin@admin.com','','residential','6I/7eYszRWohRxet0c4jOw==',0,'teste1','teste2',1,'2014-12-08 16:24:17','2014-12-08 16:24:17','2014-08-03 10:18:35','2014-08-03 10:18:35',0,'2014-08-03 10:18:35',1,'2014-11-10 15:13:21',0,'2014-08-03 10:18:35'),(14,'joao@teste.com','','1234567@','B51kc+mfTvuiKqErH60f8Q==',0,'teste1','teste2',1,'2014-11-10 12:25:29','2014-11-10 12:25:29','2014-08-21 08:09:49','2014-08-21 08:09:49',0,'2014-08-21 08:09:49',0,'2014-08-21 08:09:49',0,'2014-08-21 08:09:49'),(15,'mario@teste.com','','1234567@','qonsTBU/6xiHkqE8HoSMkg==',0,'teste1','teste2',1,'2014-12-12 07:57:16','2014-12-12 07:57:16','2014-08-21 08:12:23','2014-08-21 08:12:23',0,'2014-08-21 08:12:23',0,'2014-08-21 08:12:23',0,'2014-08-21 08:12:23'),(16,'sofia@teste.com','','1234567@','On85YGw9Je20Gzty1mpnnw==',0,'teste1','teste2',1,'2014-12-09 11:08:50','2014-12-09 11:08:11','2014-08-21 08:13:09','2014-08-21 08:13:09',0,'2014-08-21 08:13:09',0,'2014-08-21 08:13:09',0,'2014-08-21 08:13:09'),(17,'ro@teste.com','','1234567@','jPJyHhQK0TR7wZ5EazCgRQ==',0,'teste1','teste2',1,'2014-11-10 12:25:56','2014-11-10 12:25:55','2014-08-21 08:13:52','2014-08-21 08:13:52',0,'2014-08-21 08:13:52',0,'2014-08-21 08:13:52',0,'2014-08-21 08:13:52'),(18,'jorge@t.com','','1234567@','od8EqAgHx6AN4r4bMv5idA==',0,'teste1','teste2',1,'2014-08-21 09:46:31','2014-08-21 09:46:31','2014-08-21 08:15:06','2014-08-21 08:15:06',0,'2014-08-21 08:15:06',0,'2014-08-21 08:15:06',0,'2014-08-21 08:15:06'),(19,'p@t.com','','1234567@','gc0G1KzzdGIx0Nmu8MZKrA==',0,'teste1','teste2',1,'2014-11-10 12:26:30','2014-11-10 12:26:20','2014-08-21 08:16:33','2014-08-21 08:16:33',0,'2014-08-21 08:16:33',0,'2014-08-21 08:16:33',0,'2014-08-21 08:16:33'),(20,'p@t.com','','1234567@','3DV8yAdPfbF85WaPRW7gLA==',0,'teste1','teste2',1,'2014-08-21 10:06:21','2014-08-21 10:06:21','2014-08-21 08:18:18','2014-08-21 08:18:18',0,'2014-08-21 08:18:18',0,'2014-08-21 08:18:18',0,'2014-08-21 08:18:18'),(21,'mario@teste.com','','1234567@','1+jncLglm3MqSWwtqltoTQ==',0,'teste1','teste2',1,'2014-08-21 08:20:56','2014-08-21 08:20:56','2014-08-21 08:20:56','2014-08-21 08:20:56',0,'2014-08-21 08:20:56',0,'2014-08-21 08:20:56',0,'2014-08-21 08:20:56');
/*!40000 ALTER TABLE `my_aspnet_membership` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_profiles`
--

DROP TABLE IF EXISTS `my_aspnet_profiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_profiles` (
  `userId` int(11) NOT NULL,
  `valueindex` longtext,
  `stringdata` longtext,
  `binarydata` longblob,
  `lastUpdatedDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_profiles`
--

LOCK TABLES `my_aspnet_profiles` WRITE;
/*!40000 ALTER TABLE `my_aspnet_profiles` DISABLE KEYS */;
/*!40000 ALTER TABLE `my_aspnet_profiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_roles`
--

DROP TABLE IF EXISTS `my_aspnet_roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_roles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `applicationId` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_roles`
--

LOCK TABLES `my_aspnet_roles` WRITE;
/*!40000 ALTER TABLE `my_aspnet_roles` DISABLE KEYS */;
INSERT INTO `my_aspnet_roles` VALUES (1,1,'Morador'),(2,1,'Sindico'),(3,1,'Visitante'),(4,1,'Administradora'),(5,1,'Proprietario'),(6,1,'Funcionario'),(7,1,'Responsavel'),(8,1,'Profissional'),(9,1,'AdministradorSistema');
/*!40000 ALTER TABLE `my_aspnet_roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_schemaversion`
--

DROP TABLE IF EXISTS `my_aspnet_schemaversion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_schemaversion` (
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_schemaversion`
--

LOCK TABLES `my_aspnet_schemaversion` WRITE;
/*!40000 ALTER TABLE `my_aspnet_schemaversion` DISABLE KEYS */;
INSERT INTO `my_aspnet_schemaversion` VALUES (8);
/*!40000 ALTER TABLE `my_aspnet_schemaversion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_sessioncleanup`
--

DROP TABLE IF EXISTS `my_aspnet_sessioncleanup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_sessioncleanup` (
  `LastRun` datetime NOT NULL,
  `IntervalMinutes` int(11) NOT NULL,
  `ApplicationId` int(11) NOT NULL,
  PRIMARY KEY (`ApplicationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_sessioncleanup`
--

LOCK TABLES `my_aspnet_sessioncleanup` WRITE;
/*!40000 ALTER TABLE `my_aspnet_sessioncleanup` DISABLE KEYS */;
INSERT INTO `my_aspnet_sessioncleanup` VALUES ('2014-08-11 18:50:00',10,1);
/*!40000 ALTER TABLE `my_aspnet_sessioncleanup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_sessions`
--

DROP TABLE IF EXISTS `my_aspnet_sessions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_sessions` (
  `SessionId` varchar(191) NOT NULL,
  `ApplicationId` int(11) NOT NULL,
  `Created` datetime NOT NULL,
  `Expires` datetime NOT NULL,
  `LockDate` datetime NOT NULL,
  `LockId` int(11) NOT NULL,
  `Timeout` int(11) NOT NULL,
  `Locked` tinyint(1) NOT NULL,
  `SessionItems` longblob,
  `Flags` int(11) NOT NULL,
  PRIMARY KEY (`SessionId`,`ApplicationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_sessions`
--

LOCK TABLES `my_aspnet_sessions` WRITE;
/*!40000 ALTER TABLE `my_aspnet_sessions` DISABLE KEYS */;
/*!40000 ALTER TABLE `my_aspnet_sessions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_users`
--

DROP TABLE IF EXISTS `my_aspnet_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `applicationId` int(11) NOT NULL,
  `name` varchar(256) NOT NULL,
  `isAnonymous` tinyint(1) NOT NULL DEFAULT '1',
  `lastActivityDate` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_users`
--

LOCK TABLES `my_aspnet_users` WRITE;
/*!40000 ALTER TABLE `my_aspnet_users` DISABLE KEYS */;
INSERT INTO `my_aspnet_users` VALUES (5,1,'Administrador',0,'2014-12-08 16:24:17'),(14,1,'João',0,'2014-11-10 12:25:29'),(15,1,'mario',0,'2014-12-12 07:57:16'),(16,1,'sofia',0,'2014-12-09 11:08:50'),(17,1,'ronalso',0,'2014-11-10 12:25:56'),(18,1,'jorge',0,'2014-08-21 09:46:31'),(19,1,'pedro',0,'2014-11-10 12:26:30'),(20,1,'rosa',0,'2014-08-21 10:06:21'),(21,1,'josefa',0,'2014-08-21 08:20:56');
/*!40000 ALTER TABLE `my_aspnet_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `my_aspnet_usersinroles`
--

DROP TABLE IF EXISTS `my_aspnet_usersinroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `my_aspnet_usersinroles` (
  `userId` int(11) NOT NULL DEFAULT '0',
  `roleId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`userId`,`roleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `my_aspnet_usersinroles`
--

LOCK TABLES `my_aspnet_usersinroles` WRITE;
/*!40000 ALTER TABLE `my_aspnet_usersinroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `my_aspnet_usersinroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_acessocondominio`
--

DROP TABLE IF EXISTS `tb_acessocondominio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_acessocondominio` (
  `IdAcessoCondominio` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) NOT NULL,
  `IdCondominio` int(11) NOT NULL,
  `DataHora` datetime NOT NULL,
  `TipoAcesso` enum('Entrada','Saida') NOT NULL,
  PRIMARY KEY (`IdAcessoCondominio`),
  KEY `fk_tb_acessocondominio_tb_pessoa1_idx` (`IdPessoa`),
  KEY `fk_tb_acessocondominio_tb_condominio1_idx` (`IdCondominio`),
  CONSTRAINT `fk_tb_acessocondominio_tb_condominio1` FOREIGN KEY (`IdCondominio`) REFERENCES `tb_condominio` (`IdCondominio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_acessocondominio_tb_pessoa1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_acessocondominio`
--

LOCK TABLES `tb_acessocondominio` WRITE;
/*!40000 ALTER TABLE `tb_acessocondominio` DISABLE KEYS */;
INSERT INTO `tb_acessocondominio` VALUES (2,18,3,'2014-12-08 16:38:46','Entrada'),(3,18,3,'2014-12-12 07:57:21','Entrada');
/*!40000 ALTER TABLE `tb_acessocondominio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_acessoveiculo`
--

DROP TABLE IF EXISTS `tb_acessoveiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_acessoveiculo` (
  `IdAcessoVeiculo` int(11) NOT NULL AUTO_INCREMENT,
  `DataHora` datetime NOT NULL,
  `IdVeiculo` int(11) NOT NULL,
  `TipoAcesso` enum('Entrada','Saida') NOT NULL,
  PRIMARY KEY (`IdAcessoVeiculo`),
  KEY `tb_acessoveiculo_tb_veiculo1_idx` (`IdVeiculo`),
  CONSTRAINT `tb_acessoveiculo_tb_veiculo1` FOREIGN KEY (`IdVeiculo`) REFERENCES `tb_veiculo` (`IdVeiculo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_acessoveiculo`
--

LOCK TABLES `tb_acessoveiculo` WRITE;
/*!40000 ALTER TABLE `tb_acessoveiculo` DISABLE KEYS */;
INSERT INTO `tb_acessoveiculo` VALUES (1,'2014-11-10 15:09:58',5,'Entrada');
/*!40000 ALTER TABLE `tb_acessoveiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_areapublica`
--

DROP TABLE IF EXISTS `tb_areapublica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_areapublica` (
  `IdAreaPublica` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(60) NOT NULL,
  `Local` varchar(60) NOT NULL,
  `Tamanho` varchar(15) NOT NULL,
  `ValorReserva` decimal(10,0) NOT NULL,
  `IdCondominio` int(11) NOT NULL,
  `StatusAreaPublica` enum('Disponivel','Reservado','Indisponivel') NOT NULL DEFAULT 'Disponivel',
  PRIMARY KEY (`IdAreaPublica`),
  KEY `TB_Espaco_TB_Condominio1_idx` (`IdCondominio`),
  CONSTRAINT `TB_Espaco_TB_Condominio1` FOREIGN KEY (`IdCondominio`) REFERENCES `tb_condominio` (`IdCondominio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_areapublica`
--

LOCK TABLES `tb_areapublica` WRITE;
/*!40000 ALTER TABLE `tb_areapublica` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_areapublica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_atendimento`
--

DROP TABLE IF EXISTS `tb_atendimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_atendimento` (
  `IdAtendimento` int(11) NOT NULL AUTO_INCREMENT,
  `IdPesssoa` int(11) NOT NULL,
  `Titulo` varchar(100) NOT NULL,
  `Descricao` varchar(1000) NOT NULL,
  `StatusAtendimento` enum('Resolvido','EmAnalise') NOT NULL DEFAULT 'EmAnalise',
  PRIMARY KEY (`IdAtendimento`),
  KEY `TB_Atendimento_TB_Pessoa1_idx` (`IdPesssoa`),
  CONSTRAINT `TB_Atendimento_TB_Pessoa1` FOREIGN KEY (`IdPesssoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_atendimento`
--

LOCK TABLES `tb_atendimento` WRITE;
/*!40000 ALTER TABLE `tb_atendimento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_atendimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_bloco`
--

DROP TABLE IF EXISTS `tb_bloco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_bloco` (
  `IdBloco` int(11) NOT NULL AUTO_INCREMENT,
  `IdCondominio` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `QuantidadeAndares` int(11) NOT NULL,
  `QuantidadeMoradias` int(11) NOT NULL,
  PRIMARY KEY (`IdBloco`),
  KEY `TB_Bloco_TB_Condominio1_idx` (`IdCondominio`),
  CONSTRAINT `TB_Bloco_TB_Condominio1` FOREIGN KEY (`IdCondominio`) REFERENCES `tb_condominio` (`IdCondominio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_bloco`
--

LOCK TABLES `tb_bloco` WRITE;
/*!40000 ALTER TABLE `tb_bloco` DISABLE KEYS */;
INSERT INTO `tb_bloco` VALUES (1,1,'Admin',0,0),(3,3,'Olimpo',12,48),(5,3,'Atenas',12,48),(6,4,'Tulipa',3,12),(7,4,'Orquídea',3,12);
/*!40000 ALTER TABLE `tb_bloco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_comentario`
--

DROP TABLE IF EXISTS `tb_comentario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_comentario` (
  `IdComentario` int(11) NOT NULL AUTO_INCREMENT,
  `IdPostagem` int(11) NOT NULL,
  `IdPessoa` int(11) NOT NULL,
  `Comentario` varchar(500) NOT NULL,
  `Data` datetime NOT NULL,
  PRIMARY KEY (`IdComentario`),
  KEY `TB_Comentario_TB_Postagem1_idx` (`IdPostagem`),
  KEY `TB_Comentario_TB_Pessoa1_idx` (`IdPessoa`),
  CONSTRAINT `TB_Comentario_TB_Pessoa1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `TB_Comentario_TB_Postagem1` FOREIGN KEY (`IdPostagem`) REFERENCES `tb_postagem` (`IdPostagem`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_comentario`
--

LOCK TABLES `tb_comentario` WRITE;
/*!40000 ALTER TABLE `tb_comentario` DISABLE KEYS */;
INSERT INTO `tb_comentario` VALUES (1,1,17,'Quanto custa','2014-12-09 10:54:24');
/*!40000 ALTER TABLE `tb_comentario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_condominio`
--

DROP TABLE IF EXISTS `tb_condominio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_condominio` (
  `IdCondominio` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Rua` varchar(100) NOT NULL,
  `Numero` varchar(10) NOT NULL,
  `Bairro` varchar(50) NOT NULL,
  `Complemento` varchar(100) DEFAULT NULL,
  `CEP` varchar(8) NOT NULL,
  `Cidade` varchar(50) NOT NULL,
  `Estado` char(2) NOT NULL,
  PRIMARY KEY (`IdCondominio`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_condominio`
--

LOCK TABLES `tb_condominio` WRITE;
/*!40000 ALTER TABLE `tb_condominio` DISABLE KEYS */;
INSERT INTO `tb_condominio` VALUES (1,'Admistrador','Administrador','0','Administardor','','00000000','Administrador','ND'),(3,'Condomínio Atlanta','Atlanta','455','Luzia',NULL,'49500000','Aracaju','SE'),(4,'Pousada Verde','Adélia Franco','2000','Grageru',NULL,'49500000','Aracaju','SE');
/*!40000 ALTER TABLE `tb_condominio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_enquete`
--

DROP TABLE IF EXISTS `tb_enquete`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_enquete` (
  `IdEnquete` int(11) NOT NULL AUTO_INCREMENT,
  `IdPesssoa` int(11) NOT NULL,
  `Titulo` varchar(100) NOT NULL,
  `Descricao` varchar(500) NOT NULL,
  `DataInicio` datetime NOT NULL,
  `DataFim` datetime NOT NULL,
  `StatusEnquete` enum('EmVotacao','Pausada','Finalizada') NOT NULL DEFAULT 'EmVotacao',
  PRIMARY KEY (`IdEnquete`),
  KEY `TB_Enquete_TB_Pessoa1_idx` (`IdPesssoa`),
  CONSTRAINT `TB_Enquete_TB_Pessoa1` FOREIGN KEY (`IdPesssoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_enquete`
--

LOCK TABLES `tb_enquete` WRITE;
/*!40000 ALTER TABLE `tb_enquete` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_enquete` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_grupoplanocontas`
--

DROP TABLE IF EXISTS `tb_grupoplanocontas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_grupoplanocontas` (
  `IdGrupoPlanoDeConta` int(11) NOT NULL AUTO_INCREMENT,
  `TipoPlanoDeConta` enum('Receita','Despesa') NOT NULL,
  `Descricao` varchar(100) NOT NULL,
  PRIMARY KEY (`IdGrupoPlanoDeConta`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_grupoplanocontas`
--

LOCK TABLES `tb_grupoplanocontas` WRITE;
/*!40000 ALTER TABLE `tb_grupoplanocontas` DISABLE KEYS */;
INSERT INTO `tb_grupoplanocontas` VALUES (2,'Despesa','Administrativa');
/*!40000 ALTER TABLE `tb_grupoplanocontas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_moradia`
--

DROP TABLE IF EXISTS `tb_moradia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_moradia` (
  `IdMoradia` int(11) NOT NULL AUTO_INCREMENT,
  `IdBloco` int(11) NOT NULL,
  `Andar` varchar(15) NOT NULL,
  `Numero` varchar(10) NOT NULL,
  `TipoMoradia` enum('Cobertura','Padrao','Duplex','Triplex','Casa') NOT NULL DEFAULT 'Padrao',
  PRIMARY KEY (`IdMoradia`),
  KEY `TB_Moradia_TB_Bloco1_idx` (`IdBloco`),
  CONSTRAINT `TB_Moradia_TB_Bloco1` FOREIGN KEY (`IdBloco`) REFERENCES `tb_bloco` (`IdBloco`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_moradia`
--

LOCK TABLES `tb_moradia` WRITE;
/*!40000 ALTER TABLE `tb_moradia` DISABLE KEYS */;
INSERT INTO `tb_moradia` VALUES (1,1,'0','0','Padrao'),(10,6,'1','102','Padrao'),(11,7,'3','303','Cobertura'),(12,5,'9','901','Padrao'),(13,3,'2','202','Padrao');
/*!40000 ALTER TABLE `tb_moradia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_movimentacaofinanceira`
--

DROP TABLE IF EXISTS `tb_movimentacaofinanceira`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_movimentacaofinanceira` (
  `IdMovimentacaoFinanceira` int(11) NOT NULL AUTO_INCREMENT,
  `Valor` decimal(10,2) NOT NULL,
  `DataRegistro` datetime NOT NULL,
  `NotaFiscal` varchar(50) NOT NULL,
  `Descricao` varchar(200) DEFAULT NULL,
  `StatusMovimentacao` enum('EmAnalise','Autorizada','NaoAutorizada','Registrada','Finalizada') NOT NULL DEFAULT 'EmAnalise',
  `Baixa` tinyint(1) NOT NULL DEFAULT '0',
  `IdPlanoDeConta` int(11) NOT NULL,
  `IdReservaAmbiente` int(11) NOT NULL,
  `IdPessoa` int(11) NOT NULL,
  PRIMARY KEY (`IdMovimentacaoFinanceira`),
  KEY `fk_tb_movimentacaofinanceira_tb_planodeconta1_idx` (`IdPlanoDeConta`),
  KEY `fk_tb_movimentacaofinanceira_tb_reservaambiente1_idx` (`IdReservaAmbiente`),
  KEY `fk_tb_movimentacaofinanceira_tb_pessoa1_idx` (`IdPessoa`),
  CONSTRAINT `fk_tb_movimentacaofinanceira_tb_pessoa1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_movimentacaofinanceira_tb_planodeconta1` FOREIGN KEY (`IdPlanoDeConta`) REFERENCES `tb_planodeconta` (`IdPlanoDeConta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_movimentacaofinanceira_tb_reservaambiente1` FOREIGN KEY (`IdReservaAmbiente`) REFERENCES `tb_reservaambiente` (`IdReservaAmbiente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_movimentacaofinanceira`
--

LOCK TABLES `tb_movimentacaofinanceira` WRITE;
/*!40000 ALTER TABLE `tb_movimentacaofinanceira` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_movimentacaofinanceira` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_ocorrencia`
--

DROP TABLE IF EXISTS `tb_ocorrencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_ocorrencia` (
  `IdOcorrencia` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) NOT NULL,
  `Titulo` varchar(50) NOT NULL,
  `Descricao` varchar(500) NOT NULL,
  `DataCriacao` datetime NOT NULL,
  `TipoOcorrencia` enum('Barulho','Roubo','DanoAoPatrimonio','Outros') NOT NULL DEFAULT 'Barulho',
  `StatusOcorrencia` enum('EmAnalise','EmExecucao','Rresolvida','Finalizada') NOT NULL DEFAULT 'EmAnalise',
  `OutrosTiposOcorrencia` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdOcorrencia`),
  KEY `TB_Ocorrencia_TB_Pessoa1_idx` (`IdPessoa`),
  CONSTRAINT `TB_Ocorrencia_TB_Pessoa1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_ocorrencia`
--

LOCK TABLES `tb_ocorrencia` WRITE;
/*!40000 ALTER TABLE `tb_ocorrencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_ocorrencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_opcoesenquete`
--

DROP TABLE IF EXISTS `tb_opcoesenquete`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_opcoesenquete` (
  `IdOpcao` int(11) NOT NULL AUTO_INCREMENT,
  `IdEnquete` int(11) NOT NULL,
  `Descricao` varchar(50) NOT NULL,
  PRIMARY KEY (`IdOpcao`),
  KEY `TB_OpcoesEnquete_TB_Enquete1_idx` (`IdEnquete`),
  CONSTRAINT `TB_OpcoesEnquete_TB_Enquete1` FOREIGN KEY (`IdEnquete`) REFERENCES `tb_enquete` (`IdEnquete`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_opcoesenquete`
--

LOCK TABLES `tb_opcoesenquete` WRITE;
/*!40000 ALTER TABLE `tb_opcoesenquete` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_opcoesenquete` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pessoa`
--

DROP TABLE IF EXISTS `tb_pessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pessoa` (
  `IdPessoa` int(11) NOT NULL AUTO_INCREMENT,
  `CPF` varchar(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `RG` varchar(15) NOT NULL,
  `Sexo` char(1) NOT NULL,
  `TelefoneFixo` varchar(12) DEFAULT NULL,
  `TelefoneCelular` varchar(12) DEFAULT NULL,
  `Rua` varchar(100) NOT NULL,
  `Numero` varchar(10) NOT NULL,
  `Complemento` varchar(100) DEFAULT NULL,
  `Bairro` varchar(50) NOT NULL,
  `CEP` varchar(8) NOT NULL,
  `Cidade` varchar(50) NOT NULL,
  `Estado` char(2) NOT NULL,
  `IdUser` int(11) NOT NULL,
  `IdSetor` int(11) NOT NULL,
  `Ativa` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`IdPessoa`),
  KEY `fk_tb_pessoa_my_aspnet_users1_idx` (`IdUser`),
  KEY `fk_tb_pessoa_tb_setor1_idx` (`IdSetor`),
  CONSTRAINT `fk_tb_pessoa_my_aspnet_users1` FOREIGN KEY (`IdUser`) REFERENCES `my_aspnet_users` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_pessoa_tb_setor1` FOREIGN KEY (`IdSetor`) REFERENCES `tb_setor` (`IdSetor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pessoa`
--

LOCK TABLES `tb_pessoa` WRITE;
/*!40000 ALTER TABLE `tb_pessoa` DISABLE KEYS */;
INSERT INTO `tb_pessoa` VALUES (1,'12345678','Administrador','12345678','M',NULL,'','A definir','0',NULL,'A definir','0','A definir','ND',5,1,1),(16,'36832513364','João','36832513364','M',NULL,NULL,'Rua A','455',NULL,'Grageru','49045280','Aracaju','SE',14,1,0),(17,'11657441555','Mário','11657441555','M',NULL,NULL,'Rua A','202',NULL,'Centro','49045280','Aracaju','SE',15,1,0),(18,'97985417230','Sofia','97985417230','F',NULL,NULL,'Rua A','101',NULL,'Grageru','49045280','Aracaju','SE',16,1,0),(19,'27114615051','Ronaldo','27114615051','M',NULL,NULL,'Atlanta','2000',NULL,'Luzia','49045280','Aracaju','SE',17,1,0),(20,'17173248949','Jorge','17173248949','M',NULL,NULL,'Rua A','101',NULL,'Grageru','49045280','Aracaju','SE',18,1,0),(21,'29821899684','Pedro','29821899684','M',NULL,NULL,'Atlanta','202',NULL,'Centro','49045280','Aracaju','SE',19,1,0),(22,'83277273113','Rosa','83277273113','F',NULL,NULL,'Atlanta','303',NULL,'Luzia','49045280','Aracaju','SE',20,1,0),(23,'76130575858','Josefa','76130575858','F',NULL,NULL,'Rua A','2000',NULL,'Centro','49045280','Aracaju','SE',21,1,0);
/*!40000 ALTER TABLE `tb_pessoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pessoamoradia`
--

DROP TABLE IF EXISTS `tb_pessoamoradia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pessoamoradia` (
  `IdPessoa` int(11) NOT NULL,
  `Ativo` tinyint(1) NOT NULL,
  `IdPerfil` int(11) NOT NULL,
  `IdMoradia` int(11) NOT NULL,
  PRIMARY KEY (`IdPessoa`,`IdMoradia`,`IdPerfil`),
  KEY `fk_tb_perfilpessoa_tb_pessoa1_idx` (`IdPessoa`),
  KEY `fk_tb_perfilpessoa_my_aspnet_roles1_idx` (`IdPerfil`),
  KEY `fk_tb_perfilpessoa_tb_moradia1_idx` (`IdMoradia`),
  CONSTRAINT `fk_tb_perfilpessoa_my_aspnet_roles1` FOREIGN KEY (`IdPerfil`) REFERENCES `my_aspnet_roles` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_perfilpessoa_tb_moradia1` FOREIGN KEY (`IdMoradia`) REFERENCES `tb_moradia` (`IdMoradia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_perfilpessoa_tb_pessoa1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pessoamoradia`
--

LOCK TABLES `tb_pessoamoradia` WRITE;
/*!40000 ALTER TABLE `tb_pessoamoradia` DISABLE KEYS */;
INSERT INTO `tb_pessoamoradia` VALUES (1,1,9,1),(16,1,1,12),(16,1,5,12),(16,1,7,12),(17,1,1,13),(17,1,2,13),(17,1,5,13),(17,1,7,13),(18,1,1,13),(19,1,1,11),(19,1,2,11),(19,1,5,11),(19,1,7,11),(20,1,5,10),(20,0,7,10),(21,1,1,10),(21,1,7,10),(22,1,3,10),(23,1,6,13),(23,1,8,13);
/*!40000 ALTER TABLE `tb_pessoamoradia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_planodeconta`
--

DROP TABLE IF EXISTS `tb_planodeconta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_planodeconta` (
  `IdPlanoDeConta` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(150) NOT NULL,
  `IdTipoPlanoDeConta` int(11) NOT NULL,
  PRIMARY KEY (`IdPlanoDeConta`),
  KEY `fk_tb_planodeconta_tb_grupoplanocontas1_idx` (`IdTipoPlanoDeConta`),
  CONSTRAINT `fk_tb_planodeconta_tb_grupoplanocontas1` FOREIGN KEY (`IdTipoPlanoDeConta`) REFERENCES `tb_grupoplanocontas` (`IdGrupoPlanoDeConta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_planodeconta`
--

LOCK TABLES `tb_planodeconta` WRITE;
/*!40000 ALTER TABLE `tb_planodeconta` DISABLE KEYS */;
INSERT INTO `tb_planodeconta` VALUES (1,'Taxa de Condomínio',0),(2,'Taxa Extra',0);
/*!40000 ALTER TABLE `tb_planodeconta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pontuacaopessoa`
--

DROP TABLE IF EXISTS `tb_pontuacaopessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pontuacaopessoa` (
  `IdPontuacaoPessoa` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) NOT NULL,
  `Comentario` varchar(250) DEFAULT NULL,
  `Pontuacao` enum('Zero','Um','Dois','Tres','Quatro','Cinco','Seis','Sete','Oito','Nove','Dez') NOT NULL,
  PRIMARY KEY (`IdPontuacaoPessoa`,`IdPessoa`),
  KEY `fk_tb_pontuacao_has_tb_pessoa_tb_pessoa1_idx` (`IdPessoa`),
  CONSTRAINT `fk_tb_pontuacao_has_tb_pessoa_tb_pessoa1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pontuacaopessoa`
--

LOCK TABLES `tb_pontuacaopessoa` WRITE;
/*!40000 ALTER TABLE `tb_pontuacaopessoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pontuacaopessoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_postagem`
--

DROP TABLE IF EXISTS `tb_postagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_postagem` (
  `IdPostagem` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) NOT NULL,
  `Titulo` varchar(100) NOT NULL,
  `Descricao` varchar(500) NOT NULL,
  `DataCriacao` datetime NOT NULL,
  `DataEncerramento` datetime DEFAULT NULL,
  PRIMARY KEY (`IdPostagem`),
  KEY `TB_Postagem_TB_Pessoa1_idx` (`IdPessoa`),
  CONSTRAINT `TB_Postagem_TB_Pessoa1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_postagem`
--

LOCK TABLES `tb_postagem` WRITE;
/*!40000 ALTER TABLE `tb_postagem` DISABLE KEYS */;
INSERT INTO `tb_postagem` VALUES (1,17,'Manuntenção Elevador','O elevador se encontra com problemas','2014-12-09 10:52:22','2014-11-22 00:00:00'),(4,17,'Teste Ferramenta','A ferramenta parece boa','2014-12-10 19:27:23','2014-12-23 00:00:00');
/*!40000 ALTER TABLE `tb_postagem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_reservaambiente`
--

DROP TABLE IF EXISTS `tb_reservaambiente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_reservaambiente` (
  `IdReservaAmbiente` int(11) NOT NULL AUTO_INCREMENT,
  `IdPesssoa` int(11) NOT NULL,
  `DataInicio` datetime NOT NULL,
  `DataFim` datetime NOT NULL,
  `IdAreaPublica` int(11) NOT NULL,
  PRIMARY KEY (`IdReservaAmbiente`),
  KEY `TB_ReservaAmbiente_TB_Pessoa1_idx` (`IdPesssoa`),
  KEY `tb_reservaambiente_tb_areapublica1_idx` (`IdAreaPublica`),
  CONSTRAINT `tb_reservaambiente_tb_areapublica1` FOREIGN KEY (`IdAreaPublica`) REFERENCES `tb_areapublica` (`IdAreaPublica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `TB_ReservaAmbiente_TB_Pessoa1` FOREIGN KEY (`IdPesssoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_reservaambiente`
--

LOCK TABLES `tb_reservaambiente` WRITE;
/*!40000 ALTER TABLE `tb_reservaambiente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_reservaambiente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_restricaoacesso`
--

DROP TABLE IF EXISTS `tb_restricaoacesso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_restricaoacesso` (
  `IdRestricaoAcesso` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) NOT NULL,
  `IdMoradia` int(11) NOT NULL,
  `Restrito` tinyint(1) NOT NULL DEFAULT '0',
  `Dia` enum('Segunda','Terca','Quarta','Quinta','Sexta','Sabado','Domingo') NOT NULL,
  `HoraEntrada` enum('ZeroHora','UmaHora','DuasHora','TresHora','QuatroHora','CincoHora','SeisHora','SeteHora','OitoHora','NoveHora','DezHora','OnzeHora','DozeHora','TrezeHora','QuatorzeHora','QuinzeHora','DezesseisHora','DezesseteHora','DezoitoHora','DezenoveHora','VinteHora','VinteUmHora','VinteDuasHora','VinteTresHora','VinteQuatroHora') DEFAULT NULL,
  `HoraSaida` enum('ZeroHora','UmaHora','DuasHora','TresHora','QuatroHora','CincoHora','SeisHora','SeteHora','OitoHora','NoveHora','DezHora','OnzeHora','DozeHora','TrezeHora','QuatorzeHora','QuinzeHora','DezesseisHora','DezesseteHora','DezoitoHora','DezenoveHora','VinteHora','VinteUmHora','VinteDuasHora','VinteTresHora','VinteQuatroHora') DEFAULT NULL,
  PRIMARY KEY (`IdRestricaoAcesso`),
  KEY `fk_tb_restricaoacesso_tb_pessoa1_idx` (`IdPessoa`),
  KEY `fk_tb_restricaoacesso_tb_moradia1_idx` (`IdMoradia`),
  CONSTRAINT `fk_tb_restricaoacesso_tb_moradia1` FOREIGN KEY (`IdMoradia`) REFERENCES `tb_moradia` (`IdMoradia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_restricaoacesso_tb_pessoa1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_restricaoacesso`
--

LOCK TABLES `tb_restricaoacesso` WRITE;
/*!40000 ALTER TABLE `tb_restricaoacesso` DISABLE KEYS */;
INSERT INTO `tb_restricaoacesso` VALUES (13,17,13,0,'Segunda','ZeroHora','ZeroHora'),(14,18,13,0,'Segunda','ZeroHora','ZeroHora'),(15,16,12,0,'Segunda','ZeroHora','ZeroHora'),(16,19,11,0,'Segunda','ZeroHora','ZeroHora'),(17,21,10,0,'Segunda','ZeroHora','ZeroHora');
/*!40000 ALTER TABLE `tb_restricaoacesso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_setor`
--

DROP TABLE IF EXISTS `tb_setor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_setor` (
  `IdSetor` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) NOT NULL,
  `Descricao` varchar(100) NOT NULL,
  PRIMARY KEY (`IdSetor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_setor`
--

LOCK TABLES `tb_setor` WRITE;
/*!40000 ALTER TABLE `tb_setor` DISABLE KEYS */;
INSERT INTO `tb_setor` VALUES (1,'Não selecionado','Setor padrão para cadastro de pessoa');
/*!40000 ALTER TABLE `tb_setor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_veiculo`
--

DROP TABLE IF EXISTS `tb_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_veiculo` (
  `IdVeiculo` int(11) NOT NULL AUTO_INCREMENT,
  `IdPesssoa` int(11) NOT NULL,
  `Placa` varchar(7) NOT NULL,
  `Modelo` varchar(50) NOT NULL,
  `Cor` varchar(20) NOT NULL,
  `TipoVeiculo` enum('Carro','Motocicleta') NOT NULL DEFAULT 'Carro',
  `IdMoradia` int(11) NOT NULL,
  PRIMARY KEY (`IdVeiculo`),
  KEY `TB_Veiculo_TB_Pessoa1_idx` (`IdPesssoa`),
  KEY `tb_veiculo_tb_moradia1_idx` (`IdMoradia`),
  CONSTRAINT `tb_veiculo_tb_moradia1` FOREIGN KEY (`IdMoradia`) REFERENCES `tb_moradia` (`IdMoradia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `TB_Veiculo_TB_Pessoa1` FOREIGN KEY (`IdPesssoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_veiculo`
--

LOCK TABLES `tb_veiculo` WRITE;
/*!40000 ALTER TABLE `tb_veiculo` DISABLE KEYS */;
INSERT INTO `tb_veiculo` VALUES (3,17,'HYJ1450','Corsa','Vermelho','Carro',13),(4,16,'NVK1120','Siena','Prata','Carro',12),(5,21,'IAK3040','Ninja','Amarela','Motocicleta',10);
/*!40000 ALTER TABLE `tb_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_votoenquete`
--

DROP TABLE IF EXISTS `tb_votoenquete`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_votoenquete` (
  `IdVoto` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) NOT NULL,
  `IdEnquete` int(11) NOT NULL,
  `IdOpcao` int(11) NOT NULL,
  `DataVoto` datetime NOT NULL,
  PRIMARY KEY (`IdVoto`),
  KEY `TB_VotoEnquete_TB_OpcoesEnquete1_idx` (`IdOpcao`),
  KEY `TB_VotoEnquete_TB_Pessoa1_idx` (`IdPessoa`),
  KEY `tb_votoenquete_tb_enquete1_idx` (`IdEnquete`),
  CONSTRAINT `tb_votoenquete_tb_enquete1` FOREIGN KEY (`IdEnquete`) REFERENCES `tb_enquete` (`IdEnquete`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `TB_VotoEnquete_TB_OpcoesEnquete1` FOREIGN KEY (`IdOpcao`) REFERENCES `tb_opcoesenquete` (`IdOpcao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `TB_VotoEnquete_TB_Pessoa1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_votoenquete`
--

LOCK TABLES `tb_votoenquete` WRITE;
/*!40000 ALTER TABLE `tb_votoenquete` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_votoenquete` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-12-23 16:10:20
