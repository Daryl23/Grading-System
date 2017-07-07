DROP DATABASE Student
create database Student
Use Student
create table StudentInfo(
StudentID int not null primary key,
Student_Last_name nvarchar(max),
Student_First_name nvarchar(max),
Student_Middle_name nvarchar(max),
Academic_Year_Started nvarchar(max),
Student_Address nvarchar(max),
DOB date,
POB nvarchar(max),
Civil_Status nvarchar(max),
Citizenship nvarchar(max),
Gender nvarchar(max),
Father_Name nvarchar(max),
Mother_Name nvarchar(max),
Contact_Number nvarchar(max),
Date_Of_Baptism nvarchar(max),
Place_Of_Baptism nvarchar(max),
Date_Of_Confirmation nvarchar(max),
Place_Of_Confirmation nvarchar(max),
Date_Of_Parents_Marriage nvarchar(max),
Date_Of_Installation_Lectorate nvarchar(max),
Place_Of_Installation_Lectorate nvarchar(max),
Date_Of_Installation_Acolyte nvarchar(max),
Place_Of_Installation_Acolyte nvarchar(max),
Date_Of_Diaconate_Ordination nvarchar(max),
Place_Of_Diaconate_Ordination nvarchar(max),
Date_Of_Priesthood_Ordination nvarchar(max),
Place_Of_Priesthood_Ordination nvarchar(max),
Elementary nvarchar(max),
Highschool nvarchar(max),
College nvarchar(max),   
Birth_Certificate nvarchar(max),
Baptismal_Certificate nvarchar(max),
Confirmation_Certificate nvarchar(max),
Marriage_Certificate nvarchar(max),
Medical_Certificate nvarchar(max),
TOR nvarchar(max),
)
select * from StudentInfo 
insert into StudentInfo 
values
(
1, 
'Carreon', 
'Froilan Jr.,',
'C.', 
'AY 2003-2004', 
'Poblacion, Rosario, Batangas', 
'1982-06-08', 
'Rosario, Batangas', 
'Single', 
'Filipino', 
'Male', 
'Froilan Carreon Sr.', 
'Josie Carreon', 
'', 
'1982-10-03', 
'Rosario, Batangas', 
'1993-03-13', 
'Rosario, Batangas', 
'1981-04-22', 
'', 
'', 
'', 
'', 
'', 
'', 
'', 
'', 
'', 
'', 
'', 
'TO FOLLOW', 
'TO FOLLOW', 
'TO FOLLOW', 
'TO FOLLOW', 
'RECEIVED', 
'TO FOLLOW'
);

select * from StudentInfo 

insert into StudentInfo 
values
(
3, 
'Casquejo', 
'Ismael',
'',
'AY 2003-2004', 
'', 
'1979-06-06', 
'Tanauan, Batangas', 
'Single', 
'Filipino', 
'Male', 
'Nazario Cascuejo', 
'Teresita Consultado', 
'', 
'', 
'', 
'1989-12-02', 
'Tanauan, Batangas', 
'1963-05-05', 
Null, 
'', 
Null, 
'', 
Null, 
'', 
Null, 
'', 
'', 
'', 
'', 
'RECEIVED', 
'TO FOLLOW', 
'TO FOLLOW', 
'TO FOLLOW', 
'TO FOLLOW', 
'TO FOLLOW'
);


select * from StudentInfo


/*CONVERT(datetime ,'', 103)*/


/*filenames: sfsts_students
	databasename: Student
	tablename: StudentInfo
*/

create table StudentInfoArchive(
StudentID int not null primary key,
Student_Last_name nvarchar(max),
Student_First_name nvarchar(max),
Student_Middle_name nvarchar(max),
Academic_Year_Started nvarchar(max),
Student_Address nvarchar(max),
DOB date,
POB nvarchar(max),
Civil_Status nvarchar(max),
Citizenship nvarchar(max),
Gender nvarchar(max),
Father_Name nvarchar(max),
Mother_Name nvarchar(max),
Contact_Number nvarchar(max),
Date_Of_Baptism nvarchar(max),
Place_Of_Baptism nvarchar(max),
Date_Of_Confirmation nvarchar(max),
Place_Of_Confirmation nvarchar(max),
Date_Of_Parents_Marriage nvarchar(max),
Date_Of_Installation_Lectorate nvarchar(max),
Place_Of_Installation_Lectorate nvarchar(max),
Date_Of_Installation_Acolyte nvarchar(max),
Place_Of_Installation_Acolyte nvarchar(max),
Date_Of_Diaconate_Ordination nvarchar(max),
Place_Of_Diaconate_Ordination nvarchar(max),
Date_Of_Priesthood_Ordination nvarchar(max),
Place_Of_Priesthood_Ordination nvarchar(max),
Elementary nvarchar(max),
Highschool nvarchar(max),
College nvarchar(max),   
Birth_Certificate nvarchar(max),
Baptismal_Certificate nvarchar(max),
Confirmation_Certificate nvarchar(max),
Marriage_Certificate nvarchar(max),
Medical_Certificate nvarchar(max),
TOR nvarchar(max),
)


select * from StudentInfoArchive 
select * from StudentInfo

CREATE TABLE StudentCourse (
  courseid int IDENTITY(1,1) PRIMARY KEY,
  coursecode varchar(20) NOT NULL,
  coursename varchar(70) NOT NULL,
  coursehr int NOT NULL,
  yearlevel int NOT NULL,
  semester int NOT NULL) 

--
-- Dumping data for table `tblcourse`
--

INSERT INTO StudentCourse ( coursecode, coursename, coursehr, yearlevel, semester) VALUES
('Scr 114', 'Biblical Languages', 3, 1, 1),
( 'Thed 103', 'Introduction to Theology', 2, 1, 1),
( 'Hist 131', 'The Church in Ancient Times', 3, 1, 1),
( 'Lit 127', 'Principles and Norms of Liturgy', 3, 1, 1),
( 'Thef 106.1', 'Fundamental of Ecclesiology & Magisterium', 2, 1, 1),
( 'Meth 101', 'Methods of Theological Research', 2, 1, 1),

( 'Them 122.1', 'Fundamental Moral Theology 1', 3, 1, 2),
( 'Lat 145', 'Ecclesiastical Latin I', 2, 1, 2),
( 'Scr 114b', 'Greek', 3, 1, 2),
( 'Thed 105', 'Theology of God, One And Triune', 3, 1, 2),
( 'Thef 104', 'Theology of Revelation', 3, 1, 2),

( 'Meth 102', 'Thesis Seminar', 2, 1, 3),
( 'Them 122.2', 'Fundamental Moral Theology II', 3, 1, 3),
( 'Thep 138.1', 'Mass Communication for Evangelization I', 2, 1, 3),
( 'Lit 128', 'The Sanctification of Time', 2, 1, 3),
( 'Lat 146', 'Ecclesiastical Latin II', 2, 1, 3),
( 'Scr 115', 'Introduction to Sacred Scriptures', 3, 1, 3),

( 'Scr 116', 'The Pentateuch and Historical Books', 3, 2, 1),
( 'Thed 107.1', 'Theological Anthropology I: Creation & Sin', 3, 2, 1),
( 'Thed 108.1', 'Christology', 3, 2, 1),
( 'Them 123', 'The Theological Virtues', 3, 2, 1),
( 'Pat 135', 'The Ante-Nicene Fathers', 3, 2, 1),
( 'Thep 138.2', 'Mass Communication for Evangelization II', 2, 2, 1),

( 'Hist 132', 'The Church in Medieval Times', 3, 2, 2),
( 'Thed 107.2', 'Theological Anthropology II: Grace', 3, 2, 2),
( 'Thef 106.2', 'Ecclesiology', 3, 2, 2),
( 'Thed 109', 'Mariology', 2, 2, 2),
( 'Thed 110.3', 'Ecumenism', 2, 2, 2),
( 'Thed 108.2', 'Soteriology', 2, 2, 2),

( 'Them 124', 'The Moral Virtues', 3, 2, 3),
( 'Them 125.1', 'Justice and Human Development', 3, 2, 3),
( 'Hist 133', 'The Church in Modern Times', 3, 2, 3),
( 'Pat 136', 'The Post-Nicene Fathers', 3, 2, 3),
( 'Scr 117', 'The Sy
noptic and Gospel Acts', 3, 2, 3),

( 'Scr 118', 'The Sapiential Books', 2, 3, 1),
( 'Scr 119', 'Prophetic Books', 2, 3, 1),
( 'Thed 110.1', 'Missiology', 2, 3, 1),
( 'Thes 111.1', 'Theology of Sacraments in General', 3, 3, 1),
( 'Them 125.3', 'Contemporary Moral Problems Related to Human Life', 3, 3, 1),
( 'Can 140', 'Introduction to Canon Law', 2, 3, 1),

('Scr 120', 'The Johannine Writings', 2, 3, 2),
( 'Scr 121', 'Apuline and Catholic Epistles', 2, 3, 2),
( 'Thed 110.2', 'Theology of Church Ministries', 2, 3, 2),
( 'Arch 137', 'Christian Archaeology', 1, 3, 2),
( 'Thes 111.2', 'Theology of Sacraments of Initiation', 2, 3, 2),
( 'Them 125.2', 'Sexual & Medical Ethics', 3, 3, 2),
( 'Can 141', 'Canon Law 1', 3, 3, 2),

( 'Hist 134', 'Philippine Church History', 3, 3, 3),
( 'Thes 111.3', 'Theology of Sacraments of Healing', 3, 3, 3),
( 'Thes 111.4', 'Theology of the Eucharist', 2, 3, 3),
( 'Thesp 144', 'Spiritual Theology', 2, 3, 3),
( 'Thed 112', 'Eschatology', 3, 3, 3),
( 'Can 142', 'Canon Law 2', 3, 3, 3),
/*Hindi Kasali
( 'Scr 118', 'The Sapiential Books', 2, 4, 1),
( 'Scr 119', 'Prophetic Books', 2, 4, 1),
*/
( 'Thep 138.3', 'Homilectic I: Theory and Praxis', 2, 4, 1),
( 'Lit 129', 'Liturgy of the Sacraments & Sacramentals', 2, 4, 1),
( 'Thes 111.5', 'Theology of Holy Orders', 3, 4, 1),
( 'Thes 111.6', 'Theology of Marriage', 1, 4, 1),
( 'Them 126', 'Moral Problems Related to the Sacraments/Ad Audiendas', 3, 4, 1),
/*Hindi Kasali
( 'Scr 120', 'The Johannine Writings', 2, 4, 2),
( 'Scr 121', 'Pauline and Catholic Epistles', 2, 4, 2),
*/
( 'Can 143', 'Canon Law on Marriage', 3, 4, 2),
( 'Thed 113', 'Dogmatic Synthesis/De Universa', 2, 4, 2),
( 'Thep 139.1', 'Pastoral Theology', 3, 4, 2),

( 'Thep 138.4', 'Homilectic II: Praxis', 2, 4, 3),
( 'Thesp 139.2', 'Parish Administration: Theory & Praxis', 3, 4, 3),
( 'Lit 130', 'Liturgy of the Mass: Theory & Praxis', 2, 4, 3);

-- --------------------------------------------------------

--
-- Table structure for table `tblgrade`
--

CREATE TABLE StudentGrade (
  gradeid int IDENTITY(1,1) PRIMARY KEY,
  studentid int NOT NULL,
  courseid int NOT NULL,
  grade decimal(3,2) NOT NULL
) 

SELECT distinct (Student_Last_name + ' ' + Student_First_name + ' '
 + Student_Middle_name) 
As StudentName,StudentInfo.StudentID As studentid
 FROM StudentInfo
 WHERE charindex( 'b',Student_Last_name)!=0
 
 
 SELECT StudentGrade.courseid 
 As courseid,coursecode,coursename,coursehr,grade 
 FROM StudentGrade,StudentCourse 
 WHERE StudentGrade.courseid=StudentCourse.courseid 

 AND yearlevel='1'  
 AND semester='1' 
 GROUP BY yearlevel,semester,StudentGrade.courseid,coursecode,coursename,coursehr,grade 
 
  AND StudentID='" & StudNo & "' 
  Select * FROM StudentGrade
  
  SELECT Student_Last_name,Student_Last_name,Student_Middle_name 
  FROM StudentInfo,StudentGrade 
  WHERE StudentInfo.StudentID=StudentGrade.StudentID
  
  Select * from StudentGrade
  Select * from studentinfo
  DElete from StudentGrade where StudentID=1
  Select * from StudentCourse