use ProjetoLoja
go
insert into TipoPessoa values('Fisica'),('Juridica')
go
insert into TipoUsuario values('Administrador'),('Vendedor')

insert into Pessoa values('Jeferson','teste@teste.com',2)

insert into Usuario values(1,'123',1)

insert into TipoTransacao
values ('Entrada'), ('Saída')

insert into Pessoa
values ('admin', 'admin@admin.com', 1)

insert into PessoaFisica
values (2, '00000000000', 'MG11111111')

insert into Pessoa
values ('Fornecedor 02', 'fornecedor02@fornecedor02.com', 2), ('Fornecedor 03', 'fornecedor03@fornecedor03.com', 2), ('Fornecedor 04', 'fornecedor04@fornecedor04.com', 2), ('Fornecedor 05', 'fornecedor05@fornecedor05.com', 2)

insert into Usuario
values (2, 'admin', 1)

insert into Marca
values ('Marca 01'), ('Marca 02')

insert into Modelo
values ('Modelo 01', 1), ('Modelo 02', 2)

insert into StatusTransacao
values ('Ok'), ('Cancelada')

insert into Transacao
values (GETDATE(), 0, 1, 1, 1, 2)