USE SECOND_BOOK
GO
exec sp_rename 'TBook.UserID','Username'
ALTER TABLE TBook ALTER COLUMN Username varchar(12)
UPDATE TBook SET Username = '王五' where BookID='2006001'
UPDATE TBook SET Username = '李四' where BookID='2006002'