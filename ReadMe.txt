Project Working Log

Online References:

EF Core vs EF 6:
http://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx

Blob size MySql Db:
https://stackoverflow.com/questions/7071662/mysql-text-vs-blob-vs-clob

Blob Storage Requirements:
https://dev.mysql.com/doc/refman/5.7/en/storage-requirements.html

Blob = L + 2 bytes, where L < 2^16  MaxLength(65,536)..65Kb             Database uses image 12KB
MediumBlob = L + 3 bytes, where L < 2^24  MaxLength(16777216)..16Mb     Database uses image 117KB
==========================================
TINYBLOB   (or TINYTEXT)   = 1+(2^ 8) =        257 characters
BLOB       (or TEXT)       = 2+(2^16) =      65538 characters
MEDIUMBLOB (or MEDIUMTEXT) = 3+(2^24) =   16777219 characters
LONGBLOB   (or LONGTEXT)   = 4+(2^32) = 4294967300 characters
==========================================
Table 8.2 Maximum Length of strings used with EF Core
Data Type	Maximum Length	.NET Type
CHAR	255	string
BINARY	255	byte[]
VARCHAR, VARBINARY	65,535	string, byte[]
TINYBLOB, TINYTEXT	255	byte[]
BLOB, TEXT	65,535	byte[]
MEDIUMBLOB, MEDIUMTEXT	16,777,215	byte[]
LONGBLOB, LONGTEXT	4,294,967,295	byte[]
ENUM	65,535	string
SET	65,535	string
==========================================
Read/Write image to Database: 
https://stackoverflow.com/questions/25400555/save-and-retrieve-image-binary-from-sql-server-using-entity-framework-6#25400976

Json string as base64:
https://stackoverflow.com/questions/1443158/binary-data-in-json-string-something-better-than-base64 
https://stackoverflow.com/questions/21325661/convert-image-path-to-base64-string

Fastest way to convert Image to Byte array:
https://stackoverflow.com/questions/17352061/fastest-way-to-convert-image-to-byte-array

Save and retrieve image (binary) from SQL Server using Entity Framework 6:
https://stackoverflow.com/questions/25400555/save-and-retrieve-image-binary-from-sql-server-using-entity-framework-6#25400976

Object de-serializing from base64 in C#:
https://stackoverflow.com/questions/31339708/object-de-serializing-from-base64-in-c-sharp

Omline converter:
http://www.dailycoding.com/Utils/Converter/ImageToBase64.aspx

convert_image_to_base64_string_and_base64_string_to_image:
http://www.dailycoding.com/posts/convert_image_to_base64_string_and_base64_string_to_image.aspx

Retrieving an image from database with Linq to SQL:
https://stackoverflow.com/questions/1266223/retrieving-an-image-from-database-with-linq-to-sql?rq=1

Display Image from database in ASP.Net MVC (curent method):
https://www.aspsnippets.com/Articles/Display-Image-from-database-in-ASPNet-MVC.aspx

MVC How to display a byte array image from model:
https://stackoverflow.com/questions/17952514/mvc-how-to-display-a-byte-array-image-from-model

ASP.NET MVC - Displaying Images using Custom Html Helper Method (TODO):
http://www.devcurry.com/2012/10/aspnet-mvc-displaying-images-using.html
=====================



