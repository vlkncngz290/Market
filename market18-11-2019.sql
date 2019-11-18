CREATE DATABASE  IF NOT EXISTS `market` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `market`;
-- MySQL dump 10.13  Distrib 8.0.14, for Win64 (x86_64)
--
-- Host: 192.168.1.249    Database: market
-- ------------------------------------------------------
-- Server version	8.0.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `urun_satis_hareketleri`
--

DROP TABLE IF EXISTS `urun_satis_hareketleri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `urun_satis_hareketleri` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `urun_id` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tarih` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `saat` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `miktar` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `birim` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `satis_fiyati` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fis_id` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `urun_satis_hareketleri`
--

LOCK TABLES `urun_satis_hareketleri` WRITE;
/*!40000 ALTER TABLE `urun_satis_hareketleri` DISABLE KEYS */;
/*!40000 ALTER TABLE `urun_satis_hareketleri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `urunler`
--

DROP TABLE IF EXISTS `urunler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `urunler` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `urun_adi` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `urun_grubu` int(11) DEFAULT NULL,
  `urun_alt_grubu` int(11) DEFAULT NULL,
  `stok_sayisi` int(11) DEFAULT NULL,
  `raf` int(11) DEFAULT NULL,
  `uretici_firma` int(11) DEFAULT NULL,
  `resim` longblob,
  `barkod` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `birim` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `satis_fiyati` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `minimum_stok_sayisi` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `urunler`
--

LOCK TABLES `urunler` WRITE;
/*!40000 ALTER TABLE `urunler` DISABLE KEYS */;
/*!40000 ALTER TABLE `urunler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'market'
--

--
-- Dumping routines for database 'market'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-11-18 17:27:52
