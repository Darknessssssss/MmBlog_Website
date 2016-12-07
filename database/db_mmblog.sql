/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50627
Source Host           : localhost:3306
Source Database       : db_mmblog

Target Server Type    : MYSQL
Target Server Version : 50627
File Encoding         : 65001

Date: 2016-12-08 01:02:08
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `t_user`
-- ----------------------------
DROP TABLE IF EXISTS `t_user`;
CREATE TABLE `t_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `nickname` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `type` int(11) NOT NULL DEFAULT '1',
  `face` varchar(255) NOT NULL DEFAULT 'default.png',
  `regtime` varchar(255) NOT NULL DEFAULT '0000000000',
  `llitime` varchar(255) NOT NULL DEFAULT '0000000000',
  `llide` varchar(255) NOT NULL DEFAULT 'Unknow',
  `llii` varchar(255) NOT NULL DEFAULT '0.0.0.0',
  PRIMARY KEY (`id`,`email`,`phone`,`nickname`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_user
-- ----------------------------
INSERT INTO `t_user` VALUES ('1', 'dyfdyf930812', '13523717833', 'new_8s', '1qaz2wsx', '0', 'default.png', '0000000000', '0000000000', 'unknow', '0.0.0.0');
