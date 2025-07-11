use Dbbatch12
create table tbEmployee(
 eid int primary key identity (1,1),
 ename nvarchar(50),
 age int,
 emobileno nvarchar(50),
 epost nvarchar(40),
 esalary decimal(20,2)
)
select * from tbEmployee

insert into  tbEmployee(ename,age,emobileno,epost,esalary) values('ram',25,'255266512','SE',524000.25)
insert into tbEmployee(ename , age, emobileno, epost,esalary)values('Shyam', 23,'6826639','Dev',4582)
insert into tbEmployee(ename , age, emobileno, epost,esalary)values('Ankit', 21,'6826659','SE',58615)
insert into  tbEmployee(ename,age,emobileno,epost,esalary) values('Suman',22,'255266512','It',524000.25)
insert into tbEmployee(ename , age, emobileno, epost,esalary)values('Deepak', 26,'6826639','Manager',4582)
insert into tbEmployee(ename , age, emobileno, epost,esalary)values('rahul', 26,'6826659','Po',58615)

--waq to get the record of employee whose eid is 2.
select * from tbEmployee where eid=2;

--waq to get the record of specfic column ename or epost.
select ename,epost from tbEmployee


select ename,epost from tbEmployee where eid = 4;
select ename,epost from tbEmployee where eid = 4 or eid = 3;