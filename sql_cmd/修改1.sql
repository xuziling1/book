USE SECOND_BOOK
GO
exec sp_rename 'TBook.UserID','Username'
ALTER TABLE TBook ALTER COLUMN Username varchar(12)
UPDATE TBook SET Username = '����' where BookID='2006001'
UPDATE TBook SET Username = '����' where BookID='2006002'