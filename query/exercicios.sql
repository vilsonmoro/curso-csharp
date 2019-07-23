--Trazer somente as marcas que Felipe cadastrou
select *
from marcas m
where m.UsuInc = (select u.id from usuarios u
                  where u.Usuario like 'Felipe')

go 

--Trazer somente as marcas que Giomar cadastrou
select count(*) as 'Quantidade'
from marcas m
where m.UsuInc = 1
order by 'Quantidade' desc;

go 

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select count(*) as 'Quantidade'
from marcas m
where m.UsuInc = 2 or m.UsuInc = 1
order by 'Quantidade' asc;

--Trazer somente os carros que Felipe cadastrou
select c.Modelo
from carros c
inner join Usuarios u on u.id = c.UsuInc
where u.Usuario = 'Felipe';

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select sum(v.quantidade) as 'Qtde', count(v.quantidade) as 'Count'
from vendas v
where v.UsuInc = 2;

--Trazer o valor total de vendas 2019 isolado
select year(v.DatInc) as 'ano',  sum(v.Quantidade) as 'Qtde'
from vendas v
where year(v.DatInc)=2019
group by year(v.DatInc)

--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
select year(v.DatInc) as 'ano', month(v.DatInc) as 'Mês', sum(v.Quantidade)
from vendas v
group by year(v.DatInc), month(v.DatInc)


select m.Nome, count(*) as 'Qtde'
from marcas m
inner join carros c on c.Marca = m.Id
where m.UsuInc = 1
group by m.nome;

select top 1 c.Modelo, sum(v.Quantidade) as 'Qtde'
from vendas v
inner join carros c on v.Carro = c.id
group by c.Modelo
order by [Qtde] desc

select top 3 c.Modelo, sum(v.Valor) as 'Qtde'
from vendas v
inner join carros c on v.Carro = c.id
group by c.Modelo
order by [Qtde] desc


--Trazer  a marca mais vendida de todos os anos
select top 1 m.Nome, sum(v.Quantidade) as 'Qtde'
from vendas v
inner join carros c on v.Carro = c.id
inner join marcas m on c.Marca = m.id
group by m.Nome
order by [Qtde] desc

--Trazer  a marca mais vendida de todos os anos
select top 1 m.Nome, sum(v.Valor) as 'Valor'
from vendas v
inner join carros c on v.Carro = c.id
inner join marcas m on c.Marca = m.id
group by m.Nome
order by [Valor] desc

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select u.Usuario,  sum(v.Quantidade) as 'Qtde'
from vendas v
inner join usuarios u on v.UsuInc = u.Id
group by u.Usuario
order by [Qtde] desc

go
--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select u.Usuario, sum(v.Valor) as 'R$ Total'
from vendas v
inner join usuarios u on v.UsuInc = u.Id
group by u.Usuario
order by [R$ Total] asc;