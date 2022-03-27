create table Student(
StudId int,
Sname varchar(20),
Dob DateTime
);

create table Course_Details
(Cid int, 
Cname varchar(20), 
Cduration int, 
Ccourse varchar, 
Cfees int, 
Clevel varchar(20), 
Cplacement varchar(20), 
Ctype varchar(20), 
choice int, 
Monthlyfee varchar(30)
);

create table EnrollDet
(Sid int,
Cid int,
endate DateTime);

create procedure student
@StudId int,
@Sname varchar(20),
@Dob DateTime
as
Begin
Insert into Student(StudId,Sname,Dob) values(@StudId,@Sname,@Dob)
End
select * from Student;

create procedure Course_Detail
@Cid int, 
@Cname varchar(20), 
@Cduration int, 
@Ccourse varchar, 
@Cfees int, 
@Clevel varchar(20), 
@Cplacement varchar(20),
@Ctype varchar(20), 
@choice int, 
@Monthlyfee varchar(30)
as
Begin
Insert into Course_Details(Cid,Cname,Cduration,Ccourse,Cfees,Clevel,Cplacement,Ctype,choice,Monthlyfee) values(@Cid,@Cname,@Cduration,@Ccourse,@Cfees,@Clevel,@Cplacement,@Ctype,@choice,@Monthlyfee)
End
select * from Course_Details;


Create Procedure EnrollmentDet
@Sid int,
@Cid int,
@endate DateTime
as
Begin
Insert into EnrollDet(Sid,Cid,endate) values(@Sid,@Cid,@endate)
End
select * from EnrollDet;


