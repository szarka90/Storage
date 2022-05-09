-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Már 19. 10:41
-- Kiszolgáló verziója: 10.4.20-MariaDB
-- PHP verzió: 8.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `storage`
--
CREATE DATABASE IF NOT EXISTS `storage` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `storage`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `company_data`
--

CREATE TABLE `company_data` (
  `id` int(11) NOT NULL,
  `name` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `tax_number` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `country` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `postcode` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `city` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `address` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `web` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `bank_account` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `comment` varchar(500) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `company_data`
--

INSERT INTO `company_data` (`id`, `name`, `tax_number`, `country`, `postcode`, `city`, `address`, `web`, `bank_account`, `comment`) VALUES
(1, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `contact_for_partners`
--

CREATE TABLE `contact_for_partners` (
  `id` int(11) NOT NULL,
  `partner_id` int(11) NOT NULL,
  `contact_name` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `phone` varchar(50) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `title` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `contact_for_partners`
--

INSERT INTO `contact_for_partners` (`id`, `partner_id`, `contact_name`, `phone`, `email`, `title`) VALUES
(1, 3, 'Jóska Pista', '+36201234567', 'pelda@gmail.com', 'CEO'),
(2, 8, 'Kis Józska', '+3620/123-4567', 'pelda@pelda.com', 'eladó'),
(3, 8, 'Szalmon Ella', '+3630/123-4567', 'valami@valami.hu', 'Eladó'),
(4, 5, 'Kármán Adrienn', '+36202814337', 'karman.adri@gmail.com', 'Pedikűrös'),
(5, 9, 'Káposzta József', '+3620/456-2545', 'jozsef@kaposztakft.hu', 'Ügyvezető'),
(6, 9, 'Trab Antal', '+3630/789-2536', 'antal@kaposztakft.hu', 'Értékesítő'),
(7, 10, 'Teszt Elek', '+3620-1234567', 'tesztelek@tesztzrt.hu', 'ügyvezető'),
(9, 13, 'Nyúl Ferenc', '+3620/222-3344', 'nyul.ferenc@tiktok.hu', 'beszerző');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `order_date` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `completion_date` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `payment_deadline` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `innoviced` tinyint(1) NOT NULL,
  `terms_of_payment` int(11) NOT NULL,
  `customer` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `orders`
--

INSERT INTO `orders` (`id`, `order_date`, `completion_date`, `payment_deadline`, `innoviced`, `terms_of_payment`, `customer`) VALUES
(35, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Nap Pali'),
(36, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Valami cég Kft.'),
(37, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Valami cég Kft.'),
(38, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Beauty-full sziget'),
(39, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Valami cég Kft.'),
(40, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Kala Pál'),
(45, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Példa Kft.'),
(46, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Kala Pál'),
(48, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Teszt Zrt.'),
(49, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 1, 'Káposzta Kft.'),
(63, '2022-03-15 14:04:59', '2022-03-15 14:04:59', '2022-03-15 14:04:59', 0, 2, 'Teszt Zrt.'),
(64, '2022-03-15 21:07:14', '2022-03-18 21:07:14', '2022-03-29 21:07:14', 0, 1, 'Ez+Az Kft.'),
(65, '2022-03-18 18:11:07.', '2022-03-18 18:11:07.', '2022-03-18 18:11:07.', 1, 0, 'Tiktok Kft'),
(66, '2022-03-18 19:45:32.', '2022-03-18 19:45:32.', '2022-03-18 19:45:32.', 1, 0, 'Teszt Zrt.');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `orders_company_data`
--

CREATE TABLE `orders_company_data` (
  `id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `name` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `tax_number` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `country` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `postcode` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `city` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `address` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `web` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `bank_account` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `comment` varchar(500) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `orders_company_data`
--

INSERT INTO `orders_company_data` (`id`, `order_id`, `name`, `tax_number`, `country`, `postcode`, `city`, `address`, `web`, `bank_account`, `comment`) VALUES
(25, 35, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(26, 36, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(27, 37, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(28, 38, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(29, 39, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(30, 40, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(35, 45, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(36, 46, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(38, 48, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(39, 49, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(53, 63, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(54, 64, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(55, 65, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?'),
(56, 66, 'Teszt Kft.', '12345678-2-14', 'Magyarország', '2100', 'Gödöllő', 'Testvérvárosok útja 114.', 'www.tesztcompany.com/hu', '12345678-12345678-12345678', 'jó?');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `orders_users`
--

CREATE TABLE `orders_users` (
  `id` int(10) NOT NULL,
  `order_id` int(11) NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `user_name` varchar(20) NOT NULL,
  `Registered` varchar(20) DEFAULT NULL,
  `type_of_users` int(11) NOT NULL,
  `email` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `orders_users`
--

INSERT INTO `orders_users` (`id`, `order_id`, `name`, `user_name`, `Registered`, `type_of_users`, `email`) VALUES
(29, 35, 'Administrator', 'admin', '2022-01-30 20:50:27', 0, 'admin@admin.hu'),
(30, 36, 'Administrator', 'admin', '2022-01-30 20:50:27', 0, 'admin@admin.hu'),
(31, 37, 'Administrator', 'admin', '2022-01-30 20:50:27', 0, 'admin@admin.hu'),
(32, 38, 'Kármán Adrienn', 'adi', '2022-01-30 18:16:49', 1, 'karman.adri@gmail.com'),
(33, 39, 'Administrator', 'admin', '2022-01-30 20:50:27', 0, 'admin@admin.hu'),
(34, 40, 'Administrator', 'admin', '2022-01-30 20:50:27', 0, 'admin@admin.hu'),
(39, 45, 'Kármán Adrienn', 'adi', '2022-01-30 18:16:49', 1, 'karman.adri@gmail.com'),
(40, 46, 'Mekk Elek', 'meke', '2022-02-03 21:24:23', 1, 'mekk.elek@tesztkft.hu'),
(42, 48, 'Kármán Adrienn', 'adi', '2022-01-30 18:16:49', 1, 'karman.adri@gmail.com'),
(43, 49, 'Administrator', 'admin', '2022-01-30 20:50:27', 0, 'admin@admin.hu'),
(57, 63, 'Administrator', 'admin', '2022-01-30 20:50:27', 0, 'admin@admin.hu'),
(58, 64, 'Mekk Elek', 'meke', '2022-02-03 21:24:23', 1, 'mekk.elek@tesztkft.hu'),
(59, 65, 'Administrator', 'admin', '2022-01-30 20:50:27', 0, 'admin@admin.hu'),
(60, 66, 'Administrator', 'admin', '2022-01-30 20:50:27', 0, 'admin@admin.hu');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `order_partner`
--

CREATE TABLE `order_partner` (
  `id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `type` int(11) NOT NULL,
  `name` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `tax_number` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `billing_country` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `billing_postcode` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `billing_city` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `billing_address` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `delivery_country` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `delivery_postcode` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `delivery_city` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `delivery_address` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `web` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `bank_account` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `comment` varchar(500) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `order_partner`
--

INSERT INTO `order_partner` (`id`, `order_id`, `type`, `name`, `tax_number`, `billing_country`, `billing_postcode`, `billing_city`, `billing_address`, `delivery_country`, `delivery_postcode`, `delivery_city`, `delivery_address`, `web`, `bank_account`, `comment`) VALUES
(25, 35, 0, 'Nap Pali', '', 'Magyarország', '2100', 'Gödölllő', 'Rózsa utca 9.', 'Magyarország', '2100', 'Gödölllő', 'Rózsa utca 9.', '', '12345678-00000000-12345678', 'tegezni'),
(26, 36, 1, 'Valami cég Kft.', '12345678-2-14', 'Magyarország', '1164', 'Budapest', 'Veres Péter út 12.', 'Magyarország', '1164', 'Budapest', 'Veres Péter út 12.', 'www.valami.hu', '', ''),
(27, 37, 1, 'Valami cég Kft.', '12345678-2-14', 'Magyarország', '1164', 'Budapest', 'Veres Péter út 12.', 'Magyarország', '1164', 'Budapest', 'Veres Péter út 12.', 'www.valami.hu', '', ''),
(28, 38, 1, 'Beauty-full sziget', '123456-13', 'Magyarország', '2100', 'Gödöllő', 'Petőfi tér 11.', 'Magyarország', '2100', 'Gödöllő', 'Petőfi tér 11.', '', '', 'fff'),
(29, 39, 1, 'Valami cég Kft.', '12345678-2-14', 'Magyarország', '1164', 'Budapest', 'Veres Péter út 12.', 'Magyarország', '1164', 'Budapest', 'Veres Péter út 12.', 'www.valami.hu', '', ''),
(30, 40, 0, 'Kala Pál', '', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 2.', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 2.', '', '', ''),
(35, 45, 1, 'Példa Kft.', '1234567-2-89', 'Magyarország', '1154', 'Budapest', 'Szentmihályi út 112.', 'Magyarország', '1154', 'Budapest', 'Szentmihályi út 112.', 'www.peldakft.hu', '12345678-87654321-12345678', ''),
(36, 46, 0, 'Kala Pál', '', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 2.', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 2.', '', '', ''),
(38, 48, 1, 'Teszt Zrt.', '12345678-2-12', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 112.', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 112.', 'www.tesztzrt.hu', '12345678-12345678-12345678', ''),
(39, 49, 1, 'Káposzta Kft.', '12345678-1-14', 'Magyarország', '1103', 'Budapest', 'Szentendrei út 112/c.', 'Magyarország', '1103', 'Budapest', 'Szentendrei út 112/c.', 'www.kaposztakft.hu', '00000000-00000000-00000000', 'Hétfőn zárva tartanak!'),
(53, 63, 1, 'Teszt Zrt.', '12345678-2-12', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 112.', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 112.', 'www.tesztzrt.hu', '12345678-12345678-12345678', ''),
(54, 64, 1, 'Ez+Az Kft.', '1234567-1-14', 'Magyarország', '1165', 'Budapest', 'Fő út 14.', 'Magyarország', '1165', 'Budapest', 'Fő út 14.', 'www.valami.net', '00000000-00000000', ''),
(55, 65, 1, 'Tiktok Kft', '1234567-1-14', 'Magyarország', '1121', 'Budapest', 'Vezér u 12.', 'Magyarország', '1121', 'Budapest', 'Vezér u 12.', 'www.tiktokkft.hu', '12345678-12345678', ''),
(56, 66, 1, 'Teszt Zrt.', '12345678-2-12', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 112.', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 112.', 'www.tesztzrt.hu', '12345678-12345678-12345678', '');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `order_products`
--

CREATE TABLE `order_products` (
  `id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `order_discount` int(11) NOT NULL,
  `product_name` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `product_number` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `quantity` int(11) NOT NULL,
  `vat` int(11) NOT NULL,
  `netto_buy_price` double NOT NULL,
  `brutto_buy_price` double NOT NULL,
  `netto_sell_price` double NOT NULL,
  `brutto_sell_price` double NOT NULL,
  `stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `order_products`
--

INSERT INTO `order_products` (`id`, `order_id`, `order_discount`, `product_name`, `product_number`, `quantity`, `vat`, `netto_buy_price`, `brutto_buy_price`, `netto_sell_price`, `brutto_sell_price`, `stock`) VALUES
(0, 36, 0, 'Plüss madár', 'WZ000124', 0, 0, 1000, 1270, 1000, 1270, 2),
(1, 37, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 100, 127, 2),
(2, 37, 0, 'Plüss madár', 'WZ000124', 0, 0, 1000, 1270, 1000, 1270, 2),
(4, 37, 0, 'Sony MDR V700DJ fejhallgató', 'SNY00001', 0, 0, 12000, 15240, 15900, 20193, 5),
(1, 39, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 100, 127, 10),
(2, 39, 0, 'Plüss madár', 'WZ000124', 0, 0, 1000, 1270, 1000, 1270, 5),
(1, 40, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 100, 127, 10),
(2, 40, 0, 'Plüss madár', 'WZ000124', 0, 0, 1000, 1270, 1000, 1270, 10),
(1, 45, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 90, 114.3, 5),
(2, 46, 0, 'Plüss madár', 'WZ000124', 0, 0, 1000, 1270, 950, 1206.5, 6),
(2, 35, 0, 'Plüss madár', 'WZ000124', 0, 0, 1000, 1270, 1000, 1270, 11),
(5, 48, 0, 'Kingston SSD 240GB', 'KG00001', 0, 0, 7000, 8890, 8000, 10160, 2),
(1, 48, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 100, 127, 5),
(4, 48, 0, 'Sony MDR V700DJ fejhallgató', 'SNY00001', 0, 0, 12000, 15240, 15900, 20193, 3),
(1, 49, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 100, 127, 5),
(1, 63, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 127, 127, 30),
(2, 63, 0, 'Plüss madár', 'WZ000124', 0, 0, 1000, 1270, 1270, 1270, 20),
(5, 63, 0, 'Kingston SSD 240GB', 'KG000012', 0, 0, 7000, 8890, 8890, 10160, 10),
(6, 63, 0, 'Power Bank 10000 mAh', 'PWRB10000HU', 0, 0, 6000, 7620, 7620, 10160, 5),
(1, 64, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 100, 127, 20),
(1, 65, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 100, 127, 12),
(7, 65, 0, 'Vezeték nélküli töltő', 'AZB000122', 0, 0, 1800, 2286, 2500, 3175, 5),
(6, 65, 0, 'Power Bank 10000 mAh', 'PWRB10000HU', 0, 0, 6000, 7620, 8000, 10160, 10),
(1, 66, 0, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 100, 127, 10);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `partner`
--

CREATE TABLE `partner` (
  `id` int(11) NOT NULL,
  `type` int(11) NOT NULL,
  `name` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `tax_number` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `billing_country` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `billing_postcode` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `billing_city` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `billing_address` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `delivery_country` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `delivery_postcode` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `delivery_city` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `delivery_address` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `web` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `bank_account` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  `comment` varchar(500) CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `partner`
--

INSERT INTO `partner` (`id`, `type`, `name`, `tax_number`, `billing_country`, `billing_postcode`, `billing_city`, `billing_address`, `delivery_country`, `delivery_postcode`, `delivery_city`, `delivery_address`, `web`, `bank_account`, `comment`) VALUES
(2, 0, 'Nap Pali', '', 'Magyarország', '2100', 'Gödölllő', 'Rózsa utca 9.', 'Magyarország', '2100', 'Gödölllő', 'Rózsa utca 9.', '', '12345678-00000000-12345678', 'tegezni'),
(3, 1, 'Példa Kft.', '1234567-2-89', 'Magyarország', '1154', 'Budapest', 'Szentmihályi út 112.', 'Magyarország', '1154', 'Budapest', 'Szentmihályi út 112.', 'www.peldakft.hu', '12345678-87654321-12345678', ''),
(4, 0, 'Kala Pál', '', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 2.', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 2.', '', '', ''),
(5, 1, 'Beauty-full sziget', '123456-13', 'Magyarország', '2100', 'Gödöllő', 'Petőfi tér 11.', 'Magyarország', '2100', 'Gödöllő', 'Petőfi tér 11.', '', '', 'fff'),
(8, 1, 'Valami cég Kft.', '12345678-2-14', 'Magyarország', '1164', 'Budapest', 'Veres Péter út 12.', 'Magyarország', '1164', 'Budapest', 'Veres Péter út 12.', 'www.valami.hu', '', ''),
(9, 1, 'Káposzta Kft.', '12345678-1-14', 'Magyarország', '1103', 'Budapest', 'Szentendrei út 112/c.', 'Magyarország', '1103', 'Budapest', 'Szentendrei út 112/c.', 'www.kaposztakft.hu', '00000000-00000000-00000000', 'Hétfőn zárva tartanak!'),
(10, 1, 'Teszt Zrt.', '12345678-2-12', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 112.', 'Magyarország', '1165', 'Budapest', 'Veres Péter út 112.', 'www.tesztzrt.hu', '12345678-12345678-12345678', ''),
(13, 1, 'Tiktok Kft', '1234567-1-14', 'Magyarország', '1121', 'Budapest', 'Vezér u 12.', 'Magyarország', '1121', 'Budapest', 'Vezér u 12.', 'www.tiktokkft.hu', '12345678-12345678', ''),
(14, 1, 'Ez+Az Kft.', '1234567-1-14', 'Magyarország', '1165', 'Budapest', 'Fő út 14.', 'Magyarország', '1165', 'Budapest', 'Fő út 14.', 'www.valami.net', '00000000-00000000', '');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `product_name` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `product_number` varchar(100) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `quantity` int(11) NOT NULL,
  `vat` int(11) NOT NULL,
  `netto_buy_price` double NOT NULL,
  `brutto_buy_price` double NOT NULL,
  `netto_sell_price` double NOT NULL,
  `brutto_sell_price` double NOT NULL,
  `stock` int(11) NOT NULL,
  `min_stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `products`
--

INSERT INTO `products` (`id`, `product_name`, `product_number`, `quantity`, `vat`, `netto_buy_price`, `brutto_buy_price`, `netto_sell_price`, `brutto_sell_price`, `stock`, `min_stock`) VALUES
(1, 'Hajkefe', 'WZ00123', 0, 0, 100, 127, 100, 127, 978, 3),
(2, 'Plüss madár', 'WZ000124', 0, 0, 1000, 1270, 1000, 1270, 170, 2),
(4, 'Sony MDR V700DJ fejhallgató', 'SNY00001', 0, 0, 12000, 15240, 15900, 20193, 8, 10),
(5, 'Kingston SSD 240GB', 'KG000012', 0, 0, 7000, 8890, 8000, 10160, 20, 5),
(6, 'Power Bank 10000 mAh', 'PWRB10000HU', 0, 0, 6000, 7620, 8000, 10160, 90, 5),
(7, 'Vezeték nélküli töltő', 'AZB000122', 0, 0, 1800, 2286, 2500, 3175, 5, 12);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(10) NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `user_name` varchar(20) NOT NULL,
  `password` varbinary(256) NOT NULL,
  `Registered` varchar(20) DEFAULT NULL,
  `type_of_users` int(11) NOT NULL,
  `email` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `name`, `user_name`, `password`, `Registered`, `type_of_users`, `email`) VALUES
(6, 'Kármán Adrienn', 'adi', 0x303033304143303637303432303136304633304531303543303736303145304531304135304532303535304630303637303935303336303233304338304233303838304234303435303945303133304639303738304437304338303436304634, '2022-01-30 18:16:49.', 1, 'karman.adri@gmail.com'),
(7, 'Administrator', 'admin', 0x303843303639303736304535304235303431303034303135304244304539303038304244303444304545303135304446304231303637304139304338303733304643303442304238304138303146303646303241304234303438304139303138, '2022-01-30 20:50:27.', 0, 'admin@admin.hu'),
(8, 'Mekk Elek', 'meke', 0x303033304143303637303432303136304633304531303543303736303145304531304135304532303535304630303637303935303336303233304338304233303838304234303435303945303133304639303738304437304338303436304634, '2022-02-03 21:24:23.', 1, 'mekk.elek@tesztkft.hu'),
(9, 'User', 'user', 0x303034304638303939303644304137303633304237304139303639304231303032303845304533303030303735303639304541304633304136303335303438303644304441304232303131304435303132304338303542303944304638304642, '2022-03-06 12:39:01.', 1, 'user@admin.com');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `company_data`
--
ALTER TABLE `company_data`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `contact_for_partners`
--
ALTER TABLE `contact_for_partners`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_partner_kapcsolattarto` (`partner_id`);

--
-- A tábla indexei `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `orders_company_data`
--
ALTER TABLE `orders_company_data`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_orders_orders_company_data` (`order_id`) USING BTREE;

--
-- A tábla indexei `orders_users`
--
ALTER TABLE `orders_users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_orders_orders_users` (`order_id`);

--
-- A tábla indexei `order_partner`
--
ALTER TABLE `order_partner`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_orders_order_partner` (`order_id`) USING BTREE;

--
-- A tábla indexei `order_products`
--
ALTER TABLE `order_products`
  ADD KEY `FK_orders_order_products` (`order_id`);

--
-- A tábla indexei `partner`
--
ALTER TABLE `partner`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `user_name` (`user_name`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `company_data`
--
ALTER TABLE `company_data`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT a táblához `contact_for_partners`
--
ALTER TABLE `contact_for_partners`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT a táblához `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=67;

--
-- AUTO_INCREMENT a táblához `orders_company_data`
--
ALTER TABLE `orders_company_data`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT a táblához `orders_users`
--
ALTER TABLE `orders_users`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT a táblához `order_partner`
--
ALTER TABLE `order_partner`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT a táblához `partner`
--
ALTER TABLE `partner`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT a táblához `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `contact_for_partners`
--
ALTER TABLE `contact_for_partners`
  ADD CONSTRAINT `FK_partner_kapcsolattarto` FOREIGN KEY (`partner_id`) REFERENCES `partner` (`id`);

--
-- Megkötések a táblához `orders_company_data`
--
ALTER TABLE `orders_company_data`
  ADD CONSTRAINT `orders_company_data_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `orders_users`
--
ALTER TABLE `orders_users`
  ADD CONSTRAINT `orders_users_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `order_partner`
--
ALTER TABLE `order_partner`
  ADD CONSTRAINT `order_partner_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `order_products`
--
ALTER TABLE `order_products`
  ADD CONSTRAINT `order_products_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
