from pyspark.sql import SparkSession, DataFrame


spark = SparkSession.builder.appName("task2").getOrCreate()

categories_table = spark.createDataFrame([
    (1, "Category 1"),
    (2, "Category 2"),
    (3, "Category 3"),
    (4, "Category 4"),
    (5, "Category 5"),
    (6, "Category 6"),],
    ["id", "category_name"],
)

products_table = spark.createDataFrame([
    (1, "Product 1"),
    (2, "Product 2"),
    (3, "Product 3"),
    (4, "Product 4"),
    (5, "Product 5"),
    (6, "Product 6"),
    (7, "Product 7"),
    (8, "Product 8"),
    (9, "Product 9"),
    (10, "Product 10"), ],
    ["id", "product_name", ]
)


ER_table_products_vs_categories = spark.createDataFrame([
    (1, 1),
    (2, 3),
    (3, 2),
    (3, 4),
    (6, 4),
    (4, 5),
    (5, 6),
    (6, 7),
    (6, 8),
    (4, 2),
    (1, 8),
    (4, 9),
    (1, 10)],
    ["category_id", "product_id", ]
)




df_data = (products_table.join(ER_table_products_vs_categories,
    products_table.id == ER_table_products_vs_categories.product_id, how='left')
    .join(categories_table,
    ER_table_products_vs_categories.category_id == categories_table.id, how='left')
    .select(['category_name', 'product_name'])
)

df_data.orderBy("category_id", "product_id", ).show(truncate=True)