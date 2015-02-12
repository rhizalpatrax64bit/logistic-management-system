/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50516
Source Host           : localhost:3306
Source Database       : dmx_logistic

Target Server Type    : MYSQL
Target Server Version : 50516
File Encoding         : 65001

Date: 2014-04-13 14:31:28
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `agent`
-- ----------------------------
DROP TABLE IF EXISTS `agent`;
CREATE TABLE `agent` (
  `ID_AGENT` int(11) NOT NULL AUTO_INCREMENT,
  `HANDLING_ID` int(11) DEFAULT NULL,
  `KODEAGENT` varchar(255) DEFAULT '',
  `NAMAAGENT` varchar(255) DEFAULT NULL,
  `ALAMAT` varchar(255) DEFAULT NULL,
  `CP` varchar(255) DEFAULT NULL,
  `TELEPON` varchar(255) DEFAULT NULL,
  `NPWP` varchar(255) DEFAULT NULL,
  `BANK` varchar(255) DEFAULT NULL,
  `ACCOUNTNUMBER` varchar(255) DEFAULT NULL,
  `ATASNAMA` varchar(255) DEFAULT NULL,
  `IS_AF` tinyint(1) DEFAULT NULL,
  `IS_TRUCK` tinyint(1) DEFAULT NULL,
  `IS_WH` tinyint(1) DEFAULT NULL,
  `IS_GRDH` tinyint(1) DEFAULT NULL COMMENT 'ground handlig',
  `IS_DELIVERY` tinyint(1) DEFAULT NULL,
  `IS_SHIPPING` tinyint(1) DEFAULT NULL,
  `IS_REGULATEDAGENT` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_AGENT`),
  KEY `fk_handling_` (`HANDLING_ID`),
  CONSTRAINT `fk_handling_` FOREIGN KEY (`HANDLING_ID`) REFERENCES `agenthanding` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of agent
-- ----------------------------
INSERT INTO `agent` VALUES ('1', '4', 'A01', 'DAKOTA ', 'MEDAN\r\n', '-', '-', '', '', '', '', '1', '0', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('2', '1', 'A02', 'CV AGUNG', 'MEDAN\r\n', '-', '-', '', '', '', '', '1', '0', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('3', '1', 'A03', 'ANGGA', '-', '-', '-', '', '', '', '', '1', '0', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('4', '2', 'A04', 'BATAVIA', '-', '-', '-', '', '', '', '', '1', '0', '0', '0', '1', '1', '1');
INSERT INTO `agent` VALUES ('5', '1', 'A05', 'BITTARA EXPRESS - KDI', '-', '-', '-', '', '', '', '', '1', '0', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('6', '1', 'A06', 'BITTARA EXPRESS - UPG', '-', '-', '-', '', '', '', '', '1', '0', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('7', '1', 'A07', 'BUANA CIPTA', '-', '-', '-', '', '', '', '', '1', '0', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('8', '1', 'A08', 'CIKOPOTRANS', '-', '-', '-', '', '', '', '', '0', '1', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('9', '1', 'A09', 'DALLAS', '-', '-', '-', '', '', '', '', '0', '1', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('10', '1', 'A010', 'UTAMA DUTA RAYA', '-', '-', '-', '', '', '', '', '0', '1', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('11', '1', 'A011', 'DBM BDJ', '-', '-', '-', '', '', '', '', '0', '1', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('12', '1', 'A012', 'DBM MENADO', '-', '-', '-', '', '', '', '', '0', '1', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('13', '1', 'A013', 'DBM MES', '-', '-', '-', '', '', '', '', '0', '1', '0', '0', '1', null, null);
INSERT INTO `agent` VALUES ('14', '1', 'A014', 'DBM PADANG', '-', '-', '-', '-', '', '', '', '0', '0', '1', '0', '1', null, null);
INSERT INTO `agent` VALUES ('15', '1', 'A015', 'DBM PKU', '-', '-', '-', '', '', '', '', '0', '0', '1', '0', '1', null, null);
INSERT INTO `agent` VALUES ('19', '4', 'A18', 'test', 'test', 'testRW', 'test', 'test', 'test', 'test', 'test', '1', '0', '0', '0', null, null, null);
INSERT INTO `agent` VALUES ('20', '7', 'A19', 'tst', 'est', 'test', 'test', 'stes', 'sts', 'sts', 'sss', '1', '1', '1', '1', '1', '1', '1');
INSERT INTO `agent` VALUES ('21', '6', 'A20', 'tdst', 'test', 'tes', 'tes', 'stes', 'sss', 'ss', 'sss', '0', '0', '0', '1', null, null, null);
INSERT INTO `agent` VALUES ('22', '3', 'A21', 'tsds', 'testsa', 'atata', 'da', 'adfa', 'adfa', 'adfa', 'adfa', '0', '0', '0', '0', null, null, null);
INSERT INTO `agent` VALUES ('23', '3', 'A22', 'te', 'ata', 'adad', 'adfa', 'fadsf', 'dfa', 'adfafa', 'a', '0', '0', '0', '0', null, null, null);
INSERT INTO `agent` VALUES ('24', '3', 'A23', 'tadta', 'adfad', 'dfadf', 'adfadfafd', 'adfa', 'adf', 'dfadf', 'adf', '0', '0', '0', '0', null, null, null);
INSERT INTO `agent` VALUES ('25', '5', 'A25', 'GARUDA', 'TEST', 'TEST', 'TEST', 'TEST', 'TEST', 'TEST', 'TEST', '1', '0', '0', '0', '0', '0', '0');
INSERT INTO `agent` VALUES ('26', '5', 'A26', 'BATAVIA', 'TEST', 'TEST', 'TEST', 'TEST', 'TEST', 'TEST', 'TEST', '1', '0', '0', '0', '0', '0', '0');

-- ----------------------------
-- Table structure for `agenthanding`
-- ----------------------------
DROP TABLE IF EXISTS `agenthanding`;
CREATE TABLE `agenthanding` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `KODE` varchar(255) DEFAULT NULL,
  `NAMA` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of agenthanding
-- ----------------------------
INSERT INTO `agenthanding` VALUES ('1', 'SH', 'SHIPPING');
INSERT INTO `agenthanding` VALUES ('2', 'DL', 'DELIVERY');
INSERT INTO `agenthanding` VALUES ('3', 'WH', 'WAREHOUSE');
INSERT INTO `agenthanding` VALUES ('4', 'RA', 'REGULATED AGENT');
INSERT INTO `agenthanding` VALUES ('5', 'SMU', 'SMU');
INSERT INTO `agenthanding` VALUES ('6', 'GRDH', 'GRDH');
INSERT INTO `agenthanding` VALUES ('7', 'TRK', 'TRUCKING');

-- ----------------------------
-- Table structure for `agentpricelist`
-- ----------------------------
DROP TABLE IF EXISTS `agentpricelist`;
CREATE TABLE `agentpricelist` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDAGENTHANDLING` int(11) DEFAULT NULL,
  `IDORIGIN` int(11) DEFAULT NULL,
  `IDAGENT` int(11) DEFAULT NULL,
  `IDDEST` int(11) DEFAULT NULL,
  `IDJNSKIRIM` int(11) DEFAULT NULL,
  `IDLAYANAN` int(11) DEFAULT NULL,
  `RATEHANDLING` float(11,0) DEFAULT NULL,
  `MINPAKET` float(11,0) DEFAULT NULL,
  `ISACTIVE` tinyint(1) DEFAULT NULL,
  `STARTDATE` datetime DEFAULT NULL,
  `ENDDATE` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_dest` (`IDDEST`),
  KEY `fk_jnskrm` (`IDJNSKIRIM`),
  KEY `fk_layanan_` (`IDLAYANAN`),
  KEY `fk_origin` (`IDORIGIN`),
  KEY `fk_agent` (`IDAGENT`),
  KEY `fk_ahadling` (`IDAGENTHANDLING`),
  CONSTRAINT `fk_agent` FOREIGN KEY (`IDAGENT`) REFERENCES `agent` (`ID_AGENT`),
  CONSTRAINT `fk_ahadling` FOREIGN KEY (`IDAGENTHANDLING`) REFERENCES `agenthanding` (`ID`),
  CONSTRAINT `fk_dest` FOREIGN KEY (`IDDEST`) REFERENCES `kota` (`IDKOTA`),
  CONSTRAINT `fk_jnskrm` FOREIGN KEY (`IDJNSKIRIM`) REFERENCES `modakirim` (`IDJNSKIRIM`),
  CONSTRAINT `fk_layanan_` FOREIGN KEY (`IDLAYANAN`) REFERENCES `layanan` (`IDLAYANAN`),
  CONSTRAINT `fk_origin` FOREIGN KEY (`IDORIGIN`) REFERENCES `kota` (`IDKOTA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of agentpricelist
-- ----------------------------

-- ----------------------------
-- Table structure for `area`
-- ----------------------------
DROP TABLE IF EXISTS `area`;
CREATE TABLE `area` (
  `IDAREA` int(11) NOT NULL AUTO_INCREMENT,
  `KODEAREA` varchar(4) DEFAULT NULL,
  `NAMAAREA` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDAREA`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of area
-- ----------------------------
INSERT INTO `area` VALUES ('37', 'A01', 'INDOESIA BAGIAN BARAT');
INSERT INTO `area` VALUES ('38', 'A02', 'INDONESIA BAGIAN TIMUR');

-- ----------------------------
-- Table structure for `bank`
-- ----------------------------
DROP TABLE IF EXISTS `bank`;
CREATE TABLE `bank` (
  `KODEBANK` varchar(255) NOT NULL DEFAULT '',
  `NAMABANK` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`KODEBANK`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of bank
-- ----------------------------
INSERT INTO `bank` VALUES ('B-01', 'BCA');
INSERT INTO `bank` VALUES ('B-03', 'MANDIRI');
INSERT INTO `bank` VALUES ('B-04', 'BNI');
INSERT INTO `bank` VALUES ('B-05', 'DANAMON');
INSERT INTO `bank` VALUES ('B-06', 'BANK JABAR');
INSERT INTO `bank` VALUES ('B-07', 'LIPPO');
INSERT INTO `bank` VALUES ('B-08', 'MUAMALAT');
INSERT INTO `bank` VALUES ('B-09', 'CIMB NIAGA');
INSERT INTO `bank` VALUES ('B-10', 'PUNDI');
INSERT INTO `bank` VALUES ('B-02', 'BRI');

-- ----------------------------
-- Table structure for `barang`
-- ----------------------------
DROP TABLE IF EXISTS `barang`;
CREATE TABLE `barang` (
  `KODEBARANG` varchar(255) NOT NULL DEFAULT '',
  `BARCODE` varchar(255) DEFAULT NULL,
  `NAMABARANG` varchar(255) DEFAULT NULL,
  `NAMASATUAN` varchar(255) DEFAULT NULL,
  `ISISATUAN` int(11) DEFAULT NULL,
  `KODEDEPARTMENT` varchar(255) DEFAULT NULL,
  `NAMADEPARTMENT` varchar(255) DEFAULT NULL,
  `STOK` int(11) DEFAULT NULL,
  `TOTALBARANG` int(11) DEFAULT NULL,
  `HARGABELI1` decimal(10,0) DEFAULT NULL,
  `HARGABELI2` decimal(10,0) DEFAULT NULL,
  `BRUTO` decimal(10,0) DEFAULT NULL,
  `DISKONRP1` float DEFAULT NULL,
  `DISKONRP2` float DEFAULT NULL,
  `DISKONPS1` float DEFAULT NULL,
  `DISKONPS2` float DEFAULT NULL,
  `DISKONPS3` float DEFAULT NULL,
  `DISKONPS4` float DEFAULT NULL,
  `DISKONPS5` float DEFAULT NULL,
  `PPN` int(11) DEFAULT NULL,
  `NETTO` decimal(10,0) DEFAULT NULL,
  `HARGAPOKOKBELI1` decimal(10,0) DEFAULT NULL,
  `HARGAPOKOKBELI2` decimal(10,0) DEFAULT NULL,
  `MARGINPROFIT` float DEFAULT NULL,
  `HARGAJUAL1` decimal(10,0) DEFAULT NULL,
  `HARGAJUAL2` decimal(10,0) DEFAULT NULL,
  `MARGINSPESIAL` float DEFAULT NULL,
  `HARGASPESIAL` decimal(10,0) DEFAULT NULL,
  `QTY1` int(11) DEFAULT NULL,
  `QTY2` int(11) DEFAULT NULL,
  `QTY3` int(11) DEFAULT NULL,
  `QTY4` int(11) DEFAULT NULL,
  `QTY5` int(11) DEFAULT NULL,
  `MARGIN1` float DEFAULT NULL,
  `MARGIN2` float DEFAULT NULL,
  `MARGIN3` float DEFAULT NULL,
  `MARGIN4` float DEFAULT NULL,
  `MARGIN5` float DEFAULT NULL,
  `HARGA1` decimal(10,0) DEFAULT NULL,
  `HARGA2` decimal(10,0) DEFAULT NULL,
  `HARGA3` decimal(10,0) DEFAULT NULL,
  `HARGA4` decimal(10,0) DEFAULT NULL,
  `HARGA5` decimal(10,0) DEFAULT NULL,
  `GUDANG` varchar(255) DEFAULT NULL,
  `RESET` tinyint(4) DEFAULT NULL,
  `TGLBELI` date DEFAULT NULL,
  `TGLUPDATE` date DEFAULT NULL,
  `TGLEXPIRED` date DEFAULT NULL,
  PRIMARY KEY (`KODEBARANG`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of barang
-- ----------------------------
INSERT INTO `barang` VALUES ('001300913132012', '089686530025', 'PROMINA BB BRS MRH120GR', 'LUSIN', '12', '001', 'SUSU/MAKANAN/BUBUR BAYI', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('001300913132038', '089686530124', 'PROMINA BB KC HJ 120GR', 'LUSIN', '12', '001', 'SUSU/MAKANAN/BUBUR BAYI', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('001300913132101', '089686542431', 'PROMINA BT ATI AYM 25GR', 'LUSIN', '12', '001', 'SUSU/MAKANAN/BUBUR BAYI', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('001300913132143', '896865351506', 'SUN KC HIJAU  EKO 120GR', 'LUSIN', '12', '001', 'SUSU/MAKANAN/BUBUR BAYI', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('002300913111902', '8998009010248', 'ULTRA MILK STROBERI', 'LUSIN', '12', '002', 'SUSU DEWASA/KALSIUM/IH/IM', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('005300913130951', '8992628034142', 'BIMOLI SPESIAL 1L/B', 'KODI', '20', '005', 'MINYAK GORENG/GULA BERMERK/ABN', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('006300913130826', '089686017700', 'SARIMI AYM EKS BWG 70GR', 'LUSIN', '12', '006', 'MIE/BIHUN/TEPUNG/GANDUM/BERAS', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('009300913130651', '8991002101104', 'ABC KOPI BROWNIS 30GR', 'LUSIN', '12', '009', 'SEREAL SARAPAN/KOPI/KOPSUS/TEH', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('009300913130746', '8991002103832', 'GOOD DAY CHOCOCINO 20GR', 'LUSIN', '12', '009', 'SEREAL SARAPAN/KOPI/KOPSUS/TEH', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('010300913132238', '089686400854', 'INDOFOOD SMBL XPDS275ML', 'LUSIN', '12', '010', 'BUMBU DPR/BHN KUE/SARDEN/KRNT', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('010300913132302', '089686385816', 'INDOFOOD MAGIC LZT 8GR', 'LUSIN', '12', '010', 'BUMBU DPR/BHN KUE/SARDEN/KRNT', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('010300913132558', '089686440430', 'IF BUMBU RENDANG 45g', 'LUSIN', '12', '010', 'BUMBU DPR/BHN KUE/SARDEN/KRNT', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('011300913130304', '8996001600146', 'TEH PUCUK HARUM', 'LUSIN', '12', '011', 'MINUMAN RINGAN/SERBUK/SUPLEMEN', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('016300913132400', '8998866600552', 'SOKLIN LNT MINT 400ML/R', 'LUSIN', '12', '016', 'PEMBERSIH/PNGHRM KACA/LANTAI', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('019300913132631', '8993189271632', 'MAMY POPO BABY WIPES', 'LUSIN', '12', '019', 'KAPAS/TISU/PEMBALUT/POPOK/CB', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('021300913130131', '8991906101057', 'LA LIGHTS MERAH', 'LUSIN', '12', '021', 'ROKOK', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('026300913132708', '8998866100557', 'EMERON SHP B SHINE 90ML', 'LUSIN', '12', '026', 'SABUN MANDI BATANG/CAIR/HAND', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('053300913131938', '8998866601436', 'DAIA BUNGA 900GR', 'LUSIN', '12', '053', 'DETERJEN BUBUK/KRIM/BTANGAN', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('053300913132123', '8998866602600', 'SOKLIN POWER DET 900GR', 'LUSIN', '12', '053', 'DETERJEN BUBUK/KRIM/BTANGAN', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('053300913132217', '8998866602822', 'SOKLIN POWER SCH 59GR', 'LUSIN', '12', '053', 'DETERJEN BUBUK/KRIM/BTANGAN', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');
INSERT INTO `barang` VALUES ('053300913132333', '8998866182218', 'MAMA LEMON 400ML/R', 'LUSIN', '12', '053', 'DETERJEN BUBUK/KRIM/BTANGAN', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '', '0', '2013-09-30', '0001-01-01', '0001-01-01');

-- ----------------------------
-- Table structure for `barangpromo`
-- ----------------------------
DROP TABLE IF EXISTS `barangpromo`;
CREATE TABLE `barangpromo` (
  `KODEPROMO` varchar(255) NOT NULL DEFAULT '',
  `NAMAPROMO` varchar(255) DEFAULT NULL,
  `BARCODE` varchar(255) DEFAULT NULL,
  `HARGAPOKOK` decimal(10,0) DEFAULT NULL,
  `MARGINPROFIT` float DEFAULT NULL,
  `HARGAJUAL` decimal(10,0) DEFAULT NULL,
  `QTY` int(11) DEFAULT NULL,
  PRIMARY KEY (`KODEPROMO`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of barangpromo
-- ----------------------------
INSERT INTO `barangpromo` VALUES ('B-01', 'PEPSODENT', '1324536789', '5000', '0', '5300', '6');
INSERT INTO `barangpromo` VALUES ('B-02', 'MARGARIN', '2221113344', '5000', '0', '5400', '10');
INSERT INTO `barangpromo` VALUES ('B-03', 'SARIMI', '332241236547', '2300', '0', '2500', '30');
INSERT INTO `barangpromo` VALUES ('B-04', 'LA MERAH LIGHTS ', '88776654243', '11500', '0', '12000', '8');
INSERT INTO `barangpromo` VALUES ('B-05', 'SUSU BENDERA', '33112254321', '45000', '0', '47000', '6');
INSERT INTO `barangpromo` VALUES ('B-06', 'L-MEN', '88745634251', '40000', '0', '45000', '7');
INSERT INTO `barangpromo` VALUES ('B-07', 'POP MIE', '99885635342', '5500', '0', '6000', '8');

-- ----------------------------
-- Table structure for `biaya`
-- ----------------------------
DROP TABLE IF EXISTS `biaya`;
CREATE TABLE `biaya` (
  `IDBIAYA` int(11) NOT NULL AUTO_INCREMENT,
  `FEEMARKETING` float(11,0) DEFAULT NULL,
  `REFUNDCUST` float(11,0) DEFAULT NULL,
  `GDH` float(11,0) DEFAULT NULL,
  `AFSMU` float(11,0) DEFAULT NULL,
  `TRUCKING` float(11,0) DEFAULT NULL,
  `DELIVERY` float(11,0) DEFAULT NULL,
  `SEAFREIGHT` float(11,0) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`IDBIAYA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of biaya
-- ----------------------------

-- ----------------------------
-- Table structure for `customer`
-- ----------------------------
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `IDCUSTOMER` int(11) NOT NULL AUTO_INCREMENT,
  `KODECUSTOMER` varchar(255) NOT NULL DEFAULT '',
  `NAMACUSTOMER` varchar(255) DEFAULT NULL,
  `ALAMAT` varchar(255) DEFAULT NULL,
  `TELEPON` varchar(255) DEFAULT NULL,
  `HP` varchar(255) DEFAULT NULL,
  `EMAIL` varchar(255) DEFAULT NULL,
  `IDMARKETING` int(11) DEFAULT NULL,
  PRIMARY KEY (`IDCUSTOMER`),
  KEY `FK_MRK` (`IDMARKETING`),
  CONSTRAINT `FK_MRK` FOREIGN KEY (`IDMARKETING`) REFERENCES `marketing` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of customer
-- ----------------------------
INSERT INTO `customer` VALUES ('1', 'C01', 'AM-PM', '-', '-', '-', '-', '2');
INSERT INTO `customer` VALUES ('2', 'C02', 'ACADE MASTER', '-', '-', '-', '', '3');
INSERT INTO `customer` VALUES ('3', 'C03', 'Andy', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('4', 'C04', 'APIP', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('5', 'C05', 'Arafah', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('6', 'C06', 'Aris', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('7', 'C07', 'Actual Pro', '-', '-', '-', '', '2');
INSERT INTO `customer` VALUES ('8', 'C08', 'AIRPLANE', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('9', 'C09', 'AMI\r\n', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('10', 'C10', 'Bayu', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('11', 'C11', 'BLACK HELL', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('12', 'C12', 'Beauty Green', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('13', 'C13', 'Bundar', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('14', 'C14', 'C-59', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('15', 'C15', 'CV. Bi Ensi', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('16', 'C16', 'CV HERBATAMA', '-', '-', '-', '', '6');
INSERT INTO `customer` VALUES ('17', 'C17', 'CV V NAT', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('18', 'C18', 'Dedi\r\n', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('19', 'C19', 'Demuse', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('20', 'C20', 'Dead Seventy', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('21', 'C21', 'Dewa\r\nDewa\r\n', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('22', 'C22', 'Endang\r\n', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('23', 'C23', 'Effex', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('24', 'C24', 'Evil Army', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('25', 'C25', 'Epidemic', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('26', 'C26', 'Fajri', '-', '-', '-', null, '1');
INSERT INTO `customer` VALUES ('27', 'C27', 'Flea Magic', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('28', 'C28', 'Flo', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('29', 'C29', 'Freaky Famous\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('30', 'C30', 'GREYSIDE', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('31', 'C31', 'Humaniora', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('32', 'C32', 'Hessa Corp', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('33', 'C33', 'Insider\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('34', 'C34', 'JakGos Group', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('35', 'C35', 'Johan\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('36', 'C36', 'Lia', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('37', 'C37', 'Lunatic', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('38', 'C38', 'Matius', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('39', 'C39', 'MBT\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('40', 'C40', 'Meri', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('41', 'C41', 'Mira\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('42', 'C42', 'Mitra Promo\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('43', 'C43', 'Mulia Konveksi\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('44', 'C44', 'Mugabe\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('45', 'C45', 'MW\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('46', 'C46', 'Neps\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('47', 'C47', 'Ozy\r\n', '-', '-', '-', null, null);
INSERT INTO `customer` VALUES ('48', 'C48', 'MTI', '-', '-', '-', 'GHGHGHGHGH', '2');

-- ----------------------------
-- Table structure for `detailstt`
-- ----------------------------
DROP TABLE IF EXISTS `detailstt`;
CREATE TABLE `detailstt` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDINVOICE` int(11) DEFAULT NULL,
  `IDCUSTOMER` int(11) DEFAULT NULL,
  `NOCONNOTE` varchar(255) DEFAULT NULL,
  `TGLCONNOTE` date DEFAULT NULL,
  `TGLMANIFEST` date DEFAULT NULL,
  `NOACCOUNT` varchar(255) DEFAULT NULL,
  `NOREFERENSI` varchar(255) DEFAULT NULL,
  `CONSIGNEE` varchar(255) DEFAULT NULL,
  `PHONE` varchar(255) DEFAULT NULL,
  `FAX` varchar(255) DEFAULT NULL,
  `ALAMAT` varchar(255) DEFAULT NULL,
  `IDSTATUSSTT` int(11) DEFAULT NULL,
  `IDSERVICE` int(11) DEFAULT NULL,
  `IDHANDLING` int(11) DEFAULT NULL,
  `IDORIGIN` int(11) DEFAULT NULL,
  `IDDESC` int(11) DEFAULT NULL,
  `PCS` float(11,0) DEFAULT NULL,
  `WEIGHT` float(11,0) DEFAULT NULL,
  `WEIGHTDIM` float(11,0) DEFAULT NULL,
  `DIM_P` float(11,0) DEFAULT NULL,
  `DIM_L` float(11,0) DEFAULT NULL,
  `DIM_T` float(11,0) DEFAULT NULL,
  `RATE_KIRIM` float(11,0) DEFAULT NULL,
  `CHARGE_KIRIM` float(11,0) DEFAULT NULL,
  `CHARGE_DIM` float(11,0) DEFAULT NULL,
  `PPNPERCENT` float(11,0) DEFAULT NULL,
  `PPN` float(11,0) DEFAULT NULL,
  `INSURANCE` float(11,0) DEFAULT NULL,
  `INCURANCEPERCENT` decimal(11,2) DEFAULT NULL,
  `NBARANGINSURANCE` float(11,0) DEFAULT NULL,
  `PACKING` float(11,0) DEFAULT NULL,
  `IDTERUSAN` int(11) DEFAULT NULL,
  `CHARGE_TERUSAN` float(11,0) DEFAULT NULL,
  `NOSMU` varchar(255) DEFAULT NULL,
  `IDMARKETING` int(11) DEFAULT NULL,
  `IDA_SHIPPING` int(11) DEFAULT NULL,
  `IDA_DELIVERY` int(11) DEFAULT NULL,
  `IDA_WAREHOUSE` int(11) DEFAULT NULL,
  `IDA_RA` int(11) DEFAULT NULL,
  `IDA_TRUCKING` int(11) DEFAULT NULL,
  `IDA_SMU` int(11) DEFAULT NULL,
  `IDA_GRDH` int(11) DEFAULT NULL,
  `COST_SHIPPING` float(11,0) DEFAULT NULL,
  `COST_DELIVERY` float(11,0) DEFAULT NULL,
  `COST_TRUCKING` float(11,0) DEFAULT NULL,
  `COST_WAREHOUSE` float(11,0) DEFAULT NULL,
  `COST_RA` float(11,0) DEFAULT NULL,
  `COST_SMU` float(11,0) DEFAULT NULL,
  `COST_GRDH` float(11,0) DEFAULT NULL,
  `COST_FEEMARKETING` float(11,0) DEFAULT NULL,
  `COST_REFUNDCUST` float(11,0) DEFAULT NULL,
  `IDSTATUSBAYAR` int(11) DEFAULT NULL,
  `TOTAL_CHARGE` float(11,0) DEFAULT NULL,
  `TOTAL_COST` float(11,0) DEFAULT NULL,
  `TOTAL_PROFIT` float(11,0) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=145 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of detailstt
-- ----------------------------
INSERT INTO `detailstt` VALUES ('135', '96', '1', '234556', '2014-02-05', '2014-02-05', '', '', 'andri', '08191', '', 'bandung', '2', '1', '1', '54', '38', '23', '32', '0', '0', '0', '0', '19000', '608000', '0', '10', '60800', '3500', '0.35', '1000000', '1000000', null, '0', '', '2', '1', '1', '1', '1', '1', '1', '1', '64000', '41600', null, '48000', '57600', '57600', '51200', '0', '0', '1', '1672300', '384000', '1288300');
INSERT INTO `detailstt` VALUES ('136', null, '1', '234214', '2014-02-06', '2014-02-06', '', '', 'Riki', '081910115911', '', 'banjar', '3', '1', '1', '54', '38', '234', '50', '0', '0', '0', '0', '19000', '950000', '0', '0', '0', '0', '0.00', '0', '0', null, '0', 'xxxxx', '2', null, null, null, null, null, '1', null, '0', '0', null, '0', '0', '97500', '0', '0', '0', '1', '950000', '0', '0');
INSERT INTO `detailstt` VALUES ('137', '97', '1', '45324532', '2014-02-06', '2014-02-06', '', '', 'Riki', '081910115911', '', 'banjar', '2', '1', '1', '54', '38', '34', '50', '0', '0', '0', '0', '19000', '950000', '0', '0', '0', '0', '0.00', '0', '0', null, '0', 'ssdfsdf', '2', null, null, null, null, null, '1', null, '0', '0', null, '0', '0', '75000', '0', '0', '0', '1', '950000', '75000', '20000');
INSERT INTO `detailstt` VALUES ('138', '98', '2', '3463733453', '2014-02-06', '2014-02-06', '', '', 'TEST UDARA D2D', '-', '-', 'MATARAM', '2', '1', '1', '54', '17', '34', '67', '0', '0', '0', '0', '21500', '1440500', '0', '0', '0', '0', '0.00', '0', '0', null, '0', '', '3', null, null, null, null, null, null, null, '0', '0', null, '0', '0', '0', '0', '0', '0', '1', '1440500', '0', '0');
INSERT INTO `detailstt` VALUES ('139', '99', '1', '4652354245', '2014-02-08', '2014-02-08', '', '', 'MAMAN', '081232142', '', '', '2', '1', '1', '54', '17', '23', '45', '0', '0', '0', '0', '21500', '967500', '0', '10', '96750', '0', '0.00', '0', '2000000', '8', '0', 'XXX', '2', null, null, null, null, null, null, null, '0', '0', null, '0', '0', '0', '0', '0', '0', '1', '3064250', '0', '0');
INSERT INTO `detailstt` VALUES ('140', '103', '1', '64534573623', '2014-02-08', '2014-02-08', '', '', 'TARJO', '012345', '--', '-', '2', '1', '2', '18', '19', '34', '50', '0', '0', '0', '0', '26000', '1300000', '0', '0', '0', '0', '0.00', '0', '0', '10', '0', '', '2', null, null, null, null, null, null, null, '1000', '1000', null, '1000', '1000', '1000', '1000', '1000', '1000', '1', '1300000', '9000', '1291000');
INSERT INTO `detailstt` VALUES ('141', null, '3', '3333', '2014-02-13', '2014-02-14', '', '', 'andri', '08191', '-', 'bandung', '1', '1', '1', '54', '17', '23', '60', '0', '0', '0', '0', '21500', '1290000', '0', '0', '0', '0', '0.00', '0', '0', '9', '0', '', '1', null, null, null, null, null, null, null, '0', '0', null, '0', '0', '0', '0', '0', '0', '1', '1290000', '0', '0');
INSERT INTO `detailstt` VALUES ('142', '98', '1', 'tesdtst', '2014-02-15', '2014-02-15', '', '', 'a', 'a', '-', 'a', '2', '1', '1', '54', '17', '0', '10', '0', '0', '0', '0', '280000', '2800000', '0', '0', '0', '0', '0.00', '0', '0', '8', '0', '', '2', null, null, null, null, null, null, null, '0', '0', null, '0', '0', '0', '0', '0', '1000000', '1', '2800000', '1000000', '7960000');
INSERT INTO `detailstt` VALUES ('143', null, '3', 'test', '2014-02-16', '2014-02-16', '', '', 'Riki', '081910115911', '-', 'banjar', '1', '1', '1', '54', '19', '23', '60', '0', '0', '0', '0', '25000', '1500000', '0', '0', '0', '0', '0.00', '0', '0', '10', '0', 'xcxv', '1', null, null, null, null, null, '26', null, '0', '0', null, '0', '0', '300000', '0', '0', '0', '1', '1500000', '300000', '1200000');
INSERT INTO `detailstt` VALUES ('144', '99', '1', 'TRUCKINH', '2014-02-18', '2014-02-18', '', '', 'RIKI2', 'TEST', 'TEST', 'TEST TAB', '2', '1', '1', '54', '38', '2', '56', '0', '0', '0', '0', '19000', '1064000', '0', '0', '0', '0', '0.00', '0', '0', null, '0', 'XXXX', '2', '1', '1', '1', '1', '1', '26', '1', '112000', '70000', '60000', '84000', '100800', '100800', '89600', '0', '0', '1', '1064000', '617200', '446800');

-- ----------------------------
-- Table structure for `gudang`
-- ----------------------------
DROP TABLE IF EXISTS `gudang`;
CREATE TABLE `gudang` (
  `KODEGUDANG` varchar(255) NOT NULL DEFAULT '',
  `NAMAGUDANG` varchar(255) DEFAULT NULL,
  `KETERANGAN` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`KODEGUDANG`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of gudang
-- ----------------------------
INSERT INTO `gudang` VALUES ('BG-01', 'GUDANG 1', '');
INSERT INTO `gudang` VALUES ('BG-02', 'GUDANG 2', '');
INSERT INTO `gudang` VALUES ('BG-03', 'GUDANG 3', '');
INSERT INTO `gudang` VALUES ('BG-04', 'GUDANG 4', '');
INSERT INTO `gudang` VALUES ('fsfd', 'fs', 'sdfs');
INSERT INTO `gudang` VALUES ('dfa', 'adgfa', 'adfga');

-- ----------------------------
-- Table structure for `invoice`
-- ----------------------------
DROP TABLE IF EXISTS `invoice`;
CREATE TABLE `invoice` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TGLINVOICE` date DEFAULT NULL,
  `KODEINVOICE` varchar(255) DEFAULT NULL,
  `IDCUSTOMER` int(11) DEFAULT NULL,
  `REF_TCHARGE` float(11,0) DEFAULT NULL,
  `REF_TCOST` float(11,0) DEFAULT NULL,
  `KETERANGAN` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_CUST` (`IDCUSTOMER`),
  KEY `KODEINVOICE` (`KODEINVOICE`),
  CONSTRAINT `FK_CUST` FOREIGN KEY (`IDCUSTOMER`) REFERENCES `customer` (`IDCUSTOMER`)
) ENGINE=InnoDB AUTO_INCREMENT=100 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of invoice
-- ----------------------------
INSERT INTO `invoice` VALUES ('96', '2014-02-05', 'C01/DMX/1/02/14', '1', '0', '0', 'tetst');
INSERT INTO `invoice` VALUES ('97', '2014-02-01', 'C01/DMX/2/02/14', '1', '0', '0', 'invoice 2');
INSERT INTO `invoice` VALUES ('98', '2014-02-01', 'C01/DMX/3/02/14', '1', '0', '0', 'test');
INSERT INTO `invoice` VALUES ('99', '2014-02-01', 'C01/DMX/4/02/14', '1', '0', '0', 'test');

-- ----------------------------
-- Table structure for `invoicequeue`
-- ----------------------------
DROP TABLE IF EXISTS `invoicequeue`;
CREATE TABLE `invoicequeue` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TGLINVOICE` date DEFAULT NULL,
  `NOURUT` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of invoicequeue
-- ----------------------------
INSERT INTO `invoicequeue` VALUES ('1', '2013-11-18', '1');
INSERT INTO `invoicequeue` VALUES ('2', '2013-11-18', '2');
INSERT INTO `invoicequeue` VALUES ('3', '2014-11-01', '1');

-- ----------------------------
-- Table structure for `jenisbayar`
-- ----------------------------
DROP TABLE IF EXISTS `jenisbayar`;
CREATE TABLE `jenisbayar` (
  `IDJENISBAYAR` int(11) NOT NULL AUTO_INCREMENT,
  `KODEJENISBAYAR` varchar(255) DEFAULT NULL,
  `NAMAJENISBAYAR` varchar(255) DEFAULT NULL,
  `ARUS` int(1) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDJENISBAYAR`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of jenisbayar
-- ----------------------------
INSERT INTO `jenisbayar` VALUES ('1', 'UANG MUKA', 'Pembayaran DP', '0', '2013-11-01 15:05:35', null, '2014-01-15 09:21:37', null);
INSERT INTO `jenisbayar` VALUES ('2', 'SISA INVOICE', 'Pemabayaran Sisa Invoice', '0', '2013-11-01 15:05:56', null, '2014-01-15 09:21:46', null);
INSERT INTO `jenisbayar` VALUES ('3', 'PELUNASAN', 'Pembayaran Pelunasan', '0', '2013-11-01 15:06:22', null, '2014-01-15 09:21:53', null);
INSERT INTO `jenisbayar` VALUES ('4', 'PEMBAYARAN BIAYA ', 'Pembayaran Biaya ', '1', null, null, null, null);

-- ----------------------------
-- Table structure for `kota`
-- ----------------------------
DROP TABLE IF EXISTS `kota`;
CREATE TABLE `kota` (
  `IDKOTA` int(11) NOT NULL AUTO_INCREMENT,
  `IDAREA` int(11) DEFAULT NULL,
  `KODEKOTA` varchar(255) DEFAULT NULL,
  `NAMAKOTA` varchar(255) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDKOTA`),
  KEY `FK_AREA` (`IDAREA`),
  CONSTRAINT `FK_AREA` FOREIGN KEY (`IDAREA`) REFERENCES `area` (`IDAREA`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of kota
-- ----------------------------
INSERT INTO `kota` VALUES ('17', '37', 'BDJ', 'BANJARMASIN', null, null, null, null);
INSERT INTO `kota` VALUES ('18', '37', 'BKS', 'BENGKULU', null, null, null, null);
INSERT INTO `kota` VALUES ('19', '37', 'BPN', 'BALIKPAPAN', null, null, null, null);
INSERT INTO `kota` VALUES ('20', '37', 'BTJ', 'BANDA ACEH', null, null, null, null);
INSERT INTO `kota` VALUES ('21', '37', 'BTH', 'BATAM', null, null, null, null);
INSERT INTO `kota` VALUES ('22', '37', 'DTB', 'JAMBI', null, null, null, null);
INSERT INTO `kota` VALUES ('23', '37', 'JOG', 'JOGJA', null, null, null, null);
INSERT INTO `kota` VALUES ('24', '37', 'LMP', 'LAMPUNG', null, null, null, null);
INSERT INTO `kota` VALUES ('25', '37', 'MEDAN', 'MES', null, null, null, null);
INSERT INTO `kota` VALUES ('26', '37', 'MLG', 'MALANG', null, null, null, null);
INSERT INTO `kota` VALUES ('27', '37', 'PDG', 'PADANG', null, null, null, null);
INSERT INTO `kota` VALUES ('28', '37', 'PKG', 'PANGKAL PINANG', null, null, null, null);
INSERT INTO `kota` VALUES ('29', '37', 'PKU', 'PEKANBARU', null, null, null, null);
INSERT INTO `kota` VALUES ('30', '37', 'PKY', 'PALANGKARAYA', null, null, null, null);
INSERT INTO `kota` VALUES ('31', '37', 'PLM', 'PALEMBANG', null, null, null, null);
INSERT INTO `kota` VALUES ('32', '37', 'PNK', 'PONTIANAK', null, null, null, null);
INSERT INTO `kota` VALUES ('33', '37', 'SMD', 'SAMARINDA', null, null, null, null);
INSERT INTO `kota` VALUES ('34', '37', 'SUB', 'SURABAYA', null, null, null, null);
INSERT INTO `kota` VALUES ('35', '37', 'SOC', 'SOLO', null, null, null, null);
INSERT INTO `kota` VALUES ('36', '37', 'TNJ', 'TANJUNG PINGAN', null, null, null, null);
INSERT INTO `kota` VALUES ('37', '37', 'TRK', 'TARAKAN', null, null, null, null);
INSERT INTO `kota` VALUES ('38', '38', 'AMI', 'MATARAM', null, null, null, null);
INSERT INTO `kota` VALUES ('39', '38', 'AMQ', 'AMBON', null, null, null, null);
INSERT INTO `kota` VALUES ('40', '38', 'BIK', 'BIAK', null, null, null, null);
INSERT INTO `kota` VALUES ('41', '38', 'DJJ', 'JAYAPURA', null, null, null, null);
INSERT INTO `kota` VALUES ('42', '38', 'DPS', 'DENPASAR', null, null, null, null);
INSERT INTO `kota` VALUES ('43', '38', 'GTO', 'GORONTALO', null, null, null, null);
INSERT INTO `kota` VALUES ('44', '38', 'KDI', 'KENDARI', null, null, null, null);
INSERT INTO `kota` VALUES ('45', '38', 'KOE', 'KUPANG', null, null, null, null);
INSERT INTO `kota` VALUES ('46', '38', 'LUX', 'LUWUK', null, null, null, null);
INSERT INTO `kota` VALUES ('47', '38', 'MDC', 'MANADO', null, null, null, null);
INSERT INTO `kota` VALUES ('48', '38', 'MKW', 'MANOKWARI', null, null, null, null);
INSERT INTO `kota` VALUES ('49', '38', 'PLW', 'PALU', null, null, null, null);
INSERT INTO `kota` VALUES ('50', '38', 'SOQ', 'SORONG', null, null, null, null);
INSERT INTO `kota` VALUES ('51', '38', 'TIM', 'TIMIKA', null, null, null, null);
INSERT INTO `kota` VALUES ('52', '38', 'TTE', 'TERNATE', null, null, null, null);
INSERT INTO `kota` VALUES ('53', '38', 'UPG', 'MAKASAR', null, null, null, null);
INSERT INTO `kota` VALUES ('54', '37', 'BDO', 'BANDUNG', null, null, null, null);
INSERT INTO `kota` VALUES ('55', '37', 'TKG', 'TANJUNG KARANG', null, null, null, null);

-- ----------------------------
-- Table structure for `layanan`
-- ----------------------------
DROP TABLE IF EXISTS `layanan`;
CREATE TABLE `layanan` (
  `IDLAYANAN` int(11) NOT NULL AUTO_INCREMENT,
  `KODELAYANAN` varchar(255) DEFAULT NULL,
  `NAMALAYANAN` varchar(255) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDLAYANAN`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of layanan
-- ----------------------------
INSERT INTO `layanan` VALUES ('1', 'D TO D', 'DOOR TO DOOR', '2013-11-01 14:33:14', null, '2014-01-12 08:57:23', null);
INSERT INTO `layanan` VALUES ('2', 'D TO P', 'DOOR TO PORT', '2013-11-01 14:33:34', null, '2014-01-12 08:57:36', null);
INSERT INTO `layanan` VALUES ('3', 'P TO P', 'PORT TO PORT', '2013-11-01 14:33:47', null, '2014-01-12 08:57:47', null);
INSERT INTO `layanan` VALUES ('4', 'P TO D', 'PORT TO DOOR', '2013-11-01 14:34:04', null, '2014-01-12 08:57:52', null);

-- ----------------------------
-- Table structure for `loginhistory`
-- ----------------------------
DROP TABLE IF EXISTS `loginhistory`;
CREATE TABLE `loginhistory` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `iduser` int(11) DEFAULT NULL,
  `level` varchar(255) DEFAULT NULL,
  `tgllogin` datetime DEFAULT NULL,
  `ipaddress` varchar(255) DEFAULT NULL,
  `islogin` tinyint(1) DEFAULT NULL,
  `tgllogout` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_user` (`iduser`),
  CONSTRAINT `fk_user` FOREIGN KEY (`iduser`) REFERENCES `user` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of loginhistory
-- ----------------------------

-- ----------------------------
-- Table structure for `marketing`
-- ----------------------------
DROP TABLE IF EXISTS `marketing`;
CREATE TABLE `marketing` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `KODE` varchar(255) DEFAULT '',
  `NAMA` varchar(255) DEFAULT NULL,
  `ALAMAT` varchar(255) DEFAULT NULL,
  `TELEPON` varchar(255) DEFAULT NULL,
  `EMAIL` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of marketing
-- ----------------------------
INSERT INTO `marketing` VALUES ('1', 'M01', 'GERRY', '-', '-', '-');
INSERT INTO `marketing` VALUES ('2', 'M02', 'UTENG\r\n', '-', '-', '-');
INSERT INTO `marketing` VALUES ('3', 'M03', 'TEDDY R', '-', '-', '-');
INSERT INTO `marketing` VALUES ('4', 'M04', 'WISNU', '-', '-', '-');
INSERT INTO `marketing` VALUES ('5', 'M05', 'RUDI\r\n', '-', '-', '-');
INSERT INTO `marketing` VALUES ('6', 'M06', 'ANDRI', '-', '-', '-');
INSERT INTO `marketing` VALUES ('7', 'M07', 'DINA\r\nDINA', '-', '-', '-');

-- ----------------------------
-- Table structure for `metodebayar`
-- ----------------------------
DROP TABLE IF EXISTS `metodebayar`;
CREATE TABLE `metodebayar` (
  `IDMETODEBAYAR` int(11) NOT NULL AUTO_INCREMENT,
  `METODEBAYAR` varchar(255) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` varchar(0) DEFAULT NULL,
  `UPDATED_BY` varchar(0) DEFAULT NULL,
  PRIMARY KEY (`IDMETODEBAYAR`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of metodebayar
-- ----------------------------
INSERT INTO `metodebayar` VALUES ('1', 'CASH', '2013-11-01 19:30:12', null, null, null);
INSERT INTO `metodebayar` VALUES ('2', 'TRANSFER', '2013-11-01 19:30:21', null, null, null);

-- ----------------------------
-- Table structure for `modakirim`
-- ----------------------------
DROP TABLE IF EXISTS `modakirim`;
CREATE TABLE `modakirim` (
  `IDJNSKIRIM` int(11) NOT NULL AUTO_INCREMENT,
  `KODEJNSKIRIM` varchar(255) DEFAULT NULL,
  `NAMAJNSKIRIM` varchar(255) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDJNSKIRIM`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of modakirim
-- ----------------------------
INSERT INTO `modakirim` VALUES ('1', 'A/F', 'UDARA', '2013-11-01 14:38:22', null, '2014-01-19 11:19:49', null);
INSERT INTO `modakirim` VALUES ('2', 'D/R', 'DARAT', '2013-11-01 14:38:30', null, '2014-01-19 11:19:52', null);
INSERT INTO `modakirim` VALUES ('3', 'L/U', 'LAUT', '2013-11-01 14:38:46', null, '2014-01-19 11:19:57', null);

-- ----------------------------
-- Table structure for `penerima`
-- ----------------------------
DROP TABLE IF EXISTS `penerima`;
CREATE TABLE `penerima` (
  `IDPENERIMA` int(11) NOT NULL AUTO_INCREMENT,
  `KODEPENERIMA` varchar(255) NOT NULL DEFAULT '',
  `NAMAPENERIMA` varchar(255) DEFAULT NULL,
  `ALAMAT` varchar(255) DEFAULT NULL,
  `TELEPON` varchar(255) DEFAULT NULL,
  `FAX` varchar(255) DEFAULT NULL,
  `HP` varchar(255) DEFAULT NULL,
  `EMAIL` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDPENERIMA`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of penerima
-- ----------------------------
INSERT INTO `penerima` VALUES ('48', 'P01', 'MAMAN', '-', '-', '-', '081232142', '-');
INSERT INTO `penerima` VALUES ('49', 'P02', 'TARJO', '-', '-', '--', '012345', '-');
INSERT INTO `penerima` VALUES ('50', '', 'Riki', 'banjar', '022901', '-', '081910115911', 'mricky.it@gmail.com');
INSERT INTO `penerima` VALUES ('51', '', 'andri', 'bandung', '02211231', '-', '08191', '-');
INSERT INTO `penerima` VALUES ('52', '', 'a', 'a', 'a', '-', 'a', 'a');
INSERT INTO `penerima` VALUES ('53', '', 'FAX', 'FAX', 'FAX', 'FAX', 'FAX', 'FAX');
INSERT INTO `penerima` VALUES ('54', '', 'TEST UDARA D2D', 'MATARAM', '-', '-', '-', '-');
INSERT INTO `penerima` VALUES ('56', '', 'RIKI2', 'TEST TAB', 'TEST', 'TEST', 'TEST', 'TEST');
INSERT INTO `penerima` VALUES ('58', '', 'testupdate', 'testupdate', 'testupdate', 'testupdate', 'testupdate', 'testupdate');

-- ----------------------------
-- Table structure for `pricelist`
-- ----------------------------
DROP TABLE IF EXISTS `pricelist`;
CREATE TABLE `pricelist` (
  `IDPRICELIST` int(11) NOT NULL AUTO_INCREMENT,
  `IDCUSTOMER` int(11) DEFAULT NULL,
  `IDLAYANAN` int(11) DEFAULT NULL,
  `KOTAASAL` int(11) DEFAULT NULL,
  `IDKOTA` int(11) DEFAULT NULL,
  `IDTERUSAN` int(11) DEFAULT '0',
  `IDHANDLING` int(11) DEFAULT NULL,
  `CHARGE/KG` float(11,0) DEFAULT NULL,
  `RC/KG` float(11,0) DEFAULT NULL,
  `DURASIWAKTU` varchar(255) DEFAULT NULL,
  `IDAGENT` int(11) DEFAULT NULL,
  `KETERANGAN` varchar(255) DEFAULT NULL,
  `ISAKTIF` tinyint(1) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDPRICELIST`),
  KEY `fk_layanan` (`IDLAYANAN`),
  KEY `fk_kota` (`IDKOTA`),
  KEY `fk_asal` (`KOTAASAL`),
  KEY `fk_agentss` (`IDAGENT`),
  KEY `fk_handling` (`IDHANDLING`),
  KEY `fk_cust_` (`IDCUSTOMER`),
  KEY `fk_terusan` (`IDTERUSAN`),
  CONSTRAINT `fk_agentss` FOREIGN KEY (`IDAGENT`) REFERENCES `agent` (`ID_AGENT`),
  CONSTRAINT `fk_areakota` FOREIGN KEY (`IDKOTA`) REFERENCES `kota` (`IDKOTA`),
  CONSTRAINT `fk_asal` FOREIGN KEY (`KOTAASAL`) REFERENCES `kota` (`IDKOTA`),
  CONSTRAINT `fk_cust_` FOREIGN KEY (`IDCUSTOMER`) REFERENCES `customer` (`IDCUSTOMER`),
  CONSTRAINT `fk_handling` FOREIGN KEY (`IDHANDLING`) REFERENCES `modakirim` (`IDJNSKIRIM`),
  CONSTRAINT `fk_layanan` FOREIGN KEY (`IDLAYANAN`) REFERENCES `layanan` (`IDLAYANAN`),
  CONSTRAINT `fk_terusan` FOREIGN KEY (`IDTERUSAN`) REFERENCES `terusan` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of pricelist
-- ----------------------------
INSERT INTO `pricelist` VALUES ('49', '1', '1', '54', '17', '0', '1', '21500', '0', '2 - 3 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('50', '1', '1', '54', '17', '8', '1', '30000', '0', '5 - 6 hari', null, null, '0', null, null, '2014-02-15 11:46:50', null);
INSERT INTO `pricelist` VALUES ('51', '1', '1', '54', '17', '9', '1', '25000', '0', '3 -4 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('52', '1', '1', '54', '18', '0', '1', '15500', '0', '1 - 2 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('53', '1', '1', '54', '18', '7', '1', '23000', '0', '3 - 4 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('54', '1', '1', '54', '19', '0', '1', '25000', '0', '2 - 3 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('55', '1', '1', '54', '38', '0', '1', '19000', '0', '1 - 2hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('56', '1', '1', '54', '38', '16', '1', '25000', '0', '3 - 5 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('57', '1', '1', '54', '38', '17', '1', '23500', '0', '4 - 5 hari', null, null, '1', null, null, '2014-02-03 20:53:21', null);
INSERT INTO `pricelist` VALUES ('58', '1', '1', '54', '39', '0', '1', '30000', '0', '3 - 4 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('59', '1', '1', '54', '39', '19', '1', '32000', '0', '5 - 6 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('60', '1', '1', '54', '40', '0', '1', '51000', '0', '3 - 4 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('61', '1', '1', '54', '41', '0', '1', '50000', '0', '2 - 3 hari', null, null, '1', null, null, null, null);
INSERT INTO `pricelist` VALUES ('63', '1', '1', '54', '17', '8', '1', '280000', '100000', '2-4 AHRI', null, null, '1', null, null, '2014-02-15 11:47:52', null);
INSERT INTO `pricelist` VALUES ('64', '2', '1', '54', '19', '0', '1', '15000', '10000', '2 - 3 hai', null, null, '1', null, null, null, null);

-- ----------------------------
-- Table structure for `pricelistagent`
-- ----------------------------
DROP TABLE IF EXISTS `pricelistagent`;
CREATE TABLE `pricelistagent` (
  `IDPRICELIST` int(11) NOT NULL AUTO_INCREMENT,
  `IDLAYANAN` int(11) DEFAULT NULL,
  `JNSCOST` varchar(255) DEFAULT NULL,
  `KOTAASAL` int(11) DEFAULT NULL,
  `IDKOTA` int(11) DEFAULT NULL,
  `IDTERUSAN` int(11) DEFAULT NULL,
  `IDHANDLING` int(11) DEFAULT NULL,
  `CHARGE/KG` float(11,0) DEFAULT NULL,
  `DURASIWAKTU` varchar(255) DEFAULT NULL,
  `IDAGENT` int(11) DEFAULT NULL,
  `MINIMAL` int(11) DEFAULT NULL,
  `KETERANGAN` varchar(255) DEFAULT NULL,
  `ISAKTIF` tinyint(1) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDPRICELIST`),
  KEY `fk_layanan` (`IDLAYANAN`),
  KEY `fk_kota` (`IDKOTA`),
  KEY `fk_asal` (`KOTAASAL`),
  KEY `fk_agentss` (`IDAGENT`),
  KEY `fk_handling` (`IDHANDLING`),
  KEY `fk_terusan` (`IDTERUSAN`),
  CONSTRAINT `pricelistagent_ibfk_1` FOREIGN KEY (`IDAGENT`) REFERENCES `agent` (`ID_AGENT`),
  CONSTRAINT `pricelistagent_ibfk_2` FOREIGN KEY (`IDKOTA`) REFERENCES `kota` (`IDKOTA`),
  CONSTRAINT `pricelistagent_ibfk_3` FOREIGN KEY (`KOTAASAL`) REFERENCES `kota` (`IDKOTA`),
  CONSTRAINT `pricelistagent_ibfk_5` FOREIGN KEY (`IDHANDLING`) REFERENCES `modakirim` (`IDJNSKIRIM`),
  CONSTRAINT `pricelistagent_ibfk_6` FOREIGN KEY (`IDLAYANAN`) REFERENCES `layanan` (`IDLAYANAN`),
  CONSTRAINT `pricelistagent_ibfk_7` FOREIGN KEY (`IDTERUSAN`) REFERENCES `terusan` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of pricelistagent
-- ----------------------------
INSERT INTO `pricelistagent` VALUES ('40', '1', 'FREIGHT', '54', '38', '0', '1', '1500', 'CHARGE UDARA ', '1', null, null, '1', null, null, '2014-01-27 11:30:36', null);
INSERT INTO `pricelistagent` VALUES ('42', '1', 'DELIVERY', '54', '38', '0', '1', '1300', 'test', '1', null, null, '1', null, null, '2014-02-14 18:00:11', null);
INSERT INTO `pricelistagent` VALUES ('44', '1', 'WAREHOUSING', '54', '38', '0', '2', '1500', 'WAREHOUSING', '1', null, null, '1', null, null, null, null);
INSERT INTO `pricelistagent` VALUES ('45', '1', 'GRDH', '54', '38', '0', '2', '1600', 'GDH', '1', null, null, '1', null, null, null, null);
INSERT INTO `pricelistagent` VALUES ('46', '1', 'RA', '54', '38', '0', '2', '1800', 'RA', '1', null, null, '1', null, null, null, null);
INSERT INTO `pricelistagent` VALUES ('47', '1', 'SHIPPING', '54', '38', '8', '1', '2000', 'SHIPPING', '1', null, null, '1', null, null, '2014-02-14 17:59:41', null);
INSERT INTO `pricelistagent` VALUES ('49', '1', 'FREIGHT', '54', '38', '0', '1', '25000', 'TEST', '4', null, null, '1', null, null, null, null);
INSERT INTO `pricelistagent` VALUES ('50', '1', 'SHIPPING', '54', '38', '0', '1', '40000', '', '4', null, null, '1', null, null, null, null);
INSERT INTO `pricelistagent` VALUES ('51', '1', 'FREIGHT', '54', '25', '0', '1', '25000', 'TEST', '5', null, null, '1', null, null, null, null);
INSERT INTO `pricelistagent` VALUES ('52', '1', 'DELIVERY', '54', '25', '0', '1', '35000', 'TEST', '5', null, null, '1', null, null, '2014-02-02 08:07:16', null);
INSERT INTO `pricelistagent` VALUES ('53', '1', 'DELIVERY', '54', '38', '0', '1', '0', 'test', '1', null, null, '1', null, null, '2014-02-14 18:00:00', null);
INSERT INTO `pricelistagent` VALUES ('54', '1', 'TRUCKING', '54', '38', '0', '1', '2000', 'TEST', '1', null, null, '1', null, null, null, null);
INSERT INTO `pricelistagent` VALUES ('56', '1', 'DELIVERY', '54', '18', '7', '1', '25000', '10000', '1', null, null, '1', null, null, null, null);

-- ----------------------------
-- Table structure for `refaccount`
-- ----------------------------
DROP TABLE IF EXISTS `refaccount`;
CREATE TABLE `refaccount` (
  `IDACCOUNT` int(11) NOT NULL AUTO_INCREMENT,
  `IDBANK` int(11) DEFAULT NULL,
  `NAMAACCOUNT` varchar(255) DEFAULT NULL,
  `NOACCOUNT` varchar(255) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDACCOUNT`),
  KEY `fk_bank` (`IDBANK`),
  CONSTRAINT `fk_bank` FOREIGN KEY (`IDBANK`) REFERENCES `refbank` (`IDBANK`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of refaccount
-- ----------------------------
INSERT INTO `refaccount` VALUES ('1', '2', 'PT. DWIWANTARA MUDA', '1320004801743', '2013-11-01 22:11:55', null, null, null);
INSERT INTO `refaccount` VALUES ('2', '1', 'RUDIANTO RASYID', '4381335311', '2013-11-01 22:12:41', null, null, null);

-- ----------------------------
-- Table structure for `refbank`
-- ----------------------------
DROP TABLE IF EXISTS `refbank`;
CREATE TABLE `refbank` (
  `IDBANK` int(11) NOT NULL AUTO_INCREMENT,
  `KODEBANK` varchar(255) NOT NULL DEFAULT '',
  `NAMABANK` varchar(255) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`KODEBANK`,`IDBANK`),
  KEY `IDBANK` (`IDBANK`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of refbank
-- ----------------------------
INSERT INTO `refbank` VALUES ('1', 'B-01', 'BCA', null, null, null, null);
INSERT INTO `refbank` VALUES ('1', 'B-02', 'BRI', null, null, null, null);
INSERT INTO `refbank` VALUES ('2', 'B-03', 'MANDIRI', null, null, '2013-11-01 22:06:01', null);
INSERT INTO `refbank` VALUES ('3', 'B-04', 'BNI', null, null, '2013-11-01 22:06:02', null);
INSERT INTO `refbank` VALUES ('4', 'B-05', 'DANAMON', null, null, '2013-11-01 22:06:03', null);
INSERT INTO `refbank` VALUES ('5', 'B-06', 'BANK JABAR', null, null, '2013-11-01 22:06:05', null);
INSERT INTO `refbank` VALUES ('6', 'B-07', 'LIPPO', null, null, '2013-11-01 22:06:06', null);
INSERT INTO `refbank` VALUES ('7', 'B-08', 'MUAMALAT', null, null, '2013-11-01 22:06:08', null);
INSERT INTO `refbank` VALUES ('8', 'B-09', 'CIMB NIAGA', null, null, '2013-11-01 22:06:10', null);
INSERT INTO `refbank` VALUES ('9', 'B-10', 'PUNDI', null, null, '2013-11-01 22:06:12', null);

-- ----------------------------
-- Table structure for `reports_services`
-- ----------------------------
DROP TABLE IF EXISTS `reports_services`;
CREATE TABLE `reports_services` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(256) NOT NULL,
  `description` text NOT NULL,
  `cost` decimal(11,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of reports_services
-- ----------------------------
INSERT INTO `reports_services` VALUES ('1', 'test title', 'test decription ', '3.80');
INSERT INTO `reports_services` VALUES ('2', 'test title', 'test decription ', '3.80');
INSERT INTO `reports_services` VALUES ('3', 'test title', 'test decription ', '0.80');
INSERT INTO `reports_services` VALUES ('4', 'test title', 'test decription ', '0.35');

-- ----------------------------
-- Table structure for `sales`
-- ----------------------------
DROP TABLE IF EXISTS `sales`;
CREATE TABLE `sales` (
  `KODESALES` varchar(255) NOT NULL DEFAULT '',
  `NAMASALES` varchar(255) DEFAULT NULL,
  `ALAMAT` varchar(255) DEFAULT NULL,
  `TELEPON` varchar(255) DEFAULT NULL,
  `EMAIL` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`KODESALES`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of sales
-- ----------------------------
INSERT INTO `sales` VALUES ('S-01', 'Arif Rachmanudin S.si', 'Sidomukti 56 Bandung', '022-765432', 'Arif@yahoo.com');
INSERT INTO `sales` VALUES ('S-02', 'Bagas Ramadhan', 'Jakarta - Plumpang', '021-77665544', 'Bagas@gmail.com');
INSERT INTO `sales` VALUES ('S-03', 'Shintia', 'Bandung Dago', '022-987654', 'Sintia_cantik@yahoo.com');
INSERT INTO `sales` VALUES ('S-04', 'Laras', 'Sukabumi', '0243-765432', 'laras@yahoo.com');
INSERT INTO `sales` VALUES ('S-05', 'Keshan', 'Bandung', '022-987654', 'ke2@gmail.com');
INSERT INTO `sales` VALUES ('S-06', 'Dwiandra', 'Cianjur', '0432-99887766', 'dwi@gmail.com');
INSERT INTO `sales` VALUES ('S-07', 'Muhidin', 'Serang Banten', '09977654', 'muhidin@plasa.com');
INSERT INTO `sales` VALUES ('S-08', 'Almira', 'Surabaya Perak', '0643-9988776', 'almira@yahoo.co.id');
INSERT INTO `sales` VALUES ('S-09', 'Surya Perdana', 'Caheum Bandung', '022-776654', 'surya@gmail.com');
INSERT INTO `sales` VALUES ('S-10', 'Badra', 'Kuningan', '0232-887765', 'badra@yahoo.com');

-- ----------------------------
-- Table structure for `satuan`
-- ----------------------------
DROP TABLE IF EXISTS `satuan`;
CREATE TABLE `satuan` (
  `KODESATUAN` varchar(255) NOT NULL DEFAULT '',
  `NAMASATUAN` varchar(255) DEFAULT NULL,
  `ISI` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`KODESATUAN`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of satuan
-- ----------------------------
INSERT INTO `satuan` VALUES ('ST-01', 'COLLY', '0');
INSERT INTO `satuan` VALUES ('ST-02', 'PEACES', '0');

-- ----------------------------
-- Table structure for `statusbayar`
-- ----------------------------
DROP TABLE IF EXISTS `statusbayar`;
CREATE TABLE `statusbayar` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NAMASTATUS` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of statusbayar
-- ----------------------------
INSERT INTO `statusbayar` VALUES ('1', 'PAID');
INSERT INTO `statusbayar` VALUES ('2', 'UNPAID');

-- ----------------------------
-- Table structure for `statuskirim`
-- ----------------------------
DROP TABLE IF EXISTS `statuskirim`;
CREATE TABLE `statuskirim` (
  `IDSTATUS` int(11) NOT NULL AUTO_INCREMENT,
  `KODESTATUS` varchar(255) DEFAULT NULL,
  `NAMASTATUS` varchar(255) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDSTATUS`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of statuskirim
-- ----------------------------
INSERT INTO `statuskirim` VALUES ('1', null, 'PICK-UP', '2013-11-01 14:57:08', null, null, null);
INSERT INTO `statuskirim` VALUES ('2', null, 'DELIVERY', '2013-11-01 14:57:16', null, null, null);
INSERT INTO `statuskirim` VALUES ('3', null, 'RECIEVED', '2013-11-01 14:57:44', null, null, null);

-- ----------------------------
-- Table structure for `statusstt`
-- ----------------------------
DROP TABLE IF EXISTS `statusstt`;
CREATE TABLE `statusstt` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `KODE` varchar(255) DEFAULT NULL,
  `DESC` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of statusstt
-- ----------------------------
INSERT INTO `statusstt` VALUES ('1', 'INV', 'STT YANG MASUK KE DALAM NO INVOICE YANG AKAN DICETAK');
INSERT INTO `statusstt` VALUES ('2', 'PAID', 'SUDAH DICETAK INVOICE');
INSERT INTO `statusstt` VALUES ('3', 'CASH ', 'PEMBAYARAN SECARA CASH');
INSERT INTO `statusstt` VALUES ('4', 'COLL', 'PEMBAYARAN SECARA COLLECT (AGENT DELIVERY)');

-- ----------------------------
-- Table structure for `supplier`
-- ----------------------------
DROP TABLE IF EXISTS `supplier`;
CREATE TABLE `supplier` (
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
  `JENISPRODUK` int(11) DEFAULT NULL,
  PRIMARY KEY (`KODESUPPLIER`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of supplier
-- ----------------------------
INSERT INTO `supplier` VALUES ('SS-01', 'PT FAMILY JAYA OK', 'SIDOMUKTI 56 BANDUNG', '081220071074', '022-7766554', '4', '0', '9988776655443', 'BCA', '9845321', 'ARIF RACHMANUDIN', '1');
INSERT INTO `supplier` VALUES ('SS-02', 'PT SUSU BENDERA', 'DAYEUH KOLOT BANDUNG', '098764532', '022-7766342', '8', '0', '906745231', 'CIMB NIAGA', '453217', 'BUDI RAHARJO', '2');
INSERT INTO `supplier` VALUES ('SS-03', 'PT CERES', 'DAYEUH KOLOT BANDUNG', '089734521', '022-90897865', '6', '0', '9900112854', 'DANAMON', '90589643', 'SLAMET RIYADI', '3');

-- ----------------------------
-- Table structure for `tagihan`
-- ----------------------------
DROP TABLE IF EXISTS `tagihan`;
CREATE TABLE `tagihan` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDAGENT` int(11) DEFAULT NULL,
  `TGLDATANGINV` datetime DEFAULT NULL,
  `TGLINV` datetime DEFAULT NULL,
  `NOINV` varchar(255) DEFAULT NULL,
  `JUMLAHTAGIHAN` float(11,0) DEFAULT NULL,
  `KETERANGAN` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_agent_` (`IDAGENT`),
  CONSTRAINT `fk_agent_` FOREIGN KEY (`IDAGENT`) REFERENCES `agent` (`ID_AGENT`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tagihan
-- ----------------------------
INSERT INTO `tagihan` VALUES ('1', '1', '2014-02-07 13:43:14', '2014-02-09 13:43:18', '229/DK-P/V/2013', '462500', 'TESTING');
INSERT INTO `tagihan` VALUES ('2', '1', '2014-02-09 00:00:00', '2014-02-09 00:00:00', 'xxx', '200000', 'TETST');
INSERT INTO `tagihan` VALUES ('3', '1', '2014-02-09 00:00:00', '2014-02-09 00:00:00', 'dd', '500000', 'TEST');
INSERT INTO `tagihan` VALUES ('4', '1', '2014-02-09 00:00:00', '2014-02-09 00:00:00', 'ATTTA', '250000', 'TEST');
INSERT INTO `tagihan` VALUES ('5', '1', '2014-02-09 00:00:00', '2014-02-09 00:00:00', 'DFSFD', '400000', 'test');
INSERT INTO `tagihan` VALUES ('6', '3', '2014-02-09 00:00:00', '2014-02-09 00:00:00', 'TSSA', '200000', 'test');
INSERT INTO `tagihan` VALUES ('7', '1', '2014-02-12 00:00:00', '2014-02-12 00:00:00', 'DFA', '450000', 'TEST');

-- ----------------------------
-- Table structure for `terusan`
-- ----------------------------
DROP TABLE IF EXISTS `terusan`;
CREATE TABLE `terusan` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDKOTA` int(11) DEFAULT NULL,
  `NAMATERUSAN` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk` (`IDKOTA`),
  CONSTRAINT `fk` FOREIGN KEY (`IDKOTA`) REFERENCES `kota` (`IDKOTA`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of terusan
-- ----------------------------
INSERT INTO `terusan` VALUES ('7', '18', 'lubuk linggau');
INSERT INTO `terusan` VALUES ('8', '17', 'Amuntai');
INSERT INTO `terusan` VALUES ('9', '17', 'Banjarbaru');
INSERT INTO `terusan` VALUES ('10', '19', 'Sangatta');
INSERT INTO `terusan` VALUES ('11', '20', 'Meulaboh');
INSERT INTO `terusan` VALUES ('12', '55', 'Metro');
INSERT INTO `terusan` VALUES ('13', '25', 'Kabanjahe');
INSERT INTO `terusan` VALUES ('14', '25', 'Pulau Samosir');
INSERT INTO `terusan` VALUES ('15', '27', 'Payakumbuh');
INSERT INTO `terusan` VALUES ('16', '38', 'Sengigi');
INSERT INTO `terusan` VALUES ('17', '38', 'Lombol Timur');
INSERT INTO `terusan` VALUES ('19', '39', 'Tual');
INSERT INTO `terusan` VALUES ('20', '41', 'Maumere');
INSERT INTO `terusan` VALUES ('21', '45', 'Atambua');
INSERT INTO `terusan` VALUES ('22', '47', 'Minahasa Selatan');
INSERT INTO `terusan` VALUES ('23', '47', 'Minahasa Utara');
INSERT INTO `terusan` VALUES ('24', '49', 'Sigli');
INSERT INTO `terusan` VALUES ('25', null, null);

-- ----------------------------
-- Table structure for `tipebayar`
-- ----------------------------
DROP TABLE IF EXISTS `tipebayar`;
CREATE TABLE `tipebayar` (
  `IDTIPEBAYAR` int(11) NOT NULL AUTO_INCREMENT,
  `KODETIPEBAYAR` varchar(255) DEFAULT NULL,
  `NAMATIPEBAYAR` varchar(255) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDTIPEBAYAR`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tipebayar
-- ----------------------------
INSERT INTO `tipebayar` VALUES ('1', 'TP01', 'CASH/TUNAI', null, null, null, null);
INSERT INTO `tipebayar` VALUES ('2', 'TP02', 'TRANSFER', null, null, null, null);

-- ----------------------------
-- Table structure for `transaksipembayaran`
-- ----------------------------
DROP TABLE IF EXISTS `transaksipembayaran`;
CREATE TABLE `transaksipembayaran` (
  `IDPEMBAYARAN` int(11) NOT NULL AUTO_INCREMENT,
  `IDINVOICE` int(11) DEFAULT NULL,
  `NOTRANSAKSI` varchar(255) DEFAULT NULL,
  `NOTRANSFER` varchar(255) DEFAULT NULL,
  `TGLBAYAR` datetime DEFAULT NULL,
  `IDSTT` int(11) DEFAULT NULL,
  `IDMETODEBAYAR` int(11) DEFAULT NULL,
  `IDJENISBAYAR` int(11) DEFAULT NULL,
  `TOTALBAYAR` int(11) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDPEMBAYARAN`),
  KEY `FK_JNS` (`IDJENISBAYAR`),
  KEY `FK_TIPE` (`IDMETODEBAYAR`),
  KEY `FK_IDSTT` (`IDSTT`),
  KEY `FK_IDINVOICE_` (`IDINVOICE`),
  CONSTRAINT `FK_IDINVOICE_` FOREIGN KEY (`IDINVOICE`) REFERENCES `invoice` (`ID`),
  CONSTRAINT `FK_IDSTT` FOREIGN KEY (`IDSTT`) REFERENCES `detailstt` (`ID`),
  CONSTRAINT `FK_JNS` FOREIGN KEY (`IDJENISBAYAR`) REFERENCES `jenisbayar` (`IDJENISBAYAR`),
  CONSTRAINT `FK_TIPE` FOREIGN KEY (`IDMETODEBAYAR`) REFERENCES `metodebayar` (`IDMETODEBAYAR`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of transaksipembayaran
-- ----------------------------
INSERT INTO `transaksipembayaran` VALUES ('1', '96', 'C01/DMX/1/02/14', '', '2014-02-06 00:00:00', null, '1', '3', '72300', null, null, null, null);
INSERT INTO `transaksipembayaran` VALUES ('2', '96', 'C01/DMX/1/02/14', '', '2014-02-06 00:00:00', null, '1', '3', '1600000', null, null, null, null);
INSERT INTO `transaksipembayaran` VALUES ('3', null, '234214', '', '2014-02-06 00:00:00', '136', '1', '3', '235000', null, null, null, null);
INSERT INTO `transaksipembayaran` VALUES ('4', null, '234214', '', '2014-02-06 00:00:00', '136', '1', '3', '1000000', null, null, null, null);
INSERT INTO `transaksipembayaran` VALUES ('5', '97', 'C01/DMX/2/02/14', '', '2014-02-06 00:00:00', null, '1', '1', '50000', null, null, null, null);
INSERT INTO `transaksipembayaran` VALUES ('6', '97', 'C01/DMX/2/02/14', '', '2014-02-06 00:00:00', null, '1', '3', '50000', null, null, null, null);
INSERT INTO `transaksipembayaran` VALUES ('7', '97', 'C01/DMX/2/02/14', '', '2014-02-06 00:00:00', null, '1', '3', '850000', null, null, null, null);
INSERT INTO `transaksipembayaran` VALUES ('8', null, '3463733453', '', '2014-02-14 00:00:00', '138', '1', '3', '1440500', null, null, null, null);

-- ----------------------------
-- Table structure for `transaksipembayarantagihan`
-- ----------------------------
DROP TABLE IF EXISTS `transaksipembayarantagihan`;
CREATE TABLE `transaksipembayarantagihan` (
  `IDPEMBAYARAN` int(11) NOT NULL AUTO_INCREMENT,
  `IDTAGIHAN` int(11) DEFAULT NULL,
  `NOTRANSAKSI` varchar(255) DEFAULT NULL,
  `NOTRANSFER` varchar(255) DEFAULT NULL,
  `TGLBAYAR` datetime DEFAULT NULL,
  `IDMETODEBAYAR` int(11) DEFAULT NULL,
  `IDJENISBAYAR` int(11) DEFAULT NULL,
  `TOTALBAYAR` int(11) DEFAULT NULL,
  `CREATED_AT` datetime DEFAULT NULL,
  `CREATED_BY` varchar(255) DEFAULT NULL,
  `UPDATED_AT` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UPDATED_BY` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDPEMBAYARAN`),
  KEY `FK_JNS` (`IDJENISBAYAR`),
  KEY `FK_TIPE` (`IDMETODEBAYAR`),
  KEY `fk_tagihan` (`IDTAGIHAN`),
  CONSTRAINT `fk_tagihan` FOREIGN KEY (`IDTAGIHAN`) REFERENCES `tagihan` (`ID`),
  CONSTRAINT `transaksipembayarantagihan_ibfk_3` FOREIGN KEY (`IDJENISBAYAR`) REFERENCES `jenisbayar` (`IDJENISBAYAR`),
  CONSTRAINT `transaksipembayarantagihan_ibfk_4` FOREIGN KEY (`IDMETODEBAYAR`) REFERENCES `metodebayar` (`IDMETODEBAYAR`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of transaksipembayarantagihan
-- ----------------------------
INSERT INTO `transaksipembayarantagihan` VALUES ('25', '7', 'DFA', '', '2014-02-12 00:00:00', '1', '3', '400000', null, null, null, null);
INSERT INTO `transaksipembayarantagihan` VALUES ('26', '7', 'DFA', '', '2014-02-12 00:00:00', '1', '3', '50000', null, null, '2014-02-12 14:06:01', null);
INSERT INTO `transaksipembayarantagihan` VALUES ('27', '6', 'TSSA', '', '2014-02-12 00:00:00', '1', '3', '100000', null, null, null, null);
INSERT INTO `transaksipembayarantagihan` VALUES ('28', '6', 'TSSA', '', '2014-02-12 00:00:00', '1', '3', '100000', null, null, null, null);
INSERT INTO `transaksipembayarantagihan` VALUES ('29', '5', 'DFSFD', '', '2014-02-12 00:00:00', '1', '3', '200000', null, null, null, null);
INSERT INTO `transaksipembayarantagihan` VALUES ('30', '5', 'DFSFD', '', '2014-02-12 00:00:00', '1', '3', '200000', null, null, null, null);
INSERT INTO `transaksipembayarantagihan` VALUES ('31', '4', 'ATTTA', '', '2014-02-12 00:00:00', '1', '3', '250000', null, null, null, null);
INSERT INTO `transaksipembayarantagihan` VALUES ('32', '3', 'dd', '', '2014-02-12 00:00:00', '1', '3', '500000', null, null, null, null);
INSERT INTO `transaksipembayarantagihan` VALUES ('33', '2', 'xxx', '', '2014-02-12 00:00:00', '1', '3', '200000', null, null, null, null);
INSERT INTO `transaksipembayarantagihan` VALUES ('34', '1', '229/DK-P/V/2013', '', '2014-02-12 00:00:00', '1', '3', '200000', null, null, null, null);
INSERT INTO `transaksipembayarantagihan` VALUES ('35', '1', '229/DK-P/V/2013', '', '2014-02-12 00:00:00', '1', '3', '262500', null, null, null, null);

-- ----------------------------
-- Table structure for `user`
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) DEFAULT NULL,
  `level` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `hp` varchar(255) DEFAULT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  `isaktif` tinyint(1) DEFAULT NULL,
  `isbiayastt` tinyint(1) DEFAULT NULL,
  `ispiutang` tinyint(1) DEFAULT NULL,
  `iscustomer` tinyint(1) DEFAULT NULL,
  `isagent` tinyint(1) DEFAULT NULL,
  `ispricelist` tinyint(1) DEFAULT NULL,
  `isuser` tinyint(1) DEFAULT NULL,
  `islaporan` tinyint(1) DEFAULT NULL,
  `isLogin` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('7', 'manager', 'MANAGER', 'manager', 'äÌæÌØÔî', '-', '-', '1', '1', '1', '1', '1', '1', '1', '1', '0');
INSERT INTO `user` VALUES ('10', 'Dina', 'MANAGER', 'Dina', 'ÒÜæÌ', '-', '-', '1', '1', '1', '1', '1', '1', '1', '1', '0');

-- ----------------------------
-- View structure for `laporanpiutang`
-- ----------------------------
DROP VIEW IF EXISTS `laporanpiutang`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `laporanpiutang` AS select ifnull(`inv`.`TGLINVOICE`,`stt`.`TGLCONNOTE`) AS `TGLINVOICESTT`,ifnull((select `c`.`NAMACUSTOMER` from `customer` `c` where ((`c`.`IDCUSTOMER` = `stt`.`IDCUSTOMER`) and (`c`.`IDCUSTOMER` = `inv`.`IDCUSTOMER`))),(select `customer`.`NAMACUSTOMER` AS `customer` from `customer` where (`customer`.`IDCUSTOMER` = `stt`.`IDCUSTOMER`))) AS `CUSTOMER`,ifnull((select sum(`detailstt`.`TOTAL_CHARGE`) from `detailstt` where (`detailstt`.`IDINVOICE` = `stt`.`IDINVOICE`)),(select sum(`detailstt`.`TOTAL_CHARGE`) from `detailstt` where (`detailstt`.`ID` = `stt`.`ID`))) AS `TOTALCHARGE`,ifnull(`inv`.`KODEINVOICE`,`stt`.`NOCONNOTE`) AS `INVOICESTT`,coalesce(ifnull(`pmb`.`TOTALBAYAR`,`trx`.`TOTALBAYAR`),0) AS `JUMLAHBAYAR`,ifnull(`trx`.`TGLBAYAR`,`pmb`.`TGLBAYAR`) AS `TGLBAYAR`,(select `metodebayar`.`METODEBAYAR` from `metodebayar` where (`metodebayar`.`IDMETODEBAYAR` = ifnull(`trx`.`IDMETODEBAYAR`,`pmb`.`IDMETODEBAYAR`))) AS `METODEBAYAR` from (((`detailstt` `stt` left join `transaksipembayaran` `pmb` on((`stt`.`ID` = `pmb`.`IDSTT`))) left join `invoice` `inv` on((`stt`.`IDINVOICE` = `inv`.`ID`))) left join `transaksipembayaran` `trx` on((`inv`.`ID` = `trx`.`IDINVOICE`))) ;

-- ----------------------------
-- View structure for `laporanpiutangall`
-- ----------------------------
DROP VIEW IF EXISTS `laporanpiutangall`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `laporanpiutangall` AS select `lap`.`TGLINVOICESTT` AS `TGLINVOICESTT`,`lap`.`CUSTOMER` AS `CUSTOMER`,(select `m`.`NAMA` from (`marketing` `m` join `customer` `c` on((`m`.`ID` = `c`.`IDMARKETING`))) where (`c`.`NAMACUSTOMER` = `lap`.`CUSTOMER`)) AS `MARKETING`,`lap`.`TOTALCHARGE` AS `TOTALCHARGE`,`lap`.`INVOICESTT` AS `INVOICESTT`,`lap`.`JUMLAHBAYAR` AS `JUMLAHBAYAR`,`lap`.`TGLBAYAR` AS `TGLBAYAR`,`lap`.`METODEBAYAR` AS `METODEBAYAR` from `laporanpiutang` `lap` ;

-- ----------------------------
-- View structure for `v_agent`
-- ----------------------------
DROP VIEW IF EXISTS `v_agent`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_agent` AS select `agent`.`ID_AGENT` AS `IDAGENT`,`agent`.`KODEAGENT` AS `KODEAGENT`,`h`.`NAMA` AS `HANDLING`,`agent`.`NAMAAGENT` AS `NAMAAGENT`,`agent`.`ALAMAT` AS `ALAMAT`,`agent`.`CP` AS `CP`,`agent`.`TELEPON` AS `TELEPON`,(case `agent`.`IS_AF` when 1 then 'YES' else 'NO' end) AS `AF`,(case `agent`.`IS_SHIPPING` when 1 then 'YES' else 'NO' end) AS `SHIPPING`,(case `agent`.`IS_DELIVERY` when 1 then 'YES' else 'NO' end) AS `DELIVERY`,(case `agent`.`IS_REGULATEDAGENT` when 1 then 'YES' else 'NO' end) AS `RA`,(case `agent`.`IS_TRUCK` when 1 then 'YES' else 'NO' end) AS `TRUCKING`,(case `agent`.`IS_WH` when 1 then 'YES' else 'NO' end) AS `WAREHOUSING`,(case `agent`.`IS_GRDH` when 1 then 'YES' else 'NO' end) AS `GROUNDHANDLING` from (`agent` join `agenthanding` `h` on((`agent`.`HANDLING_ID` = `h`.`ID`))) order by `agent`.`ID_AGENT` ;

-- ----------------------------
-- View structure for `v_bankaccount`
-- ----------------------------
DROP VIEW IF EXISTS `v_bankaccount`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_bankaccount` AS select `refaccount`.`IDACCOUNT` AS `IDACCOUNT`,`refaccount`.`NAMAACCOUNT` AS `NAMAACCOUNT`,`refaccount`.`NOACCOUNT` AS `NOACCOUNT` from (`refaccount` join `refbank`) ;

-- ----------------------------
-- View structure for `v_customer`
-- ----------------------------
DROP VIEW IF EXISTS `v_customer`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_customer` AS select `c`.`KODECUSTOMER` AS `KODECUSTOMER`,`c`.`NAMACUSTOMER` AS `NAMACUSTOMER`,`c`.`ALAMAT` AS `ALAMAT`,`c`.`HP` AS `HP`,`m`.`KODE` AS `KODEMARKETING`,`m`.`NAMA` AS `MARKETING`,`c`.`IDCUSTOMER` AS `IDCUSTOMER`,`c`.`EMAIL` AS `EMAIL`,`c`.`TELEPON` AS `TELEPON`,`m`.`ID` AS `IDMARKETING` from (`customer` `c` left join `marketing` `m` on((`c`.`IDMARKETING` = `m`.`ID`))) ;

-- ----------------------------
-- View structure for `v_invoice`
-- ----------------------------
DROP VIEW IF EXISTS `v_invoice`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_invoice` AS select `a`.`ID` AS `ID`,`a`.`TGLINVOICE` AS `TGLINVOICE`,`a`.`KODEINVOICE` AS `KODEINVOICE`,`b`.`NAMACUSTOMER` AS `NAMACUSTOMER`,`detailstt`.`TOTAL_CHARGE` AS `JUMLAHINVOICE`,`detailstt`.`TOTAL_COST` AS `JUMLAHCOST`,`detailstt`.`TOTAL_PROFIT` AS `JUMLAHPROFIT`,`marketing`.`NAMA` AS `MARKETING` from (((`invoice` `a` join `customer` `b` on((`b`.`IDCUSTOMER` = `a`.`IDCUSTOMER`))) join `detailstt` on((`detailstt`.`IDINVOICE` = `a`.`ID`))) left join `marketing` on((`marketing`.`ID` = `b`.`IDMARKETING`))) ;

-- ----------------------------
-- View structure for `v_kota`
-- ----------------------------
DROP VIEW IF EXISTS `v_kota`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_kota` AS select `k`.`IDKOTA` AS `IDKOTA`,`a`.`KODEAREA` AS `KODEAREA`,`a`.`NAMAAREA` AS `NAMAAREA`,`k`.`NAMAKOTA` AS `NAMAKOTA`,`k`.`KODEKOTA` AS `KODEKOTA`,`k`.`IDAREA` AS `IDAREA` from (`kota` `k` join `area` `a` on((`k`.`IDAREA` = `a`.`IDAREA`))) ;

-- ----------------------------
-- View structure for `v_list_historitpembayarantagihan`
-- ----------------------------
DROP VIEW IF EXISTS `v_list_historitpembayarantagihan`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_list_historitpembayarantagihan` AS select `jenisbayar`.`NAMAJENISBAYAR` AS `NAMAJENISBAYAR`,`transaksipembayarantagihan`.`NOTRANSAKSI` AS `NOTRANSAKSI`,`transaksipembayarantagihan`.`NOTRANSFER` AS `NOTRANSFER`,`transaksipembayarantagihan`.`TGLBAYAR` AS `TGLBAYAR`,`transaksipembayarantagihan`.`TOTALBAYAR` AS `TOTALBAYAR`,`metodebayar`.`METODEBAYAR` AS `METODEBAYAR`,`transaksipembayarantagihan`.`IDTAGIHAN` AS `IDTAGIHAN`,`transaksipembayarantagihan`.`IDPEMBAYARAN` AS `IDPEMBAYARAN`,`jenisbayar`.`KODEJENISBAYAR` AS `KODEJENISBAYAR`,`jenisbayar`.`IDJENISBAYAR` AS `IDJENISBAYAR` from ((`transaksipembayarantagihan` join `metodebayar` on((`metodebayar`.`IDMETODEBAYAR` = `transaksipembayarantagihan`.`IDMETODEBAYAR`))) join `jenisbayar` on((`jenisbayar`.`IDJENISBAYAR` = `transaksipembayarantagihan`.`IDJENISBAYAR`))) ;

-- ----------------------------
-- View structure for `v_list_pembayaran`
-- ----------------------------
DROP VIEW IF EXISTS `v_list_pembayaran`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_list_pembayaran` AS select `v_stt`.`ID` AS `ID`,`transaksipembayaran`.`IDPEMBAYARAN` AS `IDPEMBAYARAN`,`transaksipembayaran`.`NOTRANSAKSI` AS `NOTRANSAKSI`,`transaksipembayaran`.`NOTRANSFER` AS `NOTRANSFER`,`v_stt`.`TGLCONNOTE` AS `TGLCONNOTE`,`v_stt`.`NOCONNOTE` AS `NOCONNOTE`,`v_stt`.`CHARGE_KIRIM` AS `CHARGE_KIRIM`,`metodebayar`.`METODEBAYAR` AS `METODEBAYAR`,`jenisbayar`.`NAMAJENISBAYAR` AS `NAMAJENISBAYAR`,`transaksipembayaran`.`TGLBAYAR` AS `TGLBAYAR`,`transaksipembayaran`.`TOTALBAYAR` AS `TOTALBAYAR`,`transaksipembayaran`.`IDSTT` AS `IDSTT`,`jenisbayar`.`KODEJENISBAYAR` AS `KODEJENISBAYAR` from (((`transaksipembayaran` join `v_stt` on((`v_stt`.`ID` = `transaksipembayaran`.`IDSTT`))) join `metodebayar` on((`metodebayar`.`IDMETODEBAYAR` = `transaksipembayaran`.`IDMETODEBAYAR`))) join `jenisbayar` on((`jenisbayar`.`IDJENISBAYAR` = `transaksipembayaran`.`IDJENISBAYAR`))) ;

-- ----------------------------
-- View structure for `v_list_pembayaraninvoice`
-- ----------------------------
DROP VIEW IF EXISTS `v_list_pembayaraninvoice`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_list_pembayaraninvoice` AS select `transaksipembayaran`.`IDPEMBAYARAN` AS `IDPEMBAYARAN`,`transaksipembayaran`.`NOTRANSAKSI` AS `NOTRANSAKSI`,`transaksipembayaran`.`NOTRANSFER` AS `NOTRANSFER`,`metodebayar`.`METODEBAYAR` AS `METODEBAYAR`,`jenisbayar`.`NAMAJENISBAYAR` AS `NAMAJENISBAYAR`,`transaksipembayaran`.`TGLBAYAR` AS `TGLBAYAR`,`transaksipembayaran`.`TOTALBAYAR` AS `TOTALBAYAR`,`invoice`.`TGLINVOICE` AS `TGLINVOICE`,`invoice`.`KODEINVOICE` AS `KODEINVOICE`,`invoice`.`ID` AS `ID`,`jenisbayar`.`KODEJENISBAYAR` AS `KODEJENISBAYAR` from (((`transaksipembayaran` join `metodebayar` on((`metodebayar`.`IDMETODEBAYAR` = `transaksipembayaran`.`IDMETODEBAYAR`))) join `jenisbayar` on((`jenisbayar`.`IDJENISBAYAR` = `transaksipembayaran`.`IDJENISBAYAR`))) join `invoice` on((`invoice`.`ID` = `transaksipembayaran`.`IDINVOICE`))) ;

-- ----------------------------
-- View structure for `v_list_pmbtagihan`
-- ----------------------------
DROP VIEW IF EXISTS `v_list_pmbtagihan`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_list_pmbtagihan` AS select `jenisbayar`.`NAMAJENISBAYAR` AS `NAMAJENISBAYAR`,`transaksipembayarantagihan`.`NOTRANSAKSI` AS `NOTRANSAKSI`,`transaksipembayarantagihan`.`NOTRANSFER` AS `NOTRANSFER`,`transaksipembayarantagihan`.`TGLBAYAR` AS `TGLBAYAR`,sum(`transaksipembayarantagihan`.`TOTALBAYAR`) AS `TOTALBAYAR`,`metodebayar`.`METODEBAYAR` AS `METODEBAYAR`,`transaksipembayarantagihan`.`IDTAGIHAN` AS `IDTAGIHAN`,`transaksipembayarantagihan`.`IDPEMBAYARAN` AS `IDPEMBAYARAN`,`jenisbayar`.`KODEJENISBAYAR` AS `KODEJENISBAYAR`,`jenisbayar`.`IDJENISBAYAR` AS `IDJENISBAYAR` from ((`transaksipembayarantagihan` join `metodebayar` on((`metodebayar`.`IDMETODEBAYAR` = `transaksipembayarantagihan`.`IDMETODEBAYAR`))) join `jenisbayar` on((`jenisbayar`.`IDJENISBAYAR` = `transaksipembayarantagihan`.`IDJENISBAYAR`))) group by `transaksipembayarantagihan`.`IDTAGIHAN` ;

-- ----------------------------
-- View structure for `v_piutanginvoice`
-- ----------------------------
DROP VIEW IF EXISTS `v_piutanginvoice`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_piutanginvoice` AS select `customer`.`NAMACUSTOMER` AS `NAMACUSTOMER`,`detailstt`.`TGLCONNOTE` AS `TGLCONNOTE`,`invoice`.`TGLINVOICE` AS `TGLINVOICE`,`invoice`.`KODEINVOICE` AS `KODEINVOICE`,`detailstt`.`NOCONNOTE` AS `NOCONNOTE`,`detailstt`.`TOTAL_CHARGE` AS `TOTAL_CHARGE`,`trxinv`.`NOTRANSAKSI` AS `INVNOTRANSAKSI`,`trxinv`.`NOTRANSFER` AS `INVNOTRANSFER`,`customer`.`KODECUSTOMER` AS `KODECUSTOMER`,`trxinv`.`TGLBAYAR` AS `INVTGLBAYAR`,`trxinv`.`TOTALBAYAR` AS `INVTOTALBAYAR`,`mbinv`.`METODEBAYAR` AS `INVMETODEBAYAR`,`trxstt`.`IDSTT` AS `IDSTT`,`trxstt`.`NOTRANSAKSI` AS `STTNOTRANSAKSI`,`trxstt`.`NOTRANSFER` AS `STTNOTRANSFER`,`trxstt`.`TGLBAYAR` AS `STTTGLBAYAR`,`trxstt`.`TOTALBAYAR` AS `STTTOTALBAYAR`,`mbstt`.`METODEBAYAR` AS `METODEBAYAR`,`marketing`.`NAMA` AS `MARKETING` from (((((((`detailstt` left join `invoice` on((`invoice`.`ID` = `detailstt`.`IDINVOICE`))) join `customer` on((`customer`.`IDCUSTOMER` = `detailstt`.`IDCUSTOMER`))) left join `transaksipembayaran` `trxinv` on((`trxinv`.`IDINVOICE` = `detailstt`.`IDINVOICE`))) left join `metodebayar` `mbinv` on((`mbinv`.`IDMETODEBAYAR` = `trxinv`.`IDMETODEBAYAR`))) left join `transaksipembayaran` `trxstt` on((`trxstt`.`IDSTT` = `detailstt`.`ID`))) left join `metodebayar` `mbstt` on((`mbstt`.`IDMETODEBAYAR` = `trxstt`.`IDMETODEBAYAR`))) left join `marketing` on((`marketing`.`ID` = `customer`.`IDMARKETING`))) ;

-- ----------------------------
-- View structure for `v_pricelist`
-- ----------------------------
DROP VIEW IF EXISTS `v_pricelist`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_pricelist` AS select `pricelist`.`IDPRICELIST` AS `IDPRICELIST`,`customer`.`KODECUSTOMER` AS `KODECUSTOMER`,`pricelist`.`IDCUSTOMER` AS `IDCUSTOMER`,`customer`.`NAMACUSTOMER` AS `CUSTOMER`,`pricelist`.`IDLAYANAN` AS `IDSERVICE`,`layanan`.`NAMALAYANAN` AS `SERVICE`,`pricelist`.`IDHANDLING` AS `IDHANDLING`,`modakirim`.`NAMAJNSKIRIM` AS `HANDLING`,`asal`.`IDKOTA` AS `IDASAL`,`asal`.`NAMAKOTA` AS `ASAL`,`pricelist`.`IDKOTA` AS `IDTUJUAN`,`tujuan`.`NAMAKOTA` AS `TUJUAN`,`pricelist`.`CHARGE/KG` AS `CHARGE`,`pricelist`.`RC/KG` AS `REFUND`,`pricelist`.`DURASIWAKTU` AS `DURASIWAKTU`,`terusan`.`NAMATERUSAN` AS `NAMATERUSAN`,`pricelist`.`ISAKTIF` AS `ISAKTIF`,`terusan`.`ID` AS `IDTERUSAN`,`layanan`.`KODELAYANAN` AS `KODELAYANAN`,`asal`.`KODEKOTA` AS `KODEASAL`,`tujuan`.`KODEKOTA` AS `KODETUJUAN`,`area`.`NAMAAREA` AS `NAMAAREA`,`area`.`KODEAREA` AS `KODEAREA` from (((((((`pricelist` join `layanan` on((`layanan`.`IDLAYANAN` = `pricelist`.`IDLAYANAN`))) join `modakirim` on((`modakirim`.`IDJNSKIRIM` = `pricelist`.`IDHANDLING`))) join `customer` on((`customer`.`IDCUSTOMER` = `pricelist`.`IDCUSTOMER`))) left join `kota` `asal` on((`asal`.`IDKOTA` = `pricelist`.`KOTAASAL`))) left join `kota` `tujuan` on((`tujuan`.`IDKOTA` = `pricelist`.`IDKOTA`))) left join `terusan` on((`terusan`.`ID` = `pricelist`.`IDTERUSAN`))) join `area` on((`area`.`IDAREA` = `tujuan`.`IDAREA`))) ;

-- ----------------------------
-- View structure for `v_pricelistagent`
-- ----------------------------
DROP VIEW IF EXISTS `v_pricelistagent`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_pricelistagent` AS select `layanan`.`KODELAYANAN` AS `KODELAYANAN`,`layanan`.`NAMALAYANAN` AS `NAMALAYANAN`,`asal`.`IDKOTA` AS `IDKOTA`,`asal`.`KODEKOTA` AS `KODEKOTA`,`asal`.`NAMAKOTA` AS `NAMAKOTA`,`kota`.`IDKOTA` AS `IDKOTATUJUAN`,`kota`.`KODEKOTA` AS `KODEKOTATUJUAN`,`kota`.`NAMAKOTA` AS `NAMAKOTATUJUAN`,`terusan`.`ID` AS `ID`,`terusan`.`NAMATERUSAN` AS `NAMATERUSAN`,`modakirim`.`IDJNSKIRIM` AS `IDJNSKIRIM`,`modakirim`.`KODEJNSKIRIM` AS `KODEJNSKIRIM`,`modakirim`.`NAMAJNSKIRIM` AS `NAMAJNSKIRIM`,`pricelistagent`.`CHARGE/KG` AS `CHARGE`,`pricelistagent`.`DURASIWAKTU` AS `DURASIWAKTU`,`pricelistagent`.`IDAGENT` AS `IDAGENT`,`pricelistagent`.`KETERANGAN` AS `KETERANGAN`,`pricelistagent`.`ISAKTIF` AS `ISAKTIF`,`agent`.`KODEAGENT` AS `KODEAGENT`,`agent`.`NAMAAGENT` AS `NAMAAGENT`,`pricelistagent`.`IDPRICELIST` AS `IDPRICELIST`,`pricelistagent`.`JNSCOST` AS `JNSCOST`,`layanan`.`IDLAYANAN` AS `IDLAYANAN`,`pricelistagent`.`IDHANDLING` AS `IDHANDLING` from ((((((`pricelistagent` join `layanan` on((`layanan`.`IDLAYANAN` = `pricelistagent`.`IDLAYANAN`))) join `kota` `asal` on((`asal`.`IDKOTA` = `pricelistagent`.`KOTAASAL`))) join `kota` on((`kota`.`IDKOTA` = `pricelistagent`.`IDKOTA`))) left join `terusan` on((`terusan`.`ID` = `pricelistagent`.`IDTERUSAN`))) join `modakirim` on((`modakirim`.`IDJNSKIRIM` = `pricelistagent`.`IDHANDLING`))) join `agent` on((`pricelistagent`.`IDAGENT` = `agent`.`ID_AGENT`))) ;

-- ----------------------------
-- View structure for `v_statusinvoice`
-- ----------------------------
DROP VIEW IF EXISTS `v_statusinvoice`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_statusinvoice` AS select `a`.`ID` AS `ID`,`a`.`TGLINVOICE` AS `TGLINVOICE`,`a`.`KODEINVOICE` AS `KODEINVOICE`,`b`.`NAMACUSTOMER` AS `NAMACUSTOMER`,(select sum(`detailstt`.`PPN`) from `detailstt` where (`detailstt`.`IDINVOICE` = `a`.`ID`)) AS `PPN`,(select sum(`detailstt`.`INSURANCE`) from `detailstt` where (`detailstt`.`IDINVOICE` = `a`.`ID`)) AS `INSURANCE`,(select sum(`detailstt`.`PACKING`) from `detailstt` where (`detailstt`.`IDINVOICE` = `a`.`ID`)) AS `PACKING`,(select sum(`detailstt`.`TOTAL_CHARGE`) from `detailstt` where (`detailstt`.`IDINVOICE` = `a`.`ID`)) AS `CHARGE`,(select coalesce(sum(`v_list_pembayaraninvoice`.`TOTALBAYAR`),0) from `v_list_pembayaraninvoice` where (`v_list_pembayaraninvoice`.`ID` = `a`.`ID`)) AS `TOTALBAYAR`,((select sum(`detailstt`.`TOTAL_CHARGE`) from `detailstt` where (`detailstt`.`IDINVOICE` = `a`.`ID`)) - (select coalesce(sum(`v_list_pembayaraninvoice`.`TOTALBAYAR`),0) from `v_list_pembayaraninvoice` where (`v_list_pembayaraninvoice`.`ID` = `a`.`ID`))) AS `SISAKEKURANGAN` from (`invoice` `a` join `customer` `b` on((`b`.`IDCUSTOMER` = `a`.`IDCUSTOMER`))) ;

-- ----------------------------
-- View structure for `v_statuspembayaran`
-- ----------------------------
DROP VIEW IF EXISTS `v_statuspembayaran`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_statuspembayaran` AS select `v_stt`.`TGLCONNOTE` AS `TGLCONNOTE`,`v_stt`.`NOCONNOTE` AS `NOCONNOTE`,`v_stt`.`RATE_KIRIM` AS `RATE_KIRIM`,`v_stt`.`PPN` AS `PPN`,`v_stt`.`INSURANCE` AS `INSURANCE`,`v_stt`.`WEIGHT` AS `WEIGHT`,`v_stt`.`WEIGHTDIM` AS `WEIGHTDIM`,`v_stt`.`TOTAL_CHARGE` AS `TOTAL_CHARGE`,sum(`v_list_pembayaran`.`TOTALBAYAR`) AS `TotalPembayaran`,(`v_stt`.`TOTAL_CHARGE` - sum(`v_list_pembayaran`.`TOTALBAYAR`)) AS `SisaKekurangan`,(case when (coalesce(sum(`v_list_pembayaran`.`TOTALBAYAR`)) = `v_stt`.`TOTAL_CHARGE`) then 'LUNAS' else 'BELUM LUNAS' end) AS `STATUS` from (`v_list_pembayaran` join `v_stt` on((`v_stt`.`ID` = `v_list_pembayaran`.`IDSTT`))) ;

-- ----------------------------
-- View structure for `v_statustagihan`
-- ----------------------------
DROP VIEW IF EXISTS `v_statustagihan`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_statustagihan` AS select `tagihan`.`ID` AS `ID`,`agent`.`ID_AGENT` AS `IDAGENT`,`agent`.`NAMAAGENT` AS `NAMAAGENT`,(select `agenthanding`.`NAMA` from `agenthanding` where (`agenthanding`.`ID` = `agent`.`HANDLING_ID`)) AS `HANDLING`,`tagihan`.`TGLDATANGINV` AS `TGLDATANGINV`,`tagihan`.`TGLINV` AS `TGLINV`,`tagihan`.`NOINV` AS `NOINV`,`tagihan`.`JUMLAHTAGIHAN` AS `JUMLAHTAGIHAN`,`agent`.`KODEAGENT` AS `KODEAGENT`,`v_list_pmbtagihan`.`TGLBAYAR` AS `TGLBAYAR`,coalesce(`v_list_pmbtagihan`.`TOTALBAYAR`,0) AS `TOTALBAYAR`,(coalesce(`tagihan`.`JUMLAHTAGIHAN`,0) - coalesce(`v_list_pmbtagihan`.`TOTALBAYAR`,0)) AS `SISA`,`v_list_pmbtagihan`.`METODEBAYAR` AS `METODEBAYAR`,(case when (coalesce(`tagihan`.`JUMLAHTAGIHAN`,0) = coalesce(`v_list_pmbtagihan`.`TOTALBAYAR`,0)) then 'LUNAS' else 'BELUM LUNAS' end) AS `STATUS`,`tagihan`.`KETERANGAN` AS `KETERANGAN` from ((`tagihan` left join `agent` on((`agent`.`ID_AGENT` = `tagihan`.`IDAGENT`))) left join `v_list_pmbtagihan` on((`v_list_pmbtagihan`.`IDTAGIHAN` = `tagihan`.`ID`))) ;

-- ----------------------------
-- View structure for `v_stt`
-- ----------------------------
DROP VIEW IF EXISTS `v_stt`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_stt` AS select `detailstt`.`TGLCONNOTE` AS `TGLCONNOTE`,`detailstt`.`NOCONNOTE` AS `NOCONNOTE`,`statusstt`.`KODE` AS `TYPEOFPAYMENT`,`detailstt`.`CONSIGNEE` AS `CONSIGNEE`,`detailstt`.`PCS` AS `PCS`,`detailstt`.`WEIGHT` AS `WEIGHT`,`detailstt`.`CHARGE_KIRIM` AS `CHARGE_KIRIM`,`detailstt`.`PACKING` AS `PACKING`,`detailstt`.`TOTAL_CHARGE` AS `TOTAL_CHARGE`,`customer`.`KODECUSTOMER` AS `KODECUSTOMER`,`customer`.`NAMACUSTOMER` AS `NAMACUSTOMER`,`kota`.`NAMAKOTA` AS `NAMAKOTA`,`kotaasal`.`NAMAKOTA` AS `KOTAASAL`,`kota`.`KODEKOTA` AS `DEST`,`detailstt`.`COST_FEEMARKETING` AS `FEEMKT`,`detailstt`.`COST_REFUNDCUST` AS `REFUND`,`detailstt`.`COST_DELIVERY` AS `CDELIVERY`,`agntrucking`.`ID_AGENT` AS `IDAGNTTRUCK`,(select `layanan`.`KODELAYANAN` from `layanan` where (`layanan`.`IDLAYANAN` = `detailstt`.`IDSERVICE`)) AS `SERVICE`,`agntrucking`.`NAMAAGENT` AS `AGNTTRUCKING`,`agnaf`.`ID_AGENT` AS `IDAGNTAF`,`agnaf`.`NAMAAGENT` AS `AGNTAF`,`agnwh`.`ID_AGENT` AS `IDAGNTWH`,`agnwh`.`NAMAAGENT` AS `AGNTWH`,`detailstt`.`COST_WAREHOUSE` AS `CWH`,`agngrdh`.`ID_AGENT` AS `IDAGNGRDH`,`agngrdh`.`NAMAAGENT` AS `AGNTGRDH`,`detailstt`.`COST_GRDH` AS `CGRDH`,`detailstt`.`TOTAL_COST` AS `TOTAL_COST`,`detailstt`.`TOTAL_PROFIT` AS `TOTAL_PROFIT`,`agntrucking`.`KODEAGENT` AS `KAGNTTRUCKING`,`agnaf`.`KODEAGENT` AS `KAGNTAF`,`agnwh`.`KODEAGENT` AS `KAGNTWH`,`agngrdh`.`KODEAGENT` AS `KAGNTGRDH`,`detailstt`.`ID` AS `ID`,`kotaasal`.`KODEKOTA` AS `KODEASAL`,`kota`.`KODEKOTA` AS `KODEDEST`,`modakirim`.`IDJNSKIRIM` AS `IDHANDLING`,`modakirim`.`NAMAJNSKIRIM` AS `HANDLING`,`detailstt`.`PHONE` AS `PHONE`,`detailstt`.`FAX` AS `FAX`,`detailstt`.`DIM_P` AS `DIM_P`,`detailstt`.`DIM_L` AS `DIM_L`,`detailstt`.`DIM_T` AS `DIM_T`,`detailstt`.`RATE_KIRIM` AS `RATE_KIRIM`,`detailstt`.`PPN` AS `PPN`,`detailstt`.`INSURANCE` AS `INSURANCE`,`detailstt`.`COST_RA` AS `COST_RA`,`detailstt`.`COST_SMU` AS `COST_SMU`,`detailstt`.`PPNPERCENT` AS `PPNPERCENT`,`detailstt`.`NBARANGINSURANCE` AS `NBARANGINSURANCE`,`detailstt`.`INCURANCEPERCENT` AS `INCURANCEPERCENT`,`detailstt`.`WEIGHTDIM` AS `WEIGHTDIM`,`detailstt`.`IDINVOICE` AS `IDINVOICE`,`invoice`.`KODEINVOICE` AS `KODEINVOICE`,`marketing`.`NAMA` AS `MARKETING`,`detailstt`.`IDMARKETING` AS `IDMARKETING`,`detailstt`.`IDSTATUSSTT` AS `IDSTATUSSTT`,`detailstt`.`TGLMANIFEST` AS `TGLMANIFEST`,`agntshipping`.`ID_AGENT` AS `IDAGNTSHIPPING`,`agntshipping`.`KODEAGENT` AS `KAGNTSHIPPING`,`agntshipping`.`NAMAAGENT` AS `AGNTSHIPPING`,`agntra`.`ID_AGENT` AS `IDAGNTRA`,`agntra`.`KODEAGENT` AS `KAGNTRA`,`agntra`.`NAMAAGENT` AS `AGNTRA`,`detailstt`.`COST_SHIPPING` AS `COST_SHIPPING`,`detailstt`.`ALAMAT` AS `ALAMAT`,`agntdelivery`.`ID_AGENT` AS `IDAGNDELIVERY`,`agntdelivery`.`KODEAGENT` AS `KAGNTDELIVERY`,`agntdelivery`.`NAMAAGENT` AS `AGNTDELIVERY`,`detailstt`.`NOSMU` AS `NOSMU`,`marketing`.`KODE` AS `KODEMARKETING`,`detailstt`.`COST_SMU` AS `CSMU`,`v_terusan`.`NAMATERUSAN` AS `NAMATERUSAN`,`v_terusan`.`KODEKOTA` AS `KODEKOTA`,`invoice`.`KETERANGAN` AS `KETERANGAN`,`detailstt`.`COST_TRUCKING` AS `CTRUCKING` from (((((((((((((((`detailstt` join `statusstt` on((`detailstt`.`IDSTATUSSTT` = `statusstt`.`ID`))) left join `customer` on((`detailstt`.`IDCUSTOMER` = `customer`.`IDCUSTOMER`))) join `kota` on((`kota`.`IDKOTA` = `detailstt`.`IDDESC`))) join `kota` `kotaasal` on((`kotaasal`.`IDKOTA` = `detailstt`.`IDORIGIN`))) left join `agent` `agntrucking` on((`agntrucking`.`ID_AGENT` = `detailstt`.`IDA_TRUCKING`))) left join `agent` `agnaf` on((`agnaf`.`ID_AGENT` = `detailstt`.`IDA_SMU`))) left join `agent` `agnwh` on((`agnwh`.`ID_AGENT` = `detailstt`.`IDA_WAREHOUSE`))) left join `agent` `agngrdh` on((`agngrdh`.`ID_AGENT` = `detailstt`.`IDA_GRDH`))) join `modakirim` on((`modakirim`.`IDJNSKIRIM` = `detailstt`.`IDHANDLING`))) left join `invoice` on((`invoice`.`ID` = `detailstt`.`IDINVOICE`))) left join `marketing` on((`marketing`.`ID` = `detailstt`.`IDMARKETING`))) left join `agent` `agntshipping` on((`agntshipping`.`ID_AGENT` = `detailstt`.`IDA_SHIPPING`))) left join `agent` `agntra` on((`agntra`.`ID_AGENT` = `detailstt`.`IDA_RA`))) left join `agent` `agntdelivery` on((`agntdelivery`.`ID_AGENT` = `detailstt`.`IDA_DELIVERY`))) left join `v_terusan` on((`v_terusan`.`ID` = `detailstt`.`IDTERUSAN`))) ;

-- ----------------------------
-- View structure for `v_sttpembayaran`
-- ----------------------------
DROP VIEW IF EXISTS `v_sttpembayaran`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_sttpembayaran` AS select `v_stt`.`ID` AS `ID`,`v_stt`.`IDINVOICE` AS `IDINVOICE`,`v_stt`.`KETERANGAN` AS `KETERANGAN`,`v_stt`.`KODEINVOICE` AS `KODEINVOICE`,`v_stt`.`TGLCONNOTE` AS `DATE`,`v_stt`.`NAMACUSTOMER` AS `CUSTOMER`,`v_stt`.`MARKETING` AS `MARKETING`,`v_stt`.`FEEMKT` AS `FEEMKT`,`v_stt`.`REFUND` AS `REFUND`,`v_stt`.`HANDLING` AS `HANDLING`,`v_stt`.`IDSTATUSSTT` AS `IDSTATUSSTT`,`v_stt`.`TYPEOFPAYMENT` AS `TPAYMENT`,`v_stt`.`NOCONNOTE` AS `NOCONNOTE`,`v_stt`.`DEST` AS `DEST`,`v_stt`.`NAMATERUSAN` AS `NAMATERUSAN`,`v_stt`.`CONSIGNEE` AS `CONSIGNEE`,`v_stt`.`PCS` AS `COLLIE`,`v_stt`.`WEIGHT` AS `WEIGHT`,`v_stt`.`WEIGHTDIM` AS `WEIGHTDIM`,`v_stt`.`CHARGE_KIRIM` AS `CHARGE_KIRIM`,`v_stt`.`RATE_KIRIM` AS `RATE_KIRIM`,`v_stt`.`TOTAL_CHARGE` AS `TOTAL_CHARGE`,`v_stt`.`PACKING` AS `PACKING`,`v_stt`.`PPN` AS `PPN`,`v_stt`.`INSURANCE` AS `INSURANCE`,((`v_stt`.`PPN` + `v_stt`.`INSURANCE`) + `v_stt`.`PACKING`) AS `OTHERCHARGE`,`v_stt`.`SERVICE` AS `SERVICE`,(select coalesce(sum(`v_list_pembayaran`.`TOTALBAYAR`),0) from `v_list_pembayaran` where (`v_list_pembayaran`.`IDSTT` = `v_stt`.`ID`)) AS `TOTALBAYAR`,(`v_stt`.`TOTAL_CHARGE` - (select coalesce(sum(`v_list_pembayaran`.`TOTALBAYAR`),0) from `v_list_pembayaran` where (`v_list_pembayaran`.`IDSTT` = `v_stt`.`ID`))) AS `SISAKEKURANGAN`,(case when (coalesce((select coalesce(sum(`v_list_pembayaran`.`TOTALBAYAR`),0) from `v_list_pembayaran` where (`v_list_pembayaran`.`IDSTT` = `v_stt`.`ID`))) = `v_stt`.`TOTAL_CHARGE`) then 'LUNAS' else 'BELUM LUNAS' end) AS `STATUS`,`v_stt`.`AGNTAF` AS `AGNTAF`,`v_stt`.`AGNTTRUCKING` AS `AGNTTRUCKING`,`v_stt`.`AGNTSHIPPING` AS `AGNTSHIPPING`,`v_stt`.`AGNTDELIVERY` AS `AGNTDELIVERY`,`v_stt`.`AGNTWH` AS `AGNTWH`,`v_stt`.`AGNTGRDH` AS `AGNTGRDH`,`v_stt`.`AGNTRA` AS `AGNTRA`,`v_stt`.`COST_SMU` AS `COST_SMU`,`v_stt`.`CSMU` AS `CSMU`,`v_stt`.`CDELIVERY` AS `CDELIVERY`,ifnull(`v_stt`.`CTRUCKING`,0) AS `CTRUCKING`,`v_stt`.`COST_SHIPPING` AS `COST_SHIPPING`,`v_stt`.`CGRDH` AS `CGRDH`,`v_stt`.`CWH` AS `CWH`,`v_stt`.`COST_RA` AS `COST_RA`,`v_stt`.`TOTAL_COST` AS `TOTAL_COST`,`v_stt`.`TOTAL_PROFIT` AS `TOTAL_PROFIT` from `v_stt` ;

-- ----------------------------
-- View structure for `v_tagihan`
-- ----------------------------
DROP VIEW IF EXISTS `v_tagihan`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_tagihan` AS select `agent`.`ID_AGENT` AS `ID_AGENT`,`agent`.`KODEAGENT` AS `KODEAGENT`,`agent`.`NAMAAGENT` AS `NAMAAGENT`,`tagihan`.`TGLDATANGINV` AS `TGLDATANGINV`,`tagihan`.`TGLINV` AS `TGLINV`,`tagihan`.`NOINV` AS `NOINV`,`tagihan`.`JUMLAHTAGIHAN` AS `JUMLAHTAGIHAN`,`tagihan`.`KETERANGAN` AS `KETERANGAN`,`tagihan`.`ID` AS `ID`,`agenthanding`.`NAMA` AS `NAMA` from ((`tagihan` join `agent` on((`agent`.`ID_AGENT` = `tagihan`.`IDAGENT`))) join `agenthanding` on((`agenthanding`.`ID` = `agent`.`HANDLING_ID`))) ;

-- ----------------------------
-- View structure for `v_terusan`
-- ----------------------------
DROP VIEW IF EXISTS `v_terusan`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`127.0.0.1` SQL SECURITY DEFINER VIEW `v_terusan` AS select `kota`.`KODEKOTA` AS `KODEKOTA`,`terusan`.`NAMATERUSAN` AS `NAMATERUSAN`,`kota`.`IDKOTA` AS `IDKOTA`,`terusan`.`ID` AS `ID` from (`kota` join `terusan` on((`terusan`.`IDKOTA` = `kota`.`IDKOTA`))) ;

-- ----------------------------
-- Procedure structure for `insertInvoice`
-- ----------------------------
DROP PROCEDURE IF EXISTS `insertInvoice`;
DELIMITER ;;
CREATE DEFINER=`root`@`127.0.0.1` PROCEDURE `insertInvoice`(`_TGLINVOICE` varchar(20),`_KODEINVOICE` varchar(20),`_KODECUSTOMER` varchar(20),`_KETERANGAN` varchar(255))
BEGIN
DECLARE z INT;
SELECT a.IDCUSTOMER INTO z from customer a where a.KODECUSTOMER = _KODECUSTOMER;
INSERT INTO invoice(TGLINVOICE,KODEINVOICE,IDCUSTOMER,REF_TCHARGE,REF_TCOST,KETERANGAN)
VALUES(_TGLINVOICE,_KODEINVOICE,z,0,0,_KETERANGAN);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `insertPRICELISTAGENT`
-- ----------------------------
DROP PROCEDURE IF EXISTS `insertPRICELISTAGENT`;
DELIMITER ;;
CREATE DEFINER=`root`@`127.0.0.1` PROCEDURE `insertPRICELISTAGENT`(IN `_IDAGENTHANDLING` int,IN `_IDORIGIN` int,IN `_IDAGENT` int,IN `_IDDEST` int,IN `_IDJNSKIRIM` int,IN `_IDLAYANAN` int,IN `_RATEHANDLING` int,IN `_MINPAKET` int,IN `_ISACTIVE` tinyint)
BEGIN
INSERT INTO agentpricelist(IDAGENTHANDLING,IDORIGIN,IDAGENT,IDDEST,IDJNSKIRIM,IDLAYANAN,RATEHANDLING,MINPAKET,ISACTIVE)
VALUES(_IDAGENTHANDLING,_IDORIGIN,_IDAGENT,_IDDEST,_IDJNSKIRIM,_IDLAYANAN,_RATEHANDLING,_MINPAKET,_ISACTIVE);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `insertSTT`
-- ----------------------------
DROP PROCEDURE IF EXISTS `insertSTT`;
DELIMITER ;;
CREATE DEFINER=`root`@`127.0.0.1` PROCEDURE `insertSTT`(IN `_KODECUSTOMER` varchar(20),IN `_NOCONNOTE` varchar(20),IN `_TGLCONNOTE` varchar(20),IN `_TGLMANIFEST` varchar(20),IN `_NOACCOUNT` varchar(20),IN `_NOREFERENSI` varchar(20),IN `_CONSIGNEE` varchar(20),IN `_PHONE` varchar(20),IN `_FAX` varchar(20),IN `_ALAMAT` varchar(20),IN `_NAMAMARKETING` varchar(20),IN `_IDSTATUSSTT` int,IN `_IDSERVICE` int,IN `_IDHANDLING` int,IN `_NAMAKOTAORIGIN` varchar(20),IN `_NAMAKOTADEST` varchar(20),IN `_PCS` float,IN `_WEIGHT` float,IN `_WEIGHTDIM` float,IN `DIM_P` float,IN `_DIM_L` float,IN `_DIM_T` float,IN `_RATE_KIRIM` float,IN `_CHARGE_KIRIM` float,IN `_CHARGE_DIM` float,IN `_PPN` float,IN `_INSURANCE` float,IN `_PACKING` float,IN `_CHARGE_TERUSAN` float,IN `_KAGENT_SHIPPING` varchar(20),IN `_KAGENT_DELIVERY` varchar(20),IN `_KAGENT_WAREHOUSE` varchar(20),IN `_KOTATERUSAN` varchar(20),IN `_KAGENT_RA` varchar(20),IN `_KAGENT_TRUCKING` varchar(20),IN `_KAGENT_SMU` varchar(20),IN `_NOSMU` varchar(20),IN `_KAGENT_GRDH` varchar(20),IN `_COST_SHIPPING` float,IN `_COST_DELIVERY` float,IN `_COST_TRUCKING` float,IN `_COST_WAREHOUSE` float,IN `_COST_RA` float,IN `_COST_SMU` float,IN `_COST_GRDH` float,IN `_COST_FEEMARKETING` float,IN `_COST_REFUNDCUST` float,IN `_IDSTATUSBAYAR` int,IN `_TOTAL_CHARGE` float,IN `_TOTAL_COST` float,IN `_TOTAL_PROFIT` float,IN `_NBARANGINSURANCE` float,IN `_PPNPERCENT` float,IN `_INCURANCEPERCENT` float)
BEGIN
DECLARE _IDTERUSAN INT;
DECLARE _IDCUSTOMER INT;
DECLARE _IDA_SHIPPING INT;
DECLARE _IDA_DELIVERY INT;
DECLARE _IDA_WAREHOUSE INT;
DECLARE _IDA_RA INT;
DECLARE _IDA_TRUCKING INT;
DECLARE _IDA_SMU INT;
DECLARE _IDA_GRDH INT;
DECLARE _IDKOTAORIGIN INT;
DECLARE _IDKOTADEST INT;
DECLARE _IDMARKETING INT;
SELECT ID INTO _IDTERUSAN FROM terusan WHERE NAMATERUSAN = _KOTATERUSAN;
SELECT a.ID_AGENT INTO _IDA_SHIPPING FROM agent a WHERE a.KODEAGENT = _KAGENT_SHIPPING;
SELECT b.ID_AGENT INTO _IDA_DELIVERY FROM agent b WHERE b.KODEAGENT = _KAGENT_DELIVERY;
SELECT c.ID_AGENT INTO _IDA_WAREHOUSE FROM agent c WHERE c.KODEAGENT = _KAGENT_WAREHOUSE;
SELECT d.ID_AGENT INTO _IDA_RA FROM agent d WHERE  d.KODEAGENT = _KAGENT_RA;
SELECT e.ID_AGENT INTO _IDA_TRUCKING FROM agent e WHERE e.KODEAGENT = _KAGENT_TRUCKING;
SELECT f.ID_AGENT INTO _IDA_SMU FROM agent f WHERE  f.KODEAGENT = _KAGENT_SMU;
SELECT g.ID_AGENT INTO _IDA_GRDH FROM agent g WHERE g.KODEAGENT = _KAGENT_GRDH;
SELECT IDCUSTOMER INTO _IDCUSTOMER FROM customer  WHERE KODECUSTOMER = _KODECUSTOMER;
SELECT o.IDKOTA INTO _IDKOTAORIGIN FROM kota o  WHERE o.NAMAKOTA = _NAMAKOTAORIGIN;
SELECT d.IDKOTA INTO _IDKOTADEST FROM kota d WHERE d.NAMAKOTA = _NAMAKOTADEST;
SELECT d.ID INTO _IDMARKETING FROM marketing d WHERE d.NAMA = _NAMAMARKETING;
INSERT INTO detailstt(IDCUSTOMER,NOCONNOTE,TGLCONNOTE,TGLMANIFEST,NOACCOUNT,NOREFERENSI,CONSIGNEE,PHONE,FAX,ALAMAT,IDMARKETING,IDSTATUSSTT,IDSERVICE,IDHANDLING,IDORIGIN,IDDESC,PCS,WEIGHT,WEIGHTDIM,DIM_P,DIM_L,DIM_T,RATE_KIRIM,CHARGE_KIRIM,
CHARGE_DIM,PPN,INSURANCE,PACKING,IDTERUSAN,CHARGE_TERUSAN,IDA_SHIPPING,IDA_DELIVERY,IDA_WAREHOUSE,IDA_RA,IDA_TRUCKING,IDA_SMU,NOSMU,IDA_GRDH,
COST_SHIPPING,COST_DELIVERY,COST_TRUCKING,COST_WAREHOUSE,COST_RA,COST_SMU,COST_GRDH,COST_FEEMARKETING,COST_REFUNDCUST,IDSTATUSBAYAR,TOTAL_CHARGE,
TOTAL_COST,TOTAL_PROFIT,NBARANGINSURANCE,PPNPERCENT,INCURANCEPERCENT)
VALUES(_IDCUSTOMER,_NOCONNOTE,_TGLCONNOTE,_TGLMANIFEST,_NOACCOUNT,_NOREFERENSI,_CONSIGNEE,_PHONE,_FAX,_ALAMAT,_IDMARKETING,_IDSTATUSSTT,_IDSERVICE,_IDHANDLING,_IDKOTAORIGIN,_IDKOTADEST,_PCS,_WEIGHT,_WEIGHTDIM,DIM_P,_DIM_L,_DIM_T,_RATE_KIRIM,_CHARGE_KIRIM,
_CHARGE_DIM,_PPN,_INSURANCE,_PACKING,_IDTERUSAN,_CHARGE_TERUSAN,_IDA_SHIPPING,_IDA_DELIVERY,_IDA_WAREHOUSE,_IDA_RA,_IDA_TRUCKING,_IDA_SMU,_NOSMU,_IDA_GRDH,
_COST_SHIPPING,_COST_DELIVERY,_COST_TRUCKING,_COST_WAREHOUSE,_COST_RA,_COST_SMU,_COST_GRDH,_COST_FEEMARKETING,_COST_REFUNDCUST,_IDSTATUSBAYAR,_TOTAL_CHARGE,
_TOTAL_COST,_TOTAL_PROFIT,_NBARANGINSURANCE,_PPNPERCENT,_INCURANCEPERCENT);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `updateSTT`
-- ----------------------------
DROP PROCEDURE IF EXISTS `updateSTT`;
DELIMITER ;;
CREATE DEFINER=`root`@`127.0.0.1` PROCEDURE `updateSTT`(IN `_ID` int,IN `_KODECUSTOMER` varchar(20),IN `_NOCONNOTE` varchar(20),IN `_TGLCONNOTE` varchar(20),IN `_TGLMANIFEST` varchar(20),IN `_NOACCOUNT` varchar(20),IN `_NOREFERENSI` varchar(20),IN `_CONSIGNEE` varchar(20),IN `_PHONE` varchar(20),IN `_FAX` varchar(20),IN `_ALAMAT` varchar(20),IN `_NAMAMARKETING` varchar(20),IN `_IDSTATUSSTT` int,IN `_IDSERVICE` int,IN `_IDHANDLING` int,IN `_NAMAKOTAORIGIN` varchar(20),IN `_NAMAKOTADEST` varchar(20),IN `_PCS` float,IN `_WEIGHT` float,IN `_WEIGHTDIM` float,IN `DIM_P` float,IN `_DIM_L` float,IN `_DIM_T` float,IN `_RATE_KIRIM` float,IN `_CHARGE_KIRIM` float,IN `_CHARGE_DIM` float,IN `_PPN` float,IN `_INSURANCE` float,IN `_PACKING` float,IN `_CHARGE_TERUSAN` float,IN `_KAGENT_SHIPPING` varchar(20),IN `_KAGENT_DELIVERY` varchar(20),IN `_KAGENT_WAREHOUSE` varchar(20),IN `_KOTATERUSAN` varchar(20),IN `_KAGENT_RA` varchar(20),IN `_KAGENT_TRUCKING` varchar(20),IN `_KAGENT_SMU` varchar(20),IN `_NOSMU` varchar(20),IN `_KAGENT_GRDH` varchar(20),IN `_COST_SHIPPING` float,IN `_COST_DELIVERY` float,IN `_COST_TRUCKING` float,IN `_COST_WAREHOUSE` float,IN `_COST_RA` float,IN `_COST_SMU` float,IN `_COST_GRDH` float,IN `_COST_FEEMARKETING` float,IN `_COST_REFUNDCUST` float,IN `_IDSTATUSBAYAR` int,IN `_TOTAL_CHARGE` float,IN `_TOTAL_COST` float,IN `_TOTAL_PROFIT` float,IN `_NBARANGINSURANCE` float,IN `_PPNPERCENT` float,IN `_INCURANCEPERCENT` float)
BEGIN
DECLARE _IDTERUSAN INT;
DECLARE _IDCUSTOMER INT;
DECLARE _IDA_SHIPPING INT;
DECLARE _IDA_DELIVERY INT;
DECLARE _IDA_WAREHOUSE INT;
DECLARE _IDA_RA INT;
DECLARE _IDA_TRUCKING INT;
DECLARE _IDA_SMU INT;
DECLARE _IDA_GRDH INT;
DECLARE _IDKOTAORIGIN INT;
DECLARE _IDKOTADEST INT;
DECLARE _IDMARKETING INT;
SELECT ID INTO _IDTERUSAN FROM terusan WHERE NAMATERUSAN = _KOTATERUSAN;
SELECT a.ID_AGENT INTO _IDA_SHIPPING FROM agent a WHERE a.KODEAGENT = _KAGENT_SHIPPING;
SELECT b.ID_AGENT INTO _IDA_DELIVERY FROM agent b WHERE b.KODEAGENT = _KAGENT_DELIVERY;
SELECT c.ID_AGENT INTO _IDA_WAREHOUSE FROM agent c WHERE c.KODEAGENT = _KAGENT_WAREHOUSE;
SELECT d.ID_AGENT INTO _IDA_RA FROM agent d WHERE  d.KODEAGENT = _KAGENT_RA;
SELECT e.ID_AGENT INTO _IDA_TRUCKING FROM agent e WHERE e.KODEAGENT = _KAGENT_TRUCKING;
SELECT f.ID_AGENT INTO _IDA_SMU FROM agent f WHERE  f.KODEAGENT = _KAGENT_SMU;
SELECT g.ID_AGENT INTO _IDA_GRDH FROM agent g WHERE g.KODEAGENT = _KAGENT_GRDH;
SELECT IDCUSTOMER INTO _IDCUSTOMER FROM customer  WHERE KODECUSTOMER = _KODECUSTOMER;
SELECT o.IDKOTA INTO _IDKOTAORIGIN FROM kota o  WHERE o.NAMAKOTA = _NAMAKOTAORIGIN;
SELECT d.IDKOTA INTO _IDKOTADEST FROM kota d WHERE d.NAMAKOTA = _NAMAKOTADEST;
SELECT d.ID INTO _IDMARKETING FROM marketing d WHERE d.NAMA = _NAMAMARKETING;
UPDATE detailstt SET  IDCUSTOMER = _IDCUSTOMER,NOCONNOTE = _NOCONNOTE,TGLCONNOTE = _TGLCONNOTE,TGLMANIFEST = _TGLMANIFEST,
NOACCOUNT = _NOACCOUNT, NOREFERENSI = _NOREFERENSI,CONSIGNEE = _CONSIGNEE,PHONE = _PHONE,FAX = _FAX,
ALAMAT = _ALAMAT,IDSTATUSSTT = _IDSTATUSSTT,IDSERVICE = _IDSERVICE,IDHANDLING= _IDHANDLING,IDORIGIN = _IDKOTAORIGIN,
IDDESC = _IDKOTADEST,PCS = _PCS,WEIGHT=_WEIGHT,WEIGHTDIM =_WEIGHTDIM,DIM_P = DIM_P,DIM_L = _DIM_L,DIM_T = _DIM_T,
RATE_KIRIM = _RATE_KIRIM,CHARGE_KIRIM = _CHARGE_KIRIM,CHARGE_DIM = _CHARGE_DIM,PPN = _PPN,INSURANCE = _INSURANCE,
PACKING = _PACKING,IDTERUSAN=_IDTERUSAN,CHARGE_TERUSAN=_CHARGE_TERUSAN,IDA_SHIPPING=_IDA_SHIPPING,IDA_DELIVERY=_IDA_DELIVERY,
IDA_WAREHOUSE=_IDA_WAREHOUSE,IDA_RA=_IDA_RA,IDA_TRUCKING=_IDA_TRUCKING,IDA_SMU=_IDA_SMU,NOSMU=_NOSMU,IDA_GRDH=_IDA_GRDH,
COST_SHIPPING=_COST_SHIPPING,COST_DELIVERY=_COST_DELIVERY,COST_TRUCKING=_COST_TRUCKING,COST_WAREHOUSE=_COST_WAREHOUSE,COST_RA=_COST_RA,
COST_SMU=_COST_SMU,COST_GRDH=_COST_GRDH,COST_FEEMARKETING=_COST_FEEMARKETING,COST_REFUNDCUST=_COST_REFUNDCUST,
IDSTATUSBAYAR=_IDSTATUSBAYAR,TOTAL_CHARGE=_TOTAL_CHARGE,
TOTAL_COST=_TOTAL_COST,TOTAL_PROFIT=_TOTAL_PROFIT,NBARANGINSURANCE=_NBARANGINSURANCE,
PPNPERCENT=_PPNPERCENT,INCURANCEPERCENT=_INCURANCEPERCENT,IDMARKETING=_IDMARKETING WHERE ID =_ID;
END
;;
DELIMITER ;

-- ----------------------------
-- Function structure for `getNOINVOICE`
-- ----------------------------
DROP FUNCTION IF EXISTS `getNOINVOICE`;
DELIMITER ;;
CREATE DEFINER=`root`@`127.0.0.1` FUNCTION `getNOINVOICE`(startDate VARCHAR(20), endDate VARCHAR(20),kodecust VARCHAR(20)) RETURNS int(11)
    DETERMINISTIC
BEGIN
DECLARE no_inv VARCHAR(20);
DECLARE n INT;
DECLARE s INT;
SET s = (SELECT MAX(SUBSTR(inv.KODEINVOICE, 9, 1)) FROM invoice inv where inv.TGLINVOICE BETWEEN startDate and endDate and inv.IDCUSTOMER = (SELECT IDCUSTOMER FROM customer where KODECUSTOMER = kodecust));
IF ISNULL(s) THEN SET s = 0;
END IF;
RETURN s+1;
END
;;
DELIMITER ;
