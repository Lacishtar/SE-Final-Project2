SELECT p1.name, p1.price, p1.price, p2.PhoneDesc
FROM products p1
JOIN ShoppingCart.dbo.Phones p2 ON p1.name = p2.PhoneName;

select name from products
select PhoneName from ShoppingCart.dbo.Phones

