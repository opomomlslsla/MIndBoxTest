# Angles-master

тестовое задание для компании MindBox.

Решение задания №3:

SELECT P."ProductName", C."CategoryName"
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id;
