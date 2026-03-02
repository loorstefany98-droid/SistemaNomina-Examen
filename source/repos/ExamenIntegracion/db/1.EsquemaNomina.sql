create database empresa;
use empresa;

create table departments (
dept_no int primary key identity(1,1),
dept_name varchar(50) not null unique
);
GO

create table employees (
emp_no int primary key identity(1,1),
ci varchar(50) not null unique,
birth_date varchar(50) not null,
first_name varchar(50) not null,
last_name varchar(50) not null,
gender char(1) not null,
hire_date varchar(50) not null,
correo varchar(100) null,
constraint CK_employees_gender check (gender in ('M', 'F'))
);
GO

create table dept_emp (
emp_no int not null,
dept_no int not null,
from_date varchar(50) not null,
to_date varchar(50) not null,
primary key (emp_no, dept_no),
constraint FK_dept_emp_employees
foreign key (emp_no) references employees(emp_no),
constraint FK_dept_emp_departments
foreign key (dept_no) references departments(dept_no)
);
GO

create table dept_manager (
emp_no int not null,
dept_no int not null,
from_date varchar(50) not null,
to_date varchar(50) not null,
primary key (emp_no, dept_no),
constraint FK_dept_manager_employees
foreign key (emp_no) references employees(emp_no),
constraint FK_dept_manager_departments
foreign key (dept_no) references departments(dept_no)
);
Go

create table users (
emp_no int primary key,
usuario varchar(100) not null unique,
clave varchar(100) not null,
constraint FK_users_employees
foreign key (emp_no) references employees(emp_no)
);
GO

create table salaries (
emp_no int not null,
salary bigint not null,
from_date varchar(50) not null,
to_date varchar(50) null,
primary key (emp_no, from_date),
constraint FK_salaries_employees
foreign key (emp_no) references employees(emp_no)
);
GO

create table titles (
emp_no int not null,
title varchar(90) not null,
from_date varchar(50) not null,
to_date varchar(50) null,
primary key (emp_no, title, from_date),
constraint FK_titles_employees
foreign key (emp_no) references employees(emp_no)
);
GO

create table log_AuditoriaSalarios (
id int primary key identity(1,1),
usuario varchar(50) not null,
fechaActualiz date not null default getdate(),
DetalleCambio varchar(250) not null,
salario bigint not null,
emp_no int not null,
constraint FK_log_auditoria_emplyees
foreign key (emp_no) references employees(emp_no)
);
GO