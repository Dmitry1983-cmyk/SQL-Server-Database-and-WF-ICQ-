create database ICQ_DB;

use ICQ_DB;

create table User_Data(
Id int identity primary key,
[Name] varchar(25),
[LastName] varchar(25),
[NickName] varchar(25),
PhoneNumber varchar(15),
[Mail] varchar(25)
);

create table Photo_table(
Id int identity primary key,
Photo image,
PhotoId int
constraint FK_Photo_table_to_User_Data foreign key(PhotoId) references User_Data(Id)
);

create table LoginPassword(
Id int identity primary key,
[Login] varchar(20),
[Password] varchar(20),
UserId int,
constraint FK_LoginPassword_to_User_Data foreign key(UserId) references User_Data(Id) 
);

drop table LoginPassword
drop table User_Data

insert into User_Data([Name],[LastName],[NickName],PhoneNumber,[Mail]) values('Name','Last Name','NickName','123456789012345','test@mail.com');
insert into LoginPassword([Login],[Password]) values('TestLogin','TestPass');

select * from User_Data join LoginPassword on User_data.Id=LoginPassword.Id join Photo_table on LoginPassword.Id=Photo_table.Id /* 3 in 1 */


select *from User_Data
select *from LoginPassword 
select *from Photo_table 

select [NickName] from User_Data join LoginPassword on User_data.Id=LoginPassword.Id join Photo_table on LoginPassword.Id=Photo_table.Id where [Login] != 'петя123'

Select [Name] From User_Data where ([Name] = 'Иван'or [Name] = 'Петя')
Select [Name] From User_Data where ([Name] <> 'Иван')

select * from User_Data join LoginPassword on User_data.Id=LoginPassword.Id join Photo_table on LoginPassword.Id=Photo_table.Id where ([Login]<>'петя123') /*тут работает запрос, не работает в VS*/