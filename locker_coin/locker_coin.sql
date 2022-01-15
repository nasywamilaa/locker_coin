-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.4.17-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for locker_coin
CREATE DATABASE IF NOT EXISTS `locker_coin` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `locker_coin`;

-- Dumping structure for table locker_coin.jenis_ukuran
CREATE TABLE IF NOT EXISTS `jenis_ukuran` (
  `id_ukuran` int(11) NOT NULL AUTO_INCREMENT,
  `ukuran` varchar(255) DEFAULT NULL,
  `biaya` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_ukuran`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table locker_coin.jenis_ukuran: ~0 rows (approximately)
/*!40000 ALTER TABLE `jenis_ukuran` DISABLE KEYS */;
/*!40000 ALTER TABLE `jenis_ukuran` ENABLE KEYS */;

-- Dumping structure for table locker_coin.locker
CREATE TABLE IF NOT EXISTS `locker` (
  `id_locker` int(11) NOT NULL AUTO_INCREMENT,
  `id_ukuran` int(11) DEFAULT NULL,
  `nama_locker` varchar(255) DEFAULT NULL,
  `lokasi` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_locker`),
  KEY `id_ukuran` (`id_ukuran`),
  CONSTRAINT `FJU` FOREIGN KEY (`id_ukuran`) REFERENCES `jenis_ukuran` (`id_ukuran`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table locker_coin.locker: ~0 rows (approximately)
/*!40000 ALTER TABLE `locker` DISABLE KEYS */;
/*!40000 ALTER TABLE `locker` ENABLE KEYS */;

-- Dumping structure for table locker_coin.penyewaan
CREATE TABLE IF NOT EXISTS `penyewaan` (
  `id_sewa` int(11) NOT NULL AUTO_INCREMENT,
  `id_locker` int(11) DEFAULT NULL,
  `waktu_sewa` datetime DEFAULT NULL,
  `waktu_kembali` int(11) DEFAULT NULL,
  `bayar_sebelum_pinjam` int(11) DEFAULT NULL,
  `rencana_pinjam` int(11) DEFAULT NULL,
  `kelebihan_pinjam` int(11) DEFAULT NULL,
  `total_bayar` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_sewa`),
  KEY `id_locker` (`id_locker`),
  CONSTRAINT `FKL` FOREIGN KEY (`id_locker`) REFERENCES `locker` (`id_locker`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table locker_coin.penyewaan: ~0 rows (approximately)
/*!40000 ALTER TABLE `penyewaan` DISABLE KEYS */;
/*!40000 ALTER TABLE `penyewaan` ENABLE KEYS */;

-- Dumping structure for table locker_coin.user
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table locker_coin.user: ~0 rows (approximately)
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
