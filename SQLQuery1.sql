select epost,count(*) as TotalEmployee from tbEmployee group by epost

select epost,Sum(esalary) as TotalSalary from tbEmployee group by epost

select epost,count(*) TotalEmployee ,Sum(esalary) as TotalSalary from tbEmployee group by epost




