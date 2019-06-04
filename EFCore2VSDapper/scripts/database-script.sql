CREATE Table Authors
(
   Id int identity primary key,
   [Name] nvarchar(50),
   Country nvarchar(50)
)

Declare @Id int
Set @Id = 1

While @Id <= 500000
Begin 
   Insert Into Authors values ('Author - ' + CAST(@Id as nvarchar(10)),
              'Country - ' + CAST(@Id as nvarchar(10)) + ' name')   
   Set @Id = @Id + 1
End