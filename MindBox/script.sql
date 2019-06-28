--Product
--	Id
--	Name

--Category
--	Id
--	Name

--связь многие-ко-многим реализуется за счет таблицы ProductCategory
--	ProductId
--	CategoryId

SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Product AS p
LEFT JOIN ProductCategory AS pc
	ON p.Id = pc.ProductId
LEFT JOIN Category AS c
	ON pc.CategoryId = c.Id