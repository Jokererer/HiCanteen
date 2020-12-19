/*
Navicat MySQL Data Transfer

Source Server         : dang
Source Server Version : 50732
Source Host           : localhost:3306
Source Database       : canteenordering

Target Server Type    : MYSQL
Target Server Version : 50732
File Encoding         : 65001

Date: 2020-12-18 18:42:02
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for customer
-- ----------------------------
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `customerID` int(11) NOT NULL AUTO_INCREMENT,
  `customerName` varchar(255) NOT NULL,
  `customerPasswd` varchar(255) NOT NULL,
  `customerAddress` varchar(255) NOT NULL,
  `customerPhone` char(15) NOT NULL,
  PRIMARY KEY (`customerID`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of customer
-- ----------------------------
INSERT INTO `customer` VALUES ('101', '123', '123', 'www', '1555');
INSERT INTO `customer` VALUES ('102', '党文娟', '123', '1234567', '临湖');
INSERT INTO `customer` VALUES ('103', 'TextBox', 'TextBox', 'TextBox', 'TextBox');
INSERT INTO `customer` VALUES ('104', '向诗瑶', '123456', '临湖3', '12345609876');

-- ----------------------------
-- Table structure for dishes
-- ----------------------------
DROP TABLE IF EXISTS `dishes`;
CREATE TABLE `dishes` (
  `dishesID` int(11) NOT NULL AUTO_INCREMENT,
  `dishesName` varchar(255) NOT NULL,
  `merchantID` int(11) NOT NULL,
  `price` float NOT NULL,
  `sales` int(11) DEFAULT NULL,
  PRIMARY KEY (`dishesID`),
  KEY `merchantID` (`merchantID`),
  CONSTRAINT `dishes_ibfk_1` FOREIGN KEY (`merchantID`) REFERENCES `merchant` (`merchantID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=388 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of dishes
-- ----------------------------
INSERT INTO `dishes` VALUES ('1', '燕麦粥', '101', '2', '144');
INSERT INTO `dishes` VALUES ('2', '皮蛋瘦肉粥', '101', '2', '229');
INSERT INTO `dishes` VALUES ('3', '青菜粥', '101', '2', '254');
INSERT INTO `dishes` VALUES ('4', '南瓜小米粥', '101', '2', '266');
INSERT INTO `dishes` VALUES ('5', '燕麦牛奶', '101', '2', '295');
INSERT INTO `dishes` VALUES ('6', '绿豆汤', '101', '2', '107');
INSERT INTO `dishes` VALUES ('7', '牛奶豆花', '101', '2', '183');
INSERT INTO `dishes` VALUES ('8', '煮玉米', '101', '3', '143');
INSERT INTO `dishes` VALUES ('9', '番茄鸡蛋炒面', '102', '7', '197');
INSERT INTO `dishes` VALUES ('10', '火腿炒面', '102', '7', '159');
INSERT INTO `dishes` VALUES ('11', '青椒炒面', '102', '9', '113');
INSERT INTO `dishes` VALUES ('12', '鸡丝炒面', '102', '9', '145');
INSERT INTO `dishes` VALUES ('13', '肉丝炒面', '102', '9', '115');
INSERT INTO `dishes` VALUES ('14', '土豆火腿炒面', '102', '9', '187');
INSERT INTO `dishes` VALUES ('15', '香菇火腿炒面', '102', '9', '182');
INSERT INTO `dishes` VALUES ('16', '土豆鸡蛋炒面', '102', '9', '270');
INSERT INTO `dishes` VALUES ('17', '青椒火腿炒面', '102', '9', '242');
INSERT INTO `dishes` VALUES ('18', '土豆肉丝盖浇饭', '103', '12', '104');
INSERT INTO `dishes` VALUES ('19', '青椒肉丝盖浇饭', '103', '12', '223');
INSERT INTO `dishes` VALUES ('20', '香菇腊肉盖浇饭', '103', '12', '204');
INSERT INTO `dishes` VALUES ('21', '番茄牛肉盖浇饭', '103', '12', '199');
INSERT INTO `dishes` VALUES ('22', '土豆牛肉盖浇饭', '103', '12', '275');
INSERT INTO `dishes` VALUES ('23', '青椒牛肉盖浇饭', '103', '12', '194');
INSERT INTO `dishes` VALUES ('24', '木耳牛肉盖浇饭', '103', '12', '142');
INSERT INTO `dishes` VALUES ('25', '香菇牛肚盖浇饭', '103', '13', '240');
INSERT INTO `dishes` VALUES ('26', '火腿腊肠盖浇饭', '103', '13', '256');
INSERT INTO `dishes` VALUES ('27', '红油热干面', '104', '5', '198');
INSERT INTO `dishes` VALUES ('28', '骨汤面', '104', '5', '203');
INSERT INTO `dishes` VALUES ('29', '酸辣面', '104', '6', '253');
INSERT INTO `dishes` VALUES ('30', '炸酱面', '104', '8', '161');
INSERT INTO `dishes` VALUES ('31', '番茄鸡蛋面', '104', '9', '202');
INSERT INTO `dishes` VALUES ('32', '火腿鸡蛋面', '104', '10', '247');
INSERT INTO `dishes` VALUES ('33', '炸酱热干面', '104', '10', '173');
INSERT INTO `dishes` VALUES ('34', '牛肉热干面', '104', '14', '123');
INSERT INTO `dishes` VALUES ('35', '五谷原汤粉', '105', '6.5', '293');
INSERT INTO `dishes` VALUES ('36', '鲜香玉米粉', '105', '7.5', '195');
INSERT INTO `dishes` VALUES ('37', '牛肉丸粉', '105', '8', '191');
INSERT INTO `dishes` VALUES ('38', '五谷鱼片粉', '105', '10', '240');
INSERT INTO `dishes` VALUES ('39', '番茄肉丸粉', '105', '11', '233');
INSERT INTO `dishes` VALUES ('40', '五谷牛肉粉', '105', '12', '287');
INSERT INTO `dishes` VALUES ('41', '五谷牛肚粉', '105', '12', '194');
INSERT INTO `dishes` VALUES ('42', '五谷虾粉', '105', '12', '209');
INSERT INTO `dishes` VALUES ('43', '鸭血，豆泡，粉丝', '106', '6', '125');
INSERT INTO `dishes` VALUES ('44', '鸭血，豆泡，粉丝，鸭肝', '106', '6.5', '157');
INSERT INTO `dishes` VALUES ('45', '鸭血，豆泡，粉丝，鸭肠', '106', '7.5', '213');
INSERT INTO `dishes` VALUES ('46', '鸭血，豆泡，粉丝，鸭胗', '106', '8', '174');
INSERT INTO `dishes` VALUES ('47', '鸭血，豆泡，粉丝，鸭肝，鸭肠', '106', '9', '290');
INSERT INTO `dishes` VALUES ('48', '鸭血，豆泡，粉丝，鸭肠，鸭胗', '106', '10', '180');
INSERT INTO `dishes` VALUES ('49', '鸭血全套粉丝', '106', '11', '250');
INSERT INTO `dishes` VALUES ('50', '辣子油泼面', '107', '6', '295');
INSERT INTO `dishes` VALUES ('51', '火腿油泼面', '107', '7', '143');
INSERT INTO `dishes` VALUES ('52', '鸡蛋油泼面', '107', '7', '173');
INSERT INTO `dishes` VALUES ('53', '肉丝油泼面', '107', '8', '217');
INSERT INTO `dishes` VALUES ('54', '炸酱油泼面', '107', '9', '160');
INSERT INTO `dishes` VALUES ('55', '牛肉油泼面', '107', '10', '121');
INSERT INTO `dishes` VALUES ('56', '麻辣砂锅面', '107', '10', '137');
INSERT INTO `dishes` VALUES ('57', '鸡蛋砂锅面', '107', '7', '195');
INSERT INTO `dishes` VALUES ('58', '火腿砂锅面', '107', '8', '117');
INSERT INTO `dishes` VALUES ('59', '馒头', '108', '0.4', '234');
INSERT INTO `dishes` VALUES ('60', '花卷', '108', '0.5', '291');
INSERT INTO `dishes` VALUES ('61', '红糖馒头', '108', '1', '225');
INSERT INTO `dishes` VALUES ('62', '玉米馒头', '108', '1', '215');
INSERT INTO `dishes` VALUES ('63', '豆沙包', '108', '1', '101');
INSERT INTO `dishes` VALUES ('64', '粉丝包', '108', '1', '203');
INSERT INTO `dishes` VALUES ('65', '青菜包', '108', '1', '130');
INSERT INTO `dishes` VALUES ('66', '腌菜包', '108', '1', '200');
INSERT INTO `dishes` VALUES ('67', '鲜肉包', '108', '1', '204');
INSERT INTO `dishes` VALUES ('68', '发糕', '108', '1.5', '137');
INSERT INTO `dishes` VALUES ('69', '甜饭团', '109', '5', '222');
INSERT INTO `dishes` VALUES ('70', '招牌饭团', '109', '6', '262');
INSERT INTO `dishes` VALUES ('71', '铁板里脊饭团', '109', '6', '185');
INSERT INTO `dishes` VALUES ('72', '鸡柳饭团', '109', '6', '269');
INSERT INTO `dishes` VALUES ('73', '韩式泡菜饭团', '109', '6', '190');
INSERT INTO `dishes` VALUES ('74', '玉米热狗饭团', '109', '6', '241');
INSERT INTO `dishes` VALUES ('75', '海苔海鲜饭团', '109', '6', '111');
INSERT INTO `dishes` VALUES ('76', '海苔海草饭团', '109', '6', '208');
INSERT INTO `dishes` VALUES ('77', '麻辣鱼丁饭团', '109', '7', '258');
INSERT INTO `dishes` VALUES ('78', '台湾卤肉饭', '110', '11', '155');
INSERT INTO `dishes` VALUES ('79', '台湾鸡腿饭', '110', '12', '297');
INSERT INTO `dishes` VALUES ('80', '台湾鸭腿饭', '110', '12', '253');
INSERT INTO `dishes` VALUES ('81', '台湾牛肚饭', '110', '13', '271');
INSERT INTO `dishes` VALUES ('82', '台湾牛肉饭', '110', '13', '230');
INSERT INTO `dishes` VALUES ('83', '台湾卤肉牛肉饭', '110', '15', '112');
INSERT INTO `dishes` VALUES ('84', '台湾卤肉牛肚饭', '110', '15', '182');
INSERT INTO `dishes` VALUES ('85', '鸡蛋热狗饭', '110', '10', '177');
INSERT INTO `dishes` VALUES ('86', '台湾烤肉饭', '110', '11', '217');
INSERT INTO `dishes` VALUES ('87', '台湾烫饭', '110', '10', '189');
INSERT INTO `dishes` VALUES ('88', '青椒鸡蛋炒面', '111', '7', '151');
INSERT INTO `dishes` VALUES ('89', '孜然肉丝炒面', '111', '8', '146');
INSERT INTO `dishes` VALUES ('90', '青椒肉丝炒面 ', '111', '8', '264');
INSERT INTO `dishes` VALUES ('91', '青菜肉丝炒面', '111', '8', '133');
INSERT INTO `dishes` VALUES ('92', '孜然鸡蛋肉丝炒面', '111', '9.5', '116');
INSERT INTO `dishes` VALUES ('93', '香菇鸡蛋肉丝炒面', '111', '9.5', '247');
INSERT INTO `dishes` VALUES ('94', '韭菜鸡蛋水饺', '111', '3.5', '101');
INSERT INTO `dishes` VALUES ('95', '芹菜肉馅水饺', '111', '3.5', '113');
INSERT INTO `dishes` VALUES ('96', '蒸饺十个', '111', '4.5', '222');
INSERT INTO `dishes` VALUES ('97', '烧麦', '111', '1.5', '208');
INSERT INTO `dishes` VALUES ('98', '奶黄包', '111', '1', '210');
INSERT INTO `dishes` VALUES ('99', '牛肉汤粉', '112', '10', '227');
INSERT INTO `dishes` VALUES ('100', '牛杂汤粉', '112', '10', '118');
INSERT INTO `dishes` VALUES ('101', '加牛杂', '112', '6', '291');
INSERT INTO `dishes` VALUES ('102', '肉夹馍', '112', '6', '156');
INSERT INTO `dishes` VALUES ('103', '菜夹馍', '112', '4', '230');
INSERT INTO `dishes` VALUES ('104', '蛋夹馍', '112', '4', '249');
INSERT INTO `dishes` VALUES ('105', '酸辣粉', '112', '8', '251');
INSERT INTO `dishes` VALUES ('106', '炒河粉', '112', '8', '254');
INSERT INTO `dishes` VALUES ('107', '炒米粉', '112', '8', '202');
INSERT INTO `dishes` VALUES ('108', '炒意大利面', '112', '8', '271');
INSERT INTO `dishes` VALUES ('109', '白吉饼', '112', '1.5', '188');
INSERT INTO `dishes` VALUES ('110', '卤蛋', '112', '1.5', '273');
INSERT INTO `dishes` VALUES ('111', '重庆小面', '113', '6', '173');
INSERT INTO `dishes` VALUES ('112', '剁椒拌面', '113', '8', '260');
INSERT INTO `dishes` VALUES ('113', '担担面', '113', '7', '143');
INSERT INTO `dishes` VALUES ('114', '清汤抄手', '113', '9', '144');
INSERT INTO `dishes` VALUES ('115', '藤椒抄手', '113', '9', '113');
INSERT INTO `dishes` VALUES ('116', '老麻抄手', '113', '9', '287');
INSERT INTO `dishes` VALUES ('117', '红烧牛肉面', '113', '10', '126');
INSERT INTO `dishes` VALUES ('118', '干拌刀削面', '113', '1', '184');
INSERT INTO `dishes` VALUES ('119', '金牌热干面', '114', '4', '225');
INSERT INTO `dishes` VALUES ('120', '一品豆腐面', '114', '6', '230');
INSERT INTO `dishes` VALUES ('121', '三鲜粉', '114', '7', '116');
INSERT INTO `dishes` VALUES ('122', '三鲜面', '114', '7', '128');
INSERT INTO `dishes` VALUES ('123', '招牌鱼粉', '114', '8', '253');
INSERT INTO `dishes` VALUES ('124', '花甲粉', '114', '10', '134');
INSERT INTO `dishes` VALUES ('125', '酸辣渔粉', '114', '8', '149');
INSERT INTO `dishes` VALUES ('126', '鲜虾粉', '114', '11', '105');
INSERT INTO `dishes` VALUES ('127', '蟹棒粉', '114', '7', '146');
INSERT INTO `dishes` VALUES ('128', '鱼丸粉', '114', '7', '299');
INSERT INTO `dishes` VALUES ('129', '生烫羊肉粉', '114', '9', '223');
INSERT INTO `dishes` VALUES ('130', '黑椒牛肉粉', '114', '11', '297');
INSERT INTO `dishes` VALUES ('131', '招牌水煮鱼', '115', '12', '119');
INSERT INTO `dishes` VALUES ('132', '老坛酸菜泡椒鱼', '115', '13', '265');
INSERT INTO `dishes` VALUES ('133', '网红豆花鱼', '115', '14', '266');
INSERT INTO `dishes` VALUES ('134', '水煮藤椒鱼', '115', '14', '237');
INSERT INTO `dishes` VALUES ('135', '酸菜鱼土豆粉', '115', '14', '113');
INSERT INTO `dishes` VALUES ('136', '番茄龙利鱼', '115', '15', '271');
INSERT INTO `dishes` VALUES ('137', '开胃番茄鱼', '115', '12', '141');
INSERT INTO `dishes` VALUES ('138', '水煮毛血旺', '115', '11', '260');
INSERT INTO `dishes` VALUES ('139', '水煮肥牛', '115', '13', '216');
INSERT INTO `dishes` VALUES ('140', '招牌烧鸭饭', '116', '13', '172');
INSERT INTO `dishes` VALUES ('141', '广式腊肠饭', '116', '13', '291');
INSERT INTO `dishes` VALUES ('142', '金牌鹅腿饭', '116', '14', '174');
INSERT INTO `dishes` VALUES ('143', '梅酱鸡腿范', '116', '14', '192');
INSERT INTO `dishes` VALUES ('144', '梅酱鸭腿饭', '116', '14', '214');
INSERT INTO `dishes` VALUES ('145', '台式卤肉饭', '116', '13', '155');
INSERT INTO `dishes` VALUES ('146', '海南白切鸡饭', '116', '13', '106');
INSERT INTO `dishes` VALUES ('147', '玫瑰鼓油鸡饭', '116', '14', '129');
INSERT INTO `dishes` VALUES ('148', '酱香猪脚饭', '116', '15', '256');
INSERT INTO `dishes` VALUES ('149', '培根火腿双拼', '117', '10', '299');
INSERT INTO `dishes` VALUES ('150', '中式烧肉饭', '117', '11', '178');
INSERT INTO `dishes` VALUES ('151', '茄汁鸡肉饭', '117', '12', '281');
INSERT INTO `dishes` VALUES ('152', '茄汁烧肉饭', '117', '12', '135');
INSERT INTO `dishes` VALUES ('153', '茄汁鸡排饭', '117', '12', '282');
INSERT INTO `dishes` VALUES ('154', '茄汁肥牛', '117', '12', '264');
INSERT INTO `dishes` VALUES ('155', '咖喱鸡肉饭', '117', '13', '231');
INSERT INTO `dishes` VALUES ('156', '咖喱烧肉饭', '117', '13', '255');
INSERT INTO `dishes` VALUES ('157', '黑胡椒肥牛饭', '117', '13', '155');
INSERT INTO `dishes` VALUES ('158', '韩式泡菜肥牛饭', '117', '13', '275');
INSERT INTO `dishes` VALUES ('159', '黄焖素菜', '118', '9', '172');
INSERT INTO `dishes` VALUES ('160', '黄焖鸡', '118', '13', '244');
INSERT INTO `dishes` VALUES ('161', '黄焖豆腐鸡', '118', '14', '158');
INSERT INTO `dishes` VALUES ('162', '大盘鸡', '118', '13.5', '163');
INSERT INTO `dishes` VALUES ('163', '麻辣回锅肉饭', '119', '11', '149');
INSERT INTO `dishes` VALUES ('164', '香辣孜然培根饭', '119', '11', '194');
INSERT INTO `dishes` VALUES ('165', '照烧香菇肉丸饭', '119', '11', '216');
INSERT INTO `dishes` VALUES ('166', '照烧鸡肉饭', '119', '12', '196');
INSERT INTO `dishes` VALUES ('167', '黑椒鸡肉饭', '119', '12', '215');
INSERT INTO `dishes` VALUES ('168', '孜然鸡肉饭', '119', '12', '216');
INSERT INTO `dishes` VALUES ('169', '百事可乐鸡', '120', '15', '137');
INSERT INTO `dishes` VALUES ('170', '酱香鸭腿饭', '120', '15', '196');
INSERT INTO `dishes` VALUES ('171', '歌乐山辣子鸡饭', '120', '15', '171');
INSERT INTO `dishes` VALUES ('172', '台式三杯鸡', '120', '15', '243');
INSERT INTO `dishes` VALUES ('173', '牛肉炒饭', '121', '10', '168');
INSERT INTO `dishes` VALUES ('174', '鸡蛋鸭肠炒饭', '121', '10', '229');
INSERT INTO `dishes` VALUES ('175', '鸡蛋培根炒饭', '121', '10', '121');
INSERT INTO `dishes` VALUES ('176', '鸡蛋牛肉炒饭', '121', '12', '238');
INSERT INTO `dishes` VALUES ('177', '鸡蛋牛肚炒饭', '121', '12', '119');
INSERT INTO `dishes` VALUES ('178', '牛奶', '122', '2', '110');
INSERT INTO `dishes` VALUES ('179', '米浆', '122', '2', '192');
INSERT INTO `dishes` VALUES ('180', '西米露', '122', '2', '153');
INSERT INTO `dishes` VALUES ('181', '双皮奶', '122', '3', '216');
INSERT INTO `dishes` VALUES ('182', '红茶', '122', '3', '257');
INSERT INTO `dishes` VALUES ('183', '绿茶', '122', '3', '135');
INSERT INTO `dishes` VALUES ('184', '黑米粥', '122', '3', '103');
INSERT INTO `dishes` VALUES ('185', '小米粥', '122', '3', '145');
INSERT INTO `dishes` VALUES ('186', '红糖燕麦粥', '122', '3', '105');
INSERT INTO `dishes` VALUES ('187', '酱香饼', '123', '2', '281');
INSERT INTO `dishes` VALUES ('188', '玉米饼', '123', '2', '192');
INSERT INTO `dishes` VALUES ('189', '酸菜饼', '123', '2', '278');
INSERT INTO `dishes` VALUES ('190', '包菜肉饼', '123', '2', '151');
INSERT INTO `dishes` VALUES ('191', '千层饼', '123', '2', '191');
INSERT INTO `dishes` VALUES ('192', '太阳饼', '123', '3.5', '244');
INSERT INTO `dishes` VALUES ('193', '公婆饼', '123', '3.5', '205');
INSERT INTO `dishes` VALUES ('194', '卷饼', '123', '4', '139');
INSERT INTO `dishes` VALUES ('195', '掉渣饼', '124', '2', '140');
INSERT INTO `dishes` VALUES ('196', '藕片', '124', '2', '269');
INSERT INTO `dishes` VALUES ('197', '包菜', '124', '2', '117');
INSERT INTO `dishes` VALUES ('198', '黄瓜', '124', '2', '178');
INSERT INTO `dishes` VALUES ('199', '鸡柳', '124', '3', '113');
INSERT INTO `dishes` VALUES ('200', '火腿', '124', '3', '186');
INSERT INTO `dishes` VALUES ('201', '面筋', '124', '3', '194');
INSERT INTO `dishes` VALUES ('202', '骨肉相连', '124', '3', '292');
INSERT INTO `dishes` VALUES ('203', '五花肉', '124', '3', '137');
INSERT INTO `dishes` VALUES ('204', '纯肉排', '124', '3', '276');
INSERT INTO `dishes` VALUES ('205', '香蜡肉条', '124', '3', '169');
INSERT INTO `dishes` VALUES ('206', '麦片牛奶', '125', '5', '263');
INSERT INTO `dishes` VALUES ('207', '椰汁红豆', '125', '5', '127');
INSERT INTO `dishes` VALUES ('208', '烤奶', '125', '5', '244');
INSERT INTO `dishes` VALUES ('209', '浓情巧克力', '125', '5', '250');
INSERT INTO `dishes` VALUES ('210', '茉莉绿茶', '125', '4', '130');
INSERT INTO `dishes` VALUES ('211', '蜂蜜柚子茶', '125', '5', '200');
INSERT INTO `dishes` VALUES ('212', '原味奶茶', '125', '4', '139');
INSERT INTO `dishes` VALUES ('213', '椰果奶茶', '125', '5', '242');
INSERT INTO `dishes` VALUES ('214', '红豆奶茶', '125', '5', '172');
INSERT INTO `dishes` VALUES ('215', '西瓜汁', '126', '5', '178');
INSERT INTO `dishes` VALUES ('216', '柠檬绿茶', '126', '5', '216');
INSERT INTO `dishes` VALUES ('217', '金桔柠檬', '126', '5', '275');
INSERT INTO `dishes` VALUES ('218', '柠檬芦荟', '126', '5', '142');
INSERT INTO `dishes` VALUES ('219', '柚见柠檬', '126', '5', '295');
INSERT INTO `dishes` VALUES ('220', '金牌咖啡', '126', '5', '298');
INSERT INTO `dishes` VALUES ('221', '拿铁咖啡', '126', '6', '265');
INSERT INTO `dishes` VALUES ('222', '卡布奇诺', '126', '6', '243');
INSERT INTO `dishes` VALUES ('223', '原味豆浆', '127', '2', '177');
INSERT INTO `dishes` VALUES ('224', '黑豆豆浆', '127', '2', '207');
INSERT INTO `dishes` VALUES ('225', '永和豆浆', '127', '2', '254');
INSERT INTO `dishes` VALUES ('226', '绿豆浆', '127', '3', '104');
INSERT INTO `dishes` VALUES ('227', '燕麦豆浆', '127', '2', '241');
INSERT INTO `dishes` VALUES ('228', '红枣豆浆', '127', '2', '163');
INSERT INTO `dishes` VALUES ('229', '花生豆浆', '127', '2.5', '138');
INSERT INTO `dishes` VALUES ('230', '银耳汤', '127', '2.5', '179');
INSERT INTO `dishes` VALUES ('231', '一品豆花', '128', '2', '210');
INSERT INTO `dishes` VALUES ('232', '香浓豆花', '128', '2.5', '148');
INSERT INTO `dishes` VALUES ('233', '红豆豆浆', '128', '3', '280');
INSERT INTO `dishes` VALUES ('234', '绿豆豆浆', '128', '3', '239');
INSERT INTO `dishes` VALUES ('235', '红油拉面', '129', '4', '245');
INSERT INTO `dishes` VALUES ('236', '炸酱拉面', '129', '7', '170');
INSERT INTO `dishes` VALUES ('237', '油泼拉面', '129', '7', '262');
INSERT INTO `dishes` VALUES ('238', '番茄鸡蛋拉面', '129', '6', '231');
INSERT INTO `dishes` VALUES ('239', '香菇鸡丁拉面', '129', '7', '187');
INSERT INTO `dishes` VALUES ('240', '三鲜肉丝拉面', '129', '7', '238');
INSERT INTO `dishes` VALUES ('241', '红油牛肉拉面', '129', '10', '192');
INSERT INTO `dishes` VALUES ('242', '红油刀削面', '129', '4', '162');
INSERT INTO `dishes` VALUES ('243', '炸酱刀削面', '129', '7', '145');
INSERT INTO `dishes` VALUES ('244', '油泼刀削面', '129', '7', '250');
INSERT INTO `dishes` VALUES ('245', '番茄鸡蛋刀削面', '129', '6', '118');
INSERT INTO `dishes` VALUES ('246', '香菇鸡丁刀削面', '129', '7', '192');
INSERT INTO `dishes` VALUES ('247', '三鲜肉丝刀削面', '129', '7', '266');
INSERT INTO `dishes` VALUES ('248', '红油牛肉刀削面', '129', '10', '169');
INSERT INTO `dishes` VALUES ('249', '虎皮鸡蛋', '129', '1.5', '184');
INSERT INTO `dishes` VALUES ('250', '热干面', '130', '3', '233');
INSERT INTO `dishes` VALUES ('251', '桂林米粉', '130', '4', '181');
INSERT INTO `dishes` VALUES ('252', '正宗重庆小面', '130', '5', '115');
INSERT INTO `dishes` VALUES ('253', '秘制炸酱面', '130', '7', '242');
INSERT INTO `dishes` VALUES ('254', '香菇鸡丁面', '130', '7', '150');
INSERT INTO `dishes` VALUES ('255', '红油牛肉面', '130', '10', '104');
INSERT INTO `dishes` VALUES ('256', '馄饨', '130', '8', '128');
INSERT INTO `dishes` VALUES ('257', '白粥', '131', '0.5', '252');
INSERT INTO `dishes` VALUES ('258', '水煮蛋', '131', '1', '223');
INSERT INTO `dishes` VALUES ('259', '黑豆粥', '131', '2', '165');
INSERT INTO `dishes` VALUES ('260', '绿豆粥', '131', '2', '102');
INSERT INTO `dishes` VALUES ('261', '红豆粥', '131', '2', '152');
INSERT INTO `dishes` VALUES ('262', '皮蛋粥', '131', '2', '238');
INSERT INTO `dishes` VALUES ('263', '香菇鸡肉粥', '131', '2', '198');
INSERT INTO `dishes` VALUES ('264', '紫薯粥', '131', '2', '266');
INSERT INTO `dishes` VALUES ('265', '小米南瓜粥', '131', '2', '208');
INSERT INTO `dishes` VALUES ('266', '红豆牛奶', '131', '2', '211');
INSERT INTO `dishes` VALUES ('267', '玉米', '131', '3', '152');
INSERT INTO `dishes` VALUES ('268', '土家酱香饼', '132', '3', '263');
INSERT INTO `dishes` VALUES ('269', '风味千层饼', '132', '2', '202');
INSERT INTO `dishes` VALUES ('270', '鸡蛋煎饼', '132', '1.5', '139');
INSERT INTO `dishes` VALUES ('271', '汉堡', '132', '5', '181');
INSERT INTO `dishes` VALUES ('272', '粉丝馅饼', '132', '1.5', '212');
INSERT INTO `dishes` VALUES ('273', '韭菜馅饼', '132', '2', '203');
INSERT INTO `dishes` VALUES ('274', '酸辣包菜馅饼', '132', '1.5', '144');
INSERT INTO `dishes` VALUES ('275', '韭菜鸡蛋馅饼', '132', '1.5', '110');
INSERT INTO `dishes` VALUES ('276', '土豆丝卷饼', '132', '3.5', '118');
INSERT INTO `dishes` VALUES ('277', '西红柿炒蛋', '133', '8', '271');
INSERT INTO `dishes` VALUES ('278', '家常豆腐', '133', '8', '148');
INSERT INTO `dishes` VALUES ('279', '土豆肉丝', '133', '9', '238');
INSERT INTO `dishes` VALUES ('280', '香菇肉片', '133', '9', '286');
INSERT INTO `dishes` VALUES ('281', '辣子鸡丁', '133', '10', '100');
INSERT INTO `dishes` VALUES ('282', '肉末茄子', '133', '10', '199');
INSERT INTO `dishes` VALUES ('283', '香干回锅肉', '133', '10', '121');
INSERT INTO `dishes` VALUES ('284', '孜然牛肉', '133', '12', '206');
INSERT INTO `dishes` VALUES ('285', '卤水鸭', '133', '12', '238');
INSERT INTO `dishes` VALUES ('286', '酸菜拌面', '134', '5', '239');
INSERT INTO `dishes` VALUES ('287', '西红柿鸡蛋拌面', '134', '7', '108');
INSERT INTO `dishes` VALUES ('288', '酸菜肉丝拌面', '134', '8', '205');
INSERT INTO `dishes` VALUES ('289', '鸡丝拌面', '134', '8', '223');
INSERT INTO `dishes` VALUES ('290', '肉丝拌面', '134', '8', '293');
INSERT INTO `dishes` VALUES ('291', '火腿肉丝拌面', '134', '8.5', '242');
INSERT INTO `dishes` VALUES ('292', '牛肉拌面', '134', '9', '293');
INSERT INTO `dishes` VALUES ('293', '三鲜肉丝面', '134', '9', '236');
INSERT INTO `dishes` VALUES ('294', '鲜肉水饺', '134', '10', '156');
INSERT INTO `dishes` VALUES ('295', '香酥鸡排饭', '135', '12', '208');
INSERT INTO `dishes` VALUES ('296', '鸡米花饭', '135', '10', '110');
INSERT INTO `dishes` VALUES ('297', '酱烧排骨饭', '135', '12', '167');
INSERT INTO `dishes` VALUES ('298', '秘制黑鸭饭', '135', '12', '194');
INSERT INTO `dishes` VALUES ('299', '风味辣子鸡饭', '135', '12', '289');
INSERT INTO `dishes` VALUES ('300', '奥尔良鸡腿饭', '135', '10', '154');
INSERT INTO `dishes` VALUES ('301', '台湾大鸡排饭', '135', '12', '223');
INSERT INTO `dishes` VALUES ('302', '鸡腿饭', '136', '10', '232');
INSERT INTO `dishes` VALUES ('303', '鸭腿饭', '136', '10', '276');
INSERT INTO `dishes` VALUES ('304', '叉烧饭', '136', '10', '172');
INSERT INTO `dishes` VALUES ('305', '红烧肉饭', '136', '10', '164');
INSERT INTO `dishes` VALUES ('306', '可乐鸡蛋', '136', '10', '261');
INSERT INTO `dishes` VALUES ('307', '回锅肉饭', '136', '10', '135');
INSERT INTO `dishes` VALUES ('308', '干锅鸭饭', '136', '10', '247');
INSERT INTO `dishes` VALUES ('309', '香菇烧麦', '137', '4.5', '288');
INSERT INTO `dishes` VALUES ('310', '鲜肉小笼包', '137', '5', '110');
INSERT INTO `dishes` VALUES ('311', '鲜肉水晶饺', '137', '5', '163');
INSERT INTO `dishes` VALUES ('312', '鲜肉玉米饺', '137', '5', '265');
INSERT INTO `dishes` VALUES ('313', '鲜肉白菜饺', '137', '4.5', '242');
INSERT INTO `dishes` VALUES ('314', '鲜肉灌汤包', '137', '7', '186');
INSERT INTO `dishes` VALUES ('315', '鸡蛋煎包', '137', '6.5', '111');
INSERT INTO `dishes` VALUES ('316', '鸡蛋煎饺', '137', '6.5', '146');
INSERT INTO `dishes` VALUES ('317', '豆腐面/粉', '138', '4', '266');
INSERT INTO `dishes` VALUES ('318', '老坛酸菜面', '138', '4', '115');
INSERT INTO `dishes` VALUES ('319', '红烧鸡块面', '138', '8', '216');
INSERT INTO `dishes` VALUES ('320', '鱼香肉丝面', '138', '8', '206');
INSERT INTO `dishes` VALUES ('321', '香菇鸡汁面', '138', '6', '265');
INSERT INTO `dishes` VALUES ('322', '榨菜肉丝面', '138', '7', '133');
INSERT INTO `dishes` VALUES ('323', '牛肉面', '138', '12', '163');
INSERT INTO `dishes` VALUES ('324', '牛杂面', '138', '13', '147');
INSERT INTO `dishes` VALUES ('325', '素菜煲', '139', '12', '209');
INSERT INTO `dishes` VALUES ('326', '藤椒鸡煲', '139', '15', '176');
INSERT INTO `dishes` VALUES ('327', '片片鱼煲', '139', '18', '163');
INSERT INTO `dishes` VALUES ('328', '牛蛙煲', '139', '38', '184');
INSERT INTO `dishes` VALUES ('329', '排骨煲', '139', '28', '135');
INSERT INTO `dishes` VALUES ('330', '猪蹄煲', '139', '28', '244');
INSERT INTO `dishes` VALUES ('331', '地三鲜煲仔饭', '140', '9', '130');
INSERT INTO `dishes` VALUES ('332', '孜然土豆煲仔饭', '140', '9', '265');
INSERT INTO `dishes` VALUES ('333', '鱼香茄子煲仔饭', '140', '9', '197');
INSERT INTO `dishes` VALUES ('334', '香干肉丝煲仔饭', '140', '11', '263');
INSERT INTO `dishes` VALUES ('335', '酱香鸡柳煲仔饭', '140', '11', '236');
INSERT INTO `dishes` VALUES ('336', '农家小炒肉煲仔饭', '140', '11', '170');
INSERT INTO `dishes` VALUES ('337', '土豆鸡块煲仔饭', '140', '11', '128');
INSERT INTO `dishes` VALUES ('338', '红烧肥肠煲仔饭', '140', '12', '294');
INSERT INTO `dishes` VALUES ('339', '小炒鸡杂煲仔饭', '140', '12', '283');
INSERT INTO `dishes` VALUES ('340', '蒙古牛肉煲仔饭', '140', '13', '277');
INSERT INTO `dishes` VALUES ('341', '金牌烧鹅饭', '141', '10', '262');
INSERT INTO `dishes` VALUES ('342', '港式腊肠', '141', '9', '232');
INSERT INTO `dishes` VALUES ('343', '口水鸭饭', '141', '10', '179');
INSERT INTO `dishes` VALUES ('344', '黄金脆皮鸡', '141', '10', '222');
INSERT INTO `dishes` VALUES ('345', '酱香鸡', '141', '11', '264');
INSERT INTO `dishes` VALUES ('346', '原味手撕鸡', '141', '11', '113');
INSERT INTO `dishes` VALUES ('347', '港式叉烧', '141', '11', '252');
INSERT INTO `dishes` VALUES ('348', '火爆鱿鱼', '141', '12', '247');
INSERT INTO `dishes` VALUES ('349', '五香牛肉', '141', '12', '295');
INSERT INTO `dishes` VALUES ('350', '热狗炒蛋', '142', '9.5', '194');
INSERT INTO `dishes` VALUES ('351', '干煸泥鳅', '142', '11', '265');
INSERT INTO `dishes` VALUES ('352', '千页培根', '142', '9', '251');
INSERT INTO `dishes` VALUES ('353', '辣子鸡', '142', '12', '111');
INSERT INTO `dishes` VALUES ('354', '红烧鱼块', '142', '14', '101');
INSERT INTO `dishes` VALUES ('355', '川味肥肠', '142', '14', '208');
INSERT INTO `dishes` VALUES ('356', '霸王鸭', '142', '14', '238');
INSERT INTO `dishes` VALUES ('357', '糖醋鸡柳', '142', '11', '226');
INSERT INTO `dishes` VALUES ('358', '红油拉面/刀削面', '143', '5', '166');
INSERT INTO `dishes` VALUES ('359', '鸡蛋拉面/刀削面', '143', '7', '112');
INSERT INTO `dishes` VALUES ('360', '桂林牛肉米粉', '143', '12', '119');
INSERT INTO `dishes` VALUES ('361', '炸酱拉面/刀削面', '143', '8', '130');
INSERT INTO `dishes` VALUES ('362', '油泼面', '143', '8', '277');
INSERT INTO `dishes` VALUES ('363', '鸡蛋炒拉面/刀削面', '143', '8', '151');
INSERT INTO `dishes` VALUES ('364', '牛肉炒拉面/刀削面', '143', '12', '191');
INSERT INTO `dishes` VALUES ('365', '清炒小白菜', '144', '7', '170');
INSERT INTO `dishes` VALUES ('366', '红烧豆腐', '144', '7', '239');
INSERT INTO `dishes` VALUES ('367', '宫爆鸡丁', '144', '9', '108');
INSERT INTO `dishes` VALUES ('368', '韭菜鸡蛋', '144', '8', '255');
INSERT INTO `dishes` VALUES ('369', '千页豆腐肉丝', '144', '10', '104');
INSERT INTO `dishes` VALUES ('370', '金汁酸辣里脊', '144', '12', '244');
INSERT INTO `dishes` VALUES ('371', '红油牛肚', '144', '12', '260');
INSERT INTO `dishes` VALUES ('372', '土豆牛腩', '144', '13', '199');
INSERT INTO `dishes` VALUES ('373', '柳州螺蛳粉', '145', '9', '283');
INSERT INTO `dishes` VALUES ('374', '原味杂粮鱼粉', '145', '9', '116');
INSERT INTO `dishes` VALUES ('375', '酸辣鱼粉', '145', '10', '126');
INSERT INTO `dishes` VALUES ('376', '鱼丸鱼粉', '145', '8', '294');
INSERT INTO `dishes` VALUES ('377', '招牌鱼头粉', '145', '12', '279');
INSERT INTO `dishes` VALUES ('378', '茄汁鱼片粉', '145', '11', '241');
INSERT INTO `dishes` VALUES ('379', '红烧鸡块鱼粉', '145', '12', '167');
INSERT INTO `dishes` VALUES ('380', '香酥培根扒饭', '146', '9', '179');
INSERT INTO `dishes` VALUES ('381', '腊肠扒饭', '146', '9', '177');
INSERT INTO `dishes` VALUES ('382', '叉烧扒饭', '146', '10', '273');
INSERT INTO `dishes` VALUES ('383', '铁板烤肉扒饭', '146', '12', '254');
INSERT INTO `dishes` VALUES ('384', '牛腩扒饭', '146', '13', '263');
INSERT INTO `dishes` VALUES ('385', '黑椒牛柳扒饭', '146', '11.5', '213');
INSERT INTO `dishes` VALUES ('386', '绝味鸡块扒饭', '146', '12.5', '114');
INSERT INTO `dishes` VALUES ('387', '麻辣鸡丝扒饭', '146', '11.5', '195');

-- ----------------------------
-- Table structure for merchant
-- ----------------------------
DROP TABLE IF EXISTS `merchant`;
CREATE TABLE `merchant` (
  `merchantID` int(11) NOT NULL AUTO_INCREMENT,
  `merchantName` varchar(255) NOT NULL,
  `merchantPasswd` varchar(255) NOT NULL,
  `merchantPhone` char(15) NOT NULL,
  `canteenName` char(10) NOT NULL,
  PRIMARY KEY (`merchantID`)
) ENGINE=InnoDB AUTO_INCREMENT=147 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of merchant
-- ----------------------------
INSERT INTO `merchant` VALUES ('101', '温馨粥铺', '123456', '13277098986', '四食堂');
INSERT INTO `merchant` VALUES ('102', '旺旺炒面', '123456', '18365482624', '四食堂');
INSERT INTO `merchant` VALUES ('103', '盖浇饭', '123456', '18365482625', '四食堂');
INSERT INTO `merchant` VALUES ('104', '红油热干面', '123456', '18365482628', '四食堂');
INSERT INTO `merchant` VALUES ('105', '五谷杂粮粉', '123456', '18365482630', '四食堂');
INSERT INTO `merchant` VALUES ('106', '南京鸭血粉丝汤', '123456', '18365482631', '四食堂');
INSERT INTO `merchant` VALUES ('107', '山西手工面', '123456', '18365482632', '四食堂');
INSERT INTO `merchant` VALUES ('108', '手工鲜包', '123456', '18365482633', '四食堂');
INSERT INTO `merchant` VALUES ('109', '台湾饭团', '123456', '18365482634', '四食堂');
INSERT INTO `merchant` VALUES ('110', '台湾卤肉饭', '123456', '18365482636', '四食堂');
INSERT INTO `merchant` VALUES ('111', '东北水饺', '123456', '18365482597', '五食堂');
INSERT INTO `merchant` VALUES ('112', '淮南牛肉汤粉', '123456', '18365482598', '五食堂');
INSERT INTO `merchant` VALUES ('113', '重庆小面', '123456', '18365482599', '五食堂');
INSERT INTO `merchant` VALUES ('114', '鱼粉面热干面', '123456', '18365482600', '五食堂');
INSERT INTO `merchant` VALUES ('115', '水煮鱼', '123456', '18365482601', '五食堂');
INSERT INTO `merchant` VALUES ('116', '粤式烧腊', '123456', '18365482602', '五食堂');
INSERT INTO `merchant` VALUES ('117', '快乐铁板', '123456', '18365482603', '五食堂');
INSERT INTO `merchant` VALUES ('118', '黄焖鸡米饭', '123456', '18365482604', '五食堂');
INSERT INTO `merchant` VALUES ('119', '魔饭青年', '123456', '18365482605', '五食堂');
INSERT INTO `merchant` VALUES ('120', '嘿米牛肉饭', '123456', '18365482606', '五食堂');
INSERT INTO `merchant` VALUES ('121', '康乐特色炒饭', '123456', '18365482607', '五食堂');
INSERT INTO `merchant` VALUES ('122', '甜品粥铺', '123456', '18365482608', '五食堂');
INSERT INTO `merchant` VALUES ('123', '煎饼侠', '123456', '18365482609', '五食堂');
INSERT INTO `merchant` VALUES ('124', '裹然掉渣饼', '123456', '18365482610', '五食堂');
INSERT INTO `merchant` VALUES ('125', '奶茶', '123456', '18365482611', '八食堂');
INSERT INTO `merchant` VALUES ('126', '水吧', '123456', '18365482612', '八食堂');
INSERT INTO `merchant` VALUES ('127', '豆浆', '123456', '18365482613', '八食堂');
INSERT INTO `merchant` VALUES ('128', '豆腐花', '123456', '18365482614', '八食堂');
INSERT INTO `merchant` VALUES ('129', '一品香', '123456', '18365482615', '八食堂');
INSERT INTO `merchant` VALUES ('130', '汉派小吃', '123456', '18365482616', '八食堂');
INSERT INTO `merchant` VALUES ('131', '稀饭', '123456', '18365482617', '八食堂');
INSERT INTO `merchant` VALUES ('132', '风味饼屋', '123456', '18365482618', '八食堂');
INSERT INTO `merchant` VALUES ('133', '来一桶木桶饭', '123456', '18365482619', '八食堂');
INSERT INTO `merchant` VALUES ('134', '特色面', '123456', '18365482620', '八食堂');
INSERT INTO `merchant` VALUES ('135', '香酥鸡排饭', '123456', '18365482621', '八食堂');
INSERT INTO `merchant` VALUES ('136', '广州烧鹅饭', '123456', '18365482622', '八食堂');
INSERT INTO `merchant` VALUES ('137', '上海小笼包', '123456', '13993999701', '十食堂');
INSERT INTO `merchant` VALUES ('138', '襄阳牛肉面', '123456', '13993999702', '十食堂');
INSERT INTO `merchant` VALUES ('139', '鸡公煲', '123456', '13993999703', '十食堂');
INSERT INTO `merchant` VALUES ('140', '煲煲香', '123456', '13993999704', '十食堂');
INSERT INTO `merchant` VALUES ('141', '烧卤家族', '123456', '13993999705', '十食堂');
INSERT INTO `merchant` VALUES ('142', '面行人', '123456', '13993999706', '十食堂');
INSERT INTO `merchant` VALUES ('143', '川香烧肉饭', '123456', '13993999707', '十食堂');
INSERT INTO `merchant` VALUES ('144', '尚品面道', '123456', '13993999708', '十食堂');
INSERT INTO `merchant` VALUES ('145', '杂粮鱼粉', '123456', '13993999709', '十食堂');
INSERT INTO `merchant` VALUES ('146', '港式扒饭', '123456', '13993999710', '十食堂');

-- ----------------------------
-- Table structure for merchantadmi
-- ----------------------------
DROP TABLE IF EXISTS `merchantadmi`;
CREATE TABLE `merchantadmi` (
  `merchantAdmiID` int(11) NOT NULL AUTO_INCREMENT,
  `merchantAdmiPasswd` varchar(255) NOT NULL,
  `canteenName` char(15) NOT NULL,
  PRIMARY KEY (`merchantAdmiID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of merchantadmi
-- ----------------------------

-- ----------------------------
-- Table structure for orderdetails
-- ----------------------------
DROP TABLE IF EXISTS `orderdetails`;
CREATE TABLE `orderdetails` (
  `ODNum` int(11) NOT NULL AUTO_INCREMENT,
  `dishesID` int(11) NOT NULL,
  `dishesNum` int(11) NOT NULL,
  `priceSale` float NOT NULL,
  `orderID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ODNum`),
  KEY `dishesID` (`dishesID`),
  KEY `orderID` (`orderID`),
  CONSTRAINT `orderdetails_ibfk_1` FOREIGN KEY (`dishesID`) REFERENCES `dishes` (`dishesID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `orderdetails_ibfk_2` FOREIGN KEY (`orderID`) REFERENCES `orders` (`orderID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of orderdetails
-- ----------------------------

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
  `orderID` int(11) NOT NULL AUTO_INCREMENT,
  `customerID` int(11) NOT NULL,
  `merchantID` int(11) NOT NULL,
  `totalPrice` float DEFAULT NULL,
  `riderID` int(11) DEFAULT NULL,
  `orderTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `omState` tinyint(1) DEFAULT NULL,
  `orState` int(5) DEFAULT NULL,
  PRIMARY KEY (`orderID`),
  KEY `customerID` (`customerID`),
  KEY `merchantID` (`merchantID`),
  KEY `riderID` (`riderID`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`merchantID`) REFERENCES `merchant` (`merchantID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`riderID`) REFERENCES `rider` (`riderID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of orders
-- ----------------------------

-- ----------------------------
-- Table structure for rider
-- ----------------------------
DROP TABLE IF EXISTS `rider`;
CREATE TABLE `rider` (
  `riderID` int(11) NOT NULL AUTO_INCREMENT,
  `riderName` varchar(255) NOT NULL,
  `riderPasswd` varchar(255) NOT NULL,
  `riderPhone` char(15) NOT NULL,
  PRIMARY KEY (`riderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of rider
-- ----------------------------

-- ----------------------------
-- Table structure for shoppingcart
-- ----------------------------
DROP TABLE IF EXISTS `shoppingcart`;
CREATE TABLE `shoppingcart` (
  `customerID` int(11) NOT NULL,
  `merchantID` int(11) NOT NULL,
  `dishesID` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `priceSale` float NOT NULL,
  PRIMARY KEY (`customerID`,`merchantID`,`dishesID`),
  KEY `shoppingcart_ibfk_2` (`merchantID`),
  KEY `shoppingcart_ibfk_3` (`dishesID`),
  CONSTRAINT `shoppingcart_ibfk_1` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `shoppingcart_ibfk_2` FOREIGN KEY (`merchantID`) REFERENCES `merchant` (`merchantID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `shoppingcart_ibfk_3` FOREIGN KEY (`dishesID`) REFERENCES `dishes` (`dishesID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shoppingcart
-- ----------------------------

-- ----------------------------
-- Table structure for systemadmi
-- ----------------------------
DROP TABLE IF EXISTS `systemadmi`;
CREATE TABLE `systemadmi` (
  `systemAdmiID` int(11) NOT NULL,
  `systemAdmiPasswd` varchar(255) NOT NULL,
  PRIMARY KEY (`systemAdmiID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of systemadmi
-- ----------------------------

-- ----------------------------
-- Table structure for test
-- ----------------------------
DROP TABLE IF EXISTS `test`;
CREATE TABLE `test` (
  `id` int(11) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '数据插入时间',
  `temp` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of test
-- ----------------------------
INSERT INTO `test` VALUES ('1', '2020-12-17 19:38:01', null);
INSERT INTO `test` VALUES ('2', '2020-12-17 19:42:25', null);
INSERT INTO `test` VALUES ('3', '2020-12-17 20:13:50', '0');
INSERT INTO `test` VALUES ('4', '2020-12-17 20:14:10', '0');
