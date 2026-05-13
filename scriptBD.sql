create database dbEmprestimo;
use dbEmprestimo;

create table tbUsuario(
codUsu int primary key auto_increment,
nomeUsu varchar(50)
);

create table tbLivro(
codLivro int primary key auto_increment,
nomeLivro varchar(50),
imagemLivro varchar(255)
);

create table tbEmprestimo(
codEmp int primary key auto_increment,
dataEmp varchar(20),
dataDev varchar(20),
codUsu int references tbUsuario(codUsu)
);

create table itensEmp(
codItem int primary key auto_increment,
codEmp int references tbEmprestimo(codEmp),
codLivro int references tbLivro(codLivro)
);

create table Categoria(
Id int primary key auto_increment,
Nome varchar(50)
);

select * from tbLivro;

insert into tbUsuario values (default, 'Nilson'),(default, 'Bruno');