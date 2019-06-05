
--CREATE DATABASE SECOND_BOOK 

USE SECOND_BOOK
GO
CREATE TABLE TUser
(Username nvarchar(12)PRIMARY KEY NOT NULL,
Password varchar(12) NOT NULL,
QQ varchar(10),
Tel varchar(15) NOT NULL,
Photo varbinary(MAX),
Email varchar(40),
Admin int);

USE SECOND_BOOK
GO
CREATE TABLE TOnline
(Username varchar(10) PRIMARY KEY NOT NULL,
Admin int);

USE SECOND_BOOK
GO
CREATE TABLE TBook
(BookID varchar(10) PRIMARY KEY NOT NULL,
ISBN varchar(10) NOT NULL,
Bookname nvarchar(12) NOT NULL,
Author nvarchar(12),
Publisher nvarchar(12),
Photo varbinary(MAX),
Summary ntext,
UserID varchar(10) NOT NULL,
Price float NOT NULL,
Category nvarchar(12));

USE SECOND_BOOK
GO
CREATE TABLE TFavorite
(Username nvarchar(12)PRIMARY KEY NOT NULL,
BookID varchar(10));

INSERT INTO TUser(Username,Password,QQ,Tel,Email,Admin) VALUES
('张三','zhangsan','118118118','17312341234','118118118@qq.com',1),
('李四','lisi','119119119','18212341234','lisi@sina.com',0),
('王五','wangwu','120120120','18012341234','wangwu@163.com',0);

INSERT INTO TBook
(BookID,ISBN,Bookname,Author,Publisher,Summary,UserID,Price) VALUES
('2006001','200600101','小王子','埃克苏佩里','北京邮电出版社','法国儿童文学短篇童话','2016100002',15),
('2006002','200600101','简爱','夏洛蒂勃朗特','人民文学出版社','长篇小说','201610002',10);
