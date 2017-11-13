-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.7.9-log - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for db_halabja_ads
CREATE DATABASE IF NOT EXISTS `db_halabja_ads` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `db_halabja_ads`;

-- Dumping structure for table db_halabja_ads.tbl_balance
CREATE TABLE IF NOT EXISTS `tbl_balance` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `value` double DEFAULT '0',
  `creation` datetime DEFAULT CURRENT_TIMESTAMP,
  `bill_id` int(11) NOT NULL DEFAULT '0',
  `client_id` int(11) NOT NULL DEFAULT '0',
  `is_import` tinyint(1) NOT NULL DEFAULT '1',
  `is_dollar` tinyint(1) NOT NULL DEFAULT '0',
  `note` text,
  `balance_pay_id` int(11) DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `tbl_balance_ibfk_2_idx` (`bill_id`),
  KEY `FK_tbl_balance_tbl_clients` (`client_id`),
  KEY `FK_tbl_balance_tbl_balance_pay` (`balance_pay_id`),
  CONSTRAINT `FK_tbl_balance_tbl_balance_pay` FOREIGN KEY (`balance_pay_id`) REFERENCES `tbl_balance_pay` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_balance_tbl_bills` FOREIGN KEY (`bill_id`) REFERENCES `tbl_bills` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_balance_tbl_clients` FOREIGN KEY (`client_id`) REFERENCES `tbl_clients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=288 DEFAULT CHARSET=utf8 COMMENT='Type:Client,Delegate,Employer';

-- Dumping data for table db_halabja_ads.tbl_balance: ~1 rows (approximately)
/*!40000 ALTER TABLE `tbl_balance` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_balance` ENABLE KEYS */;

-- Dumping structure for table db_halabja_ads.tbl_balance_pay
CREATE TABLE IF NOT EXISTS `tbl_balance_pay` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `creation` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8;

-- Dumping data for table db_halabja_ads.tbl_balance_pay: ~1 rows (approximately)
/*!40000 ALTER TABLE `tbl_balance_pay` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_balance_pay` (`id`, `creation`) VALUES
	(0, '2017-05-23 17:46:41');
/*!40000 ALTER TABLE `tbl_balance_pay` ENABLE KEYS */;

-- Dumping structure for table db_halabja_ads.tbl_bills
CREATE TABLE IF NOT EXISTS `tbl_bills` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `is_account` tinyint(1) NOT NULL DEFAULT '1',
  `is_sell` tinyint(1) NOT NULL DEFAULT '1',
  `client_id` int(11) NOT NULL,
  `is_dollar` tinyint(1) NOT NULL DEFAULT '1',
  `is_cash` tinyint(1) NOT NULL DEFAULT '1',
  `note` text,
  `datetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `discount` double DEFAULT '0',
  `name` varchar(255) DEFAULT NULL,
  `location` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `delegate_id` int(11) NOT NULL,
  `delegate_percent` int(11) NOT NULL DEFAULT '10',
  PRIMARY KEY (`id`),
  KEY `client_id` (`client_id`),
  KEY `FK_tbl_bills_tbl_clients` (`delegate_id`),
  CONSTRAINT `FK_tbl_bills_tbl_clients` FOREIGN KEY (`delegate_id`) REFERENCES `tbl_clients` (`id`),
  CONSTRAINT `FK_tbl_bills_tbl_clients_2` FOREIGN KEY (`client_id`) REFERENCES `tbl_clients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=454 DEFAULT CHARSET=utf8;

-- Dumping data for table db_halabja_ads.tbl_bills: ~4 rows (approximately)
/*!40000 ALTER TABLE `tbl_bills` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_bills` (`id`, `is_account`, `is_sell`, `client_id`, `is_dollar`, `is_cash`, `note`, `datetime`, `discount`, `name`, `location`, `phone`, `email`, `delegate_id`, `delegate_percent`) VALUES
	(0, 1, 1, 1, 1, 1, '0', '2016-06-24 13:42:36', 0, '0', '0', '0', '0', 2, 10);
/*!40000 ALTER TABLE `tbl_bills` ENABLE KEYS */;

-- Dumping structure for table db_halabja_ads.tbl_clients
CREATE TABLE IF NOT EXISTS `tbl_clients` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `location` varchar(255) DEFAULT '',
  `mobile` varchar(50) DEFAULT '',
  `email` varchar(50) DEFAULT '',
  `type` int(2) NOT NULL DEFAULT '0',
  `is_active` tinyint(1) NOT NULL DEFAULT '1',
  `percent` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=98 DEFAULT CHARSET=utf8 COMMENT='public enum clientType\r\n        {\r\n            Client,\r\n            Supplier,\r\n            Delegate,\r\n            Employer\r\n        }';

-- Dumping data for table db_halabja_ads.tbl_clients: ~30 rows (approximately)
/*!40000 ALTER TABLE `tbl_clients` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_clients` (`id`, `name`, `location`, `mobile`, `email`, `type`, `is_active`, `percent`) VALUES
	(1, 'نقدي', 'دهوك', '0750', '@', 0, 1, 0),
	(2, 'العام', 'دهوك', '0', '@', 2, 1, 0);
/*!40000 ALTER TABLE `tbl_clients` ENABLE KEYS */;

-- Dumping structure for table db_halabja_ads.tbl_debits
CREATE TABLE IF NOT EXISTS `tbl_debits` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `datetime` datetime DEFAULT CURRENT_TIMESTAMP,
  `is_dollar` tinyint(1) NOT NULL DEFAULT '0',
  `is_pay` tinyint(1) NOT NULL DEFAULT '0',
  `value` double NOT NULL DEFAULT '0',
  `employee_id` int(11) NOT NULL,
  `note` text,
  PRIMARY KEY (`id`),
  KEY `employee_id` (`employee_id`),
  CONSTRAINT `tbl_debits_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `tbl_clients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8;

-- Dumping data for table db_halabja_ads.tbl_debits: ~0 rows (approximately)
/*!40000 ALTER TABLE `tbl_debits` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_debits` ENABLE KEYS */;

-- Dumping structure for table db_halabja_ads.tbl_dollar
CREATE TABLE IF NOT EXISTS `tbl_dollar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `value` double NOT NULL DEFAULT '0',
  `creation` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8;

-- Dumping data for table db_halabja_ads.tbl_dollar: ~31 rows (approximately)
/*!40000 ALTER TABLE `tbl_dollar` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_dollar` (`id`, `value`, `creation`) VALUES
	(1, 1300, '2017-01-31 11:04:52');
/*!40000 ALTER TABLE `tbl_dollar` ENABLE KEYS */;

-- Dumping structure for table db_halabja_ads.tbl_products
CREATE TABLE IF NOT EXISTS `tbl_products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` text,
  `price` double NOT NULL DEFAULT '0',
  `count` double NOT NULL DEFAULT '0',
  `note` text,
  `bill_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `bill_id` (`bill_id`),
  CONSTRAINT `tbl_products_ibfk_1` FOREIGN KEY (`bill_id`) REFERENCES `tbl_bills` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1789 DEFAULT CHARSET=utf8;

-- Dumping data for table db_halabja_ads.tbl_products: ~3 rows (approximately)
/*!40000 ALTER TABLE `tbl_products` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_products` ENABLE KEYS */;

-- Dumping structure for table db_halabja_ads.tbl_users
CREATE TABLE IF NOT EXISTS `tbl_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `type` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Dumping data for table db_halabja_ads.tbl_users: ~3 rows (approximately)
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_users` (`id`, `name`, `password`, `type`) VALUES
	(1, 'admin', 'admin', 0),
	(2, 'siver', '1', 1),
	(3, 'obyda', '2', 1);
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;

-- Dumping structure for procedure db_halabja_ads.getCaseValue
DELIMITER //
CREATE DEFINER=`root`@`%` PROCEDURE `getCaseValue`(
	IN `from` DATETIME,
	IN `to` DATETIME


















































)
BEGIN
	declare getCashSellDinar double;
	declare getCashSellDollar double;
	declare getCashSell double;
	
	declare getDebitSellDinar double;
	declare getDebitSellDollar double;
	declare getDebitSell double;
	
	declare getDebitSellDateDinar double;
	declare getDebitSellDateDollar double;
	declare getDebitSellDate double;
	
	declare getCashNotSellDinar double;
	declare getCashNotSellDollar double;
	declare getCashNotSell double;
	
	declare getCashNotSellNotCashDinar double;
	declare getCashNotSellNotCashDollar double;
	declare getCashNotSellNotCash double;
	
	declare getCashNotSellNotCashDateDinar double;
	declare getCashNotSellNotCashDateDollar double;
	declare getCashNotSellNotCashDate double;
	
	declare getDelegatesReceivingDinar double;
	declare getDelegatesReceivingDollar double;
	declare getDelegatesReceiving double;
	
	declare getDelegatesRemainingDinar double;
	declare getDelegatesRemainingDollar double;
	declare getDelegatesRemaining double;
	
	declare getBalanceDelegateDateDinar double;
	declare getBalanceDelegateDateDollar double;
	declare getBalanceDelegateDate double;
	
	declare getBalanceDelegateDinar double;
	declare getBalanceDelegateDollar double;
	declare getBalanceDelegate double;
	
	declare getBalanceExportSalaryDinar double;
	declare getBalanceExportSalaryDollar double;
	declare getBalanceExportSalary double;
	
	declare getBalanceExportNonSalaryDinar double;
	declare getBalanceExportNonSalaryDollar double;
	declare getBalanceExportNonSalary double;
	
	declare getBalanceImportDinar double;
	declare getBalanceImportDollar double;
	declare getBalanceImport double;
	
	declare getDebitsTotalDinar double;
	declare getDebitsTotalDollar double;
	declare getDebitsTotal double;
	
	declare getDebitsTotalDateDinar double;
	declare getDebitsTotalDateDollar double;
	declare getDebitsTotalDate double;
	
	declare earningsDinar double;
	declare earningsDollar double;
	declare earnings double;
	
	declare caseValueDinar double;
	declare caseValueDollar double;
	declare caseValue double;
	
	set getBalanceDelegateDateDinar = getBalanceDelegateFromTo(`from`,`to`,0);
	set getBalanceDelegateDateDollar = getBalanceDelegateFromTo(`from`,`to`,1);
	set getBalanceDelegateDate = getBalanceDelegateFromTo(`from`,`to`,2);
	
	set getBalanceDelegateDinar = getBalanceDelegate(`to`,0);
	set getBalanceDelegateDollar = getBalanceDelegate(`to`,1);
	set getBalanceDelegate = getBalanceDelegate(`to`,2);
	
	set getDelegatesReceivingDinar = getDelegatesReceiving(`to`,0) - getBalanceDelegate(`to`,0);
	set getDelegatesReceivingDollar = getDelegatesReceiving(`to`,1) - getBalanceDelegate(`to`,1);
	set getDelegatesReceiving = getDelegatesReceiving(`to`,2) - getBalanceDelegate(`to`,2);
	
	set getDelegatesRemainingDinar = getDelegatesRemaining(`to`,0) ;
	set getDelegatesRemainingDollar = getDelegatesRemaining(`to`,1) ;
	set getDelegatesRemaining = getDelegatesRemaining(`to`,2) ;
	
	set getBalanceExportSalaryDinar = getBalanceFromTo(`from`,`to`,0,1,0) - getBalanceDelegateDateDinar;
	set getBalanceExportSalaryDollar = getBalanceFromTo(`from`,`to`,0,1,1)- getBalanceDelegateDateDollar;
	set getBalanceExportSalary = getBalanceFromTo(`from`,`to`,0,1,2) - getBalanceDelegateDate;
	
	set getBalanceImportDinar = getBalanceFromTo(`from`,`to`,1,0,0);
	set getBalanceImportDollar = getBalanceFromTo(`from`,`to`,1,0,1);
	set getBalanceImport = getBalanceFromTo(`from`,`to`,1,0,2);
	
	set getCashSellDinar = getCashFromTo(`from`,`to`,1,1,0) + getBalanceFromTo(`from`,`to`,1,0,0);
	set getCashSellDollar = getCashFromTo(`from`,`to`,1,1,1) + getBalanceFromTo(`from`,`to`,1,0,1);
	set getCashSell = getCashFromTo(`from`,`to`,1,1,2) + getBalanceFromTo(`from`,`to`,1,0,2);
	
	set getDebitSellDinar = getCash(`to`,1,0,0) - getBalance(`to`,1,0,0);
	set getDebitSellDollar = getCash(`to`,1,0,1) - getBalance(`to`,1,0,1);
	set getDebitSell = getCash(`to`,1,0,2) - getBalance(`to`,1,0,2);
	
	set getDebitSellDateDinar = getCashFromTo(`from`,`to`,1,0,0) - getBalanceFromTo(`from`,`to`,1,0,0);
	set getDebitSellDateDollar = getCashFromTo(`from`,`to`,1,0,1) - getBalanceFromTo(`from`,`to`,1,0,1);
	set getDebitSellDate = getCashFromTo(`from`,`to`,1,0,2) - getBalanceFromTo(`from`,`to`,1,0,2);
	
	set getCashNotSellDinar = getCashFromTo(`from`,`to`,0,1,0) + getBalanceFromTo(`from`,`to`,0,0,0);
	set getCashNotSellDollar = getCashFromTo(`from`,`to`,0,1,1) + getBalanceFromTo(`from`,`to`,0,0,1) ;
	set getCashNotSell = getCashFromTo(`from`,`to`,0,1,2) + getBalanceFromTo(`from`,`to`,0,0,2);
	
	set getCashNotSellNotCashDinar = getCash(`to`,0,0,0) - getBalance(`to`,0,0,0);
	set getCashNotSellNotCashDollar = getCash(`to`,0,0,1) - getBalance(`to`,0,0,1);
	set getCashNotSellNotCash = getCash(`to`,0,0,2) - getBalance(`to`,0,0,2);

	
	set getCashNotSellNotCashDateDinar = getCashFromTo(`from`,`to`,0,0,0) - getBalanceFromTo(`from`,`to`,0,0,0);
	set getCashNotSellNotCashDateDollar = getCashFromTo(`from`,`to`,0,0,1) - getBalanceFromTo(`from`,`to`,0,0,1);
	set getCashNotSellNotCashDate = getCashFromTo(`from`,`to`,0,0,2) - getBalanceFromTo(`from`,`to`,0,0,2);
	
	set getDebitsTotalDinar = 
		ifnull(
			(
				select sum(if(tbl_debits.is_pay = 1,0,tbl_debits.value)) - sum(if(tbl_debits.is_pay = 0,0,tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1))) from tbl_debits where tbl_debits.is_dollar = 0 and tbl_debits.datetime <= `to`
			)
		,0);
	set getDebitsTotalDollar = 
		ifnull(
			(
				select sum(if(tbl_debits.is_pay = 1,0,tbl_debits.value )) - sum(if(tbl_debits.is_pay = 0,0,tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1))) from tbl_debits where tbl_debits.is_dollar = 1 and tbl_debits.datetime <= `to`
			)
		,0);
	set getDebitsTotal = 
		ifnull(
			(
				select 
					(sum(if(tbl_debits.is_pay = 1,0,tbl_debits.value )) - sum(if(tbl_debits.is_pay = 0,0,tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1))))
					*
					if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)
				from tbl_debits where  tbl_debits.datetime <= `to`
			)
		,0);
		
	set getDebitsTotalDateDinar = 
		ifnull(
			(
				select 
					(sum(if(tbl_debits.is_pay = 1,0,tbl_debits.value)) - sum(if(tbl_debits.is_pay = 0,0,tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1))))
				from tbl_debits where tbl_debits.is_dollar = 0 and tbl_debits.datetime between `from` and `to`
			)
		,0);
	set getDebitsTotalDateDollar = 
		ifnull(
			(
				select sum(if(tbl_debits.is_pay = 1,0,tbl_debits.value )) - sum(if(tbl_debits.is_pay = 0,0,tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1))) from tbl_debits where tbl_debits.is_dollar = 1 and tbl_debits.datetime between `from` and `to`
			)
		,0);
	set getDebitsTotalDate = 
		ifnull(
			(
				select 
					(sum(if(tbl_debits.is_pay = 1,0,tbl_debits.value )) - sum(if(tbl_debits.is_pay = 0,0,tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1))))
					*
					if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)
				from tbl_debits where  tbl_debits.datetime between `from` and `to`
			)
		,0);

	set earningsDinar = 
		(getCash(`to`,1,1,0) + getBalance(`to`,1,0,0))
		-
		(
			(getCash(`to`,0,1,0) + getBalance(`to`,0,0,0))
			+
			(getBalance(`to`,0,1,0) - getBalanceDelegate(`to`,0))
			+
			(getDelegatesReceiving(`to`,0) )
			
		);
	set earningsDollar = 
		(getCash(`to`,1,1,1) + getBalance(`to`,1,0,1))
		-
		(
			(getCash(`to`,0,1,1) + getBalance(`to`,0,0,1))
			+
			(getBalance(`to`,0,1,1) - getBalanceDelegate(`to`,1))
			+
			(getDelegatesReceiving(`to`,1) )
			
		);
	set earnings = 
		(getCash(`to`,1,1,2) + getBalance(`to`,1,0,2))
		-
		(
			(getCash(`to`,0,1,2) + getBalance(`to`,0,0,2))
			+
			(getBalance(`to`,0,1,2) - getBalanceDelegate(`to`,2))
			+
			(getDelegatesReceiving(`to`,2) )
			
		);
	set caseValueDinar = 
		getCash(`to`,1,1,0) + getBalance(`to`,1,0,0)
		-
		(
			getCash(`to`,0,1,0)
			+
			(getBalance(`to`,0,0,0) - getBalanceDelegate(`to`,0))
			+
			(getBalance(`to`,0,1,0) - getBalanceDelegate(`to`,0))
			+
			getBalanceDelegate(`to`,0)
			+
			getDebitsTotalDinar
			+
			getBalanceDelegateDinar
		);
	set caseValueDollar = 
		getCash(`to`,1,1,1) + getBalance(`to`,1,0,1)
		-
		(
			getCash(`to`,0,1,1)
			+
			(getBalance(`to`,0,0,1) - getBalanceDelegate(`to`,1))
			+
			(getBalance(`to`,0,1,1) - getBalanceDelegate(`to`,1))
			+
			getBalanceDelegate(`to`,1)
			+
			getDebitsTotalDollar
			+
			getBalanceDelegateDollar
		);
	set caseValue = 
		getCash(`to`,1,1,2) + getBalance(`to`,1,0,2)
		-
		(
			getCash(`to`,0,1,2)
			+
			(getBalance(`to`,0,0,2) - getBalanceDelegate(`to`,2))
			+
			(getBalance(`to`,0,1,2) - getBalanceDelegate(`to`,2))
			+
			getBalanceDelegate(`to`,2)
			+
			getDebitsTotal
			+
			getBalanceDelegate
		);
	
	select 
		getCashSell as `getCashSell`,
		getCashSellDinar as `getCashSellDinar`,
		FORMAT(getCashSellDollar,2) as `getCashSellDollar`,
		
		getDebitSell as `getDebitSell`,
		getDebitSellDinar as `getDebitSellDinar`,
		FORMAT(getDebitSellDollar,2) as `getDebitSellDollar`,
		
		if(getDebitSellDate < 0,0,getDebitSellDate) as `getDebitSellDate`,
		if(getDebitSellDateDinar < 0,0,getDebitSellDateDinar) as `getDebitSellDateDinar`,
		FORMAT(if(getDebitSellDateDollar < 0,0,getDebitSellDateDollar),2) as `getDebitSellDateDollar`,
		
		getCashNotSell as `getCashNotSell`,
		getCashNotSellDinar as `getCashNotSellDinar`,
		FORMAT(getCashNotSellDollar,2) as `getCashNotSellDollar`,
		
		getCashNotSellNotCash as `getCashNotSellNotCash`,
		getCashNotSellNotCashDinar as `getCashNotSellNotCashDinar`,
		FORMAT(getCashNotSellNotCashDollar,2) as `getCashNotSellNotCashDollar`,
		
		if(getCashNotSellNotCashDate < 0,0,getCashNotSellNotCashDate) as `getCashNotSellNotCashDate`,
		if(getCashNotSellNotCashDateDinar< 0,0,getCashNotSellNotCashDateDinar) as `getCashNotSellNotCashDateDinar`,
		FORMAT(if(getCashNotSellNotCashDateDollar < 0,0,getCashNotSellNotCashDateDollar),2) as `getCashNotSellNotCashDateDollar`,
		
		getDelegatesReceiving as `getDelegatesReceiving`,
		getDelegatesReceivingDinar as `getDelegatesReceivingDinar`,
		FORMAT(getDelegatesReceivingDollar,2) as `getDelegatesReceivingDollar`,
		
		getDelegatesRemaining as `getDelegatesRemaining`,
		getDelegatesRemainingDinar as `getDelegatesRemainingDinar`,
		FORMAT(getDelegatesRemainingDollar,2) as `getDelegatesRemainingDollar`,
		
		if(getBalanceDelegateDate < 0,0,getBalanceDelegateDate) as `getBalanceDelegateDate`,
		if(getBalanceDelegateDateDinar < 0,0,getBalanceDelegateDateDinar) as `getBalanceDelegateDateDinar`,
		FORMAT(if(getBalanceDelegateDateDollar < 0,0,getBalanceDelegateDateDollar),2) as `getBalanceDelegateDateDollar`,
		
		getBalanceDelegate as `getBalanceDelegate`,
		getBalanceDelegateDinar as `getBalanceDelegateDinar`,
		FORMAT(getBalanceDelegateDollar,2) as `getBalanceDelegateDollar`,
		
		getBalanceExportSalary as `getBalanceExportSalary`,
		getBalanceExportSalaryDinar as `getBalanceExportSalaryDinar`,
		FORMAT(getBalanceExportSalaryDollar,2) as `getBalanceExportSalaryDollar`,
		
		getBalanceImport as `getBalanceImport`,
		getBalanceImportDinar as `getBalanceImportDinar`,
		FORMAT(getBalanceImportDollar,2) as `getBalanceImportDollar`,
		
		getDebitsTotal as `getDebitsTotal`,
		getDebitsTotalDinar as `getDebitsTotalDinar`,
		FORMAT(getDebitsTotalDollar,2) as `getDebitsTotalDollar`,
		
		if(getDebitsTotalDate < 0,0,getDebitsTotalDate) as `getDebitsTotalDate`,
		if(getDebitsTotalDateDinar < 0,0,getDebitsTotalDateDinar) as `getDebitsTotalDateDinar`,
		FORMAT(if(getDebitsTotalDateDollar < 0,0,getDebitsTotalDateDollar),2) as `getDebitsTotalDateDollar`,
		
		earnings as `earnings`,
		earningsDinar as `earningsDinar`,
		FORMAT(earningsDollar,2) as `earningsDollar`,
		
		caseValue as `caseValue`,
		caseValueDinar as `caseValueDinar`,
		FORMAT(caseValueDollar,2) as `caseValueDollar`
		
		
	;
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getBalance
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getBalance`(
	`to` DATETIME
,
	`isImport` INT
,
	`isSalary` TINYINT
,
	`isDollar` TINYINT





) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select
			sum(
				tbl_balance.value
				*
				if(
					isDollar = 2,
					if(tbl_balance.is_dollar = 1,getDollar(tbl_bills.datetime),1),
					if(isDollar = tbl_balance.is_dollar,1,0)
				)
			)
		from
			tbl_balance,
			tbl_bills
		where
			tbl_balance.bill_id = tbl_bills.id and
			tbl_bills.id between if(isSalary = 1,0,1) and if(isSalary = 1,0,1000000) and
			tbl_balance.is_import = isImport and 
			tbl_balance.creation <=  `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getBalanceDelegate
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getBalanceDelegate`(
	`to` DATETIME

,
	`isDollar` TINYINT




) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select
			sum(
				tbl_balance.value
				*
				if(
					isDollar = 2,
					if(tbl_balance.is_dollar = 1,getDollar(null),1),
					if(isDollar = tbl_balance.is_dollar,1,0)
				)
			)
		from
			tbl_balance,
			tbl_clients
		where
			tbl_balance.is_import = 0 and 
			tbl_clients.id = tbl_balance.client_id and
			tbl_clients.`type` = 2 and
			tbl_balance.creation <= `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getBalanceDelegateFromTo
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getBalanceDelegateFromTo`(
	`from` DATETIME,
	`to` DATETIME
,
	`isDollar` TINYINT




) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select
			sum(
				tbl_balance.value
				*
				if(
					isDollar = 2,
					if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1),
					if(isDollar = tbl_balance.is_dollar,1,0)
				)
				)
		from
			tbl_balance,
			tbl_clients
		where 
			tbl_clients.id = tbl_balance.client_id and
			tbl_clients.`type` = 2 and
			tbl_balance.creation between `from` and `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getBalanceFromTo
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getBalanceFromTo`(
	`from` DATETIME,
	`to` DATETIME,
	`isImport` TINYINT,
	`isSalary` TINYINT
,
	`isDollar` TINYINT




) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select
			sum(
				tbl_balance.value
				*
				if(
					isDollar = 2,
					if(tbl_balance.is_dollar = 1,getDollar(null),1),
					if(isDollar = tbl_balance.is_dollar,1,0)
				)
				)
		from
			tbl_balance,
			tbl_bills
		where
			tbl_balance.bill_id = tbl_bills.id and
			tbl_bills.id between if(isSalary = 1,0,1) and if(isSalary = 1,0,10000000) and
			tbl_balance.is_import = isImport and 
			tbl_balance.creation between `from` and `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getCash
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getCash`(
	`to` DATETIME

,
	`isSell` INT
,
	`isCash` INT

,
	`isDollar` TINYINT








) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select
			sum(
				(
					select
						(sum(tbl_products.price * tbl_products.count) - tbl_bills.discount)
						*
						if(
							isDollar = 2,
							if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1),
							if(isDollar = tbl_bills.is_dollar,1,0)
						)
					from
						tbl_products
					where
						tbl_products.bill_id = tbl_bills.id
				) 
			)
		from
			tbl_bills
		where
			tbl_bills.id > 0 and
			tbl_bills.is_account = 1 and
			tbl_bills.is_sell = isSell and
			tbl_bills.is_cash = isCash and
			tbl_bills.datetime <= `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getCashFromTo
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getCashFromTo`(
	`from` DATETIME,
	`to` DATETIME,
	`isSell` TINYINT,
	`isCash` TINYINT
,
	`isDollar` TINYINT





) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select
			sum(
				(
					select
						(sum(tbl_products.price * tbl_products.count) - tbl_bills.discount)
						*
						if(
							isDollar = 2,
							if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1),
							if(isDollar = tbl_bills.is_dollar,1,0)
						)
					from
						tbl_products
					where
						tbl_products.bill_id = tbl_bills.id
				)
			)
		from
			tbl_bills
		where
			tbl_bills.id > 0 and
			tbl_bills.is_account = 1 and
			tbl_bills.is_sell = isSell and
			tbl_bills.is_cash = isCash and
			tbl_bills.datetime between `from` and `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getDelegatesReceiving
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getDelegatesReceiving`(
	`to` DATETIME




,
	`isDollar` TINYINT






) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select 
			sum((
				if(tbl_bills.is_cash = 1,(((tbl_products.count * tbl_products.price) - tbl_bills.discount)  * (tbl_bills.delegate_percent/100)),(select sum(tbl_balance.value) * (tbl_bills.delegate_percent/100) from tbl_balance where tbl_balance.bill_id = tbl_bills.id ))
				*
				if(
					isDollar = 2,
					if(tbl_bills.is_dollar = 1,getDollar(null),1),
					if(isDollar = tbl_bills.is_dollar,1,0)
				)
			)) as `value` 
		
		from 
			tbl_bills,
			tbl_clients,
			tbl_products 
		where 
			tbl_bills.id > 0 and 
			tbl_clients.`type` = 2 and 
			tbl_bills.delegate_id = tbl_clients.id and 
			tbl_bills.id = tbl_products.bill_id and
			tbl_bills.datetime <= `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getDelegatesReceivingFromTo
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getDelegatesReceivingFromTo`(
	`from` DATETIME,
	`to` DATETIME,
	`isDollar` INT





) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select 
			(
				sum(if(tbl_bills.is_cash = 1,(((tbl_products.count * tbl_products.price) - tbl_bills.discount)  * (tbl_bills.delegate_percent/100)),(select sum(tbl_balance.value) * (tbl_bills.delegate_percent/100) from tbl_balance where tbl_balance.bill_id = tbl_bills.id )))
				*
				if(
					isDollar = 2,
					if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1),
					if(isDollar = tbl_bills.is_dollar,1,0)
				)
			) as `value` 
		from 
			tbl_bills,
			tbl_clients,
			tbl_products 
		where 
			tbl_bills.id > 0 and 
			tbl_clients.`type` = 2 and 
			tbl_bills.delegate_id = tbl_clients.id and 
			tbl_bills.id = tbl_products.bill_id and
			tbl_bills.datetime between `from` and `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getDelegatesRemaining
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getDelegatesRemaining`(
	`to` DATETIME




,
	`isDollar` TINYINT





) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select
		sum(ifnull((
			select
				((
					(sum(tbl_products.price * tbl_products.count ) - tbl_bills.discount)
				) * (tbl_bills.delegate_percent/100))
				*
				if(
					isDollar = 2,
					if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1),
					if(isDollar = tbl_bills.is_dollar,1,0)
				)
			from
				tbl_products
			where
				tbl_products.bill_id = tbl_bills.id
		),0) -
		ifnull((
			select
				(sum(
					tbl_balance.value
				) * (tbl_bills.delegate_percent/100))
				*
				if(
					isDollar = 2,
					if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1),
					if(isDollar = tbl_bills.is_dollar,1,0)
				)
			from
				tbl_balance
			where
				tbl_balance.bill_id = tbl_bills.id
		),0))
	from
		tbl_bills,
		tbl_clients
	where
		tbl_bills.id > 0 and
		tbl_bills.is_account = 1 and
		tbl_bills.is_sell = 1 and
		tbl_bills.is_cash = 0 and
		tbl_bills.delegate_id = tbl_clients.id and
		tbl_clients.`type` = 2 and
		tbl_bills.datetime <=`to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getDollar
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getDollar`(
	`date` DATETIME


) RETURNS double
BEGIN
	return ifnull(
			ifnull((select `value` from tbl_dollar where tbl_dollar.creation between CONCAT(DATE_FORMAT(date,'%Y-%m-%d'),' 00:00:00') and CONCAT(DATE_FORMAT(date,'%Y-%m-%d'),' 23:59:59') order by id desc limit 1),
			(select `value` from tbl_dollar where tbl_dollar.creation <= ifnull(date,CURRENT_TIMESTAMP) order by id desc limit 1)),
			(select `value` from tbl_dollar order by id desc limit 1)
		);	
END//
DELIMITER ;

-- Dumping structure for function db_halabja_ads.getImportDebit
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getImportDebit`(
	`from` DATETIME,
	`to` DATETIME
) RETURNS double
BEGIN
	return ((CAST((ifnull((
		select
			sum(if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count)) - if(tbl_bills.is_dollar = 1,tbl_bills.discount * getDollar(tbl_bills.datetime),tbl_bills.discount)
		from
			tbl_bills,
            tbl_products
		where
			tbl_bills.id = tbl_products.bill_id and
            tbl_bills.is_cash = 0 and
			tbl_bills.datetime between `from` and `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
