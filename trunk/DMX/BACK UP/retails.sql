-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Sep 26, 2013 at 05:39 PM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `retails`
--

-- --------------------------------------------------------

--
-- Table structure for table `bank`
--

CREATE TABLE IF NOT EXISTS `bank` (
  `KODEBANK` varchar(255) NOT NULL DEFAULT '',
  `NAMABANK` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`KODEBANK`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bank`
--

INSERT INTO `bank` (`KODEBANK`, `NAMABANK`) VALUES
('B-01', 'BCA'),
('B-03', 'MANDIRI'),
('B-04', 'BNI'),
('B-05', 'DANAMON'),
('B-06', 'BANK JABAR'),
('B-07', 'LIPPO'),
('B-08', 'MUAMALAT'),
('B-09', 'CIMB NIAGA'),
('B-10', 'PUNDI'),
('B-02', 'BRI');

-- --------------------------------------------------------

--
-- Table structure for table `barangpromo`
--

CREATE TABLE IF NOT EXISTS `barangpromo` (
  `KODEPROMO` varchar(255) NOT NULL DEFAULT '',
  `NAMAPROMO` varchar(255) DEFAULT NULL,
  `BARCODE` varchar(255) DEFAULT NULL,
  `HARGAPOKOK` decimal(10,0) DEFAULT NULL,
  `MARGINPROFIT` float DEFAULT NULL,
  `HARGAJUAL` decimal(10,0) DEFAULT NULL,
  `QTY` int(11) DEFAULT NULL,
  PRIMARY KEY (`KODEPROMO`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barangpromo`
--


-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE IF NOT EXISTS `department` (
  `KODEDEPARTMENT` varchar(255) NOT NULL DEFAULT '',
  `NAMADEPARTMENT` varchar(255) DEFAULT NULL,
  `MINMARGIN` int(11) DEFAULT NULL,
  `MAXMARGIN` int(11) DEFAULT NULL,
  `KETERANGAN` varchar(255) DEFAULT NULL,
  `BANYAKITEM` int(11) DEFAULT NULL,
  PRIMARY KEY (`KODEDEPARTMENT`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`KODEDEPARTMENT`, `NAMADEPARTMENT`, `MINMARGIN`, `MAXMARGIN`, `KETERANGAN`, `BANYAKITEM`) VALUES
('001', 'SUSU/MAKANAN/BUBUR BAYI', 3, 5, '', NULL),
('002', 'SUSU DEWASA/KALSIUM/IH/IM', 4, 6, '', NULL),
('003', 'MAKANAN RINGAN/KCG/PERMEN/CKLT', 8, 10, '', NULL),
('004', 'MAKANAN TITIP JUAL', 4, 5, '', NULL),
('005', 'MINYAK GORENG/GULA BERMERK/ABN', 4, 6, '', NULL),
('006', 'MIE/BIHUN/TEPUNG/GANDUM/BERAS', 3, 5, '', NULL),
('007', 'GULA/TEH LOKAL/TELUR', 5, 7, '', NULL),
('008', 'SIRUP/SQUASH/MADU', 4, 6, '', NULL),
('009', 'SEREAL SARAPAN/KOPI/KOPSUS/TEH', 8, 11, '', NULL),
('010', 'BUMBU DPR/BHN KUE/SARDEN/KRNT', 8, 12, '', NULL),
('011', 'MINUMAN RINGAN/SERBUK/SUPLEMEN', 7, 10, '', NULL),
('012', 'ES KRIM/NUGGET/SOSIS', 25, 30, '', NULL),
('013', 'SABUN CUCI BBK/KRIM/BATANGAN', 5, 10, '', NULL),
('014', 'PEWANGI/PELEMBUT/PENGHARUM', 6, 10, '', NULL),
('015', 'PENGHARUM RUANGAN/KAMPER/MOBIL', 6, 12, '', NULL),
('016', 'PEMBERSIH/PNGHRM KACA/LANTAI', 8, 12, '', NULL),
('017', 'PEMBASMI SERANGGA/NYAMUK/TIKUS', 8, 12, '', NULL),
('019', 'KAPAS/TISU/PEMBALUT/POPOK/CB', 10, 12, '', NULL),
('020', 'SIKAT GIGI/SAPUT BEDAK/BATERAI', 10, 12, '', NULL),
('021', 'ROKOK', 2, 5, '', NULL),
('022', 'SILET/KOREK API', 10, 20, '', NULL),
('023', 'PERAWATAN MUKA/KOSMETIK', 8, 10, '', NULL),
('024', 'PARFUM/DEODORANT/TISU PARFUM', 8, 10, '', NULL),
('025', 'PRWTN KULIT TNGN&TBH/HAND BODY', 8, 10, '', NULL),
('026', 'SABUN MANDI BATANG/CAIR/HAND', 4, 7, '', NULL),
('027', 'PASTA GIGI/TUSUK GIGI', 4, 7, '', NULL),
('028', 'SHAMPO/CONDITIONER/PRWTN RMBT', 4, 7, '', NULL),
('029', 'PERLENGKAPAN BAYI', 8, 15, '', NULL),
('030', 'OBAT TELAN', 8, 12, '', NULL),
('031', 'OBAT LUAR/BALSEM/OBAT KULIT/OK', 8, 12, '', NULL),
('032', 'AKSESORIS/SOUVENIR', 15, 30, '', NULL),
('034', 'ALAT/PRLNGKPN RUMAH TANGGA', 10, 12, '', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE IF NOT EXISTS `sales` (
  `KODESALES` varchar(255) NOT NULL DEFAULT '',
  `NAMASALES` varchar(255) DEFAULT NULL,
  `ALAMAT` varchar(255) DEFAULT NULL,
  `TELEPON` varchar(255) DEFAULT NULL,
  `EMAIL` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`KODESALES`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`KODESALES`, `NAMASALES`, `ALAMAT`, `TELEPON`, `EMAIL`) VALUES
('S-01', 'Arif Rachmanudin S.si', 'Sidomukti 56 Bandung', '022-765432', 'Arif@yahoo.com'),
('S-02', 'Bagas Ramadhan', 'Jakarta - Plumpang', '021-77665544', 'Bagas@gmail.com'),
('S-03', 'Shintia', 'Bandung Dago', '022-987654', 'Sintia_cantik@yahoo.com'),
('S-04', 'Laras', 'Sukabumi', '0243-765432', 'laras@yahoo.com'),
('S-05', 'Keshan', 'Bandung', '022-987654', 'ke2@gmail.com'),
('S-06', 'Dwiandra', 'Cianjur', '0432-99887766', 'dwi@gmail.com'),
('S-07', 'Muhidin', 'Serang Banten', '09977654', 'muhidin@plasa.com'),
('S-08', 'Almira', 'Surabaya Perak', '0643-9988776', 'almira@yahoo.co.id'),
('S-09', 'Surya Perdana', 'Caheum Bandung', '022-776654', 'surya@gmail.com'),
('S-10', 'Badra', 'Kuningan', '0232-887765', 'badra@yahoo.com');

-- --------------------------------------------------------

--
-- Table structure for table `satuan`
--

CREATE TABLE IF NOT EXISTS `satuan` (
  `KODESATUAN` varchar(255) NOT NULL DEFAULT '',
  `NAMASATUAN` varchar(255) DEFAULT NULL,
  `ISI` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`KODESATUAN`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `satuan`
--

INSERT INTO `satuan` (`KODESATUAN`, `NAMASATUAN`, `ISI`) VALUES
('ST-01', 'LUSIN', '12'),
('ST-02', 'PEACES', '1'),
('ST-03', 'KODI', '20');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `KODESUPPLIER` varchar(255) NOT NULL DEFAULT '',
  `NAMASUPPLIER` varchar(255) DEFAULT NULL,
  `ALAMAT` varchar(255) DEFAULT NULL,
  `CP` varchar(255) DEFAULT NULL,
  `TELEPON` varchar(255) DEFAULT NULL,
  `TEMPO` int(11) DEFAULT NULL,
  `PKP` tinyint(4) DEFAULT NULL,
  `NPWP` varchar(255) DEFAULT NULL,
  `BANK` varchar(255) DEFAULT NULL,
  `ACCOUNTNUMBER` varchar(255) DEFAULT NULL,
  `ATASNAMA` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`KODESUPPLIER`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`KODESUPPLIER`, `NAMASUPPLIER`, `ALAMAT`, `CP`, `TELEPON`, `TEMPO`, `PKP`, `NPWP`, `BANK`, `ACCOUNTNUMBER`, `ATASNAMA`) VALUES
('SS-01', 'PT FAMILY JAYA OK', 'SIDOMUKTI 56 BANDUNG', '081220071074', '022-7766554', 4, 0, '9988776655443', 'BCA', '9845321', 'ARIF RACHMANUDIN'),
('SS-02', 'PT SUSU BENDERA', 'DAYEUH KOLOT BANDUNG', '098764532', '022-7766342', 8, 1, '906745231', 'CIMB NIAGA', '453217', 'BUDI RAHARJO'),
('SS-03', 'PT CERES', 'DAYEUH KOLOT BANDUNG', '089734521', '022-90897865', 6, 1, '9900112854', 'DANAMON', '90589643', 'SLAMET RIYADI');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
