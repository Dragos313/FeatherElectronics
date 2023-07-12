create table tblAdmin
(
AdminID nvarchar(50) primary key,
[Password] nvarchar(50),
FullName nvarchar(50)
)

select * from tblAdmin

select top 1 AdminID,Password,FullName from tblAdmin where AdminID=@AdminID and Password=@Password

create table tblVanzator
(
IDVanzator int identity(1,1) primary key,
NumeVanzator nvarchar(50) Unique,
VarstaVanzator int,
TelefonVanzator nvarchar(10),
ParolaVanzator nvarchar(50)
)

select * from tblVanzator

select top 1 NumeVanzator,ParolaVanzator from tblVanzator where NumeVanzator=@NumeVanzator and ParolaVanzator=@ParolaVanzator


create table tblCategorie
(
tblCategorie int identity(1,1) primary key not null,
NumeCategorie nvarchar(50),
DescCategorie nvarchar(50)
)

create procedure adaugareCategorie
(
@NumeCategorie nvarchar(50),
@DescCategorie nvarchar(50)
)
as
begin
insert into tblCategorie (NumeCategorie,DescCategorie) values(@NumeCategorie,@DescCategorie)
end
------
select  IDCategorie as CategoryID,NumeCategorie,DescCategorie as CategoryDescription from tblCategorie

------

create procedure actalizareCategorie
(
@IDCategorie int,
@NumeCategorie nvarchar(50),
@DescCategorie nvarchar(50)
)
as
begin
update tblCategorie set NumeCategorie=@NumeCategorie,DescCategorie=@DescCategorie where IDCategorie=@IDCategorie
end
-----


create procedure stergeCategorie 
(
@IDCategorie int 
)
as
begin
Delete from tblCategorie where IDCategorie=@IDCategorie
end

create procedure adaugareVanzator
(
@NumeVanzator nvarchar(50),
@VarstaVanzator int, 
@TelefonVanzator nvarchar(50),
@ParolaVanzator nvarchar(50)
)
as
begin
insert into tblVanzator(NumeVanzator,VarstaVanzator,TelefonVanzator,ParolaVanzator) values(@NumeVanzator,@VarstaVanzator,@TelefonVanzator,@ParolaVanzator)
end
go
---------
create procedure actualizareVanzator
(
@IDVanzator int,
@NumeVanzator nvarchar(50),
@VarstaVanzator int, 
@TelefonVanzator nvarchar(50),
@ParolaVanzator nvarchar(50)
)
as
begin
update tblVanzator set =@NumeVanzator,VarstaVanzator=@VarstaVanzator,TelefonVanzator=@TelefonVanzator,ParolaVanzator=@ParolaVanzator where IDVanzator=@IDVanzator
end
go
----------
create procedure stergeVanzator
(
@IDVanzator int 
)
as
begin
Delete from tblVanzator where IDVanzator=@IDVanzator
end
go

select * from tblAdmin
select AdminID from tblAdmin where AdminID='Coder'


create procedure adaugaAdmin
(
@AdminID nvarchar(50),
@Password nvarchar(50),
@FullName nvarchar(50)
)
as
begin
Insert into tblAdmin(AdminID,[Password],FullName) values(@AdminID,@Password,@FullName)
end
go

----
create procedure actualizeazaAdmin
(
@AdminID nvarchar(50),
@Password nvarchar(50),
@FullName nvarchar(50)
)
as
begin
update tblAdmin set [Password]=@Password,FullName=@FullName where AdminID=@AdminID
end
go

select * from tblAdmin
---
create procedure stergeAdmin
(
@AdminID nvarchar(50)
)
as
begin
delete tblAdmin where AdminID=@AdminID
end
go

--

create table tblProduse
(
IdProdus int identity(1,1) primary key not null,
NumeProdus nvarchar(50),
IdCatProdus int,
PretProdus decimal(10,2),
CantitateProdus int,
)

create procedure getCategorie
as
begin
set nocount on;
select IDCategorie,NumeCategorie from tblCategorie order by NumeCategorie asc
end
go

create procedure verificaDublareProdus
(
@NumeProdus nvarchar(50),
@IdCatProdus int
)
as
begin
set nocount on;
select NumeProdus from tblProduse where NumeProdus=@NumeProdus and IdCatProdus=@IdCatProdus
end
go
----
create procedure adaugareProdus
(
@NumeProdus nvarchar(50),
@IdCatProdus int,
@PretProdus decimal(10,2),
@CantitateProdus int
)
as
begin
 
Insert into tblProduse(NumeProdus,IdCatProdus,PretProdus,CantitateProdus) values(@NumeProdus,@IdCatProdus,@PretProdus,@CantitateProdus)
end
go

----

create procedure getToateProdusele
as
begin
set nocount on;
select t1.IdProdus,t1.NumeProdus,t2.NumeCategorie,t1.IdCatProdus as IdCategorie,t1.PretProdus,t1.CantitateProdus from tblProduse as t1
inner join tblCategorie as t2 on t1.IdCatProdus=t2.IDCategorie
order by t1.NumeProdus,t2.NumeCategorie asc
end
go

---

create procedure ActualizareProdus
(
@IdProdus int,
@NumeProdus nvarchar(50),
@IdCatProdus int,
@PretProdus decimal(10,2),
@CantitateProdus int
)
as
begin
 
update tblProduse set NumeProdus=@NumeProdus,IdCatProdus=@IdCatProdus,PretProdus=@PretProdus,CantitateProdus=@CantitateProdus where IdProdus=@IdProdus
end
go

---
create procedure stergeProdus
(
@IdProdus Int
)
as
begin
 
delete from tblProduse where IdProdus=@IdProdus
end
go

create procedure getProduse_DupaCategorie
(
@IdCatProdus int
)
as
begin
set nocount on;
select t1.IdProdus,t1.NumeProdus,t2.NumeCategorie,t1.IdCatProdus as IdCategorie,t1.PretProdus,t1.CantitateProdus from tblProduse as t1
inner join tblCategorie as t2 on t1.IdCatProdus=t2.IDCategorie
where t1.IdCatProdus=@IdCatProdus
order by t1.NumeProdus,t2.NumeCategorie asc
end
go

create table tblVanzare
(
IdFactura int primary key,
IdVanzator nvarchar(50),
DataVanzare nvarchar(50),
Total decimal(18,2)
)

create procedure adaugaFactura
(
@IdFactura int,
@IdVanzator nvarchar(50),
@DataVanzare nvarchar(50),
@Total decimal(18,2)
)
as
begin
insert into tblVanzare (IdFactura,IdVanzator,DataVanzare,Total) values(@IdFactura,@IdVanzator,@DataVanzare,@Total)
end
go
---

create procedure getFactura
as
begin
set nocount on;
select IdFactura,IdVanzator,DataVanzare,Total from tblVanzare order by IdFactura desc 
end
go