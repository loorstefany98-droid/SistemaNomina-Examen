-- Script de Creación de Tablas Iniciales para el Sistema de Nómina

-- 1. Tabla de Departamentos
CREATE TABLE departments (
    dept_no INT PRIMARY KEY,
    dept_name VARCHAR(50) NOT NULL
);

-- 2. Tabla de Empleados
CREATE TABLE employees (
    emp_no INT PRIMARY KEY,
    ci VARCHAR(30) NOT NULL,
    birth_date VARCHAR(50) NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    gender CHAR(1) NOT NULL,
    hire_date VARCHAR(50) NOT NULL,
    correo VARCHAR(100)
);