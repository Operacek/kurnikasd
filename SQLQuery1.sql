select max(id) from [vejce] where Datum =(select max(Datum) from [vejce] where Datum like '2022-04-17')
select * from [vejce]