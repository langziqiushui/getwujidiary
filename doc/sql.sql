
create database diary
go

use diary
go

create table diary
(
Id varchar(36) primary key,
[address] nvarchar(100),
[key] varchar(max),
[weekday] nvarchar(10),
weather nvarchar(30),
content nvarchar(max),
createDate datetime,
CJTime datetime default getdate()
)
go

select * from diary order by createDate desc

--delete diary 

print datediff(day,'2016-09-18','2017-06-24')