-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 15, 2026 at 08:51 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_endfield`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_alat`
--

CREATE TABLE `tbl_alat` (
  `id_alat` int(11) NOT NULL,
  `kode_alat` varchar(20) NOT NULL,
  `nama_alat` varchar(100) NOT NULL,
  `kategori` varchar(50) NOT NULL,
  `wilayah` varchar(50) NOT NULL,
  `daya_terpakai` int(11) DEFAULT 0,
  `foto_path` varchar(255) DEFAULT NULL,
  `deskripsi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_alat`
--

INSERT INTO `tbl_alat` (`id_alat`, `kode_alat`, `nama_alat`, `kategori`, `wilayah`, `daya_terpakai`, `foto_path`, `deskripsi`) VALUES
(1, 'p-tbmv', 'relay', 'Power', 'Wuling', 5000, '-', '*Deskripsikan kegunaan Alat ini');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_spesifikasi`
--

CREATE TABLE `tbl_spesifikasi` (
  `id_spek` int(11) NOT NULL,
  `id_alat` int(11) NOT NULL,
  `val_1` decimal(10,2) DEFAULT 0.00,
  `val_2` decimal(10,2) DEFAULT 0.00,
  `val_3` decimal(10,2) DEFAULT 0.00,
  `val_4` double DEFAULT 0,
  `txt_1` varchar(100) DEFAULT '-',
  `txt_2` varchar(100) DEFAULT '-',
  `bool_1` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_spesifikasi`
--

INSERT INTO `tbl_spesifikasi` (`id_spek`, `id_alat`, `val_1`, `val_2`, `val_3`, `val_4`, `txt_1`, `txt_2`, `bool_1`) VALUES
(1, 1, 4.00, 26.00, 0.00, 0, '-', '-', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_alat`
--
ALTER TABLE `tbl_alat`
  ADD PRIMARY KEY (`id_alat`),
  ADD UNIQUE KEY `kode_alat` (`kode_alat`);

--
-- Indexes for table `tbl_spesifikasi`
--
ALTER TABLE `tbl_spesifikasi`
  ADD PRIMARY KEY (`id_spek`),
  ADD KEY `id_alat` (`id_alat`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_alat`
--
ALTER TABLE `tbl_alat`
  MODIFY `id_alat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_spesifikasi`
--
ALTER TABLE `tbl_spesifikasi`
  MODIFY `id_spek` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_spesifikasi`
--
ALTER TABLE `tbl_spesifikasi`
  ADD CONSTRAINT `tbl_spesifikasi_ibfk_1` FOREIGN KEY (`id_alat`) REFERENCES `tbl_alat` (`id_alat`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
