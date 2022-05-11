Select Products.Name, Categories.Name
From Products
Left Join ProdCat
on ProdCat.ProdId = Products.ProductId
Join Categories
on Categories.CategoryId = ProdCat.CatId