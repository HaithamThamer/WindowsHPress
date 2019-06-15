-- --------------------------------------------------------
-- Host:                         192.168.111.14
-- Server version:               8.0.11 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for db_h_press
CREATE DATABASE IF NOT EXISTS `db_h_press` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `db_h_press`;

-- Dumping structure for function db_h_press.getBalance
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

-- Dumping structure for function db_h_press.getBalanceDelegate
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

-- Dumping structure for function db_h_press.getBalanceDelegateFromTo
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

-- Dumping structure for function db_h_press.getBalanceFromTo
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

-- Dumping structure for procedure db_h_press.getCaseValue
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
	
	declare earningsDateDinar double;
	declare earningsDateDollar double;
	declare earningsDate double;
	
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
				select (sum(if(tbl_debits.is_pay = 1,0,tbl_debits.value)) - sum(if(tbl_debits.is_pay = 0,0,tbl_debits.value )))* if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1) from tbl_debits where tbl_debits.is_dollar = 0 and tbl_debits.datetime <= `to`
			)
		,0);
	set getDebitsTotalDollar = 
		ifnull(
			(
				select (sum(if(tbl_debits.is_pay = 1,0,tbl_debits.value )) - sum(if(tbl_debits.is_pay = 0,0,tbl_debits.value))) * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)from tbl_debits where tbl_debits.is_dollar = 1 and tbl_debits.datetime <= `to`
			)
		,0);
	set getDebitsTotal = (
		select (select ifnull(sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(null),1)),0) from tbl_debits where tbl_debits.is_pay = 1 and tbl_debits.datetime <= '{0}') - (select ifnull(sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(null),1)),0) from tbl_debits where tbl_debits.is_pay = 0 and tbl_debits.datetime <= '{0}')
	);
		
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
					(sum(if(tbl_debits.is_pay = 1,0,tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1))) - sum(if(tbl_debits.is_pay = 0,0,tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1))))
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
			(getDelegatesReceiving(`to`,2))
			
		);
		
		
		
		
		
		set earningsDateDinar = 
		(getCashFromTo(`from`,`to`,1,1,0) + getBalanceFromTo(`from`,`to`,1,0,0))
		-
		(
			(getCashFromTo(`from`,`to`,0,1,0) + getBalanceFromTo(`from`,`to`,0,0,0))
			+
			(getBalanceFromTo(`from`,`to`,0,1,0) - getBalanceDelegateFromTo(`from`,`to`,0))
			+
			(getDelegatesReceivingFromTo(`from`,`to`,0) )
			
		);
	set earningsDateDollar = 
		(getCashFromTo(`from`,`to`,1,1,1) + getBalanceFromTo(`from`,`to`,1,0,1))
		-
		(
			(getCashFromTo(`from`,`to`,0,1,1) + getBalanceFromTo(`from`,`to`,0,0,1))
			+
			(getBalanceFromTo(`from`,`to`,0,1,1) - getBalanceDelegateFromTo(`from`,`to`,1))
			+
			(getDelegatesReceivingFromTo(`from`,`to`,1) )
			
		);
	set earningsDate = 
		(getCashFromTo(`from`,`to`,1,1,2) + getBalanceFromTo(`from`,`to`,1,0,2))
		-
		(
			(getCashFromTo(`from`,`to`,0,1,2) + getBalanceFromTo(`from`,`to`,0,0,2))
			+
			(getBalanceFromTo(`from`,`to`,0,1,2) - getBalanceDelegateFromTo(`from`,`to`,2))
			+
			(getDelegatesReceivingFromTo(`from`,`to`,2) )
			
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
		
		earningsDate as `earningsDate`,
		earningsDateDinar as `earningsDateDinar`,
		FORMAT(earningsDateDollar,2) as `earningsDateDollar`,
		
		caseValue as `caseValue`,
		caseValueDinar as `caseValueDinar`,
		FORMAT(caseValueDollar,2) as `caseValueDollar`
		
	;
END//
DELIMITER ;

-- Dumping structure for function db_h_press.getCash
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

-- Dumping structure for function db_h_press.getCashFromTo
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

-- Dumping structure for procedure db_h_press.getDebits
DELIMITER //
CREATE DEFINER=`root`@`%` PROCEDURE `getDebits`(
	IN `clientName` VARCHAR(255),
	IN `isSell` TINYINT
)
    DETERMINISTIC
BEGIN
select
	id,
	name,
	location,
	mobile,
	email,
	FORMAT(ifnull((
		(
			ifnull((
				select
					sum(products.price * products.count)
				from
					tbl_bills bills
				inner join
					tbl_products products ON products.bill_id = bills.id
				where
					bills.is_dollar = 0 and
					bills.is_account = 1 and
					bills.is_sell = `isSell` and
					bills.is_cash = 0 and
					bills.client_id = tbl_clients.id
			),0)
			-
			ifnull((
				select
					sum(bills.discount)
				from
					tbl_bills bills
				
				where
					bills.is_dollar = 0 and
					bills.is_account = 1 and
					bills.is_sell = `isSell` and
					bills.is_cash = 0 and
					bills.client_id = tbl_clients.id
					
			),0)
			-
			ifnull((
				select
					sum(balance.value)
				from
					tbl_bills bills
				inner join
					tbl_balance balance ON balance.bill_id = bills.id
				where
					bills.is_dollar = 0 and
					bills.is_account = 1 and
					bills.is_sell = `isSell` and
					bills.is_cash = 0 and
					bills.client_id = tbl_clients.id
			),0)
		)
	),0),0) as `remaining_dinar`,
	FORMAT(ifnull((
		(
			ifnull((
				select
					sum(products.price * products.count)
				from
					tbl_bills bills
				inner join
					tbl_products products ON products.bill_id = bills.id
				where
					bills.is_dollar = 1 and
					bills.is_account = 1 and
					bills.is_sell = `isSell` and
					bills.is_cash = 0 and
					bills.client_id = tbl_clients.id
			),0)
			-
			ifnull((
				select
					sum(bills.discount)
				from
					tbl_bills bills
				
				where
					bills.is_dollar = 1 and
					bills.is_account = 1 and
					bills.is_sell = `isSell` and
					bills.is_cash = 0 and
					bills.client_id = tbl_clients.id
					
			),0)
			-
			ifnull((
				select
					sum(balance.value)
				from
					tbl_bills bills
				inner join
					tbl_balance balance ON balance.bill_id = bills.id
				where
					bills.is_dollar = 1 and
					bills.is_account = 1 and
					bills.is_sell = `isSell` and
					bills.is_cash = 0 and
					bills.client_id = tbl_clients.id
			),0)
		)
	),0),2) as `remaining_dollar`
	from tbl_clients where name = `clientName`
	;
END//
DELIMITER ;

-- Dumping structure for function db_h_press.getDelegatesReceiving
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getDelegatesReceiving`(
	`to` DATETIME





,
	`isDollar` TINYINT





) RETURNS double
    DETERMINISTIC
BEGIN
	return ((CAST((ifnull((
		select 
			sum((
				if(
					tbl_bills.is_cash = 1,
					(
						(
							(
								select
									sum(tbl_products.delegate_percentage)
								from
									tbl_products
								where
									tbl_products.bill_id = tbl_bills.id
							)
						)

					),
					(
						select
							sum(products.delegate_percentage)
						from
							tbl_products products
						where
							products.bill_id = tbl_bills.id and
							(
								(
									select
										sum(tbl_products.price * tbl_products.count)
									from
										tbl_products
									where
										tbl_products.bill_id = tbl_bills.id
								)
								-
								tbl_bills.discount
								-
								(
									select
										sum(tbl_balance.value)
									from
										tbl_balance
									where
										tbl_balance.bill_id = tbl_bills.id
								)
								
							) = 0
					)
				)
				*
				if(
					isDollar = 2,
					if(tbl_bills.is_dollar = 1,getDollar(null),1),
					if(isDollar = tbl_bills.is_dollar,1,0)
				)
			)) as `value` 
		
		from 
			tbl_bills,
			tbl_clients
		where 
			tbl_bills.id > 0 and 
			tbl_clients.`type` = 2 and 
			tbl_bills.delegate_id = tbl_clients.id and 
			tbl_bills.datetime <= `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_h_press.getDelegatesReceivingFromTo
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getDelegatesReceivingFromTo`(
	`from` DATETIME,
	`to` DATETIME,
	`isDollar` INT




) RETURNS double
    DETERMINISTIC
BEGIN
	return ((CAST((ifnull((
		select 
			sum((
				if(
					tbl_bills.is_cash = 1,
					(
						(
							(
								select
									sum(tbl_products.delegate_percentage)
								from
									tbl_products
								where
									tbl_products.bill_id = tbl_bills.id
							)
						)

					),
					(
						select
							sum(products.delegate_percentage)
						from
							tbl_products products
						where
							products.bill_id = tbl_bills.id and
							(
								(
									select
										sum(tbl_products.price * tbl_products.count)
									from
										tbl_products
									where
										tbl_products.bill_id = tbl_bills.id
								)
								-
								tbl_bills.discount
								-
								(
									select
										sum(tbl_balance.value)
									from
										tbl_balance
									where
										tbl_balance.bill_id = tbl_bills.id
								)
								
							) = 0
					)
				)
				*
				if(
					isDollar = 2,
					if(tbl_bills.is_dollar = 1,getDollar(null),1),
					if(isDollar = tbl_bills.is_dollar,1,0)
				)
			)) as `value` 
		
		from 
			tbl_bills,
			tbl_clients
		where 
			tbl_bills.id > 0 and 
			tbl_clients.`type` = 2 and 
			tbl_bills.delegate_id = tbl_clients.id and 
			tbl_bills.datetime between `from` and `to`
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_h_press.getDelegatesRemaining
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getDelegatesRemaining`(
	`to` DATETIME





,
	`isDollar` TINYINT




) RETURNS double
    DETERMINISTIC
BEGIN
	return ((CAST((ifnull((
		select
			(
				select
					sum(
					products.delegate_percentage
					*
					if(
						isDollar = 2,
						if(bills.is_dollar = 1,getDollar(bills.datetime),1),
						if(isDollar = bills.is_dollar,1,0)
					)
					)
					 as `delegate_percentage`
				from
					tbl_bills bills
				inner join
					tbl_products products ON products.bill_id = bills.id
				inner join
					tbl_clients clients ON clients.id = bills.delegate_id
				where
					bills.id > 0 and
					bills.is_account = 1 and
					bills.is_sell = 1 and
					bills.is_cash = 1 and
					clients.`type` = 2 and
					bills.datetime <= `to`
			)
			+
			ifnull((
				select
					sum(products.delegate_percentage
					*
					if(
						isDollar = 2,
						if(bills.is_dollar = 1,getDollar(bills.datetime),1),
						if(isDollar = bills.is_dollar,1,0)
					)
					)
					 as `delegate_percentage`
				from
					tbl_bills bills
				inner join
					tbl_products products ON products.bill_id = bills.id
				inner join
					tbl_clients clients ON clients.id = bills.delegate_id
				
				where
					bills.id > 0 and
					bills.is_account = 1 and
					bills.is_sell = 1 and
					bills.is_cash = 0 and
					clients.`type` = 2 and
					((
						(
							select
								sum(products_not_cash.price * products_not_cash.count)
							from
								tbl_bills bills_not_cash
							inner join
								tbl_products products_not_cash ON products_not_cash.bill_id = bills_not_cash.id
							where
								bills_not_cash.id = bills.id
								
						)
						-
						bills.discount
						-
						(
							select
								sum(tbl_balance.value)
							from
								tbl_balance
							where
								tbl_balance.bill_id = bills.id
						)
					) = 0)
					and
					bills.datetime <= `to`
			),0)
	
	),0)) as DECIMAL(12,2))));
END//
DELIMITER ;

-- Dumping structure for function db_h_press.getDollar
DELIMITER //
CREATE DEFINER=`root`@`%` FUNCTION `getDollar`(
	`date` DATETIME




) RETURNS double
BEGIN
	if (select count(id) from tbl_dollar ) = 0 then
		insert into tbl_dollar (value) value ('1250');
	end if;
	return ifnull(
			ifnull((select `value` from tbl_dollar where tbl_dollar.creation between CONCAT(DATE_FORMAT(date,'%Y-%m-%d'),' 00:00:00') and CONCAT(DATE_FORMAT(date,'%Y-%m-%d'),' 23:59:59') order by id desc limit 1),
			(select `value` from tbl_dollar where tbl_dollar.creation <= ifnull(date,CURRENT_TIMESTAMP) order by id desc limit 1)),
			(select `value` from tbl_dollar order by id desc limit 1)
		);
		
END//
DELIMITER ;

-- Dumping structure for function db_h_press.getImportDebit
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

-- Dumping structure for procedure db_h_press.reportDelegates
DELIMITER //
CREATE DEFINER=`root`@`%` PROCEDURE `reportDelegates`(
	IN `dateTo` DATETIME

)
    DETERMINISTIC
BEGIN
	set @received = 0;
	set @receivables = 0;
	select
		clients.name,
		FORMAT(@received := ifnull((
			(
				select
					sum(balance.value * if(balance.is_dollar = 1,getDollar(balance.creation),1))
				from
					tbl_balance balance
				where
					balance.client_id = clients.id and
					balance.creation <= `dateTo`
			)
		),0),0) as `received`,
		FORMAT(@receivables := ifnull((
			select
				sum(products.delegate_percentage * if(bills.is_dollar,getDollar(bills.datetime),1))
			from
				tbl_bills bills
			inner join
				tbl_products products ON products.bill_id = bills.id
			where
				bills.delegate_id = clients.id and
				bills.datetime <= `dateTo` and
				((
					ifnull((
						select
							sum(tbl_products.price * if(bills.is_dollar = 1,getDollar(bills.datetime),1) * tbl_products.count)
						from
							tbl_products
						where
							tbl_products.bill_id = bills.id and
							bills.is_cash = 0
					),0)
					-
					bills.discount
					-
					ifnull((
						select
							sum(tbl_balance.value * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1))
						from
							tbl_balance
						where
							tbl_balance.bill_id = bills.id and
							tbl_balance.creation <= `dateTo`
					),0)
				) = 0)
		),0) - @received,0) as `receivables`,
		FORMAT(ifnull((
			select
				sum(products.delegate_percentage * if(bills.is_dollar,getDollar(bills.datetime),1))
			from
				tbl_bills bills
			inner join
				tbl_products products ON products.bill_id = bills.id
			where
				bills.delegate_id = clients.id and
				bills.is_cash = 0 and
				bills.datetime <= `dateTo` and
				((
					ifnull((
						select
							sum(tbl_products.price * if(bills.is_dollar = 1,getDollar(bills.datetime),1) * tbl_products.count)
						from
							tbl_products
						where
							tbl_products.bill_id = bills.id
					),0)
					-
					bills.discount
					-
					ifnull((
						select
							sum(tbl_balance.value * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1))
						from
							tbl_balance
						where
							tbl_balance.bill_id = bills.id and
							tbl_balance.creation <= `dateTo`
					),0)
				) != 0)
		),0),0) as `remaining`,
		FORMAT(ifnull((
			@receivables + @received
		),0),0) as `total`
	from
		tbl_clients clients
	where
		clients.`type` = 2
	;
END//
DELIMITER ;

-- Dumping structure for table db_h_press.tbl_balance
CREATE TABLE IF NOT EXISTS `tbl_balance` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `value` double DEFAULT '0',
  `creation` datetime DEFAULT CURRENT_TIMESTAMP,
  `bill_id` int(11) NOT NULL DEFAULT '0',
  `client_id` int(11) NOT NULL DEFAULT '0',
  `is_import` tinyint(1) NOT NULL DEFAULT '1',
  `is_dollar` tinyint(1) NOT NULL DEFAULT '0',
  `note` text,
  `balance_pay_id` int(11) DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `tbl_balance_ibfk_2_idx` (`bill_id`),
  KEY `FK_tbl_balance_tbl_clients` (`client_id`),
  KEY `FK_tbl_balance_tbl_balance_pay` (`balance_pay_id`),
  CONSTRAINT `FK_tbl_balance_tbl_balance_pay` FOREIGN KEY (`balance_pay_id`) REFERENCES `tbl_balance_pay` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_balance_tbl_bills` FOREIGN KEY (`bill_id`) REFERENCES `tbl_bills` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_balance_tbl_clients` FOREIGN KEY (`client_id`) REFERENCES `tbl_clients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=348 DEFAULT CHARSET=utf8 COMMENT='Type:Client,Delegate,Employer';

-- Dumping data for table db_h_press.tbl_balance: ~185 rows (approximately)
/*!40000 ALTER TABLE `tbl_balance` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_balance` (`id`, `value`, `creation`, `bill_id`, `client_id`, `is_import`, `is_dollar`, `note`, `balance_pay_id`) VALUES
	(3, 20000, '2017-12-10 00:00:00', 12, 89, 1, 0, '', 1),
	(13, 500000, '2017-12-30 00:00:00', 0, 72, 0, 0, 'راتب شهر 12', 0),
	(14, 200000, '2018-01-04 00:00:00', 0, 71, 0, 0, 'راتب عبيدة شهر 12', 0),
	(21, 15000, '2018-01-16 00:00:00', 63, 1, 1, 0, NULL, 0),
	(23, 10000, '2018-01-20 00:00:00', 63, 1, 1, 0, NULL, 0),
	(24, 60000, '2018-01-21 00:00:00', 70, 1, 1, 0, NULL, 0),
	(26, 500000, '2018-01-31 00:00:00', 0, 72, 0, 0, 'راتب شهر 1', 0),
	(27, 200000, '2018-01-31 00:00:00', 0, 71, 0, 0, 'راتب شهر 1', 0),
	(28, 100, '2018-02-11 00:00:00', 93, 1, 1, 1, NULL, 0),
	(31, 267000, '2018-02-11 00:00:00', 77, 1, 1, 0, NULL, 0),
	(32, 70000, '2018-02-11 00:00:00', 113, 1, 1, 0, NULL, 0),
	(33, 350000, '2018-02-14 00:00:00', 102, 1, 1, 0, NULL, 0),
	(34, 930, '2018-02-17 00:00:00', 111, 1, 1, 1, NULL, 1),
	(35, 200, '2018-02-17 00:00:00', 75, 1, 1, 1, NULL, 1),
	(36, 61, '2018-02-18 00:00:00', 80, 1, 1, 1, NULL, 1),
	(37, 670, '2018-02-19 00:00:00', 75, 1, 1, 1, NULL, 1),
	(38, 175, '2018-02-21 00:00:00', 131, 122, 1, 1, NULL, 1),
	(39, 110, '2018-02-25 00:00:00', 129, 1, 1, 1, NULL, 1),
	(40, 70, '2018-02-25 00:00:00', 132, 1, 1, 1, NULL, 1),
	(43, 100000, '2018-02-28 00:00:00', 142, 1, 1, 0, NULL, 1),
	(44, 90000, '2018-03-05 00:00:00', 141, 1, 1, 0, NULL, 1),
	(47, 200000, '2018-03-01 00:00:00', 0, 71, 0, 0, 'راتب شهر 2', 1),
	(48, 500000, '2018-03-01 00:00:00', 0, 72, 0, 0, 'راتب شهر 2', 1),
	(52, 58, '2018-04-05 00:00:00', 163, 1, 1, 0, NULL, 1),
	(53, 69942, '2018-04-05 00:00:00', 163, 1, 1, 0, NULL, 1),
	(54, 50000, '2018-04-21 00:00:00', 190, 1, 1, 0, NULL, 1),
	(55, 200000, '2018-04-21 00:00:00', 187, 1, 1, 0, NULL, 1),
	(56, 238000, '2018-04-22 00:00:00', 190, 1, 1, 0, NULL, 1),
	(57, 25, '2018-04-24 00:00:00', 172, 1, 1, 1, NULL, 1),
	(59, 45000, '2018-04-29 00:00:00', 198, 1, 1, 0, NULL, 1),
	(60, 45000, '2018-04-29 00:00:00', 199, 1, 1, 0, NULL, 1),
	(61, 114, '2018-05-01 00:00:00', 186, 1, 1, 1, NULL, 1),
	(62, 200000, '2018-05-02 00:00:00', 187, 1, 1, 0, NULL, 1),
	(63, 256000, '2018-05-13 00:00:00', 200, 1, 1, 0, NULL, 1),
	(64, 420000, '2018-05-15 00:00:00', 216, 1, 1, 0, NULL, 1),
	(65, 136000, '2018-05-15 00:00:00', 215, 1, 1, 0, NULL, 1),
	(66, 500000, '2018-05-21 00:00:00', 11, 1, 1, 0, NULL, 1),
	(68, 150, '2018-06-04 00:00:00', 217, 1, 1, 1, NULL, 1),
	(72, 500000, '2018-03-31 00:00:00', 0, 72, 0, 0, 'راتب شهر 3', 1),
	(73, 500000, '2018-04-30 00:00:00', 0, 72, 0, 0, 'راتب شهر 4', 1),
	(74, 500000, '2018-06-02 00:00:00', 0, 72, 0, 0, 'راتب شهر 5', 1),
	(75, 500000, '2018-07-02 00:00:00', 0, 72, 0, 0, 'راتب شهر 6', 1),
	(76, 600000, '2018-03-31 00:00:00', 0, 71, 0, 0, 'راتب شهر 3', 1),
	(77, 600000, '2018-04-30 00:00:00', 0, 71, 0, 0, 'راتب شهر 4', 1),
	(78, 600000, '2018-05-30 00:00:00', 0, 71, 0, 0, 'راتب شهر 5', 1),
	(79, 600000, '2018-07-02 00:00:00', 0, 71, 0, 0, 'راتب شهر 6', 1),
	(80, 100000, '2018-03-10 00:00:00', 0, 71, 0, 0, 'هدية ولادة بنته زينب', 1),
	(85, 1400, '2018-07-26 00:00:00', 244, 126, 1, 1, NULL, 1),
	(86, 30000, '2018-07-26 00:00:00', 69, 1, 1, 0, NULL, 1),
	(89, 300000, '2018-07-26 00:00:00', 229, 1, 1, 0, NULL, 1),
	(90, 37500, '2018-07-26 00:00:00', 105, 1, 1, 0, NULL, 1),
	(91, 1060, '2018-07-28 00:00:00', 319, 113, 0, 1, 'رقم قائمة ستير 2703', 16),
	(95, 5000, '2018-07-29 00:00:00', 49, 89, 1, 0, '', 18),
	(96, 45000, '2018-07-29 00:00:00', 49, 89, 1, 0, '', 19),
	(97, 20000, '2018-07-29 00:00:00', 59, 89, 1, 0, '', 19),
	(98, 135000, '2018-07-29 00:00:00', 68, 89, 1, 0, '', 19),
	(99, 65000, '2018-07-29 00:00:00', 86, 89, 1, 0, '', 19),
	(100, 40000, '2018-07-29 00:00:00', 96, 89, 1, 0, '', 19),
	(101, 20000, '2018-07-29 00:00:00', 101, 89, 1, 0, '', 19),
	(102, 80000, '2018-07-29 00:00:00', 130, 89, 1, 0, '', 19),
	(103, 10000, '2018-07-29 00:00:00', 147, 89, 1, 0, '', 19),
	(104, 185000, '2018-07-29 00:00:00', 158, 89, 1, 0, '', 19),
	(106, 55000, '2018-07-31 00:00:00', 142, 1, 1, 0, NULL, 1),
	(107, 600000, '2018-08-02 00:00:00', 0, 71, 0, 0, 'راتب شهر 7', 1),
	(108, 500000, '2018-08-02 00:00:00', 0, 72, 0, 0, 'راتب شهر 7', 1),
	(111, 45000, '2018-08-02 00:00:00', 231, 1, 1, 0, NULL, 1),
	(113, 35000, '2018-08-02 00:00:00', 222, 1, 1, 0, NULL, 1),
	(117, 600000, '2018-08-05 00:00:00', 229, 1, 1, 0, NULL, 1),
	(118, 602, '2018-08-05 00:00:00', 249, 125, 1, 1, NULL, 1),
	(130, 100, '2018-08-11 00:00:00', 347, 1, 1, 1, NULL, 1),
	(131, 56, '2018-08-12 00:00:00', 347, 1, 1, 1, NULL, 1),
	(141, 144000, '2018-08-14 00:00:00', 233, 1, 1, 0, NULL, 1),
	(142, 960000, '2018-08-15 00:00:00', 356, 1, 1, 0, NULL, 1),
	(144, 25000, '2018-08-16 00:00:00', 357, 1, 1, 0, NULL, 1),
	(145, 190000, '2018-08-18 00:00:00', 229, 1, 1, 0, NULL, 1),
	(146, 340, '2018-08-19 00:00:00', 361, 131, 1, 1, NULL, 1),
	(147, 40000, '2018-08-20 00:00:00', 346, 1, 1, 0, NULL, 1),
	(148, 45000, '2018-08-26 00:00:00', 246, 1, 1, 0, NULL, 1),
	(150, 245000, '2018-09-02 00:00:00', 110, 1, 1, 0, NULL, 1),
	(169, 180000, '2018-09-03 00:00:00', 371, 1, 1, 0, NULL, 1),
	(170, 16, '2018-09-06 00:00:00', 336, 95, 0, 1, 'بيد مصطفى في اربيل 5/9/2018', 41),
	(171, 1433, '2018-09-06 00:00:00', 337, 95, 0, 1, 'بيد مصطفى في اربيل 5/9/2018', 41),
	(172, 40, '2018-09-06 00:00:00', 376, 95, 0, 1, 'بيد مصطفى في اربيل 5/9/2018', 41),
	(174, 300, '2018-09-15 00:00:00', 196, 75, 1, 1, NULL, 1),
	(175, 300, '2018-09-15 00:00:00', 219, 75, 1, 1, NULL, 1),
	(177, 1200, '2018-09-19 00:00:00', 372, 122, 1, 1, NULL, 1),
	(178, 65, '2018-09-20 00:00:00', 401, 1, 1, 1, NULL, 1),
	(179, 25000, '2018-09-22 00:00:00', 410, 77, 1, 0, NULL, 1),
	(182, 600000, '2018-10-01 00:00:00', 418, 89, 1, 0, NULL, 1),
	(183, 120000, '2018-10-02 00:00:00', 416, 1, 1, 0, NULL, 1),
	(184, 40000, '2018-10-02 00:00:00', 415, 1, 1, 0, NULL, 1),
	(187, 40, '2018-10-02 00:00:00', 420, 1, 1, 1, NULL, 1),
	(188, 292.25, '2018-10-07 00:00:00', 425, 1, 1, 1, NULL, 1),
	(189, 30000, '2018-10-11 00:00:00', 348, 1, 1, 0, '', 1),
	(190, 45, '2018-10-03 00:00:00', 352, 110, 0, 1, 'تصفية حساب المطبعة ', 44),
	(191, 40, '2018-10-03 00:00:00', 432, 110, 0, 1, 'تصفية حساب المطبعة ', 44),
	(192, 380, '2018-10-18 00:00:00', 402, 113, 0, 1, NULL, 1),
	(193, 320, '2018-10-18 00:00:00', 396, 113, 0, 1, NULL, 1),
	(197, 600000, '2018-10-20 00:00:00', 0, 71, 0, 0, 'راتب شهر 8/2018', 1),
	(198, 600000, '2018-10-20 00:00:00', 0, 71, 0, 0, 'راتب شهر 9/2018', 1),
	(199, 400000, '2018-10-20 00:00:00', 0, 71, 0, 0, 'راتب شهر 10/2018\r\n20يوم', 1),
	(200, 500000, '2018-10-20 00:00:00', 0, 72, 0, 0, 'راتب شهر 8', 1),
	(201, 500000, '2018-10-20 00:00:00', 0, 72, 0, 0, 'راتب شهر 9', 1),
	(202, 350000, '2018-10-20 00:00:00', 0, 72, 0, 0, 'راتب شهر 10', 1),
	(203, 5, '2018-10-20 00:00:00', 98, 75, 1, 1, NULL, 1),
	(204, 1000, '2018-10-20 00:00:00', 220, 1, 1, 0, NULL, 1),
	(211, 80000, '2018-10-23 00:00:00', 473, 1, 1, 0, NULL, 1),
	(212, 144375, '2018-10-24 00:00:00', 158, 89, 1, 0, 'واصل بيد مسعود', 50),
	(213, 125000, '2018-10-24 00:00:00', 345, 89, 1, 0, 'واصل بيد مسعود', 50),
	(214, 230625, '2018-10-24 00:00:00', 418, 89, 1, 0, 'واصل بيد مسعود', 50),
	(215, 320, '2018-10-24 00:00:00', 384, 1, 1, 1, NULL, 1),
	(218, 100, '2018-10-28 00:00:00', 481, 1, 1, 1, NULL, 1),
	(219, 40, '2018-10-28 00:00:00', 481, 1, 1, 1, NULL, 1),
	(220, 240000, '2018-10-30 00:00:00', 381, 1, 1, 0, NULL, 1),
	(221, 300, '2018-10-31 00:00:00', 475, 1, 1, 1, NULL, 1),
	(222, 145000, '2018-11-06 00:00:00', 484, 65, 1, 0, NULL, 1),
	(223, 100, '2018-11-07 00:00:00', 244, 126, 1, 1, NULL, 1),
	(224, 120, '2018-11-19 00:00:00', 477, 89, 1, 1, '', 52),
	(225, 44375, '2018-11-19 00:00:00', 418, 89, 1, 0, '', 54),
	(226, 51625, '2018-11-19 00:00:00', 469, 89, 1, 0, '', 54),
	(227, 100, '2018-11-21 00:00:00', 502, 1, 1, 1, NULL, 1),
	(228, 150, '2018-11-26 00:00:00', 508, 1, 1, 1, NULL, 1),
	(229, 500, '2018-11-26 00:00:00', 479, 75, 1, 1, NULL, 1),
	(230, 600, '2018-11-26 00:00:00', 394, 75, 1, 1, NULL, 1),
	(232, 25000, '2018-12-03 00:00:00', 518, 65, 1, 0, NULL, 1),
	(234, 135000, '2018-12-03 00:00:00', 505, 65, 1, 0, NULL, 1),
	(238, 35000, '2018-12-17 00:00:00', 540, 1, 1, 0, NULL, 1),
	(242, 90000, '2019-01-02 00:00:00', 531, 63, 1, 0, NULL, 1),
	(243, 30000, '2019-01-05 00:00:00', 554, 1, 1, 0, NULL, 1),
	(244, 425000, '2019-01-06 00:00:00', 469, 89, 1, 0, 'رصيد جديد', 60),
	(245, 280000, '2019-01-07 00:00:00', 532, 1, 1, 0, NULL, 1),
	(246, 298000, '2019-01-07 00:00:00', 469, 89, 1, 0, '', 62),
	(251, 35000, '2019-01-12 00:00:00', 564, 134, 1, 0, NULL, 1),
	(252, 800, '2019-01-14 00:00:00', 244, 126, 1, 1, 'واصل بيد كاك مصطفى ', 72),
	(253, 150, '2019-01-14 00:00:00', 546, 126, 1, 1, 'واصل بيد كاك مصطفى ', 72),
	(254, 40000, '2019-01-22 00:00:00', 520, 65, 1, 0, '', 73),
	(255, 35000, '2019-01-22 00:00:00', 530, 65, 1, 0, '', 73),
	(256, 70000, '2019-01-22 00:00:00', 541, 65, 1, 0, '', 73),
	(257, 85000, '2019-01-22 00:00:00', 553, 65, 1, 0, '', 73),
	(258, 75000, '2019-01-22 00:00:00', 558, 65, 1, 0, '', 73),
	(259, 35000, '2019-01-22 00:00:00', 578, 65, 1, 0, '', 73),
	(261, 500, '2019-01-30 00:00:00', 546, 126, 1, 1, NULL, 1),
	(262, 240, '2019-01-31 00:00:00', 591, 89, 1, 1, NULL, 1),
	(263, 170000, '2019-02-14 00:00:00', 603, 1, 1, 0, NULL, 1),
	(264, 30000, '2019-02-20 00:00:00', 609, 1, 1, 0, NULL, 1),
	(265, 25000, '2019-02-27 00:00:00', 614, 1, 1, 0, NULL, 1),
	(267, 150000, '2019-03-05 00:00:00', 577, 63, 1, 0, NULL, 1),
	(268, 450, '2018-07-26 00:00:00', 546, 126, 1, 1, '', 74),
	(269, 300, '2019-02-12 00:00:00', 648, 135, 1, 1, 'حساب قديم عند المنظمة', 76),
	(271, 311.25, '2018-12-10 00:00:00', 486, 73, 1, 1, '', 78),
	(272, 70, '2018-12-10 00:00:00', 494, 73, 1, 1, '', 78),
	(273, 100, '2019-02-24 00:00:00', 557, 64, 0, 1, '', 79),
	(274, 150, '2019-02-24 00:00:00', 491, 95, 0, 1, '', 81),
	(275, 242, '2019-02-24 00:00:00', 567, 95, 0, 1, '', 81),
	(276, 360000, '2019-02-24 00:00:00', 334, 129, 1, 0, '', 82),
	(277, 200000, '2019-02-24 00:00:00', 344, 129, 1, 0, '', 82),
	(278, 15000, '2019-02-24 00:00:00', 620, 129, 1, 0, '', 82),
	(312, 195, '2019-04-24 00:00:00', 72, 114, 1, 1, '', 90),
	(313, 2350, '2019-04-24 00:00:00', 51, 114, 1, 1, '', 90),
	(314, 1465, '2019-04-24 00:00:00', 50, 114, 1, 1, '', 90),
	(315, 2772, '2019-04-24 00:00:00', 97, 114, 1, 1, '', 90),
	(316, 318, '2019-04-24 00:00:00', 156, 114, 1, 1, '', 90),
	(317, 838, '2019-04-24 00:00:00', 195, 114, 1, 1, '', 90),
	(318, 1096, '2019-04-24 00:00:00', 157, 114, 1, 1, '', 90),
	(319, 275, '2019-04-24 00:00:00', 238, 114, 1, 1, '', 90),
	(320, 235, '2019-04-24 00:00:00', 239, 114, 1, 1, '', 90),
	(321, 4735, '2019-04-24 00:00:00', 243, 114, 1, 1, '', 90),
	(322, 144, '2019-04-24 00:00:00', 245, 114, 1, 1, '', 90),
	(323, 258, '2019-04-24 00:00:00', 248, 114, 1, 1, '', 90),
	(324, 4142, '2019-04-24 00:00:00', 428, 114, 1, 1, '', 90),
	(325, 224, '2019-04-24 00:00:00', 467, 114, 1, 1, '', 90),
	(326, 4406, '2019-04-24 00:00:00', 506, 114, 1, 1, '', 90),
	(327, 4493, '2019-04-24 00:00:00', 538, 114, 1, 1, '', 90),
	(328, 525, '2019-04-24 00:00:00', 573, 114, 1, 1, '', 90),
	(329, 2710.5, '2019-04-24 00:00:00', 574, 114, 1, 1, '', 90),
	(330, 1610, '2019-04-24 00:00:00', 590, 114, 1, 1, '', 90),
	(331, 600, '2019-04-24 00:00:00', 601, 114, 1, 1, '', 90),
	(332, 8685.5, '2019-04-24 00:00:00', 611, 114, 1, 1, '', 90),
	(338, 50, '2018-12-20 00:00:00', 208, 127, 1, 1, '', 92),
	(339, 70, '2018-12-20 00:00:00', 330, 127, 1, 1, '', 92),
	(340, 25000, '2018-12-20 00:00:00', 478, 127, 1, 0, '', 93),
	(341, 318, '2019-04-24 00:00:00', 521, 1, 1, 1, NULL, 1),
	(343, 2204.5, '2019-04-24 00:00:00', 611, 114, 1, 1, '', 95),
	(344, 58, '2019-04-24 00:00:00', 629, 114, 1, 1, '', 95),
	(345, 48, '2019-04-24 00:00:00', 663, 114, 1, 1, '', 95),
	(346, 272, '2019-04-24 00:00:00', 667, 114, 1, 1, '', 95),
	(347, 128, '2019-04-24 00:00:00', 668, 114, 1, 1, '', 95);
/*!40000 ALTER TABLE `tbl_balance` ENABLE KEYS */;

-- Dumping structure for table db_h_press.tbl_balance_pay
CREATE TABLE IF NOT EXISTS `tbl_balance_pay` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `creation` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=96 DEFAULT CHARSET=utf8;

-- Dumping data for table db_h_press.tbl_balance_pay: ~86 rows (approximately)
/*!40000 ALTER TABLE `tbl_balance_pay` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_balance_pay` (`id`, `creation`) VALUES
	(0, '2017-05-23 17:46:41'),
	(1, '2017-12-10 17:48:35'),
	(2, '2017-12-10 17:48:35'),
	(3, '2018-01-15 18:12:21'),
	(4, '2018-01-15 18:12:29'),
	(5, '2018-01-15 18:12:36'),
	(6, '2018-01-15 18:12:52'),
	(7, '2018-01-15 18:13:57'),
	(8, '2018-01-16 11:01:28'),
	(9, '2018-01-16 11:02:06'),
	(10, '2018-01-16 11:02:42'),
	(11, '2018-01-16 11:04:25'),
	(12, '2018-01-16 11:12:21'),
	(13, '2018-01-16 11:13:56'),
	(14, '2018-07-26 12:08:01'),
	(15, '2018-07-26 12:08:01'),
	(16, '2018-07-28 13:32:00'),
	(17, '2018-07-28 13:32:01'),
	(18, '2018-07-29 11:33:40'),
	(19, '2018-07-29 11:36:54'),
	(20, '2018-08-02 16:39:29'),
	(21, '2018-08-02 16:39:29'),
	(22, '2018-08-04 16:30:13'),
	(23, '2018-08-04 16:30:14'),
	(24, '2018-08-11 12:01:17'),
	(25, '2018-08-11 12:03:17'),
	(26, '2018-08-11 12:03:17'),
	(27, '2018-08-11 12:21:24'),
	(28, '2018-08-11 12:24:06'),
	(29, '2018-08-11 12:25:56'),
	(30, '2018-08-11 12:27:55'),
	(31, '2018-08-13 10:24:34'),
	(32, '2018-08-13 10:24:34'),
	(33, '2018-08-13 10:33:03'),
	(34, '2018-08-13 10:33:03'),
	(35, '2018-08-15 13:13:55'),
	(36, '2018-08-15 13:13:56'),
	(37, '2018-09-03 15:35:00'),
	(38, '2018-09-03 15:37:09'),
	(39, '2018-09-03 15:39:52'),
	(40, '2018-09-03 15:41:37'),
	(41, '2018-09-06 14:47:36'),
	(42, '2018-09-15 09:54:04'),
	(43, '2018-09-15 09:54:04'),
	(44, '2018-10-13 12:49:32'),
	(45, '2018-10-20 16:28:39'),
	(46, '2018-10-20 16:28:39'),
	(47, '2018-10-20 16:31:34'),
	(48, '2018-10-20 16:31:34'),
	(49, '2018-10-21 12:29:18'),
	(50, '2018-10-24 16:27:39'),
	(51, '2018-10-25 15:08:10'),
	(52, '2018-11-19 16:10:07'),
	(53, '2018-11-19 16:10:08'),
	(54, '2018-11-19 16:10:48'),
	(55, '2018-12-20 14:38:47'),
	(56, '2018-12-20 14:40:04'),
	(57, '2018-12-20 14:40:04'),
	(58, '2018-12-20 14:40:15'),
	(59, '2018-12-20 14:40:15'),
	(60, '2019-01-06 17:57:25'),
	(61, '2019-01-06 17:57:25'),
	(62, '2019-01-07 13:45:05'),
	(63, '2019-01-07 13:45:05'),
	(64, '2019-01-07 13:45:31'),
	(65, '2019-01-07 13:45:31'),
	(66, '2019-01-07 15:23:05'),
	(67, '2019-01-07 15:23:05'),
	(68, '2019-01-07 15:36:40'),
	(69, '2019-01-07 15:36:40'),
	(70, '2019-01-07 15:44:41'),
	(71, '2019-01-07 15:44:41'),
	(72, '2019-01-14 12:27:15'),
	(73, '2019-01-22 15:08:26'),
	(74, '2019-03-10 17:39:37'),
	(75, '2019-03-10 17:39:37'),
	(76, '2019-03-12 15:56:04'),
	(77, '2019-03-12 15:56:04'),
	(78, '2019-03-24 17:29:15'),
	(79, '2019-03-24 17:42:40'),
	(80, '2019-03-24 17:42:40'),
	(81, '2019-03-24 17:43:32'),
	(82, '2019-03-24 17:52:22'),
	(83, '2019-03-24 18:31:23'),
	(84, '2019-03-24 18:45:18'),
	(85, '2019-03-24 18:45:30'),
	(86, '2019-04-24 12:51:20'),
	(87, '2019-04-24 12:51:20'),
	(88, '2019-04-24 12:59:17'),
	(89, '2019-04-24 12:59:17'),
	(90, '2019-04-24 13:12:25'),
	(91, '2019-04-24 13:13:17'),
	(92, '2019-04-24 13:17:23'),
	(93, '2019-04-24 13:17:29'),
	(94, '2019-04-24 13:17:29'),
	(95, '2019-04-24 14:17:05');
/*!40000 ALTER TABLE `tbl_balance_pay` ENABLE KEYS */;

-- Dumping structure for table db_h_press.tbl_bills
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
  PRIMARY KEY (`id`),
  KEY `client_id` (`client_id`),
  KEY `FK_tbl_bills_tbl_clients` (`delegate_id`),
  CONSTRAINT `FK_tbl_bills_tbl_clients` FOREIGN KEY (`delegate_id`) REFERENCES `tbl_clients` (`id`),
  CONSTRAINT `FK_tbl_bills_tbl_clients_2` FOREIGN KEY (`client_id`) REFERENCES `tbl_clients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=705 DEFAULT CHARSET=utf8;

-- Dumping data for table db_h_press.tbl_bills: ~581 rows (approximately)
/*!40000 ALTER TABLE `tbl_bills` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_bills` (`id`, `is_account`, `is_sell`, `client_id`, `is_dollar`, `is_cash`, `note`, `datetime`, `discount`, `name`, `location`, `phone`, `email`, `delegate_id`) VALUES
	(0, 1, 1, 1, 1, 1, '', '2017-02-01 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(11, 1, 1, 1, 0, 0, '', '2017-12-10 00:00:00', 93750, 'رێڤەبەریا هاتن و چونا دهوکێ', 'دهوك', '0750', 'www.duhoktp.com', 2),
	(12, 1, 1, 89, 0, 0, '', '2017-12-10 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(49, 1, 1, 89, 0, 0, '', '2018-01-09 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(50, 1, 1, 114, 1, 0, '', '2018-02-14 00:00:00', 0.5, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(51, 1, 1, 114, 1, 0, '', '2018-02-14 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(54, 1, 0, 1, 0, 1, '', '2018-01-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(56, 1, 0, 1, 0, 1, '', '2018-01-14 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(59, 1, 1, 89, 0, 0, '', '2018-01-15 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(60, 1, 0, 1, 1, 1, '', '2018-01-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(63, 1, 1, 1, 0, 0, '', '2018-01-16 00:00:00', 0, 'سلطان دونر', 'دهوك', '0750', '@', 2),
	(64, 1, 0, 95, 1, 1, 'تم دفع من قبل قرطاسة ب تاريخ 15/1/2018\r\nتاريخ القائمة 15/1/2018', '2018-01-17 00:00:00', 0, 'قرطاسية الصهيب / عبدو', 'اربيل شارع التربة', '07503854402', 'teba-mni@hotmail.com', 2),
	(68, 1, 1, 89, 0, 0, '37500 خصم بسبب خط', '2018-01-18 00:00:00', 37500, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(69, 1, 1, 1, 0, 0, '', '2018-01-18 00:00:00', 0, 'امجد سعيد', 'دهوك', '0750', '@', 2),
	(70, 1, 1, 1, 0, 0, '', '2018-01-21 00:00:00', 10000, 'فش هاوس', 'دهوك', '0750', '@', 2),
	(72, 1, 1, 114, 1, 0, '', '2018-01-22 00:00:00', 0.2, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(73, 1, 0, 1, 0, 1, 'توصيل فلير ', '2018-01-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(74, 1, 0, 110, 1, 1, '', '2018-02-01 00:00:00', 0, 'مطبعة هاوار', 'دهوك - پشت ئاڤاهیێ دادگەهێ ', '07504457021', '@', 2),
	(75, 1, 1, 1, 1, 0, '', '2018-01-22 00:00:00', 1.5, 'سعيد حجي', 'دهوك', '07504708948', 'skatoly@yahoo.com', 2),
	(77, 1, 1, 1, 0, 0, '', '2018-01-22 00:00:00', 500, 'وان كلوبال', 'دهوك', '0750', '@', 2),
	(80, 1, 1, 1, 1, 0, 'مقابل 76000 دينار', '2018-01-23 00:00:00', 1.5, 'Active Remedy', 'دهوك', '07701883494', 'NUN', 2),
	(81, 1, 1, 1, 0, 1, '', '2018-01-24 00:00:00', 0, 'xebat factory', 'Duhok', '07508415003', 'xebatfactory@hotmail.cm', 2),
	(83, 1, 1, 1, 0, 1, '', '2018-01-25 00:00:00', 0, 'NCA', 'دهوك', '0750', '@', 2),
	(84, 1, 1, 1, 0, 1, '', '2018-01-25 00:00:00', 0, 'جيهانا سبياتيا', 'دهوك - زەری لاند', '07504938609', '@', 2),
	(86, 1, 1, 89, 0, 0, '', '2018-01-27 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(87, 1, 1, 1, 0, 1, '', '2018-01-28 00:00:00', 0, 'شيرزاد حلاق', 'دهوك', '0750', '@', 2),
	(88, 1, 0, 117, 0, 1, '', '2018-01-28 00:00:00', 0, 'پەرگەها بزاڤ', 'دهوك ', '07504247735', '@', 2),
	(90, 1, 0, 1, 1, 1, '', '2018-01-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(91, 1, 0, 1, 0, 1, '', '2018-01-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(92, 1, 1, 1, 0, 1, '', '2018-01-31 00:00:00', 0, 'كافي لاند', 'دهوك - بەرامبەر زەری پارک', '07504455049', '@', 2),
	(93, 1, 1, 1, 1, 0, '', '2018-01-31 00:00:00', 0, 'وان كلوبال', 'دهوك', '0750', '@', 2),
	(94, 1, 0, 1, 0, 1, '', '2018-01-31 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(95, 1, 0, 110, 0, 1, 'عدد 3000 نسخة 170غم القياس 21*48 وجهين', '2018-02-01 00:00:00', 0, 'مطبعة هاوار', 'دهوك - پشت ئاڤاهیێ دادگەهێ ', '07504457021', '@', 2),
	(96, 1, 1, 89, 0, 0, '', '2018-02-01 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(97, 1, 1, 114, 1, 0, '', '2018-03-01 00:00:00', 0.5, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(98, 1, 1, 75, 1, 0, '', '2018-02-04 00:00:00', 625, 'ACINO', 'دهوك', '07702778906', '@', 2),
	(99, 1, 1, 1, 0, 1, '', '2018-02-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(101, 1, 1, 89, 0, 0, '', '2018-02-06 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(102, 1, 1, 1, 0, 0, '', '2018-02-07 00:00:00', 0, 'رێڤەبەریا بەشێ هاتن و چونا قەزا ئاكرێ', 'دهوك - ئاكرێ', '07504798127', '@', 2),
	(105, 1, 1, 1, 0, 0, '', '2018-02-07 00:00:00', 0, 'مستشفي فين', 'دهوك', '0750', '@', 2),
	(107, 1, 0, 110, 1, 1, 'لم يدخل الى حساب هاوار', '2018-02-07 00:00:00', 0, 'مطبعة هاوار', 'دهوك - پشت ئاڤاهیێ دادگەهێ ', '07504457021', '@', 2),
	(108, 1, 0, 110, 0, 1, 'رقم الوصل 19485\r\n3000 بروشور طباعة وجهين 115 غرام 21*44.5\r\n', '2018-02-07 00:00:00', 0, 'مطبعة هاوار', 'دهوك - پشت ئاڤاهیێ دادگەهێ ', '07504457021', '@', 2),
	(109, 1, 0, 1, 0, 1, ' منظمة IMC\r\n900.000 عبيدة من حساب ضمير', '2018-02-10 00:00:00', 0, 'دلشاد مطبعة', 'دهوك', '0750', '@', 2),
	(110, 1, 1, 1, 0, 0, '', '2018-02-10 00:00:00', 0, 'استاذ حسام', 'دهوك', '07504583751', '@', 2),
	(111, 1, 1, 1, 1, 0, 'قانون حماية المرأة\r\nقياس 21*48\r\n170 غم وجهين\r\nمع التصميم', '2018-02-10 00:00:00', 0, 'سعيد حجي', 'دهوك', '0750', '@', 2),
	(112, 1, 0, 1, 0, 1, '', '2018-02-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(113, 1, 1, 1, 0, 0, '', '2018-02-10 00:00:00', 0, 'صديق سيدا خليل', 'دهوك', '0750', '@', 2),
	(114, 1, 1, 1, 0, 1, '', '2018-02-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(115, 1, 0, 1, 0, 1, '', '2018-02-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(116, 1, 0, 89, 1, 1, '', '2018-02-12 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(117, 1, 1, 1, 0, 1, 'تعديل البرنامج مع كوفان', '2018-02-12 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(118, 1, 0, 1, 0, 1, 'من القرطاسية', '2018-02-12 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(119, 1, 1, 1, 0, 1, 'كلامور شوب', '2018-02-12 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(120, 1, 1, 1, 0, 1, '', '2018-02-14 00:00:00', 0, 'لاباس كافى', 'دهوك', '0750', '@', 2),
	(123, 1, 1, 1, 0, 1, '', '2018-02-15 00:00:00', 0, 'منظمة NCA', 'دهوك', '0750', '@', 2),
	(124, 1, 1, 1, 0, 1, '', '2018-02-15 00:00:00', 0, 'مارتن', 'دهوك', '0750', '@', 2),
	(126, 1, 1, 1, 0, 1, '', '2018-02-15 00:00:00', 500, 'ودن هاوس', 'دهوك', '0750', '@', 2),
	(127, 1, 1, 1, 0, 1, '', '2018-02-15 00:00:00', 1000, 'نقدي', 'دهوك', '0750', '@', 2),
	(128, 1, 0, 121, 0, 1, 'قرطاسية ياد رقم القائمة 2957 تاريخ 13/2/2018\r\n07504644835\r\nقرب قرطاسية بيخال', '2018-02-14 00:00:00', 0, 'قرطاسية ياد', 'اربيل', '07504559014', '@', 2),
	(129, 1, 1, 1, 1, 0, '', '2018-02-19 00:00:00', 0, 'شركة رند', 'دهوك', '0750', '@', 2),
	(130, 1, 1, 89, 0, 0, '', '2018-02-19 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(131, 1, 1, 122, 1, 0, '', '2018-02-19 00:00:00', 0, 'ELISE CARE', 'دهوك', '0750', '@', 2),
	(132, 1, 1, 1, 1, 0, '', '2018-02-19 00:00:00', 0, 'شركة رند', 'دهوك', '0750', '@', 2),
	(133, 1, 1, 1, 0, 1, '', '2018-02-20 00:00:00', 0, 'شيرزاد حلاق', 'دهوك', '0750', '@', 2),
	(134, 1, 0, 123, 1, 1, '', '2018-02-20 00:00:00', 0, 'XEROX', 'ERBIL', '0750', '@', 2),
	(135, 1, 0, 123, 1, 1, '', '2018-02-20 00:00:00', 0, 'XEROX', 'ERBIL', '0750', '@', 2),
	(136, 1, 0, 113, 1, 1, 'من محمود', '2018-02-22 00:00:00', 0, 'ستێر کومپانی', 'دهوك - نوهەدرا', '07504309999', 'INFO@STERCOMPUTER.COM', 2),
	(137, 1, 0, 1, 0, 1, '', '2018-02-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(138, 1, 0, 1, 0, 1, '', '2018-02-19 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(140, 1, 1, 1, 0, 1, '', '2018-02-25 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(141, 1, 1, 1, 0, 0, 'تابع مصطفى', '2018-02-28 00:00:00', 0, 'عبدالخالق', 'دهوك', '0750', '@', 2),
	(142, 1, 1, 1, 0, 0, '', '2018-02-28 00:00:00', 1000, 'فێرگەها پارتی زانی', 'دهوك', '07502193807', '@', 2),
	(143, 1, 0, 124, 1, 1, 'منظمة IMC', '2018-03-05 00:00:00', 5, 'دلشاد ئاكرى', 'دهوك', '07504015740', '@', 2),
	(144, 1, 1, 1, 0, 1, '', '2018-03-05 00:00:00', 0, 'نقدي - دكتور حمزة عيسى', 'دهوك', '0750', '@', 2),
	(146, 1, 1, 1, 0, 1, '', '2018-03-07 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(147, 1, 1, 89, 0, 0, '', '2018-03-07 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(148, 1, 1, 1, 0, 1, '', '2018-03-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(149, 1, 1, 1, 0, 1, '', '2018-03-13 00:00:00', 0, 'شيرزاد حلاق', 'دهوك', '0750', '@', 2),
	(152, 1, 1, 1, 0, 1, '', '2018-03-18 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(156, 1, 1, 114, 1, 0, '', '2018-03-26 00:00:00', 0.5, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(157, 1, 1, 114, 1, 0, 'قائمة 236 مكررة \r\nبسبب عدم طبع جميع التيشيرتات\r\n', '2018-04-23 00:00:00', 144, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(158, 1, 1, 89, 0, 0, '', '2018-03-28 00:00:00', 375, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(159, 1, 1, 1, 0, 1, '', '2018-03-29 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(160, 1, 1, 1, 0, 1, '', '2018-03-31 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(161, 1, 1, 1, 0, 1, '', '2018-03-31 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(162, 1, 1, 1, 1, 1, '', '2018-04-01 00:00:00', 0, 'مەتین ', 'دهوک', '07504315912', '@', 2),
	(163, 1, 1, 1, 0, 0, '', '2018-04-02 00:00:00', 0, 'Amed TV', 'دهوك', '0750', '@', 2),
	(166, 1, 1, 1, 0, 1, '', '2018-04-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(168, 1, 1, 1, 0, 1, '', '2018-04-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(169, 1, 1, 1, 0, 1, '', '2018-04-11 00:00:00', 0, 'ثسمام مصطفى', 'دهوك', '0750', '@', 2),
	(170, 1, 1, 1, 0, 1, '', '2018-04-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(171, 1, 1, 1, 0, 1, '', '2018-04-11 00:00:00', 0, 'oscar prodution', 'دهوك', '0750', '@', 2),
	(172, 1, 1, 1, 1, 0, '', '2018-04-15 00:00:00', 0, 'Active Remedy', 'دهوك', '0750', '@', 2),
	(173, 1, 0, 1, 0, 1, '', '2018-03-29 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(174, 1, 0, 1, 0, 1, '', '2018-04-01 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(175, 1, 0, 1, 0, 1, '', '2018-04-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(176, 1, 0, 1, 0, 1, '', '2018-03-07 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(177, 1, 0, 1, 0, 1, '', '2018-03-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(178, 1, 0, 1, 1, 1, '', '2018-03-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(179, 1, 0, 124, 1, 1, '', '2018-04-05 00:00:00', 0, 'دلشاد ئاكرى', 'دهوك', '07504015740', '@', 2),
	(180, 1, 0, 1, 0, 1, '', '2018-03-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(182, 1, 0, 1, 1, 1, 'عبيدة من بغداد', '2018-04-16 00:00:00', 0, 'مركز رؤيا ', 'دهوك', '0750', '@', 2),
	(183, 1, 1, 1, 0, 1, '', '2018-04-17 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(184, 1, 1, 1, 0, 1, '', '2018-04-18 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(185, 1, 1, 99, 1, 1, '', '2018-04-18 00:00:00', 0, ' Sipan House', 'دهوك', '07504587849', '@', 2),
	(186, 1, 1, 1, 1, 0, '', '2018-04-18 00:00:00', 0, 'موظف مطبعة ميديا', 'دهوك', '0750', '@', 2),
	(187, 1, 1, 1, 0, 0, '', '2018-04-18 00:00:00', 5000, 'كلية الادراة و الاقتصاد', 'دهوك', '0750', '@', 2),
	(189, 1, 1, 1, 0, 1, '', '2018-04-19 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(190, 1, 1, 1, 0, 0, '', '2018-04-21 00:00:00', 500, 'دەزگەهێ قەلەم', 'دهوك', '07504738257', '@', 2),
	(191, 1, 1, 1, 0, 1, '', '2018-04-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(192, 1, 1, 1, 0, 1, '', '2018-04-22 00:00:00', 0, 'جودي', 'دهوك', '0750', '@', 2),
	(193, 1, 1, 1, 0, 1, '', '2018-04-23 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(195, 1, 1, 114, 1, 0, '', '2018-04-23 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(196, 1, 1, 75, 1, 0, '', '2018-04-25 00:00:00', 0, 'ACINO', 'دهوك', '07702778906', '@', 2),
	(198, 1, 1, 1, 0, 0, '', '2018-04-29 00:00:00', 0, 'شركة هسنياني', 'دهوك', '07504972222', 'khalid@hesninay.com', 2),
	(199, 1, 1, 1, 0, 0, '', '2018-04-29 00:00:00', 0, 'ALTUN', 'دهوك', '07503105649', 'altun_dekorasyon@hotmail.com', 2),
	(200, 1, 1, 1, 0, 0, '', '2018-04-30 00:00:00', 0, 'زێرەڤانی', 'دهوك', '0750', '@', 2),
	(201, 1, 1, 1, 0, 1, '', '2018-05-01 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(204, 1, 1, 1, 1, 1, '', '2018-05-02 00:00:00', 0, 'ورجينال شو', 'دهوك', '0750', '@', 2),
	(205, 1, 1, 1, 0, 1, '', '2018-05-02 00:00:00', 0, 'ورجينال شو', 'دهوك', '0750', '@', 2),
	(206, 1, 1, 1, 0, 1, '', '2018-05-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(207, 1, 1, 1, 0, 1, '', '2018-05-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(208, 1, 1, 127, 1, 0, '', '2018-05-05 00:00:00', 0, 'RAND CO.', 'دهوك', '0750', '@', 2),
	(210, 1, 1, 1, 0, 1, '', '2018-05-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(212, 1, 1, 1, 0, 1, '', '2018-05-06 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(213, 1, 1, 1, 0, 1, '', '2018-05-10 00:00:00', 0, 'بابێ زەمەن', 'دهوك', '0750', '@', 2),
	(214, 1, 1, 1, 0, 1, '', '2018-05-13 00:00:00', 0, 'زێرەڤانی', 'دهوك', '0750', '@', 2),
	(215, 1, 1, 1, 0, 0, 'ئێریڤان', '2018-05-14 00:00:00', 800, 'كومبانيا زەکئ', 'دهوك', '0750', '@', 2),
	(216, 1, 1, 1, 0, 0, '', '2018-05-14 00:00:00', 0, 'world MedicineCrops', 'دهوك', '07701830311', '@', 2),
	(217, 1, 1, 1, 1, 0, '', '2018-05-15 00:00:00', 10, 'سالم بادي', 'دهوك', '0750', '@', 2),
	(218, 1, 1, 1, 0, 1, '', '2018-05-15 00:00:00', 0, 'هەسپێ رەش', 'دهوك', '0750', '@', 2),
	(219, 1, 1, 75, 1, 0, 'ابراهيم', '2018-05-19 00:00:00', 150, 'ACINO', 'دهوك', '07702778906', '@', 2),
	(220, 1, 1, 1, 0, 0, 'تابع عبيدة', '2018-05-19 00:00:00', 324000, 'صالون ام شيماء', 'دهوك', '0750', '@', 2),
	(221, 1, 1, 1, 0, 1, '', '2018-05-20 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(222, 1, 1, 1, 0, 0, 'صديق سعيد حجي', '2018-05-21 00:00:00', 1000, 'سليمان ', 'دهوك', '0750', '@', 2),
	(223, 1, 1, 1, 0, 1, '', '2018-05-22 00:00:00', 0, 'لاباز كوفي', 'دهوك', '0750', '@', 2),
	(224, 1, 1, 1, 0, 1, '', '2018-05-23 00:00:00', 0, 'جهي ديار', 'دهوك', '0750', '@', 2),
	(225, 1, 1, 1, 0, 1, '', '2018-05-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(226, 1, 1, 1, 0, 1, 'ثلاث بزنس كارت ', '2018-05-31 00:00:00', 0, 'منظمة WEO', 'دهوك', '0750', '@', 2),
	(227, 1, 1, 1, 0, 1, '', '2018-06-04 00:00:00', 0, 'شيرزاد', 'دهوك', '0750', '@', 2),
	(228, 1, 1, 1, 0, 1, '', '2018-06-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(229, 1, 1, 1, 0, 0, '07701688297\r\nتم تقليل عدد طبع المادة الاولى من 150 الى 100 من قبل استاذ امجد', '2018-06-04 00:00:00', 0, 'استاذ امجد سعيد', 'دهوك', '07502158507', '@', 2),
	(230, 1, 1, 1, 0, 1, '', '2018-06-07 00:00:00', 50, 'فاملي فان', 'دهوك', '0750', '@', 2),
	(231, 1, 1, 1, 0, 0, 'تابع سعيد حجي', '2018-06-07 00:00:00', 3000, 'SOL MUSIC', 'دهوك', '07504570615', '@', 2),
	(232, 1, 1, 1, 0, 1, 'فترة امتيحان ', '2018-05-28 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(233, 1, 1, 1, 0, 0, '', '2018-06-10 00:00:00', 0, 'شباب و رياضة', 'دهوك', '0750', '@', 2),
	(234, 1, 1, 1, 0, 1, '', '2018-06-11 00:00:00', 0, 'بلو سكاي', 'دهوك', '0750', '@', 2),
	(235, 1, 1, 1, 0, 1, '', '2018-06-11 00:00:00', 0, 'پسمام کۆڤان', 'دهوك', '0750', '@', 2),
	(237, 1, 1, 1, 0, 1, '', '2018-06-21 00:00:00', 0, 'قەپانا مزگين', 'دهوك', '0750', '@', 2),
	(238, 1, 1, 114, 1, 0, '', '2018-06-25 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(239, 1, 1, 114, 1, 0, '', '2018-07-10 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(240, 1, 1, 1, 0, 1, '', '2018-06-24 00:00:00', 0, 'کولیژا تەکنیکی ئەندازیاری', 'دهوك', '0750', '@', 2),
	(241, 1, 1, 1, 0, 1, '', '2018-06-20 00:00:00', 0, 'کولیژا تەکنیکی ئەندازیاری', 'دهوك', '0750', '@', 2),
	(243, 1, 1, 114, 1, 0, '', '2018-07-19 00:00:00', 0.495, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(244, 1, 1, 126, 1, 0, '', '2018-07-19 00:00:00', 0, 'Tandori Rest', 'دهوك', '07701620002', '@', 2),
	(245, 1, 1, 114, 1, 0, '', '2018-07-22 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(246, 1, 1, 1, 0, 0, '', '2018-07-25 00:00:00', 0, 'ريفةبةريا وةرزش', 'دهوك', '0750', '@', 2),
	(247, 1, 0, 1, 0, 1, '', '2018-07-18 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(248, 1, 1, 114, 1, 0, '', '2018-07-25 00:00:00', 58, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(249, 1, 1, 125, 1, 0, '', '2018-07-25 00:00:00', 0, 'GIZ - IRAQ', 'دهوك', '07507538707', '@', 2),
	(250, 1, 0, 1, 0, 1, '', '2018-04-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(251, 1, 0, 1, 0, 1, '', '2018-04-23 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(252, 1, 0, 1, 0, 1, '', '2018-04-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(253, 1, 0, 1, 0, 1, '', '2018-04-29 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(254, 1, 0, 1, 1, 1, '', '2018-05-01 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(255, 1, 0, 1, 0, 1, '', '2018-05-01 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(256, 1, 0, 1, 0, 1, '', '2018-05-01 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(257, 1, 0, 1, 0, 1, '', '2018-05-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(258, 1, 0, 1, 0, 1, '', '2018-05-07 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(259, 1, 0, 1, 0, 1, '', '2018-05-14 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(260, 1, 1, 1, 0, 1, '', '2018-05-19 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(261, 1, 0, 1, 0, 1, '', '2018-05-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(262, 1, 0, 1, 0, 1, '', '2018-05-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(263, 1, 0, 1, 0, 1, '', '2018-05-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(264, 1, 0, 1, 0, 1, '', '2018-06-02 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(265, 1, 0, 1, 1, 1, '', '2018-06-02 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(266, 1, 0, 1, 0, 1, '', '2018-06-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(267, 1, 0, 1, 0, 1, '', '2018-06-07 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(268, 1, 0, 1, 0, 1, '', '2018-06-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(269, 1, 0, 1, 0, 1, '', '2018-06-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(270, 1, 0, 1, 1, 1, 'اربع ليالى800', '2018-06-25 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(271, 1, 0, 1, 1, 1, '', '2018-06-25 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(272, 1, 0, 1, 1, 1, '', '2018-06-25 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(273, 1, 0, 1, 1, 1, '', '2018-06-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(274, 1, 1, 1, 0, 1, '', '2018-06-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(275, 1, 0, 1, 0, 1, '', '2018-06-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(276, 1, 0, 1, 0, 1, '', '2018-06-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(277, 1, 0, 1, 0, 1, '', '2018-06-28 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(278, 1, 0, 1, 0, 1, '', '2018-06-28 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(279, 1, 0, 1, 0, 1, '', '2018-06-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(280, 1, 0, 1, 0, 1, '', '2018-06-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(281, 1, 0, 1, 1, 1, '', '2018-07-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(282, 1, 1, 1, 0, 1, '', '2018-07-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(283, 1, 0, 1, 0, 1, '', '2018-07-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(284, 1, 0, 1, 0, 1, '', '2018-07-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(285, 1, 0, 1, 0, 1, '', '2018-07-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(286, 1, 0, 1, 0, 1, '', '2018-07-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(287, 1, 0, 1, 0, 1, '', '2018-07-08 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(288, 1, 0, 1, 0, 1, '', '2018-07-09 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(289, 1, 0, 1, 0, 1, '', '2018-07-09 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(290, 1, 0, 1, 1, 1, '', '2018-07-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(291, 1, 0, 1, 1, 1, '', '2018-07-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(292, 1, 0, 1, 1, 1, '', '2018-07-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(293, 1, 0, 1, 0, 1, '', '2018-07-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(294, 1, 0, 1, 0, 1, '', '2018-07-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(295, 1, 0, 1, 0, 1, '', '2018-07-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(296, 1, 0, 1, 0, 1, '', '2018-07-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(297, 1, 0, 1, 0, 1, '', '2018-07-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(298, 1, 0, 1, 0, 1, '', '2018-07-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(299, 1, 0, 1, 1, 1, '', '2018-07-12 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(300, 1, 0, 1, 0, 1, '', '2018-07-12 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(301, 1, 0, 1, 0, 1, '', '2018-07-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(302, 1, 0, 1, 0, 1, '', '2018-07-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(303, 1, 0, 1, 1, 1, '', '2018-07-16 00:00:00', 0, '1', 'دهوك', '0750', '@', 2),
	(304, 1, 0, 1, 0, 1, '', '2018-07-17 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(305, 1, 0, 1, 0, 1, '', '2018-07-17 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(306, 1, 0, 1, 0, 1, '', '2018-07-18 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(307, 1, 0, 1, 1, 1, '', '2018-07-19 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(308, 1, 0, 1, 0, 1, '', '2018-07-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(309, 1, 0, 1, 1, 1, 'طبع علاكات قرطاسية حلبجة', '2018-07-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(310, 1, 0, 1, 0, 1, '', '2018-07-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(311, 1, 0, 1, 0, 1, '', '2018-07-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(312, 1, 0, 1, 0, 1, '', '2018-07-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(313, 1, 0, 1, 0, 1, '', '2018-07-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(314, 1, 0, 1, 0, 1, '', '2018-07-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(315, 1, 0, 1, 0, 1, '', '2018-07-23 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(316, 1, 0, 1, 0, 1, '', '2018-07-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(317, 1, 0, 1, 0, 1, '', '2018-07-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(319, 1, 0, 113, 1, 0, '', '2018-07-26 00:00:00', 0, 'ستێر کومپانی', 'دهوك - نوهەدرا', '07504309999', 'INFO@STERCOMPUTER.COM', 2),
	(320, 1, 1, 1, 0, 1, '', '2018-07-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(321, 1, 1, 1, 0, 1, '', '2018-07-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(322, 1, 1, 1, 0, 1, '', '2018-07-28 00:00:00', 0, 'تابلو ستوديو', 'دهوك', '0750', '@', 2),
	(323, 1, 1, 1, 0, 1, '', '2018-07-28 00:00:00', 2000, 'شيرزاد حلاق', 'دهوك', '0750', '@', 2),
	(324, 1, 0, 1, 0, 1, '', '2018-07-29 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(325, 1, 0, 1, 0, 1, '', '2018-07-29 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(326, 1, 1, 1, 0, 1, '', '2018-07-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(327, 1, 1, 1, 0, 1, '', '2018-07-31 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(328, 1, 1, 1, 0, 1, '', '2018-08-02 00:00:00', 2000, 'سعيد حجى ', 'دهوك', '07504708948', '@', 2),
	(329, 1, 0, 1, 0, 1, '', '2018-08-01 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(330, 1, 1, 127, 1, 0, 'طباعة في تركيا\r\nمقابل 84000 دينار', '2018-08-02 00:00:00', 0, 'RAND CO.', 'دهوك', '0750', '@', 2),
	(331, 1, 0, 64, 1, 1, '', '2018-08-02 00:00:00', 2.5, 'حسن مطبعة', 'دهوك', '07507337759', '@', 2),
	(333, 1, 0, 1, 0, 1, '', '2018-08-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(334, 1, 1, 129, 0, 0, '', '2018-08-04 00:00:00', 0, 'صباح حجى ', 'دهوك', '07504588851', '@', 2),
	(335, 1, 1, 1, 0, 1, '', '2018-08-04 00:00:00', 5000, 'هاني مجارى', 'دهوك', '0750', '@', 2),
	(336, 1, 0, 95, 1, 0, 'رقم القائمة 1461\r\n29/7/2018\r\nوالمادة الاولى من القائمة تابع قرطاسية', '2018-08-04 00:00:00', 0, 'قرطاسية الصهيب / عبدو', 'اربيل شارع التربة', '07503854402', 'teba-mni@hotmail.com', 2),
	(337, 1, 0, 95, 1, 0, 'رقم القائمة 1385\r\nتاريخ 15/7/2018', '2018-08-04 00:00:00', 0, 'قرطاسية الصهيب / عبدو', 'اربيل شارع التربة', '07503854402', 'teba-mni@hotmail.com', 2),
	(338, 1, 1, 1, 0, 1, '', '2018-08-07 00:00:00', 0, 'سهمى', 'دهوك', '0750', '@', 2),
	(339, 1, 1, 1, 0, 1, '', '2018-08-07 00:00:00', 4000, 'رةوةند كونكريت', 'دهوك', '07507518463', '@', 2),
	(341, 1, 0, 1, 0, 1, 'اجرة تاكسى دائرة الرياضة ', '2018-08-08 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(342, 1, 0, 1, 0, 1, '', '2018-08-09 00:00:00', 0, 'مطعم تندورى ', 'دهوك', '0750', '@', 2),
	(343, 1, 0, 1, 0, 1, '', '2018-08-09 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(344, 1, 1, 129, 0, 0, '', '2018-08-11 00:00:00', 0, 'صباح حجى ', 'دهوك', '07504588851', '@', 2),
	(345, 1, 1, 89, 0, 0, '', '2018-08-11 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(346, 1, 1, 1, 0, 0, 'تابع الند تيديكس صديق عبيدة', '2018-08-11 00:00:00', 20000, 'ilko co.', 'دهوك', '0750', '@', 2),
	(347, 1, 1, 1, 1, 0, '', '2018-08-11 00:00:00', 0, 'د.شهيد اسماعيل ', 'دهوك', '0750', '@', 2),
	(348, 1, 1, 1, 0, 0, '', '2018-08-12 00:00:00', 0, 'اطلس موبليات ', 'دهوك', '0750', '@', 2),
	(349, 1, 0, 128, 1, 1, 'دفع من قبل كوفان ', '2018-08-11 00:00:00', 0, 'شركة طه للنقل', 'دهوك - مرينا', '07508703053', '@', 2),
	(351, 1, 0, 1, 0, 1, '', '2018-08-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(352, 1, 0, 110, 1, 0, 'رقم قائمة 2969', '2018-08-13 00:00:00', 0, 'مطبعة هاوار', 'دهوك - پشت ئاڤاهیێ دادگەهێ ', '07504457021', '@', 2),
	(354, 1, 0, 1, 0, 1, '', '2018-08-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(355, 1, 0, 1, 0, 1, '', '2018-08-14 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(356, 1, 1, 1, 0, 0, 'تابع عصام حجي', '2018-08-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(357, 1, 1, 1, 0, 0, '', '2018-08-15 00:00:00', 0, 'ودن هاوس ', 'دهوك', '0750', '@', 2),
	(358, 1, 0, 130, 1, 1, '', '2018-08-15 00:00:00', 0, 'شرف الدين استانبول', 'تركيا', '00905068609568', '@', 2),
	(359, 1, 0, 1, 0, 1, 'رقم وصل 43', '2018-08-15 00:00:00', 0, 'الساعة ', 'دهوك', '0750', '@', 2),
	(360, 1, 0, 1, 0, 1, '', '2018-08-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(361, 1, 1, 131, 1, 0, 'خصم 10 دولار من قبل عبيدة', '2018-08-15 00:00:00', 0, 'مانكو', 'دهوك', '07506001122', '@', 2),
	(362, 1, 0, 1, 0, 1, 'زبر كارى ودن هاو س ', '2018-08-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(364, 1, 1, 1, 1, 1, '', '2018-08-18 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(365, 1, 1, 115, 1, 1, '', '2018-08-18 00:00:00', 0.306, 'پەرگەها هەلەبجە', 'دهوك - بازار ', '07503228811', 'halabjastat@gmail.com', 2),
	(367, 1, 1, 126, 0, 1, '', '2018-08-19 00:00:00', 10000, 'Tandori Rest', 'دهوك', '07701620002', '@', 2),
	(368, 1, 0, 1, 0, 1, '', '2018-08-19 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(369, 1, 1, 1, 0, 1, '', '2018-08-19 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(370, 1, 0, 1, 0, 1, '', '2018-08-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(371, 1, 1, 1, 0, 0, '', '2018-08-27 00:00:00', 0, 'محمد اخو دلشاد ', 'دهوك', '0750', '@', 2),
	(372, 1, 1, 122, 1, 0, '200بو قرطاسية دكه ل 2كيلو كباب ', '2018-08-27 00:00:00', 0, 'ELISE CARE', 'دهوك', '0750', '@', 2),
	(374, 1, 0, 1, 0, 1, '', '2018-08-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(375, 1, 0, 64, 1, 1, 'تم الادخال من قبل هيثم\r\nالقائمة تما شراءها في وقت سابق والان تم ادخالها \r\nوكان الصادر من اجل صباح حجي (من كلام حما)', '2018-08-10 00:00:00', 0, 'حسن مطبعة', 'دهوك', '0', '@', 2),
	(376, 1, 0, 95, 1, 0, 'رقم قائمة 1614', '2018-08-30 00:00:00', 0, 'قرطاسية الصهيب / عبدو', 'اربيل شارع التربة', '07503854402', 'teba-mni@hotmail.com', 2),
	(377, 1, 0, 1, 0, 1, 'بند ورق مات 350غرام من طرف عبدو اربيل ', '2018-08-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(380, 1, 1, 1, 0, 1, '', '2018-09-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(381, 1, 1, 1, 0, 0, '', '2018-09-04 00:00:00', 3750, 'زيرةفاني ', 'دهوك', '07502193807', '@', 2),
	(382, 1, 1, 1, 0, 1, '', '2018-09-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(383, 1, 1, 1, 0, 1, '', '2018-09-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(384, 1, 1, 1, 1, 0, '', '2018-09-04 00:00:00', 0, 'ابو سيفه ر ', 'دهوك', '0750', '@', 2),
	(385, 1, 0, 1, 0, 1, '', '2018-09-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(386, 1, 1, 1, 0, 1, '', '2018-09-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(387, 1, 0, 1, 0, 1, '', '2018-09-05 00:00:00', 1000, 'نقدي', 'دهوك', '0750', '@', 2),
	(394, 1, 1, 75, 1, 0, '', '2018-09-10 00:00:00', 27, 'ACINO', 'دهوك', '07702778906', '@', 2),
	(396, 1, 0, 113, 1, 0, '', '2018-09-10 00:00:00', 0, 'ستێر کومپانی', 'دهوك - نوهەدرا', '07504309999', 'INFO@STERCOMPUTER.COM', 2),
	(397, 1, 0, 1, 0, 1, 'تعديل تيشرت مديا ', '2018-09-10 00:00:00', 400, 'نقدي', 'دهوك', '0750', '@', 2),
	(399, 1, 1, 1, 0, 1, '', '2018-09-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(401, 1, 1, 1, 1, 0, '', '2018-09-15 00:00:00', 0, 'بيةيمانكةها ئالا', 'دهوك', '0750', '@', 2),
	(402, 1, 0, 113, 1, 0, 'رقم قائمة 10077', '2018-09-16 00:00:00', 0, 'ستێر کومپانی', 'دهوك - نوهەدرا', '07504309999', 'INFO@STERCOMPUTER.COM', 2),
	(403, 1, 1, 1, 0, 1, '', '2018-09-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(404, 1, 0, 1, 0, 1, '', '2018-09-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(405, 1, 0, 1, 0, 1, '', '2018-09-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(406, 1, 1, 1, 0, 1, '', '2018-09-18 00:00:00', 0, 'عزيز حاجى ', 'دهوك', '0750', '@', 2),
	(407, 1, 1, 1, 1, 1, '', '2018-09-18 00:00:00', 0, 'اياد شركة حلبجة', 'دهوك', '07504458081', '@', 2),
	(408, 1, 1, 1, 0, 1, '', '2018-09-19 00:00:00', 0, 'عمار سيرفس ', 'دهوك', '0750', '@', 2),
	(409, 1, 0, 1, 0, 1, '', '2018-09-20 00:00:00', 2000, 'نقدي', 'دهوك', '0750', '@', 2),
	(410, 1, 1, 77, 0, 0, '', '2018-09-20 00:00:00', 0, 'حلبجة زةرى لاند', 'دهوك', '0750', '@', 2),
	(411, 1, 1, 1, 1, 1, '', '2018-09-20 00:00:00', 0, 'PH FARMA', 'دهوك', '0750', '@', 2),
	(412, 1, 1, 1, 1, 1, '', '2018-09-22 00:00:00', 0, 'جهئ برلمان', 'دهوك', '0750', '@', 2),
	(413, 1, 0, 1, 1, 1, 'تحويل 1000دولار الى مطبعة توركياعن طريق كاك مصطفى\r\nبيد شيرزاد جميل ', '2018-09-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(415, 1, 1, 1, 0, 0, '', '2018-09-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(416, 1, 1, 1, 0, 0, '', '2018-09-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(418, 1, 1, 89, 0, 0, '', '2018-10-01 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(419, 1, 1, 1, 0, 1, '', '2018-10-01 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(420, 1, 1, 1, 1, 0, 'CYM', '2018-10-02 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(422, 1, 0, 1, 0, 1, '', '2018-10-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(423, 1, 1, 1, 0, 1, '', '2018-10-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(425, 1, 1, 1, 1, 0, '', '2018-10-07 00:00:00', 0, 'معمل دهوك ', 'دهوك', '0750', '@', 2),
	(426, 1, 1, 1, 0, 1, '', '2018-10-06 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(427, 1, 1, 1, 1, 1, '', '2018-10-06 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(428, 1, 1, 114, 1, 0, '', '2018-10-08 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(429, 1, 1, 1, 0, 1, '', '2018-10-09 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(430, 1, 0, 1, 0, 1, '', '2018-10-09 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(431, 1, 1, 1, 0, 1, '', '2018-10-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(432, 1, 0, 110, 1, 0, '', '2018-08-13 00:00:00', 0, 'مطبعة هاوار', 'دهوك - پشت ئاڤاهیێ دادگەهێ ', '07504457021', '@', 2),
	(433, 1, 0, 1, 0, 1, '', '2018-09-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(434, 1, 0, 1, 0, 1, '', '2018-10-07 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(435, 1, 0, 1, 0, 1, '', '2018-09-20 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(436, 1, 0, 1, 0, 1, '', '2018-09-23 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(437, 1, 0, 1, 0, 1, '', '2018-09-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(438, 1, 0, 1, 0, 1, '', '2018-09-25 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(439, 1, 0, 1, 0, 1, '', '2018-09-25 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(440, 1, 0, 1, 1, 1, '', '2018-10-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(441, 1, 0, 1, 0, 1, '', '2018-09-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(442, 1, 0, 1, 0, 1, '', '2018-10-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(443, 1, 0, 1, 0, 1, '', '2018-09-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(444, 1, 0, 1, 0, 1, '', '2018-09-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(445, 1, 0, 1, 0, 1, '', '2018-10-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(446, 1, 0, 1, 0, 1, '', '2018-09-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(448, 1, 0, 1, 1, 1, 'تحويل الى ورق مكربن', '2018-10-02 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(449, 1, 0, 1, 0, 1, '', '2018-10-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(450, 1, 0, 1, 0, 1, '', '2018-10-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(451, 1, 0, 1, 0, 1, '', '2018-10-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(452, 1, 0, 1, 0, 1, '', '2018-10-06 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(453, 1, 0, 1, 0, 1, '', '2018-10-07 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(454, 1, 0, 1, 0, 1, '', '2018-10-07 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(455, 1, 0, 1, 0, 1, '', '2018-10-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(456, 1, 0, 1, 0, 1, '', '2018-10-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(457, 1, 0, 1, 1, 1, '', '2018-10-08 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(459, 1, 1, 1, 0, 1, '', '2018-10-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(461, 1, 0, 1, 0, 1, '', '2018-10-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(462, 1, 1, 1, 0, 1, '', '2018-10-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(463, 1, 0, 1, 0, 1, '', '2018-10-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(464, 1, 1, 1, 0, 1, '', '2018-10-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(465, 1, 1, 1, 1, 1, '', '2018-10-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(466, 1, 0, 64, 1, 1, '', '2018-10-18 00:00:00', 3, 'حسن مطبعة', 'دهوك', '0', '@', 2),
	(467, 1, 1, 114, 1, 0, '', '2018-10-18 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(468, 1, 0, 124, 0, 1, '', '2018-10-20 00:00:00', 0, 'دلشاد ئاكرى', 'دهوك', '07504015740', '@', 2),
	(469, 1, 1, 89, 0, 0, '', '2018-10-20 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(470, 1, 0, 129, 0, 1, '', '2018-10-20 00:00:00', 0, 'صباح حجى ', 'دهوك', '07504588851', '@', 2),
	(471, 1, 1, 1, 1, 1, '', '2018-10-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(473, 1, 1, 1, 0, 0, '', '2018-10-22 00:00:00', 0, 'ورزش و لاوان / قسم GIZ', 'دهوك', '07504834544', '@', 2),
	(474, 1, 1, 1, 0, 1, '', '2018-10-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(475, 1, 1, 1, 1, 0, '', '2018-10-23 00:00:00', 0, 'استاذ امجد', 'دهوك', '07736969561', '@', 2),
	(477, 1, 1, 89, 1, 0, '', '2018-10-24 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(478, 1, 1, 127, 0, 0, '', '2018-10-28 00:00:00', 0, 'RAND CO.', 'دهوك', '0750', '@', 2),
	(479, 1, 1, 75, 1, 0, 'خصم من عبيدة', '2018-10-28 00:00:00', 100, 'ACINO', 'دهوك', '07702778906', '@', 2),
	(481, 1, 1, 1, 1, 0, 'واصل 100دولار باقى 40دولار', '2018-10-28 00:00:00', 0, 'INSTITUT FRANCAIS', 'دهوك', '07508265717', '@', 2),
	(482, 1, 1, 1, 1, 0, '', '2018-10-30 00:00:00', 0, 'قرطاسة به يف', 'دهوك', '07509969395', '@', 2),
	(483, 1, 1, 1, 0, 1, '', '2018-10-31 00:00:00', 0, 'معرض السيارات', 'دهوك', '07503639999', '@', 2),
	(484, 1, 1, 65, 0, 0, '', '2018-11-01 00:00:00', 0, 'شيرزاد مدخر', 'دهوك', '07504588649', '', 2),
	(485, 1, 0, 113, 1, 1, '', '2018-11-04 00:00:00', 0, 'ستێر کومپانی', 'دهوك - نوهەدرا', '07504309999', 'INFO@STERCOMPUTER.COM', 2),
	(486, 1, 1, 73, 1, 0, '', '2018-11-04 00:00:00', 0, 'مجمع وان كلوبال', 'دهوك', '07507318888', '@', 2),
	(487, 1, 1, 1, 0, 1, '', '2018-11-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(488, 1, 1, 1, 0, 1, '', '2018-11-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(489, 1, 1, 1, 0, 1, '', '2018-11-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(490, 1, 0, 1, 0, 1, '', '2018-11-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(491, 1, 0, 95, 1, 0, '', '2018-11-03 00:00:00', 0, 'قرطاسية الصهيب / عبدو', 'اربيل شارع التربة', '07503854402', 'teba-mni@hotmail.com', 2),
	(492, 1, 1, 1, 0, 1, '', '2018-11-08 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(493, 1, 1, 1, 1, 1, '', '2018-11-08 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(494, 1, 1, 73, 1, 0, 'د. فاروق رمضان', '2018-11-10 00:00:00', 0, 'مجمع وان كلوبال', 'دهوك', '07507318888', '@', 2),
	(497, 1, 1, 1, 0, 1, '', '2018-11-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(498, 1, 0, 1, 0, 1, '', '2018-11-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(500, 1, 1, 74, 0, 0, 'مجمع هيلب ', '2018-11-11 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(501, 1, 1, 1, 0, 1, '', '2018-11-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(502, 1, 1, 1, 1, 0, 'تابع اذستاذ حسام', '2018-10-20 00:00:00', 0, 'BWOCD', 'دهوك', '07514849342', '@', 2),
	(503, 1, 1, 1, 0, 1, '', '2018-11-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(504, 1, 1, 1, 0, 1, '', '2018-11-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(505, 1, 1, 65, 0, 0, 'مجمع هيوا', '2018-11-17 00:00:00', 0, 'شيرزاد مدخر', 'دهوك', '07504588649', '', 2),
	(506, 1, 1, 114, 1, 0, '', '2018-11-19 00:00:00', 0.5, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(507, 1, 1, 74, 0, 0, 'مجمع هيلب /تابع شيرزاد مدخر ', '2018-11-19 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(508, 1, 1, 1, 1, 0, '', '2018-11-21 00:00:00', 0, 'BWOCD', 'دهوك', '0750', '@', 2),
	(509, 1, 1, 74, 0, 0, 'تابع مجمع هيلب', '2018-11-24 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(510, 1, 1, 1, 0, 1, '', '2018-11-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(512, 1, 0, 1, 1, 1, '', '2018-11-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(513, 1, 1, 1, 0, 1, '', '2018-11-27 00:00:00', 0, 'صالون راكان و ريتا', 'دهوك', '07502303040', '@', 2),
	(514, 1, 0, 1, 0, 1, '', '2018-11-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(518, 1, 1, 65, 0, 0, 'طبع مجمع هيوا', '2018-11-28 00:00:00', 0, 'شيرزاد مدخر', 'دهوك', '07504588649', '', 2),
	(519, 1, 1, 74, 0, 0, 'طبع مجمع هيلب', '2018-11-28 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(520, 1, 1, 65, 0, 0, 'طابع مجمع هيوا ', '2018-11-28 00:00:00', 0, 'شيرزاد مدخر', 'دهوك', '07504588649', '', 2),
	(521, 1, 1, 1, 1, 0, '', '2018-11-29 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(522, 1, 1, 127, 1, 1, '', '2018-12-01 00:00:00', 0, 'RAND CO.', 'دهوك', '0750', '@', 2),
	(523, 1, 1, 1, 0, 1, '', '2018-12-02 00:00:00', 0, 'جمال محمد شرين', 'دهوك', '07504713729', '@', 2),
	(524, 1, 1, 1, 0, 1, '', '2018-12-09 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(525, 1, 1, 1, 0, 1, '', '2018-12-09 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(526, 1, 1, 74, 0, 0, 'طابع مجمع هيلب ', '2018-12-09 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(529, 1, 1, 74, 0, 0, 'طبع مجمع هليب ', '2018-12-09 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(530, 1, 1, 65, 0, 0, '', '2018-12-10 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(531, 1, 1, 63, 0, 0, '', '2018-12-12 00:00:00', 0, 'مطبعة زانا', 'دهوك', '07504505602', '@', 2),
	(532, 1, 1, 1, 0, 0, '', '2018-12-13 00:00:00', 9800, 'فێرگەها پارتی زانی', 'دهوك', '07502193807', '@', 2),
	(533, 1, 1, 1, 0, 1, 'دلوئاكرة ى ', '2018-12-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(534, 1, 1, 1, 0, 1, '', '2018-12-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(538, 1, 1, 114, 1, 0, 'استقطاع 14 $ من بنك', '2018-12-15 00:00:00', 14, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(540, 1, 1, 1, 0, 0, '', '2018-12-17 00:00:00', 1000, 'شركة سوبر بايوت هيلث', 'دهوك', '0750', '@', 2),
	(541, 1, 1, 65, 0, 0, '', '2018-12-18 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(542, 1, 1, 1, 0, 1, '', '2018-12-20 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(543, 1, 1, 74, 0, 0, '', '2018-12-22 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(544, 1, 0, 1, 1, 1, 'تحويل الى مطبعة توركيا ', '2018-12-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(545, 1, 0, 1, 1, 1, '', '2018-12-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(546, 1, 1, 126, 1, 0, '', '2018-12-22 00:00:00', 0, 'Tandori Rest', 'دهوك', '07701620002', '@', 2),
	(547, 1, 1, 1, 0, 1, '', '2018-12-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(548, 1, 1, 74, 0, 0, '', '2018-12-25 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(549, 1, 1, 74, 0, 0, '', '2018-12-25 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(550, 1, 1, 1, 0, 1, '', '2018-12-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(551, 1, 1, 1, 0, 1, '', '2018-12-29 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(552, 1, 1, 127, 1, 1, '', '2018-12-29 00:00:00', 0, 'RAND CO.', 'دهوك', '0750', '@', 2),
	(553, 1, 1, 65, 0, 0, '', '2018-12-30 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(554, 1, 1, 1, 0, 0, '', '2018-12-30 00:00:00', 0, 'حجى قرصو ', 'دهوك', '07504724347', '@', 2),
	(555, 1, 1, 1, 0, 1, '', '2018-12-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(556, 1, 1, 1, 0, 1, '', '2018-12-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(557, 1, 0, 64, 1, 0, '', '2018-12-31 00:00:00', 0, 'حسن مطبعة', 'دهوك', '07507337759', '@', 2),
	(558, 1, 1, 65, 0, 0, '', '2019-01-03 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(559, 1, 1, 1, 0, 1, '', '2019-01-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(560, 1, 1, 1, 0, 1, '', '2019-01-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(564, 1, 1, 134, 0, 0, '', '2019-01-11 00:00:00', 0, 'كومبانيا جياى خير ', 'دهوك', '07507334768', '@', 2),
	(565, 1, 1, 1, 0, 1, '', '2019-01-08 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(566, 1, 0, 1, 1, 1, '', '2019-01-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(567, 1, 0, 95, 1, 0, '', '2019-01-10 00:00:00', 0, 'قرطاسية الصهيب / عبدو', 'اربيل شارع التربة', '07503854402', 'teba-mni@hotmail.com', 2),
	(568, 0, 0, 1, 0, 1, '', '2019-01-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(569, 1, 1, 1, 0, 1, '', '2019-01-12 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(570, 1, 0, 1, 1, 1, '', '2019-01-14 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(571, 1, 0, 1, 1, 1, '', '2019-01-14 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(572, 1, 1, 129, 1, 1, '', '2019-01-14 00:00:00', 0, 'صباح حجى ', 'دهوك', '07504588851', '@', 2),
	(573, 1, 1, 114, 1, 0, '', '2019-01-16 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(574, 0, 1, 114, 1, 0, '', '2019-01-16 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(575, 1, 1, 1, 0, 1, '', '2019-01-17 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(576, 1, 0, 1, 1, 1, '', '2019-01-17 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(577, 1, 1, 63, 0, 0, '', '2019-01-17 00:00:00', 0, 'مطبعة زانا', 'دهوك', '07504505602', '@', 2),
	(578, 1, 1, 65, 0, 0, '', '2019-01-17 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(579, 1, 1, 1, 0, 1, '', '2019-01-17 00:00:00', 0, 'خارنكه ها كاس', 'دهوك', '0750', '@', 2),
	(580, 1, 0, 64, 1, 1, '', '2019-01-20 00:00:00', 0, 'حسن مطبعة', 'دهوك', '07507337759', '@', 2),
	(581, 1, 1, 1, 0, 1, '', '2019-01-20 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(582, 1, 1, 1, 0, 1, '', '2019-01-22 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(583, 1, 1, 1, 0, 1, '', '2019-01-23 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(584, 1, 1, 1, 0, 1, '', '2019-01-24 00:00:00', 0, 'كومبانيا كه هى ', 'دهوك', '07504722406', '@', 2),
	(585, 1, 1, 65, 0, 0, '', '2019-01-26 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(586, 1, 1, 74, 0, 0, '', '2019-01-27 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(587, 1, 1, 65, 0, 0, '', '2019-01-28 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(588, 1, 1, 74, 0, 0, '', '2019-01-29 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(589, 1, 1, 1, 0, 1, '', '2019-01-29 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(590, 1, 1, 114, 1, 0, '', '2019-01-30 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(591, 1, 1, 89, 1, 0, '', '2019-01-30 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(592, 1, 1, 1, 0, 1, '', '2019-01-31 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(593, 1, 0, 1, 0, 1, '', '2019-01-31 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(594, 1, 1, 1, 0, 1, '', '2019-01-31 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(595, 1, 0, 1, 0, 1, '', '2019-02-07 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(596, 1, 1, 74, 0, 0, '', '2019-02-10 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(601, 1, 1, 114, 1, 0, '', '2019-02-11 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(602, 1, 1, 1, 0, 1, '', '2019-02-12 00:00:00', 0, 'شيرازد  حلاق', 'دهوك', '0750', '@', 2),
	(603, 1, 1, 1, 0, 0, '', '2019-02-13 00:00:00', 0, 'xebat factory', 'دهوك', '07504575071', '@', 2),
	(604, 1, 0, 1, 0, 1, '', '2019-02-14 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(605, 1, 1, 74, 0, 0, '', '2019-02-14 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(606, 1, 1, 1, 0, 1, '', '2019-02-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(607, 1, 1, 1, 0, 1, '', '2019-02-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(608, 1, 1, 1, 0, 1, '', '2019-02-18 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(609, 1, 1, 1, 0, 0, '', '2019-02-18 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(610, 1, 0, 1, 0, 1, '', '2019-02-20 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(611, 1, 1, 114, 1, 0, '', '2019-02-21 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(612, 1, 0, 1, 0, 1, '', '2019-02-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(613, 1, 0, 1, 0, 1, '', '2019-02-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(614, 1, 1, 1, 0, 0, '', '2019-02-23 00:00:00', 350, 'شيرزاد حلاق ', 'دهوك', '07504740616', '@', 2),
	(615, 1, 1, 1, 0, 1, '', '2019-02-23 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(616, 1, 0, 1, 0, 1, '', '2019-02-23 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(618, 1, 1, 133, 0, 1, '', '2019-02-25 00:00:00', 0, 'صالون راكان و ريتا', 'دهوك', '07502303040', '@', 2),
	(619, 1, 0, 1, 0, 1, '', '2019-02-25 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(620, 1, 1, 129, 0, 0, '', '2019-02-26 00:00:00', 0, 'صباح حجى ', 'دهوك', '07504588851', '@', 2),
	(621, 1, 0, 1, 0, 1, '', '2019-02-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(622, 1, 1, 1, 0, 1, '', '2019-02-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(624, 1, 1, 65, 0, 0, '', '2019-02-27 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(625, 1, 0, 1, 0, 1, '', '2019-02-27 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(626, 1, 0, 1, 0, 1, '', '2019-03-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(627, 1, 1, 1, 0, 1, '', '2019-03-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(628, 1, 0, 1, 0, 1, '', '2019-03-03 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(629, 1, 1, 114, 1, 0, '', '2019-03-03 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(630, 1, 0, 1, 0, 1, '', '2019-03-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(631, 1, 1, 1, 0, 1, '', '2019-03-04 00:00:00', 0, 'شركة اسينو', 'دهوك', '0750', '@', 2),
	(632, 1, 0, 1, 0, 1, '', '2019-03-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(633, 1, 0, 1, 0, 1, '', '2019-03-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(634, 1, 1, 63, 1, 1, '', '2019-03-05 00:00:00', 0, 'مطبعة زانا', 'دهوك', '07504505602', '@', 2),
	(635, 1, 0, 1, 0, 1, '', '2019-03-05 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(636, 1, 1, 1, 0, 1, '', '2019-03-06 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(637, 1, 0, 1, 0, 1, '', '2019-03-06 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(638, 1, 0, 1, 0, 1, '', '2019-03-06 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(639, 1, 0, 1, 0, 1, '', '2019-03-06 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(640, 1, 1, 1, 1, 1, '', '2019-03-09 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(641, 1, 1, 65, 0, 0, '', '2019-03-09 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(642, 1, 1, 1, 0, 1, '', '2019-03-09 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(643, 1, 1, 74, 0, 0, '', '2019-03-10 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(644, 1, 1, 1, 0, 1, '', '2019-03-10 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(645, 1, 1, 63, 0, 0, '', '2019-03-10 00:00:00', 0, 'مطبعة زانا', 'دهوك', '07504505602', '@', 2),
	(646, 1, 1, 1, 0, 1, '', '2019-03-12 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(647, 1, 1, 135, 1, 1, '', '2019-03-12 00:00:00', 0, 'منظمة T-DEX', 'دهوك', '0750', '@', 2),
	(648, 1, 1, 135, 1, 0, '', '2019-03-12 00:00:00', 0, 'منظمة T-DEX', 'دهوك', '0750', '@', 2),
	(649, 1, 1, 1, 0, 1, '', '2019-03-12 00:00:00', 0, 'R.S SHOW', 'دهوك', '07503611993', '@', 2),
	(650, 1, 1, 1, 0, 1, '', '2019-03-13 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(651, 1, 0, 1, 0, 1, '', '2019-03-14 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(652, 1, 0, 1, 0, 1, '', '2019-03-14 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(653, 1, 0, 1, 0, 1, '', '2019-03-14 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(654, 1, 1, 65, 0, 0, '', '2019-03-16 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(655, 1, 1, 135, 1, 1, '', '2019-03-16 00:00:00', 0, 'منظمة T-DEX', 'دهوك', '0750', '@', 2),
	(656, 1, 1, 1, 1, 1, 'كارت بو بردرش', '2019-03-16 00:00:00', 0, 'دكتور حميد ', 'دهوك', '0750', '@', 2),
	(657, 1, 1, 65, 0, 0, '', '2019-03-16 00:00:00', 0, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 2),
	(658, 1, 1, 1, 0, 1, '', '2019-03-17 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(659, 1, 0, 1, 1, 1, '', '2019-03-19 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(660, 1, 1, 1, 0, 1, '', '2019-03-24 00:00:00', 0, 'harikar  electronic', 'دهوك', '0750', '@', 2),
	(661, 1, 0, 1, 1, 1, '', '2019-03-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(662, 1, 1, 1, 0, 1, '', '2019-03-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(663, 1, 1, 114, 1, 0, '', '2019-03-24 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(664, 1, 1, 1, 0, 1, '', '2019-03-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(666, 1, 1, 1, 0, 1, '', '2019-03-26 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(667, 1, 1, 114, 1, 0, '', '2019-03-26 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(668, 1, 1, 114, 1, 0, '', '2019-03-26 00:00:00', 0, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 2),
	(669, 1, 0, 1, 0, 1, '', '2019-03-28 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(670, 1, 0, 1, 0, 1, '', '2019-03-30 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(672, 1, 0, 1, 0, 1, '', '2019-03-31 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(674, 1, 1, 1, 0, 1, '', '2019-04-01 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(675, 1, 1, 1, 0, 1, '', '2019-04-02 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(676, 1, 0, 1, 0, 1, '', '2019-04-02 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(677, 1, 0, 1, 0, 1, '', '2019-04-02 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(678, 1, 0, 1, 0, 1, '', '2019-04-02 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(679, 1, 1, 74, 0, 0, '', '2019-04-03 00:00:00', 0, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 2),
	(680, 1, 0, 1, 1, 1, '', '2019-04-04 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(682, 1, 0, 1, 0, 1, '', '2019-04-07 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(683, 1, 1, 1, 0, 1, '', '2019-04-07 00:00:00', 3000, 'نقدي', 'دهوك', '0750', '@', 2),
	(685, 1, 1, 1, 0, 1, '', '2019-04-08 00:00:00', 0, 'شركة حامد احمد', 'دهوك', '07504506187', '@', 2),
	(686, 1, 1, 1, 0, 1, '', '2019-04-08 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(687, 1, 0, 1, 0, 1, '', '2019-04-08 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(688, 1, 1, 1, 0, 1, '', '2019-04-08 00:00:00', 0, 'uni pharma', 'دهوك', '07507052557', '@', 2),
	(689, 1, 1, 1, 0, 1, '', '2019-04-11 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(690, 1, 1, 89, 0, 1, '', '2019-04-13 00:00:00', 0, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 2),
	(691, 1, 0, 1, 1, 1, '', '2019-04-15 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(692, 1, 0, 1, 0, 1, '', '2019-04-16 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(695, 1, 1, 136, 0, 0, '', '2019-04-17 00:00:00', 0, 'R.S.Show', 'دهوك', '07503611993', '@', 2),
	(696, 1, 1, 1, 0, 1, '', '2019-04-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(697, 1, 1, 1, 0, 1, '', '2019-04-21 00:00:00', 488, 'نقدي', 'دهوك', '0750', '@', 2),
	(698, 1, 0, 1, 0, 1, '', '2019-04-21 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(699, 1, 1, 1, 0, 1, '', '2019-04-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(700, 1, 1, 1, 0, 1, '', '2019-04-24 00:00:00', 350, 'شيرزاد حلاق ', 'دهوك', '0750', '@', 2),
	(701, 1, 1, 1, 0, 1, '', '2019-04-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(702, 1, 0, 1, 1, 1, '', '2019-04-24 00:00:00', 0, 'نقدي', 'دهوك', '0750', '@', 2),
	(703, 1, 1, 1, 0, 0, '', '2019-04-24 00:00:00', 0, 'ishk school', 'دهوك', '0750', '@', 2),
	(704, 1, 1, 1, 1, 1, '', '2019-04-24 00:00:00', 0, 'قرطاسية زةرى لاند', 'دهوك', '0750', '@', 2);
/*!40000 ALTER TABLE `tbl_bills` ENABLE KEYS */;

-- Dumping structure for table db_h_press.tbl_clients
CREATE TABLE IF NOT EXISTS `tbl_clients` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `location` varchar(255) DEFAULT '',
  `mobile` varchar(50) DEFAULT '',
  `email` varchar(50) DEFAULT '',
  `type` int(2) NOT NULL DEFAULT '0',
  `is_import` tinyint(1) NOT NULL DEFAULT '1',
  `is_export` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=137 DEFAULT CHARSET=utf8 COMMENT='public enum clientType\r\n        {\r\n            Client,\r\n            Supplier,\r\n            Delegate,\r\n            Employer\r\n        }';

-- Dumping data for table db_h_press.tbl_clients: ~54 rows (approximately)
/*!40000 ALTER TABLE `tbl_clients` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_clients` (`id`, `name`, `location`, `mobile`, `email`, `type`, `is_import`, `is_export`) VALUES
	(1, 'نقدي', 'دهوك', '0750', '@', 0, 1, 1),
	(2, 'العام', 'دهوك', '0', '@', 2, 1, 0),
	(63, 'مطبعة زانا', 'دهوك', '07504505602', '@', 0, 1, 1),
	(64, 'حسن مطبعة', 'دهوك', '07507337759', '@', 0, 1, 1),
	(65, 'كلينيكين هيوا', 'دهوك', '07504588649', '', 0, 1, 0),
	(69, 'فرهنك', 'دهوك', '0', '@', 2, 1, 0),
	(71, 'عبيدة', 'دهوك', '0', '@', 3, 1, 0),
	(72, 'سيفر', 'دهوك', '0', '@', 3, 1, 0),
	(73, 'مجمع وان كلوبال', 'دهوك', '07507318888', '@', 0, 1, 0),
	(74, 'كلينيكين هيلب', 'دهوك', '07504276465', '@', 0, 1, 0),
	(75, 'ACINO', 'دهوك', '07702778906', '@', 0, 1, 0),
	(76, 'IFMSA', 'دهوك', '0750', '@', 0, 1, 0),
	(77, 'حلبجة زةرى لاند', 'دهوك', '0750', '@', 0, 1, 0),
	(78, 'نخشين ريكلام', 'دهوك', '07504241752', '@', 0, 1, 0),
	(79, 'PIONEER', 'دهوك', '0750', '@', 0, 1, 0),
	(80, 'ديوان', 'دهوك ', '07509001900', '@', 0, 1, 0),
	(81, 'مطبعة تركيا', 'تركيا - دياربكر', '00905378631728', '@', 0, 0, 1),
	(82, 'ايمن', 'دهوك', '07511220564', '', 0, 1, 0),
	(85, 'حسام بسام', 'دهوك', '07504954977', '@', 0, 1, 0),
	(86, 'Fish House', 'دهوك', '0750686111', '@', 0, 1, 0),
	(87, 'مطبعة ميديا', 'دهوك', '0750', '@', 0, 1, 1),
	(88, 'bilim', 'دهوك', '07703235645', 'alneaamt_pharmacist@yahoo.com', 0, 1, 0),
	(89, 'Moom Reklam', 'دهوك - بازار', '07504284533', 'mostafaabe976@gmail.com', 0, 1, 1),
	(91, 'ميديا ترافل', 'دهوك - شيخان', '07504209262', 'info@media-travels.com', 0, 1, 0),
	(94, 'قرطاسية الاخوين', 'دهوك', '0750', '@', 0, 0, 1),
	(95, 'قرطاسية الصهيب / عبدو', 'اربيل شارع التربة', '07503854402', 'teba-mni@hotmail.com', 0, 0, 1),
	(97, 'قرطاسية حلبجة', 'دهوك', '0750', '@', 0, 1, 0),
	(98, 'Golden House', 'دهوك', '07508904242', '@', 0, 1, 0),
	(99, ' Sipan House', 'دهوك', '07504587849', '@', 0, 1, 0),
	(102, 'بهرا', 'دهوك', '07504045318', '', 2, 1, 0),
	(103, 'farmatech', 'دهوك', '07508339553', '@', 0, 1, 0),
	(104, 'Tedx Duhok', 'دهوك', '07502214398', 'info@tedxduhok.com', 0, 1, 0),
	(105, 'نيوار قهار', 'دهوك', '07507927606', '', 2, 1, 0),
	(106, 'مديرية تربية نينوى', 'موصل - الفيصلية', '07512235289', 'bilalaljobori35@gmail.com', 0, 1, 0),
	(109, 'idea office', 'الموصل', '07503433208', '', 2, 1, 0),
	(110, 'مطبعة هاوار', 'دهوك - پشت ئاڤاهیێ دادگەهێ ', '07504457021', '@', 0, 0, 1),
	(111, 'قرطاسية العالمية', 'اربيل شارع التربية - خلف فندق لارسا', '0750', '@', 0, 1, 0),
	(112, 'Sebar Reklam', 'دهوك - جادا نوهدرا ', '07508552994', 'alrabeepetint@yahoo.com', 0, 1, 0),
	(113, 'ستێر کومپانی', 'دهوك - نوهەدرا', '07504309999', 'INFO@STERCOMPUTER.COM', 0, 1, 1),
	(114, 'IMC', 'دهوك', '07504853090', 'segahmed@internationalmedicalcorps.org', 0, 1, 0),
	(115, 'پەرگەها هەلەبجە', 'دهوك - بازار ', '07503228811', 'halabjastat@gmail.com', 0, 1, 1),
	(117, 'پەرگەها بزاڤ', 'دهوك ', '07504247735', '@', 0, 1, 0),
	(120, 'Mila Reklam', 'دهوك', '07507513515', '@', 0, 1, 0),
	(121, 'قرطاسية ياد', 'اربيل', '07504559014', '@', 0, 0, 1),
	(122, 'ELISE CARE', 'دهوك', '0750', '@', 0, 1, 0),
	(123, 'XEROX', 'ERBIL', '0750', '@', 0, 0, 1),
	(124, 'دلشاد ئاكرى', 'دهوك', '07504015740', '@', 0, 1, 0),
	(125, 'GIZ - IRAQ', 'دهوك', '07507538707', '@', 0, 1, 0),
	(126, 'Tandori Rest', 'دهوك', '07701620002', '@', 0, 1, 0),
	(127, 'RAND CO.', 'دهوك', '0750', '@', 0, 1, 0),
	(128, 'شركة طه للنقل', 'دهوك - مرينا', '07508703053', '@', 0, 0, 1),
	(129, 'صباح حجى ', 'دهوك', '07504588851', '@', 0, 1, 1),
	(130, 'شرف الدين استانبول', 'تركيا', '00905068609568', '@', 0, 0, 1),
	(131, 'مانكو', 'دهوك', '07506001122', '@', 0, 1, 0),
	(133, 'صالون راكان و ريتا', 'دهوك', '07502303040', '@', 0, 1, 0),
	(134, 'كومبانيا جياى خير ', 'دهوك', '07507334768', '@', 0, 1, 0),
	(135, 'منظمة T-DEX', 'دهوك', '0750', '@', 0, 1, 0),
	(136, 'R.S.Show', 'دهوك', '07503611993', '@', 0, 1, 0);
/*!40000 ALTER TABLE `tbl_clients` ENABLE KEYS */;

-- Dumping structure for table db_h_press.tbl_debits
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table db_h_press.tbl_debits: ~0 rows (approximately)
/*!40000 ALTER TABLE `tbl_debits` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_debits` ENABLE KEYS */;

-- Dumping structure for table db_h_press.tbl_dollar
CREATE TABLE IF NOT EXISTS `tbl_dollar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `value` double NOT NULL DEFAULT '0',
  `creation` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- Dumping data for table db_h_press.tbl_dollar: ~9 rows (approximately)
/*!40000 ALTER TABLE `tbl_dollar` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_dollar` (`id`, `value`, `creation`) VALUES
	(1, 1250, '2017-12-01 01:04:52'),
	(2, 1250, '2018-02-01 14:42:47'),
	(3, 1240, '2018-02-01 14:42:50'),
	(5, 1240, '2018-02-14 14:58:33'),
	(6, 1250, '2018-02-18 18:09:07'),
	(7, 1220, '2018-03-05 18:27:59'),
	(8, 1220, '2018-03-05 18:58:07'),
	(9, 1220, '2018-04-25 11:26:35'),
	(10, 1200, '2018-04-25 11:26:47'),
	(11, 1220, '2018-07-26 12:09:23'),
	(12, 1220, '2018-07-26 17:49:14'),
	(13, 1200, '2018-07-29 11:35:35');
/*!40000 ALTER TABLE `tbl_dollar` ENABLE KEYS */;

-- Dumping structure for table db_h_press.tbl_products
CREATE TABLE IF NOT EXISTS `tbl_products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` text,
  `price` double NOT NULL DEFAULT '0',
  `count` double NOT NULL DEFAULT '0',
  `note` text,
  `bill_id` int(11) NOT NULL,
  `delegate_percentage` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `bill_id` (`bill_id`),
  CONSTRAINT `tbl_products_ibfk_1` FOREIGN KEY (`bill_id`) REFERENCES `tbl_bills` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3998 DEFAULT CHARSET=utf8;

-- Dumping data for table db_h_press.tbl_products: ~828 rows (approximately)
/*!40000 ALTER TABLE `tbl_products` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_products` (`id`, `description`, `price`, `count`, `note`, `bill_id`, `delegate_percentage`) VALUES
	(23, 'طباعة دفتر وصل A5  مخرم', 2000, 10, 'نڤیسینگەها چیا', 12, 0),
	(226, 'طباعة دفتر وصل', 2000, 10, 'تورومبێل', 49, 0),
	(227, 'طباعة دفتر وصل', 3000, 10, 'زێرنگر', 49, 0),
	(268, 'شراء كارت كورك ', 6000, 2, 'فلوس من قرطاسية', 54, 0),
	(362, 'تكسي من مطبعة ميديا توصيل فليكس مرور', 3000, 1, '', 56, 0),
	(413, 'طباعة دفتر A5', 2000, 10, 'ستوكهولم', 59, 0),
	(509, 'ورق ارت 250 غرام 125 طبقة (مات + لماع )33*48', 30, 1, 'رقم القائمة 000258', 64, 0),
	(574, 'تصفية حساب مع مطبعة ميديا ', 76, 1, 'فلوس من محمود', 60, 0),
	(587, 'طباعة على ورق', 625, 40, '', 63, 0),
	(598, 'تكسي من مطبعة هاوار الى حلبجة', 3000, 1, 'پارە ژ قورتاسیێ', 73, 0),
	(599, 'تكسي الى منظمة IMC', 3000, 2, 'پارە ژ قورتاسیێ', 73, 0),
	(605, 'طباعة دفتر وصل مخرم اي فايف', 1750, 50, 'مطعم نوروز', 68, 0),
	(606, 'طباعة فتر وصل ربع اي فور', 1250, 8, 'نورسين بوك شوب', 68, 0),
	(607, 'طباعة دفتر وصل سقط ( خلتي ژ مەسعودی)', 1500, 50, '', 68, 0),
	(617, 'طباعة دفتر وصل مكربن + مخرم ( 3 ورقات )', 3500, 10, '', 81, 0),
	(619, 'طباعة على جانتة', 5000, 20, '', 83, 0),
	(624, 'طباعة دفتر وصل ', 3000, 10, '', 84, 0),
	(632, 'طباعة شهادات', 1875, 8, '', 87, 0),
	(633, 'طباعة دفتر وصل مكربن', 2500, 12, 'زێرنگریا دەلال', 86, 0),
	(634, 'طباعة دفتر وصل ', 2000, 10, 'زانا 2', 86, 0),
	(635, 'طباعة ظرف', 100, 150, 'زانا 2', 86, 0),
	(640, 'شراء ورق تيشرت + كوب', 10, 5, 'پارە ژ قورتاسیێ', 90, 0),
	(641, 'تكسي من اربيل الى دهوك', 10000, 1, 'ژ قورتاسیێ', 91, 0),
	(654, 'طباعة دفتر وصل A6', 650, 100, '', 92, 0),
	(657, 'تكسي الى مستشفى وان كلوبال', 3000, 1, 'پارە ژ قورتاسیێ', 94, 0),
	(662, 'طباعة فلير (سعيد)', 0.06875, 8000, '', 74, 0),
	(663, 'طباعة دفتر وصل', 2000, 20, 'دم دم', 96, 0),
	(685, 'باج', 10000, 1, '', 99, 0),
	(686, 'طباعة دفتر', 5000, 1, '', 99, 0),
	(688, 'طباعة دفتر ', 2000, 10, 'كارزان چەمانی', 101, 0),
	(699, 'طباعة بروشور 115 غرام', 400000, 1, 'دفع من قرطاسية', 108, 0),
	(701, 'طباعة على تيشرت و وشاح سكرين', 1400000, 1, '', 109, 0),
	(702, 'طباعة بروشور', 400000, 1, 'الدفع من قرطاسية', 95, 0),
	(710, 'كارت كورك', 6000, 1, '', 112, 0),
	(716, 'طباعة راجيت', 1, 100, '', 93, 0),
	(721, 'طباعة على ورق A4 160غرام', 85, 500, '', 77, 0),
	(722, 'طباعة فولدر 350 غرام مع كسر بالوسط', 450, 500, '', 77, 0),
	(724, 'طباعة دفاتر A3', 7000, 10, '', 113, 0),
	(726, 'Print on T-shirt', 8000, 4, '', 114, 0),
	(727, 'تكسي بو كافي لاند', 3000, 1, '', 115, 0),
	(731, 'شراء ظرف ', 1500, 3, '', 88, 0),
	(735, 'طبع فلكس 3 * 0.35', 25000, 1, '', 119, 0),
	(736, 'طباعة ملزمة ', 1666.66666666667, 150, '', 102, 0),
	(737, ' ديزاين ملزمة', 100000, 1, '', 102, 0),
	(738, 'طباعة دفتر وصولات A5', 2500, 6, '', 120, 0),
	(739, 'طباعة وصل قبض A5', 2500, 6, '', 120, 0),
	(780, 'وارد تعديل الحساب', 92000, 1, '', 117, 0),
	(781, 'شمسية ابيض للطباعة', 3000, 24, '', 118, 0),
	(782, 'اجرة نقل ', 10000, 1, '', 118, 0),
	(812, 'بند PVC عدد 25 شيت', 10000, 1, '', 128, 0),
	(813, 'تيل سبايرول اسود 1/2 عدد 100 تيل', 10000, 1, '', 128, 0),
	(814, 'ورق مكربن ابيض 75 غم 500', 7500, 10, '', 128, 0),
	(815, 'ورق تيشيرت دارك انجيكت عدد 20 شيت', 16000, 1, '', 128, 0),
	(816, 'ورق جوجو كريستال 100 شيت A4', 35000, 1, '', 128, 0),
	(817, 'ورق جوجو مغناطيس 10 شيت A4', 15000, 1, '', 128, 0),
	(818, 'تريس كوب 100 شيت اصلي', 28000, 1, '', 128, 0),
	(819, 'ورق جوجو شفاف 50 شيت A4', 15000, 1, '', 128, 0),
	(821, 'طباعة دفتر A5', 1750, 100, '', 124, 0),
	(823, 'طباعة ورق حرارى A4', 1000, 6, '', 127, 0),
	(824, 'طبع لوكو على الحقائب NCA', 5000, 20, '', 123, 0),
	(825, 'ارت 90 غم A5 بطاقة دعوة', 150, 150, '', 126, 0),
	(864, 'تصميم وطباعة ظرف دعوة', 0.25, 150, '', 80, 0),
	(865, 'راجيت دكتور', 2.5, 10, '', 80, 0),
	(875, 'طباعة دفتر وصولات A5', 2000, 10, 'ادنة', 130, 0),
	(876, 'طباعة دفتر وصولات A6', 1000, 12, 'هاريوان فون', 130, 0),
	(877, 'طباعة دفتر وصولات A5', 2000, 6, 'هسنى', 130, 0),
	(878, 'ستاند فلاير بلاستيك A6', 4000, 9, '', 130, 0),
	(893, 'طباعة شهادات A4', 2000, 10, '', 133, 0),
	(894, 'شراء كليبس للطابعة', 150, 1, '', 134, 0),
	(895, 'تبديل BTR', 1180, 1, '', 135, 0),
	(899, 'PRINT INVOICE BOOK 100 PAPER + CARBON', 7, 25, '', 131, 0),
	(900, 'حبر طابعة', 390, 2, '', 136, 0),
	(901, 'تكسي من اربيل كليبس زيروكس', 10000, 1, '', 137, 0),
	(903, 'تكسي من اربيل نقل ورق مكربن', 25000, 1, '', 138, 0),
	(904, 'طباعة بروشور ', 0.155, 3000, '', 111, 0),
	(905, 'طباعة بروشور ', 0.155, 3000, '', 111, 0),
	(906, 'طباعة فلير', 0.10625, 8000, '', 75, 0),
	(907, 'طباعة شهادات', 0.5, 43, '', 75, 0),
	(924, 'طباعة دفتر ليزرى A4 عدد 100 ', 7, 10, '', 129, 0),
	(925, 'طباعة دفتر حركة A5 عدد 50 ورقة', 2, 20, '', 129, 0),
	(926, 'دفتر وصل A5 ليزرى', 3.5, 20, '', 132, 0),
	(928, 'دفتر ملاحظات A6', 1250, 16, '', 140, 0),
	(971, 'طباعة دفتر', 750, 120, '', 141, 0),
	(981, 'بزنز كارت دكتور', 150, 100, '', 144, 0),
	(982, 'Print on Jacket', 3, 107, '', 143, 0),
	(983, 'Print on Caps', 0.5, 320, '', 143, 0),
	(984, 'Print on T- shirt', 2, 337, '', 143, 0),
	(1015, 'بزنز كارت عادي', 10000, 1, '', 146, 0),
	(1016, 'طباعة بزنس كارد', 100, 100, 'alan bamarny', 147, 0),
	(1023, 'طباعة كارت عرس', 150, 100, '', 148, 0),
	(1025, 'طباعة شهادات', 2000, 5, '', 149, 0),
	(1041, 'طباعة كوب', 10000, 1, '', 152, 0),
	(1146, 'طباعة على تيشرت', 10000, 1, '', 159, 0),
	(1147, 'طباعة دفتر وصل مخرم', 2500, 12, '', 160, 0),
	(1148, 'طباعة على تيشرت', 10000, 1, '', 161, 0),
	(1149, 'طباعة على تيشرت', 15000, 1, '', 161, 0),
	(1150, 'طباعة على ئيلك', 20, 1, '', 162, 0),
	(1155, 'طباعة ', 10000, 1, '', 166, 0),
	(1158, 'طباعة على يلك', 17500, 4, '', 163, 0),
	(1165, 'طبع ', 13000, 1, '', 168, 0),
	(1166, 'طباعة على تيشرت مطعم', 10000, 6, '', 169, 0),
	(1167, 'طباعة على بلوز صغار', 15000, 1, '', 170, 0),
	(1169, 'طباعة على ئيلك', 20000, 3, '', 171, 0),
	(1177, 'شراء ورق ارت', 155, 1, '', 107, 0),
	(1179, 'تكسي سيفر منظمة IMC', 3000, 2, 'سيفر منظمة IMC', 173, 0),
	(1181, 'نقل ورق من ربيل', 10000, 1, '', 174, 0),
	(1183, 'تكسي بو اينانا كوبا من ', 2000, 1, 'من قرطاسية دهوك', 175, 0),
	(1187, 'نقل ورق من اربيل', 10000, 1, '', 176, 0),
	(1188, 'ملمع اضافر', 10000, 1, '', 176, 0),
	(1189, 'فلاش و فرجة', 7500, 1, '', 176, 0),
	(1191, 'اكياس نفايات', 10000, 1, 'سيفر', 177, 0),
	(1193, 'حبر و درام و مصفي', 460, 1, '', 178, 0),
	(1195, 'طبع على ورق', 100, 1, '', 179, 0),
	(1197, 'شراء تيشيرت', 8000, 5, '', 180, 0),
	(1199, 'فويل كارت امسح واربح', 100, 1, 'رولة 100متر', 182, 0),
	(1200, 'ورق ok ليزر دارك A3 نوع A+B', 270, 2, 'بند 100 ورق', 182, 0),
	(1201, 'نماذج ورق مائي و ليزرى و فسفورى', 157, 1, 'مشكل', 182, 0),
	(1202, 'ورق ليزر ترانسفر A3 ', 135, 2, '', 182, 0),
	(1203, 'نقل ', 43, 1, '', 182, 0),
	(1206, 'طبع على ورق a4', 500, 20, '', 183, 0),
	(1207, 'طباعة على ورق ', 100, 45, '', 184, 0),
	(1208, 'طباعة ورق ورق ليبل', 0.48, 200, '', 185, 0),
	(1209, 'طباعة مع باج', 2, 20, '', 185, 0),
	(1219, 'طبع على ورق', 2000, 5, '', 189, 0),
	(1222, 'طباعة على تيشرت طابعة اوكي', 20000, 1, '', 191, 0),
	(1225, 'طباعة كتاب', 700, 50, '', 192, 0),
	(1226, 'طباعة كتاب', 2885, 100, '', 190, 0),
	(1227, 'طباعة على ئيلك', 22500, 4, '', 193, 0),
	(1263, 'طباعة راجيت دكتور طبع ليزري', 2.5, 10, 'دكتور ماجد حمزه الشنكالي', 172, 0),
	(1274, 'طباعة تقويم رمضان', 150, 300, '', 198, 0),
	(1275, 'طباعة تقويم رمضان', 150, 300, '', 199, 0),
	(1281, 'طباعة تيشرت حراري', 3, 13, 'اصفر', 186, 0),
	(1282, 'طباعة تيشرت حراري', 3, 25, 'نيلي', 186, 0),
	(1286, 'طباعة كوب حراري', 10000, 1, '', 201, 0),
	(1291, 'طباعة وشاح', 4500, 90, '', 187, 0),
	(1293, 'طباعة دفتر وصل A4 مكربن', 5500, 30, '', 205, 0),
	(1294, 'طباعة على ئيلك', 20000, 1, '', 206, 0),
	(1295, 'طبع', 15000, 1, '', 207, 0),
	(1298, 'طباعة وشاح', 10000, 1, '', 210, 0),
	(1304, 'طباعة بزنس كارت', 35, 1000, '', 213, 0),
	(1305, 'طباعة شهادات', 800, 320, '', 200, 0),
	(1356, 'print flayer A4 170 gsm 2 side', 600, 700, '', 216, 0),
	(1358, 'طباعة بروشور مساكية رمضان', 456, 300, '', 215, 0),
	(1360, 'طباعة على تيشرت', 10000, 9, '', 218, 0),
	(1366, 'طباعة بزنس كارت', 45, 1000, 'ميديا ترافل ', 221, 0),
	(1367, 'طباعة بروشور A4', 375, 1000, '', 11, 0),
	(1368, 'طباعة ستيكر', 21875, 10, '', 11, 0),
	(1371, 'طباعة دفتر وصل مكربن', 3750, 4, '', 223, 0),
	(1375, 'طباعة دفتر وصل', 2500, 10, '', 224, 0),
	(1376, 'طباعة على كوب', 5000, 2, '', 225, 0),
	(1377, 'طباعة بزنس كارت', 60, 1500, '', 226, 0),
	(1378, 'طباعة بوستر 33*48', 0.8, 200, 'ارجليك', 217, 0),
	(1379, 'طباعة شهادات', 2000, 15, '', 227, 0),
	(1380, 'تصميم ورقة', 10000, 1, '', 228, 0),
	(1391, 'طباعة كارت pvc', 915, 70, '', 230, 0),
	(1395, 'طبع وشاح', 40000, 1, '', 232, 0),
	(1396, 'بزنس كارت', 30000, 1, '', 232, 0),
	(1397, 'راجيت', 25000, 1, '', 232, 0),
	(1399, 'طباعة بزنس كارت', 60, 500, '', 234, 0),
	(1400, 'طباعة بزنس كارت', 50, 500, '', 235, 0),
	(1415, 'طباعو دفتر وصل', 2000, 10, '', 237, 0),
	(1452, 'طبع بحث', 10000, 2, '', 241, 0),
	(1453, 'تجليد كتب للبحث', 15000, 2, '', 241, 0),
	(1493, 'تكسي منظمة IMC', 3000, 2, 'عبيدة', 247, 0),
	(1495, 'تكسي حبر من ستير', 2000, 1, '', 250, 0),
	(1497, 'تكسي', 8000, 1, 'سيفر', 251, 0),
	(1499, 'تكسي بو IMC', 3000, 2, 'SIVER', 252, 0),
	(1501, 'سماعات', 10000, 1, '', 253, 0),
	(1505, 'كارت كورك', 12000, 1, 'سيفر', 255, 0),
	(1506, 'شراء ورق مكربن من اربيل', 240, 1, 'مع التكسي / رعد', 254, 0),
	(1508, 'مصاريف ذهاب و اياب موصل', 100000, 1, 'عبيدة', 256, 0),
	(1511, 'جرخ شفرة مقص مطبعة', 35000, 1, 'اربيل', 257, 0),
	(1512, 'تكسي', 3000, 1, '', 257, 0),
	(1514, 'نقل تيشيرت من موصل', 10000, 1, '', 258, 0),
	(1516, 'تكسي لجلب الاوراق من كرى باسى', 3000, 2, '', 259, 0),
	(1518, 'تكسي بو موصل', 5000, 1, '', 260, 0),
	(1520, 'تكسي', 3000, 1, '', 261, 0),
	(1522, 'دولك و فرجة للجام', 5000, 1, '', 262, 0),
	(1524, 'تكسي', 10000, 1, 'عبيدة', 263, 0),
	(1526, 'حبر بو مطبعة', 468000, 1, '', 264, 0),
	(1528, 'رولة ورق تيشيرت ', 350, 1, 'حسان رمزى', 265, 0),
	(1531, 'تكسي ', 2000, 1, 'سيفر', 266, 0),
	(1533, 'تكسي ستيكر للمطبعة', 5000, 2, 'سيفر', 267, 0),
	(1535, 'ترتيب المبردة', 10000, 1, 'سيفر', 268, 0),
	(1537, 'كريا ئاف 5-6', 5000, 2, '', 269, 0),
	(1551, 'سفرة ديار بكر', 200, 1, '', 272, 0),
	(1553, 'قرطاسية العالمية رقم 2397', 146, 1, '', 273, 0),
	(1555, 'تكسي بو تندورى و imc', 3000, 3, 'سيفر', 274, 0),
	(1557, 'شراء يلك لمنظمة imc', 13000, 26, '', 275, 0),
	(1560, 'خارن مطبعة عند التحويل', 8000, 2, '', 276, 0),
	(1561, 'مصاريف تحويل المطبعة', 13000, 1, '', 276, 0),
	(1562, 'عمال', 15000, 2, '', 276, 0),
	(1564, 'تكسي imc', 3000, 2, '', 277, 0),
	(1566, 'شراء تيشيرت imc', 8000, 1, '', 278, 0),
	(1568, 'بشار كهربائي', 25000, 1, '', 279, 0),
	(1570, 'طواف مبردة و منظفات', 11000, 1, '', 280, 0),
	(1572, 'اجور الادامة الشهرية لطابعة زيروكس', 150, 1, '', 281, 0),
	(1575, 'نقل سكرين مع القاعدة', 25000, 1, '', 282, 0),
	(1576, 'براغي و قاعدة للسكرين', 10000, 1, '', 282, 0),
	(1578, 'قاعدة كلينس و كلينس', 12000, 1, '', 283, 0),
	(1581, 'رولة ستيكر', 20000, 2, '', 284, 0),
	(1582, 'تكسى و فرجة ', 10000, 1, '', 284, 0),
	(1584, 'منشف شعر', 20000, 1, '', 285, 0),
	(1586, 'تكسي', 4000, 1, '', 286, 0),
	(1588, 'مغناطيس زاوية مطبعة', 1500, 1, '', 287, 0),
	(1624, 'فندق و طيارة', 400, 2, '', 270, 0),
	(1625, 'مصاريف عامة', 150, 2, '', 270, 0),
	(1626, 'مواصلات ', 50, 2, '', 270, 0),
	(1627, 'شراء محلول', 100, 1, '', 271, 0),
	(1628, 'شراء نماذج', 65, 1, '', 271, 0),
	(1629, 'تامينات مطبعة تورماتسان', 500, 1, '', 271, 0),
	(1630, 'مصاريف سكرين', 10000, 1, '', 288, 0),
	(1631, 'كارت كورك مطبعة', 12000, 1, '', 289, 0),
	(1632, 'ديون قرطاسية عالمية / بدون وصلة', 184, 1, '', 290, 0),
	(1633, 'شراء بليت', 100, 1, '', 291, 0),
	(1634, 'حبر طابعة زيروكس', 380, 1, '', 292, 0),
	(1635, 'بوري + برغي + قاعدة بوري + منشار', 29000, 1, '', 293, 0),
	(1637, 'شراء يلك منطمة NCA', 10000, 7, '', 294, 0),
	(1638, 'زاوية نجار', 2000, 1, '', 295, 0),
	(1639, 'كلينس مطبعة', 4000, 1, '', 297, 0),
	(1640, 'تكسي بو IMC', 6000, 1, '', 296, 0),
	(1641, 'تكسي من اربيل / حاجات مطبعة و حبر HP', 15000, 1, '', 298, 0),
	(1642, 'تسوية حساب قرطاسية الصهيب / بيد خليل رقم الوصلة 145', 768, 1, '', 299, 0),
	(1643, 'حبر و قوالب سكرين + نقل', 140000, 1, '', 300, 0),
	(1645, 'تبديل يلك مطبعة', 15000, 1, '', 317, 0),
	(1646, 'نقل ورق ارت من اربيل / عبدو .. من اربيل الىمكتب دهوك 45 الف / من مكتب دهوك الى مطبعة 4000', 49000, 1, '', 301, 0),
	(1647, 'تكسي مطبعة ', 3000, 1, '', 302, 0),
	(1648, 'تحويل الى اسطنبول / احمد مصطفى البيرافي / مكتب رهند .. مصاريف مطبعة', 1215, 1, '', 303, 0),
	(1649, 'تكسي', 2000, 1, '', 304, 0),
	(1650, 'هاتن و جوون IMC', 15000, 1, '', 305, 0),
	(1651, 'تكسي + شيف (سيفر)', 10000, 1, '', 306, 0),
	(1652, 'بارئ تيشرتا', 114, 1, '', 307, 0),
	(1653, 'تسوية حساب مع القرطاسية', 2542000, 1, '', 308, 0),
	(1654, 'تحويل الى تركيا باسم شرف الدين اكنجي', 1515, 1, '', 309, 0),
	(1655, 'تكسي بو تندوري', 3000, 1, '', 310, 0),
	(1656, 'نقل ورق مطبعة', 3000, 1, '', 311, 0),
	(1657, 'تكسي منظمة IMC', 4000, 2, '', 312, 0),
	(1658, 'ورق من اربيل', 5000, 1, '', 313, 0),
	(1659, 'شفرة موس', 5000, 1, '', 314, 0),
	(1660, 'تشتيت كهربائي ز شركة رند /ق 696/ مجموع 321$ توزيع بو مطبعة سنتر و قرطاسية', 185000, 1, '', 315, 0),
	(1661, 'تكسي من مطبعة ميديا + من بيت عبيدة', 3000, 2, '', 316, 0),
	(1663, 'سيت حبر طابعة زيروكس', 390, 1, 'قائمة 8908', 319, 0),
	(1664, 'سيت حبر طابعة زيروكس ', 390, 1, 'قائمة 7375', 319, 0),
	(1665, 'تبد يل درام طابعة زيروكس ', 280, 1, 'رقم قائمة 7361', 319, 0),
	(1677, 'طباعة ملزمة ', 6000, 5, 'للقرطاسية', 69, 0),
	(1680, 'تكسي بو كةهاندنا تشتيت IMC', 3000, 2, '', 320, 0),
	(1689, 'Print  on Vest', 20000, 7, 'NCA', 321, 0),
	(1697, 'طباعة مينيو ', 1750, 40, '', 70, 0),
	(1698, 'طباعة ورق 160 غرام', 75, 500, '', 105, 0),
	(1709, 'طباعة بزنس كارت', 60, 500, '', 322, 0),
	(1710, 'طباعة شهادات حلاق', 2000, 26, '', 323, 0),
	(1711, 'شراء قاعدة tvبدون وصل', 13000, 1, '', 324, 0),
	(1712, 'نقل من اربيل الى دهوك ', 20000, 1, '', 324, 0),
	(1713, 'شراء قماش', 5000, 1, '', 324, 0),
	(1715, 'شراء فلجة ', 1000, 1, '', 325, 0),
	(1725, 'دروستكرنا تومارا ئازوقةى و باجا', 35000, 1, '', 327, 0),
	(1735, 'طباعة فليكس مع تصميم', 24000, 8, '', 328, 0),
	(1737, 'توصيل ورق تندورى من تركيا الى دهوك ', 12000, 1, 'دفع من كوفان', 329, 0),
	(1798, 'طباعة دفتر وصل A5 مكربن', 3000, 6, '', 231, 0),
	(1799, 'طباعة بزنز كارت', 60, 500, '', 231, 0),
	(1819, 'طباعة بزنس كارت', 72, 500, '', 222, 0),
	(1823, 'طباعة وتخريم ستيكر تيشيرت منظمة imc', 25, 3.5, 'M2', 331, 0),
	(1824, 'طباعة ستيكر منظمة giz', 10, 8.5, 'M2', 331, 0),
	(1825, 'ورق فور ايفر طباعة صباح حجي', 100, 1, 'بند', 331, 0),
	(1826, 'شرا ء قايش مبرده ', 2000, 1, 'من قرطا سية ', 333, 0),
	(1829, 'طباعة دفتر وصولات A4', 5000, 10, '', 335, 0),
	(1830, 'طباعة دفتر وصولات A5', 2500, 10, '', 335, 0),
	(1831, 'طباعة سجل حسابات A4', 5000, 10, '', 335, 0),
	(1837, 'كارتون 300 غم 100*70 مقصوص A3', 75, 10, '', 337, 0),
	(1838, 'كارتون 300 غم 100*70 مقصوص A4', 75, 5, '', 337, 0),
	(1839, 'ارت 250 غم لماع مقصوص A4', 28, 5, '', 337, 0),
	(1840, 'ورق 80غم 70*100 مقوص 45*32 سم', 38, 4, '', 337, 0),
	(1841, 'كارتون تجليد', 1.6, 10, '', 337, 0),
	(1846, 'PRINT BOOKLET COVER 750G 100PAPER', 14, 43, '', 249, 0),
	(1847, 'كارتون تجليد', 1.6, 10, '', 336, 0),
	(1848, 'طبعة ده فتر مكربن ', 10000, 1, '', 338, 0),
	(1850, 'طباعة شهادات', 4500, 12, '', 339, 0),
	(1856, 'تاكسى من مطبعة ميديا الي حلبجة', 3000, 1, '', 341, 0),
	(1857, 'شراء قميص مطعم تندورى XL', 10000, 2, '', 342, 0),
	(1858, 'تاكسى من حسن مطبعة الى مطبعة هه له بجة ', 3000, 1, '', 343, 0),
	(1881, 'طبع كارت ', 0.02, 1000, '', 347, 0),
	(1882, 'طبع فليكس 1*2', 10, 2, '', 347, 0),
	(1883, 'طبع ستكر', 10, 1, '', 347, 0),
	(1884, 'طباعة رول اب 80*200 سم', 45, 2, '', 347, 0),
	(1885, 'طباعة دفتر راجيت A5 ', 1.6, 10, '', 347, 0),
	(1889, 'نقل كارتو ن بيتزا من توركيا الى دهوك ', 396, 1, 'تندورى ', 349, 0),
	(1890, 'طباعة ورق تيشرت ليزري مع كبس', 4000, 90, '', 334, 0),
	(1891, 'طباعة ورق تيشرت ليزري مع كبس', 4000, 50, '', 344, 0),
	(1919, 'شراء ئيلك للمنظمة IMC نموذج', 13000, 1, '', 351, 0),
	(1920, 'شراء قهوة للمطبعة', 3000, 1, '', 351, 0),
	(1921, 'ورق لا صق  بطال 33*48', 45, 1, '', 352, 0),
	(1923, 'تكسي من مطبعة هاوار الى حلبجة', 3000, 1, 'بند ورق لاصق', 354, 0),
	(1924, 'طباعة على درع', 24000, 6, '', 233, 0),
	(1925, 'حلاقة ملابس ', 7000, 1, '', 355, 0),
	(1930, 'بو علاكة سنتر حلبجة', 1000, 1, '', 358, 0),
	(1931, 'مطبعة تورماتسان', 1000, 1, '', 358, 0),
	(1932, 'عمولة ', 15, 1, '', 358, 0),
	(1934, 'طباعة كتاب', 3200, 300, '', 356, 0),
	(1935, 'فار نيش ', 60000, 1, '', 359, 0),
	(1937, 'شراء برغي و مشار', 3000, 1, '', 360, 0),
	(1941, 'طبعة تكت ', 8333.33333333333, 3, '', 357, 0),
	(1942, 'تاكسى  سيفه ر من بيت  الى سنتر ', 6000, 1, '', 362, 0),
	(1998, 'تكسي بو تندوري', 5000, 1, '', 368, 0),
	(2002, 'ستيكر عيد للجام', 75000, 1, '', 367, 0),
	(2003, 'تطريز على قميص ', 10000, 26, '', 367, 0),
	(2004, 'شرا قميص ', 10000, 2, '', 367, 0),
	(2005, 'طباعة ملزمة ملون ليزري مع تجليد كامل 120 ورقة', 7500, 100, '', 229, 0),
	(2006, 'استينساخ كتاب انكليزي 96 ورقة عادي', 4800, 50, '', 229, 0),
	(2007, 'استينساخ كتاب انكليزي 40 ورقة عادي', 2000, 50, '', 229, 0),
	(2028, 'تصميم منيو', 340, 1, '', 361, 0),
	(2029, 'علاكة ثخين', 2.2, 338.7, '', 365, 0),
	(2030, 'الضريبة', 133, 1, '', 365, 0),
	(2031, 'علاكة عادي', 1.77, 275.8, '', 365, 0),
	(2032, 'الضريبة', 88, 1, '', 365, 0),
	(2033, 'طباعة كليشة عدد 3', 140, 3, '', 365, 0),
	(2034, 'الضريبة', 75, 1, '', 365, 0),
	(2035, 'الكمرك', 40, 1, '', 365, 0),
	(2036, 'الربح', 111, 1, '', 365, 0),
	(2037, 'Print pvc card 800GSM 7*7cm', 2000, 30, '', 346, 0),
	(2040, 'طباعة فليكس 1 * 1.5 متر', 15000, 2, '', 246, 0),
	(2041, 'طباعة فليكس 1 * 1.5 متر', 15000, 1, '', 246, 0),
	(2042, 'شراء قماش 1مه تر ', 6000, 1, '', 370, 0),
	(2043, 'تاكسى  تابع د.شهيد ', 3000, 1, '', 370, 0),
	(2050, 'تكسي من زريلاند جلد حراري 3 ملم', 3000, 1, '', 374, 0),
	(2051, 'رولة صبغ', 1250, 4, '', 374, 0),
	(2056, 'تاكسى من اربيل الى دهوك ', 10000, 1, '', 377, 0),
	(2057, 'بند ورق مات 350غرام ', 40, 1, '', 376, 0),
	(2058, 'طباعة بروشور', 250, 300, '', 110, 0),
	(2059, 'طباعة فلكس عدد 3 ', 100000, 1, '', 110, 0),
	(2060, 'طباعة فلكس رول اب', 22500, 2, '', 110, 0),
	(2061, 'طباعة بطاقة دعوى مع ظرف', 500, 50, '', 110, 0),
	(2213, 'طباعة ورق 80 غرام 12 بند', 15000, 12, '', 371, 0),
	(2214, 'شهادة حلاقة ', 2000, 10, '', 380, 0),
	(2221, 'شراء كارت كوره ك مطيعة ', 12000, 1, '', 385, 0),
	(2223, 'طبع تيشرت ', 5000, 16, '', 386, 0),
	(2224, 'ماسيحة سكرين ', 3000, 7, '', 387, 0),
	(2238, 'شراء تيشريت ', 2600, 9, '', 397, 0),
	(2242, 'طباعة بطاقة دعوة A4 مع ظرف ', 2, 150, '', 196, 0),
	(2243, 'طباعة كتاب 182 صفحة مع سبايرول', 15, 30, 'طباعة ليزري', 219, 0),
	(2246, 'رجيتا دكتور ', 2500, 10, '', 399, 0),
	(2276, 'طباعة هيلك ', 14000, 10, 'ضمان لمدة 3 سنوات', 403, 0),
	(2277, 'اجرة تاكسى من مطبعة كاره الى حلبجة ', 3000, 1, '', 404, 0),
	(2278, 'جيهاز و سكرين ', 10000, 1, '', 405, 0),
	(2279, 'بزنس كارد', 19, 1000, 'طبعة فى تركيا ', 406, 0),
	(2280, 'طبع ', 12000, 1, '', 406, 0),
	(2281, 'طباعة بزنس كارت (تانك) ', 0.05, 1000, '', 407, 0),
	(2282, 'طبعة كارت من توركيا', 40, 1000, '', 408, 0),
	(2284, 'pRint booklet liserjet 21 paper', 3, 400, '', 372, 0),
	(2285, 'شراء ايلك  منظمة IMC', 12600, 45, '', 409, 0),
	(2287, 'راجيت دكتور ', 2, 10, '', 411, 0),
	(2291, 'كوب الى زه رى لاند ', 5000, 5, '', 410, 0),
	(2292, 'طباعة دفتر وصل مكربن A5', 2.5, 20, '', 412, 0),
	(2344, 'طباعة دفتر نه ور وز 1', 875, 1000, '', 418, 0),
	(2345, 'طباعة كوب ', 5000, 1, '', 419, 0),
	(2357, 'شراء سبايرول 8 ملم ', 10000, 1, '', 422, 0),
	(2358, 'طبع على غلاف كتاب ', 10000, 1, '', 423, 0),
	(2361, 'طبعه كوب', 7000, 4, '', 426, 0),
	(2429, 'طباعة فليكس ', 7, 41.75, '', 425, 0),
	(2504, 'طبعة شهاده ', 2000, 10, '', 429, 0),
	(2505, 'تاكسى من مطبعة الى ته ندورى ', 4000, 1, '', 430, 0),
	(2506, 'فلكس 3 مه تر ', 25000, 1, '', 431, 0),
	(2509, 'طبعة كارت ', 30, 1000, 'CYLM4', 348, 0),
	(2511, 'ورق ارت ', 40, 1, '', 432, 0),
	(2513, 'حبر طابعة سكرين من موصل', 5000, 1, 'محمود', 433, 0),
	(2515, 'تكسي منظمة IMC', 3000, 2, 'سيفر', 434, 0),
	(2517, 'اغراض منضمة imc', 3000, 1, 'سيفر', 435, 0),
	(2519, 'نقل كارتون بيتزا تندورى ', 15000, 1, 'سيفر', 436, 0),
	(2523, 'ستار حداد /غرفه زيروكس', 60000, 1, 'محمود', 438, 0),
	(2525, 'زريج بو دشداشه44ومملحة 6', 50000, 1, 'سيفر', 439, 0),
	(2527, 'نصب مطبعة زيروكس', 200, 1, 'كوفان', 440, 0),
	(2529, 'تكسى منظمة imc', 3000, 1, 'سيفر', 441, 0),
	(2531, 'تكسى', 4000, 1, 'عبيدة ', 442, 0),
	(2533, 'IMCرول اب', 3000, 1, 'عبيدة ', 443, 0),
	(2535, 'IMC خياط علم ', 3000, 1, 'عبيدة ', 444, 0),
	(2537, 'تكسى مطبعة /ستاندو رول اب', 2000, 1, 'سيفر', 445, 0),
	(2539, 'خياط علم ', 5000, 1, 'سيفر', 446, 0),
	(2545, 'شراء صبغ بخاخ لمطبعة ', 20000, 1, 'محمود', 449, 0),
	(2549, 'براغى وزن مطبعة سكرين ', 15000, 1, 'محمود', 450, 0),
	(2551, 'تحويل الى توركيا بيد شرف الدين ', 1000, 1, 'كوفان', 448, 0),
	(2552, 'عمولة', 10, 1, 'كوفان', 448, 0),
	(2554, 'تكسى مطبعة ', 4000, 1, 'سيفر', 451, 0),
	(2558, 'خشب سكرين', 65000, 1, 'عبيدة ', 452, 0),
	(2571, 'تكسى منظمة IMC ', 6000, 1, 'سيفر', 453, 0),
	(2573, 'هيتر مطبعة ', 50000, 1, 'سيفر', 454, 0),
	(2574, 'سيفر تكسى بو مال سه عات 7/30', 5000, 1, 'سيفر', 455, 0),
	(2576, 'ورق ميزتندورى وبرش وكارت ورق مكربن  من توركيا ', 90, 1, 'كوفان', 457, 0),
	(2579, 'الى مطبعة توركيا', 1000, 1, '', 413, 0),
	(2581, 'دار و سكوتين و بزمار', 17500, 1, '', 456, 0),
	(2582, 'طبعة ده فتر حساب ', 10000, 1, '', 459, 0),
	(2583, 'شرا ء نايلون  غلاف ورق ', 6000, 1, '', 461, 0),
	(2587, 'طبعة تشيرت ', 15000, 2, '', 462, 0),
	(2588, 'تكسى الى مطبعة كارة ', 3000, 1, '', 463, 0),
	(2589, 'طبعة دفتر وصل ', 1500, 12, '', 464, 0),
	(2590, 'طبعة بنزكارت فندق فرات ', 0.03, 1000, '', 465, 0),
	(2591, 'شراء حبر زيروكس', 380, 1, '', 402, 0),
	(2592, 'Xerox Drum V ersan t 80press013r00674', 160, 2, '', 396, 0),
	(2595, 'Print On nurse clothes 2 side', 7, 32, '', 467, 0),
	(2609, 'حبر ابيض', 20, 10, '', 468, 0),
	(2610, 'حبر اسود', 20, 5, '', 468, 0),
	(2611, 'حبر فسفورسي وعادي', 30, 6, '', 468, 0),
	(2612, 'قالب سكرين ', 40, 2, '', 468, 0),
	(2613, 'مخفف مصمغ', 15, 2, '', 468, 0),
	(2614, 'رتال دار', 16, 5, '', 468, 0),
	(2615, 'طباعة دفتر ربع A4 رقم نورورز2', 775, 1000, '', 469, 0),
	(2616, 'كلينس وكفوف مطتط /مطبعة سكرين ', 16000, 1, 'سيفر', 437, 0),
	(2618, 'طباعة تيشيرت تندورى', 7000, 27, '', 470, 0),
	(2629, 'طباعة فليكس مع تصميم ', 10000, 3.75, '', 220, 0),
	(2630, 'طباعة ستيكر مع تركيب', 17000, 12.5, '', 220, 0),
	(2631, 'طباعة فليكس بدون تركيب', 12500, 6, '', 220, 0),
	(2632, 'ستكر ', 8, 1.25, '', 471, 0),
	(2822, 'طباعة قلم منظمة IMC', 0.32, 1000, '', 116, 0),
	(2832, 'طباعة دفتر وصل مكربن A5', 5000, 16, '', 473, 0),
	(2836, 'طبعة بنزكارت ', 0.02, 6000, '', 477, 0),
	(2837, 'طبعة نه وروز بالاص', 1250, 100, '', 345, 0),
	(2838, 'طبعة شهاده ', 1, 295, '', 384, 0),
	(2839, 'بطاقة ', 1, 25, '', 384, 0),
	(2841, 'طبعة وتخريم ستكر منظمة imc', 20, 6.95, '', 466, 0),
	(2842, 'طبعة وتخريم ستكر ', 8, 5.5, '', 466, 0),
	(2843, 'ورق فور ايفر طباعة صباح حجي', 100, 1, '', 375, 0),
	(2899, 'طباعة ورق ', 0.5, 200, '', 481, 0),
	(2900, 'طباعة ورق A3', 2, 20, '', 481, 0),
	(2902, 'طباعة شهادة', 750, 80, '', 381, 0),
	(2903, 'طباعة شهادة', 750, 245, '', 381, 0),
	(2905, 'طبعة ملزمة انكليزي', 6, 50, '', 475, 0),
	(2906, 'طباعة  سجل حسابة', 15000, 2, '', 483, 0),
	(2920, 'h', 70, 1, '', 330, 0),
	(2933, 'شراء حبر طبعة زسروكس ', 550, 1, '', 485, 0),
	(2937, 'طباعة شهادة حلاق ', 2500, 2, '', 489, 0),
	(2938, 'شراء كلاف ', 5000, 1, '', 490, 0),
	(2941, 'كارتون فايل 250غA3', 10, 10, '', 491, 0),
	(2942, 'كارتون فايل 250غ A4', 5, 10, '', 491, 0),
	(2993, 'طبعة ورق فلير', 0.5, 100, '', 427, 0),
	(2994, 'طبعة ورق فلير ', 0.5, 100, '', 493, 0),
	(3001, 'طبعة فلكس ', 30000, 1, '', 497, 0),
	(3002, '', 0, 0, '', 497, 0),
	(3004, 'اجرة تاكسى من مديا الى حلبجة ', 3000, 1, '', 498, 0),
	(3006, 'طبعة كلاف ', 6250, 8, '', 501, 0),
	(3007, '', 0, 0, '', 501, 0),
	(3049, 'طبعة فلير 3طوى ', 1, 100, '', 502, 0),
	(3056, 'طبعة تشيرت', 5000, 1, '', 510, 0),
	(3057, 'طبعة بزنز كارت  ايمن', 100, 100, '', 510, 0),
	(3079, 'طباعة وتصميم بروشور', 1.5, 100, '', 508, 0),
	(3080, 'طباعة راجيت د.برفان ', 0.2, 3000, '', 479, 0),
	(3086, 'رول اب منظمة ', 40, 3, '', 512, 0),
	(3087, 'طبع مع تخريم منظمه', 20, 34, '', 512, 0),
	(3091, 'شراء موبايل الى مطبعة ', 120000, 1, '', 514, 0),
	(3101, 'بزنز كارت', 20000, 1, '150عدد', 523, 0),
	(3116, 'دفتر مختبر A4', 5000, 10, '', 505, 0),
	(3117, 'راجيت مختبر', 2500, 20, '', 505, 0),
	(3118, 'راجيت دكتور صلاح الدين', 2500, 6, '', 505, 0),
	(3119, 'كارت د صلاح الدين ', 20000, 1, 'عدد 100', 505, 0),
	(3121, 'طباعة راجيت ', 2500, 6, 'د.حميد', 484, 0),
	(3122, 'طباعة راجيت ', 2500, 6, 'د.ابراهيم', 484, 0),
	(3123, 'طباعة راجيت ', 2500, 6, 'د.سعيد', 484, 0),
	(3124, 'طباعة راجيت ', 2500, 6, 'د.بهاالدين ', 484, 0),
	(3125, 'طباعة راجيت ', 2500, 6, 'د.احمد', 484, 0),
	(3126, 'بزنز كارت ', 20000, 1, 'د. حميد', 484, 0),
	(3127, 'بزنز كارت', 20000, 1, 'د. ابراهيم', 484, 0),
	(3128, 'بزنز كارت', 10000, 1, 'د. سعيد', 484, 0),
	(3129, 'بزنز كارت', 10000, 1, 'د. بهائالدين', 484, 0),
	(3130, 'بزنز كارت', 10000, 1, 'د. احمد', 484, 0),
	(3142, 'طبعة دفتر ', 2500, 10, '', 524, 0),
	(3154, 'طبعة فلكس مجمع هيلب ', 15000, 5, '', 529, 0),
	(3155, 'اجرة تكسى ', 10000, 1, '', 529, 0),
	(3156, 'طبعة برشور مجمع هيلب ', 300, 1000, '', 526, 0),
	(3157, 'بزنز كارت د.عزيز حاجى كريت', 20000, 1, 'عدد 100', 519, 0),
	(3158, 'طبعة بزنز كارت د.شيلان', 20000, 1, 'عدد 100', 509, 0),
	(3159, 'طبعة بزنزكارت د.عبداللة ', 20000, 1, 'عدد 100', 509, 0),
	(3160, 'طبعة بزنز كارتد. زوزان', 20000, 1, 'عدد 100', 509, 0),
	(3161, 'طبعة بزنز كارت د.شرين ', 20000, 1, 'عدد 100', 509, 0),
	(3162, 'طبعة بزنز كارت د.علياء', 20000, 1, 'عدد 100', 509, 0),
	(3163, 'بزنزكارت د.زوزان ', 17500, 2, 'عدد 200 كارت', 507, 0),
	(3164, 'راجيت د.زوان ', 2500, 10, 'مجمع هيلب', 507, 0),
	(3165, 'طبعة راجيت مختبر', 1250, 20, '', 500, 0),
	(3174, 'بزنز كارت د.فاروق ', 0.1, 500, '', 494, 0),
	(3175, 'طبعة راجيت د.فاروق', 2, 10, '', 494, 0),
	(3176, 'طباعة ورقة A3 ', 0.12, 500, '', 486, 0),
	(3177, 'طباعة ورق A4', 0.24, 500, '', 486, 0),
	(3178, 'طباعة راجيت', 1.25, 105, '', 486, 0),
	(3181, 'طباعة شهادات', 750, 208, '', 142, 0),
	(3184, 'طبع رول قماش ', 1000, 200, '', 533, 0),
	(3261, 'دفتر وصولات ', 5000, 6, '', 525, 0),
	(3262, 'ورق فوتو A4', 1000, 45, '', 525, 0),
	(3267, 'طبعة دفتر قبص ', 3600, 10, '', 540, 0),
	(3269, 'ضرف', 250, 100, '', 478, 0),
	(3270, 'علاكة شركة ره ند ', 4.5, 148, '', 522, 0),
	(3271, 'طباعة بروشور', 140, 1000, 'A5 - 90G', 542, 0),
	(3275, 'طبعة بزنز كارت د.عبداللة ', 17500, 2, '', 543, 0),
	(3276, 'طبعة بزنز كارت د.زوزان', 17500, 2, '', 543, 0),
	(3277, 'طبعة بزنز كارت د.سيليفيا', 17500, 2, '', 543, 0),
	(3281, 'تحويل الى توركيا ', 2500, 1, '', 544, 0),
	(3282, 'تحويل ', 15, 1, '', 544, 0),
	(3283, 'كارتون بيزا', 0.08, 10000, '', 244, 0),
	(3284, 'ورق طعام', 0.06, 10000, '', 244, 0),
	(3285, 'ورق طعام', 0.06, 10000, '', 244, 0),
	(3286, 'مينو سفرى ', 0.3, 1000, '', 244, 0),
	(3291, 'طبعة بزنز كارت ', 25, 1000, 'اياد حلبجة ', 547, 0),
	(3292, '', 0, 0, '', 547, 0),
	(3293, 'طبعة فلكس ', 10000, 8, '', 548, 0),
	(3294, 'احرة تاكسى مع مصاريف ', 15000, 1, '', 548, 0),
	(3296, 'طبعة بروشور', 300, 500, '', 549, 0),
	(3298, 'طباعة دفتر وصل A5 ليزري', 2.5, 20, '', 208, 0),
	(3299, 'طبعة شهادة حلاق ', 2000, 14, '', 550, 0),
	(3300, '', 0, 0, '', 550, 0),
	(3301, 'طبعة كوب', 6250, 4, '', 551, 0),
	(3304, 'طبعة دفتر وصل ', 2.5, 30, '', 552, 0),
	(3312, 'طبعة ورق ', 200, 300, '', 555, 0),
	(3313, 'بزنز كارت ', 75000, 1, '500عدد', 513, 0),
	(3314, 'شهادات', 1000, 15, '', 513, 0),
	(3315, 'تصاميم', 30000, 1, '', 513, 0),
	(3316, 'طبعة كوب ', 7000, 1, '', 556, 0),
	(3317, 'شراء ورق تيشريت ليزرى ', 100, 1, '', 557, 0),
	(3322, 'طبعة راجيت د.معصوم ', 3000, 20, '', 531, 0),
	(3323, 'طبعة راجيت د.معصوم ', 3000, 10, '', 531, 0),
	(3326, 'طبعة بزنز كارت ', 150, 1000, 'صالون ريتا', 559, 0),
	(3328, 'تصليح جهاز زيروكس ', 1980, 1, '', 545, 0),
	(3329, 'طبعة واصل كراج ', 375, 80, '', 554, 0),
	(3330, 'طوى مع سلفون ', 25000, 1, '', 560, 0),
	(3331, 'طبعة شهادة ', 1150, 252, '', 532, 0),
	(3344, 'طبعة بزنز كارت د.داليا', 17500, 2, '', 553, 0),
	(3345, 'طبعة راجيت د.داليا', 2500, 10, '', 553, 0),
	(3346, 'طبعة راجيت د.احمد ', 2500, 10, '', 553, 0),
	(3347, 'طبعة بزنز كارت د.احمد على', 17500, 2, '', 541, 0),
	(3348, 'طبعة بزنز كارت د.صلاح الدين ', 17500, 2, '', 541, 0),
	(3349, 'طبعة بزنز كارت د.حميد', 17500, 2, '', 530, 0),
	(3350, 'قاعدة د.حميد', 40000, 1, '', 520, 0),
	(3364, 'طباعة مينيو PVC', 2000, 52, 'سەرەکان 1 - 3', 158, 0),
	(3365, 'طباعة مينيو 350 غرام مع سلفنة و كسر و سبايرول', 4890, 25, 'سەرەکان 2', 158, 0),
	(3366, 'تصميم مينيو ', 25000, 2, 'سەرەکان', 158, 0),
	(3367, 'طباعة مينيو A3  مع سلفنة و كسر', 2125, 25, 'سةرةكان 2', 158, 0),
	(3370, 'باجة روضة  بزارة ', 872000, 1, 'واصل بيد كوفان', 565, 0),
	(3371, 'باجه روضه دابين ', 837000, 1, 'واصل بيد كوفان', 565, 0),
	(3372, 'شركه ظه ', 300, 1, '', 566, 0),
	(3373, 'ورق ارت170غرام', 23, 4, 'قائمه 2355 مع 2082', 567, 0),
	(3374, 'كارتو فايل A3 250 غرام', 10, 10, '', 567, 0),
	(3375, 'كارتوفايل A4', 5, 10, '', 567, 0),
	(3376, '', 0, 0, '', 567, 0),
	(3390, 'طبعة ده فتر وصل ', 3500, 10, '', 564, 0),
	(3394, 'تكسى سيفه ر ', 5000, 1, '', 568, 0),
	(3397, 'ادامة شهريه جهاز زيروكس', 150, 1, '', 571, 0),
	(3398, 'تصليح جهاز زيروكس ', 325, 1, '', 571, 0),
	(3399, 'شراء  ست حبر زسرؤكز', 390, 1, '', 570, 0),
	(3400, 'شرا ء لان كار ت ', 10, 1, '', 570, 0),
	(3402, 'طبعة ورق ملابس ', 2, 100, '', 572, 0),
	(3446, 'طبعة بزنزكارت ', 17500, 2, '', 558, 0),
	(3447, 'طبعة راجيت د.هلات', 2000, 20, '', 558, 0),
	(3448, 'طبعة راجيت الاشعة ', 2500, 10, '', 518, 0),
	(3449, 'شراء سيت حبر زيروكس ', 390, 1, '', 576, 0),
	(3451, 'بز نز كارت د.داليا ', 17500, 2, '', 578, 0),
	(3452, 'طبعة دفتر وصل مع تخريم ', 2000, 10, '', 579, 0),
	(3453, 'شراء بند ورقه طباعة ', 100, 1, '', 580, 0),
	(3471, 'طبعة اجاكيت ', 5000, 3, '', 581, 0),
	(3472, 'طبعة ورق عطور ', 25000, 1, '', 582, 0),
	(3495, 'CHW flipehartA4 colored side prin ting lamin ated nylon spiral', 0.11, 80, '', 574, 0),
	(3496, 'Training lectures A4 B &W high quality ointd covern eside printing and 2slide on each page hard cover or nylon lamin at', 0.1, 40, '', 574, 0),
	(3497, 'Health book of all A4 B&W good qualitydouble side printing with nylon laminated or hard cover1English19 Arabic', 0.1, 17, '', 574, 0),
	(3498, 'Family planing flip ehartA4 size colored qouble side printing nylon laminated orhardcover spiral', 0.1, 80, '', 574, 0),
	(3499, 'PSEA postersA2colred', 0.1, 425, '', 574, 0),
	(3500, 'PFA guied', 0.1, 200, '', 574, 0),
	(3501, 'MHPSS  booklets', 0.1, 666, '', 574, 0),
	(3502, 'printing IMC logo on jackets', 0.1, 10, '', 574, 0),
	(3503, 'IMCflag 120*80 with long metalie stickand ring cover', 0.1, 18, '', 574, 0),
	(3504, 'Health flag 120*80 with long metalie stck aand ringcover', 0.1, 18, '', 574, 0),
	(3505, 'IMC L ogo steker A4', 0.1, 240, '', 574, 0),
	(3506, 'AMC logo stieker A5r', 0.1, 150, '', 574, 0),
	(3507, 'Kabarto poster materniy  flex 150*90rollup', 0.1, 1, '', 574, 0),
	(3508, 'USAID poster A2 thick paper and glossy ', 0.1, 60, '', 574, 0),
	(3509, 'Feedback reform/ Black and white printin on A4 size paper/1page', 0.1, 450, '', 574, 0),
	(3510, 'Outpatient Department form /Black and white printing on plainA4 SIZE PAPER/1PAGE', 0.1, 18000, '', 574, 0),
	(3511, 'pharmacy prescription/Black and white printing on plain A4size paper/1page', 0.1, 4200, '', 574, 0),
	(3512, 'New Tally S HEET/Blackand whie printing on plain A3sizePAPER/1PAGE', 0.1, 2400, '', 574, 0),
	(3513, 'Referral book /A4size consistof  three colored papers White Red Green ', 0.1, 24, '', 574, 0),
	(3514, 'Triagecard red color /n u mbers .from 1  to 12  thick laminated size8*8cm & ', 0.1, 6, '', 574, 0),
	(3515, 'Triage card green /numbers from 1 to100  thick laminated size 8*8cm', 0.1, 6, '', 574, 0),
	(3516, 'Triage card  ellow  numbrrs from 1  to 50 thick laminated size 8*8cm', 0.1, 6, '', 574, 0),
	(3517, 'طبعة ورق عطور', 25000, 1, '', 583, 0),
	(3518, 'Print on scarf', 4.8, 110, 'high quality', 50, 0),
	(3519, 'anbrella', 6.5, 15, 'high quality', 50, 0),
	(3520, 'Print notebook 100 paper A5 Size ', 3, 20, 'high quality', 50, 0),
	(3521, 'pen print 1 color ', 39, 20, 'high quality', 50, 0),
	(3522, 'Print on shart CMYK ', 3, 600, 'high quality', 51, 0),
	(3523, 'Print on Cap', 4, 100, 'high quality', 51, 0),
	(3524, 'CUP ', 3, 50, 'high quality', 51, 0),
	(3525, 'Print Book 4 Paper 250 Gsm + Silivan & Spairol', 3.55, 14, '', 72, 0),
	(3526, 'Print Booklet B&w', 9.7, 15, '', 72, 0),
	(3527, 'Print on Jacket', 4.5, 105, 'High Quality', 97, 0),
	(3528, 'Print on Caps', 3, 320, 'High Quality', 97, 0),
	(3529, 'Print on T- shirt', 4, 335, 'High Quality', 97, 0),
	(3530, 'Print on Jacket', 4.5, 13, 'High Quality', 156, 0),
	(3531, 'Print on shirt', 4, 46, 'High Quality', 156, 0),
	(3532, 'Print on T- shirt', 4, 19, 'High Quality', 156, 0),
	(3533, 'Print on vest', 4.5, 50, '', 157, 0),
	(3534, 'roll up', 48, 5, '', 157, 0),
	(3535, 'Print on Caps', 3.5, 50, '', 157, 0),
	(3536, 'Print on T- shirt', 4, 50, '', 157, 0),
	(3537, 'Print on T- shirt', 4, 50, '', 157, 0),
	(3538, 'flag 80*60', 50, 2, '', 157, 0),
	(3539, 'flag 20*15', 10, 10, '', 157, 0),
	(3540, 'Print On T- shirt', 7, 44, '', 195, 0),
	(3541, 'Print On Cup 50 Set', 9, 50, '', 195, 0),
	(3542, 'Poster A0 Flex', 8, 10, '', 195, 0),
	(3545, 'Print on bag', 5, 40, '', 238, 0),
	(3546, 'Print on vest', 5, 15, '', 238, 0),
	(3547, 'Print on Vest', 5, 21, '', 239, 0),
	(3548, 'Print on Doctor cloths', 5, 20, '', 239, 0),
	(3549, 'Print Sticker Pape A4r', 0.2, 150, '', 239, 0),
	(3550, 'Form - Goods flow - bin card ', 0.04, 321, '', 243, 0),
	(3551, 'outpatient Department ', 0.02, 3667, '', 243, 0),
	(3552, 'leshmaniases ', 0.02, 517, '', 243, 0),
	(3553, 'pharmacy prescrioption', 0.04, 12000, '', 243, 0),
	(3554, 'NewTally Sheet', 0.045, 3000, '', 243, 0),
	(3555, 'Form - goods flow - stock card', 0.04, 304, '', 243, 0),
	(3556, 'triage card pink color (1 - 50)', 19.5, 3, '', 243, 0),
	(3557, 'ANC card , A4 glossy paper', 0.1, 3785, '', 243, 0),
	(3558, 'Family planning pationt hard card yellow color', 0.04, 3785, '', 243, 0),
	(3559, 'Famlly Planning follow up card yellow color', 0.055, 3753, '', 243, 0),
	(3560, 'ANC follow up card A3 heavy paper', 0.2, 3755, '', 243, 0),
	(3561, 'printing Logo on Hats', 5, 15, '', 243, 0),
	(3562, 'Printing Logo on Vest', 3, 26, '', 243, 0),
	(3563, 'MHPSS booklets ', 1.62, 750, '', 243, 0),
	(3564, 'PFA glude book', 7.53, 100, '', 243, 0),
	(3565, 'Banners - rollup', 45, 4, '', 243, 0),
	(3566, 'printing case managment', 0.02, 7000, '', 243, 0),
	(3567, 'carbonated referal ', 5, 5, '', 243, 0),
	(3568, 'Print on T-shirt', 4, 36, '', 245, 0),
	(3569, 'تيشيرت ', 11, 26, '', 248, 0),
	(3570, 'قبعة', 2, 15, '', 248, 0),
	(3571, 'Visibility ltems_CHWT-SHIRTSP', 5, 45, '', 428, 0),
	(3572, 'VisibilityItems-printd', 3, 45, '', 428, 0),
	(3573, 'VisibiliyItems_Vest', 5.3, 45, '', 428, 0),
	(3574, 'Visibility Items_IMC FIag', 40, 1, '', 428, 0),
	(3575, 'Visibility items_CHWT -shirts', 10, 2, '', 428, 0),
	(3576, 'visiblityltems_CHWT', 40, 2, '', 428, 0),
	(3577, 'visibilityltems_Roll', 6, 45, '', 428, 0),
	(3578, 'visibilityItems_Caps', 3.3, 45, '', 428, 0),
	(3579, 'visibilityltems_VestKhakicolor', 14, 45, '', 428, 0),
	(3580, 'paper_printings_BrochuresA4glossy', 0.06, 21000, '', 428, 0),
	(3581, 'paper_printings_posterA2', 6, 125, '', 428, 0),
	(3582, 'paperprintingsReferralalbook50', 2, 30, '', 428, 0),
	(3583, 'paperprintingsDailyReportBook100', 2, 30, '', 428, 0),
	(3584, 'paperprintings_WaterHygienebookletA5', 1.5, 150, '', 428, 0),
	(3586, 'طبعة بزنز كارت ', 17500, 2, 'ديندار عمر ', 584, 0),
	(3587, 'طبعة راجيت د.احمدعلى ', 2500, 20, '', 585, 0),
	(3590, 'طبعة بزنز كارت د.شرين انور ', 17500, 2, '', 586, 0),
	(3591, 'طبعة بز نز كارت د.زوزان ', 17500, 2, '', 586, 0),
	(3595, 'طبعة بز نز كارت د.عبداللة ', 17500, 2, '', 588, 0),
	(3596, 'طبعة دفتر حساب ', 3500, 2, '', 589, 0),
	(3597, 'ورق طعام', 0.06, 10000, '', 546, 0),
	(3598, 'منيو سفري', 0.25, 2000, '', 546, 0),
	(3610, 'طبعة قاعدة  ست هناء', 25000, 1, '', 592, 0),
	(3611, 'طبعة مينيو ', 12, 20, '', 591, 0),
	(3612, 'اجره تكسى نجيرفان الى بيت ', 3000, 1, '', 593, 0),
	(3613, 'طبعة اسم على قاعدة ', 25000, 1, '', 594, 0),
	(3620, 'roll up', 60, 7, '', 573, 0),
	(3621, 'poster 70*100', 15, 7, '', 573, 0),
	(3628, 'اجرة فادى الى منظمه IMC', 10000, 1, '', 595, 0),
	(3634, 'راجين د.عبداللة ', 2500, 10, '', 596, 0),
	(3638, 'طبعة شهاده حلاق ', 2500, 2, '', 602, 0),
	(3643, 'طبعة دفتر وصل مكربن ', 4250, 40, '', 603, 0),
	(3644, 'اجرة تكسى نجيرفان الى بيت ', 5000, 1, '', 604, 0),
	(3645, 'طبعة راجين د.سلمان احمد', 2500, 10, '', 605, 0),
	(3646, 'طبعة بز نز كارت د.سلمان احمد', 17500, 2, '', 605, 0),
	(3647, 'طبعة اسم علة قاعدة ', 12000, 1, '', 606, 0),
	(3651, 'طبعة دفتر حساب مكربن ', 3000, 10, '', 607, 0),
	(3654, 'طبعة ورق لازق ', 1000, 90, '', 608, 0),
	(3656, 'طبعة راجيت ', 2500, 12, '', 609, 0),
	(3657, 'شراء 1مه تر قماش سه تن', 2000, 1, '', 610, 0),
	(3694, 'شراء طوب قماش سه ته ن ', 75000, 1, '', 612, 0),
	(3695, 'شراء قاصر ', 2000, 1, '', 613, 0),
	(3697, 'طبعة  وصل علاج ', 2500, 12, '', 615, 0),
	(3698, '', 0, 0, '', 615, 0),
	(3699, 'شراء قالب طبع اعلم ', 3000, 2, '', 616, 0),
	(3702, 'طبعة راجيت دكتور ', 3500, 10, '', 618, 0),
	(3705, 'اجره تكسى نجيرفان ', 3000, 1, '', 619, 0),
	(3706, 'اكل ', 14000, 1, '', 619, 0),
	(3707, 'اجره تكسى سيفر', 3000, 1, '', 619, 0),
	(3708, 'طبعة دفتر حساب', 2500, 6, '', 620, 0),
	(3709, '', 0, 0, '', 620, 0),
	(3710, 'خارن بو مطبعة ', 5000, 1, '', 621, 0),
	(3711, 'حه قى تكسى بو نجيرفان ', 3000, 1, '', 621, 0),
	(3712, 'طبعة جاكيت ', 5000, 5, '', 622, 0),
	(3713, 'طبعة راجيت د.هلات ', 2500, 10, '', 624, 0),
	(3714, '', 0, 0, '', 624, 0),
	(3715, 'خارن ', 9000, 1, '', 625, 0),
	(3716, 'طبعة شهادة حلاق ', 1950, 13, '', 614, 0),
	(3717, 'printing cops', 2, 300, '', 601, 0),
	(3719, 'شهادة تقدرية مع كفر ', 2.3, 100, 'موئتمر', 394, 0),
	(3720, 'جرجف كرسى ', 2.5, 100, '', 394, 0),
	(3721, 'علم ', 0.7, 10, '', 394, 0),
	(3722, 'دعوه ', 0.8, 100, '', 394, 0),
	(3723, 'دعوة ', 0.3, 200, '', 394, 0),
	(3724, 'طبعة ورق لصق ', 15000, 1, '', 627, 0),
	(3725, 'خارن ', 3000, 1, '', 628, 0),
	(3743, 'اجرة فادىالى IMC', 10000, 1, '', 630, 0),
	(3744, 'خارن ', 11000, 1, '', 630, 0),
	(3745, 'شراء نايلون   غلاف ', 2000, 1, '', 630, 0),
	(3752, 'طبعة كارت دعوة ', 1000, 60, '', 631, 0),
	(3753, 'اجرة تكسى نجيرفان +سيفر ', 6000, 1, '', 632, 0),
	(3754, 'خارن مطبعة ', 12000, 1, '', 633, 0),
	(3755, 'طبعة راجيت د.معصوم ', 3000, 50, '', 577, 0),
	(3756, 'طبعة بطاقة دعوة ', 0.5, 200, '', 634, 0),
	(3757, 'شراء ورق تغليف', 2000, 2, '', 635, 0),
	(3758, 'طبعة ورق لصق ', 20000, 1, '', 636, 0),
	(3759, 'اجرة تكسى نجيرفان ', 3000, 1, '', 637, 0),
	(3760, 'اكل مطبعة ', 25000, 1, '', 638, 0),
	(3763, 'شيف خارن مطبعة ', 21000, 1, '', 639, 0),
	(3764, 'تكسى سيفه ر ', 3000, 1, '', 639, 0),
	(3765, 'طبعة ورق A3سلفن وطولى 350غم', 3.5, 42, '', 640, 0),
	(3771, 'طبعة راجيت صلاح الدين ', 2500, 10, '', 641, 0),
	(3772, 'طبعة بزنز كارت د.صلا الدين ', 15000, 2, '', 641, 0),
	(3773, 'طبعة بز نز كارت د. هلات حجى ', 15000, 2, '', 641, 0),
	(3774, 'طبعة بز نز كارت د. سعيد خمو ', 15000, 2, '', 641, 0),
	(3775, 'طبعة جاكيت ', 5000, 5, '', 642, 0),
	(3778, 'طبعة ورق لصق ', 1000, 10, '', 644, 0),
	(3783, 'طبعة بز نز كارت د. زوزان ', 15000, 2, '', 643, 0),
	(3784, 'طبعة بز نز كار ت د. شيلان ', 15000, 2, '', 643, 0),
	(3785, 'طبعة بز نز كارت د.سلمان احمد', 15000, 6, '', 643, 0),
	(3788, 'حساب قديم', 300, 1, '', 648, 0),
	(3789, 'حساب قديم', 300, 1, '', 647, 0),
	(3790, 'طبعة بز نز كارت ', 17500, 2, '', 649, 0),
	(3791, 'طبعة كلاف ', 1000, 20, '', 650, 0),
	(3792, 'طبعة فلكس من مطبعة بدليس ', 25000, 1, '', 651, 0),
	(3793, 'شراء ورق من اربيل ', 931, 1, '', 652, 0),
	(3796, 'مكافة ', 250000, 1, '', 653, 0),
	(3797, 'طبعة راجيت اشعة ', 2500, 20, '', 654, 0),
	(3800, 'طبعة شهادة ', 1, 50, '', 655, 0),
	(3801, 'رول اب ', 50, 2, '', 655, 0),
	(3802, 'بزنس كارت توركيا', 60, 2, '', 656, 0),
	(3805, 'طبعة راجيت د.حميد', 2500, 20, '', 587, 0),
	(3806, 'كارت دكتور حميد', 90000, 1, '1,000كارت', 657, 0),
	(3807, 'طبعة منيو ', 10000, 1, '', 658, 0),
	(3808, 'visibility ltems-CHWShirts printing onlongsleeves hirt oneIMCDarkbluelogo on themiddle back side)28cm*10m(and one IMClogo onthe upperleftfrontside)10cm*4cm(andoneonejsl logo on the right front side (10cm*5cm)asattached photo', 6, 31, '', 506, 0),
	(3809, 'visibility ltems_CHW Shirts printing on long sleeves shirt one IMC Dark blue logo on the middle back side(28cm*10cm)and one IMC logotheupper left front side below imc logo 910cm *5cm)and one  USIAD logoon the (10cm) asattached photo', 7.5, 49, '', 506, 0),
	(3810, 'visibility ltems_printed Cap with Logo printing on Cap one IMC Dark Blue logo on the front (10cm *5cm)and jsl logo on the rightside (10cm*5cm)as attachad photo', 3, 31, '', 506, 0),
	(3811, 'visibility ltems _printedCap with logoprinting on Cap one IMCDark Blue logo on the front (13cm*5cm)and jsllogoonthe right side (10cm*5cm)and USAIDlogoon the left side as attached photo', 4.5, 49, '', 506, 0),
	(3812, 'visbility ltems_vest printing on vst one IMC Dark biue logo on the middle back side (30cm*15cm)one IMClogo on the upper left front side(10cm*5cm)and one jsllogoon the right front side (10cm*5cm)asattachedphoto', 6, 31, '', 506, 0),
	(3813, 'visibilityltems_vest printingon vest one IMCdark biue logoon themiddleback side (30cm*15cm)one IMClogoon the upperleftfront side (10cm*4cm)and one jsllogo on the left front side above IMClogoon the left frontsideaboveIMClogo(10cm*5)andusaid logoon the upperrightfrintside(10cm)asDlogot)', 7.5, 49, '', 506, 0),
	(3814, 'visibilityltems_roli up banner with (IMC&JSL)LOGO Flexize (200cm L*70cm W)as attached photo and so ftcopy.', 48, 3, '', 506, 0),
	(3815, 'visbility ltems_Rollup banner wiht(IMC JSL&USAID)  asattached photoand soft cppy.', 48, 4, '', 506, 0),
	(3816, 'Printing on T-shirtlong sleves', 4, 225, '', 506, 0),
	(3817, 'Printing on Scarf', 3.5, 500, '', 506, 0),
	(3818, 'Carbonatedreferal book3eopies', 4, 22, '', 538, 0),
	(3819, 'Booklet printing A5 heavy paper 16 pages double side', 0.8, 3900, '', 538, 0),
	(3820, 'PFA guide book A4colored 50pages with hardcover', 4.5, 150, '', 538, 0),
	(3821, 'Baneers rollup 80*200', 48, 6, '', 538, 0),
	(3822, 'printigaIMC logo on jaekets Front 9*6and backAz', 5.5, 24, '', 538, 0),
	(3823, 'printign IMC logo on Hats FRONT fRONT9*6', 3, 24, '', 538, 0),
	(3824, 'printign IMClogo on Vests Front9*6and back', 5.5, 24, '', 538, 0),
	(3825, 'صيانة زيروكس ', 150, 1, '', 659, 0),
	(3829, 'طبعة بز نز كارت ', 12500, 2, '', 660, 0),
	(3830, 'شراء رول ئاب ', 14.375, 8, '', 661, 0),
	(3831, 'رول ئاب مطبعة بيرس ', 15000, 1, '', 662, 0),
	(3832, 'طبعة مينيو ', 3500, 10, '', 646, 0),
	(3833, 'اجرة تكسى نجيرفان ', 3000, 1, '', 626, 0),
	(3835, 'طباعة دعوة مع طباعة ظرف', 1.2, 200, '', 98, 0),
	(3836, 'طباعة فلير وجه واحد 160غرام', 0.17, 1000, '', 98, 0),
	(3837, 'طباعة راجيت طبيب طباعة ليزري', 2.5, 10, 'دكتورة شيلان', 98, 0),
	(3838, 'طباعة راجيت طبيب طباعة ليزري', 2.5, 10, 'دكتور فاخر', 98, 0),
	(3839, 'طباعة فلير وجه واحد 160غرام', 0.17, 1000, '', 98, 0),
	(3848, 'printing on T- shirt logo and Messaga', 8, 525, '', 611, 0),
	(3849, 'Printing on Cup IMClogo and message', 1.5, 300, '', 611, 0),
	(3850, 'poster2*1', 15, 9, '', 611, 0),
	(3851, 'poster1.5*1', 10, 54, '', 611, 0),
	(3852, 'Trinagle Flags with Message', 1.8, 400, '', 611, 0),
	(3853, 'pen with Message and logo', 0.75, 800, '', 611, 0),
	(3854, 'Rubber Hand purple color with Logo and Message', 1.2, 500, '', 611, 0),
	(3855, 'printinglogo and messageon scaef', 4.5, 200, '', 611, 0),
	(3856, 'printing logo and message on doctors coats', 9, 200, '', 611, 0),
	(3857, 'safety pins with messaga and logo ', 0.65, 400, '', 611, 0),
	(3858, 'notebookA5with message and logo', 0.9, 400, '', 611, 0),
	(3859, 'printing hashtag and IMClogo on A3certificatepaper', 1.3, 250, '', 611, 0),
	(3866, 'طبعة بدلة', 10000, 9, '', 474, 0),
	(3880, 'شراء سبايرول بلاستك عدد3باكيت ', 25000, 1, '', 669, 0),
	(3881, 'اجره تكسى من اربيل الى دهوك  بندورق ', 10000, 1, '', 670, 0),
	(3885, 'شراء سبايرول ', 8250, 4, '', 672, 0),
	(3886, 'طبعة تيشرت ', 10000, 3, '', 674, 0),
	(3887, 'print roll up', 48, 1, '', 663, 0),
	(3888, 'print on jacket only front', 2, 15, '', 629, 0),
	(3889, 'print vizsih', 2, 14, '', 629, 0),
	(3890, 'شراء سبايرول ', 8200, 5, '', 676, 0),
	(3891, 'اجرة تكسى  من اربيل الى دهوك ', 25000, 1, '', 677, 0),
	(3892, 'اجرة تكسى من اربيل الى نقل طبعة ', 20000, 1, '', 678, 0),
	(3893, 'بزنز كارت د.زوران ', 17500, 2, '', 679, 0),
	(3894, 'بزنز كارت د.شرين ', 17500, 2, '', 679, 0),
	(3895, 'شراء سيت حبر زيروكس', 390, 1, '', 680, 0),
	(3898, 'سراء سبايرول 3باكيت ', 25000, 1, '', 682, 0),
	(3912, 'طبعة ده فتر الوصل ', 2500, 50, '', 685, 0),
	(3915, 'طبعة دفتر وصل ', 1500, 20, '', 683, 0),
	(3916, 'طبعة دفتر حساب a5', 3000, 6, '', 683, 0),
	(3917, 'شراء كارت كوره ك مطبعة ', 18000, 1, '', 687, 0),
	(3918, 'راجيت دكتور عبدالمتين ', 3000, 10, '', 688, 0),
	(3920, 'طبعة راجيت د.معصوم ', 3000, 20, '', 645, 0),
	(3921, 'طبعة بز نز كارت ', 12000, 5, '', 645, 0),
	(3922, 'طبعة راجيت د.عبدال مه تين ', 3000, 10, '', 689, 0),
	(3923, 'تخريم دفاتر عدد 450 A4', 50000, 1, '', 690, 0),
	(3924, 'printigaIMClogoon jaekts Front9*6 and backAz', 5.5, 10, '', 590, 0),
	(3925, 'printing IMCLOGO ON Tshirtfront9*6and', 5.5, 10, '', 590, 0),
	(3926, 'Case management black and whiteA4 ', 60000, 0.025, '', 590, 0),
	(3927, 'صينه طبعة زيروكس  شهرى ', 150, 1, '', 691, 0),
	(3928, 'شراء سبايرول ', 8000, 1, '', 692, 0),
	(3935, 'طبعة بز نز كارت لصق', 25000, 1, '', 695, 0),
	(3936, 'طبعة ورق ملاحظات', 1000, 30, '', 695, 0),
	(3940, 'طبعة باج ', 1000, 50, '', 696, 0),
	(3941, 'طبعة دفتر الملاحصات', 1000, 45, '', 697, 0),
	(3942, 'فلكس ', 18000, 1, '', 697, 0),
	(3943, 'فوتو 2وجه و ظهر', 250, 260, '', 697, 0),
	(3944, 'كارت ورق عادى ', 200, 45, '', 697, 0),
	(3945, 'بطاقة دعوة ', 200, 45, '', 697, 0),
	(3946, 'طبعة الشهادة ', 416, 18, '', 697, 0),
	(3947, 'طبعة فلكس ', 15000, 1, '', 698, 0),
	(3948, 'طبعة بز نز كارت ', 150, 100, 'حليمة ', 699, 0),
	(3950, 'prnet booet 252', 10, 16, '', 667, 0),
	(3951, 'prent book et56', 3, 16, '', 667, 0),
	(3952, 'prent booket80', 4, 16, '', 667, 0),
	(3953, 'prent booklet252', 10, 8, '', 668, 0),
	(3954, 'prent booklet144', 6, 8, '', 668, 0),
	(3955, 'طبعة شهادة حلاق ', 1950, 13, '', 700, 0),
	(3971, 'بيزنز كارت CYM', 0.04, 1000, '0', 401, 0),
	(3972, 'دفتر وصولات', 2.5, 10, '', 401, 0),
	(3973, 'بزنس كارت نفيسينكةها MONEY', 40, 1000, '', 415, 0),
	(3974, 'بزنز كارت ماسيا خانكئ ', 40, 3000, '', 416, 0),
	(3975, 'بزنس كارت نفيسينكةها DUHOK HOTEL', 0.04, 1000, 'CYM', 420, 0),
	(3976, 'مكتب جودي', 75, 2, '', 521, 0),
	(3977, 'كلى اشاوا', 65, 1, '', 521, 0),
	(3978, 'ريزان كاب', 30, 1, '', 521, 0),
	(3979, 'بيست فون', 33, 1, '', 521, 0),
	(3980, 'خياطة عجيب', 40, 1, '', 521, 0),
	(3981, 'تعديل الرصيد', 1711601, 1, '', 701, 0),
	(3982, 'تعديل الرصيد', 12914.5, 1, '', 702, 0),
	(3983, 'طباعة بزنزكارت', 0.05, 1000, '', 482, 0),
	(3984, 'math book', 3000, 200, '', 703, 0),
	(3985, 'scince', 3000, 200, '', 703, 0),
	(3986, 'art', 2000, 200, '', 703, 0),
	(3987, 'note book', 1000, 200, '', 703, 0),
	(3988, 'scince', 3000, 300, '', 703, 0),
	(3989, 'math', 3000, 300, '', 703, 0),
	(3990, 'scince', 3000, 50, '', 703, 0),
	(3991, 'math', 3000, 50, '', 703, 0),
	(3992, 'note book', 1000, 50, '', 703, 0),
	(3993, 'art', 2000, 50, '', 703, 0),
	(3994, 'بيع كوب الى زه رى لاند ', 1, 45, '', 704, 0),
	(3995, 'بيع جهاز طبع كوب ', 125, 1, '', 704, 0),
	(3996, 'بيع ورق طبع كوب ', 15, 2, '', 704, 0),
	(3997, 'بيع طبعة ', 300, 1, '', 704, 0);
/*!40000 ALTER TABLE `tbl_products` ENABLE KEYS */;

-- Dumping structure for table db_h_press.tbl_users
CREATE TABLE IF NOT EXISTS `tbl_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `type` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Dumping data for table db_h_press.tbl_users: ~2 rows (approximately)
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT IGNORE INTO `tbl_users` (`id`, `name`, `password`, `type`) VALUES
	(1, 'admin', 's1212', 0),
	(2, '2', '2', 1);
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
