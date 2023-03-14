SELECT Products.Name as "Имя продукта", 
	   Category.Name as "Имя категории"
	   FROM ProductToCategory 
	   LEFT JOIN Products
	   ON ProductToCategory.ProductId = Products.Id
	   LEFT JOIN Category
	   ON ProductToCategory.CategoryId = Category.Id;