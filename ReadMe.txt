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

ASP.NET MVC - Sort, filter and page table results:
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page

Use dynamic LINQ to simplify sort selection code:
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/advanced?view=aspnetcore-2.1#use-dynamic-linq-to-simplify-sort-selection-code

Best practice async smtpclient:
https://stackoverflow.com/questions/7276375/what-are-best-practices-for-using-smtpclient-sendasync-and-dispose-under-net-4#22471580

https://stackoverflow.com/questions/4709014/using-custom-domains-with-iis-express
https://stackoverflow.com/questions/3313616/iis-express-enable-external-request?rq=1
https://www.hanselman.com/blog/WorkingWithSSLAtDevelopmentTimeIsEasierWithIISExpress.aspx
VS2015
https://stackoverflow.com/questions/4709014/using-custom-domains-with-iis-express/32744234#32744234
http 404 error
https://stackoverflow.com/questions/30535336/exposing-localhost-to-the-internet-via-tunneling-using-ngrok-http-error-400

Configuring IISExpress:
https://stackoverflow.com/questions/46618360/asp-net-core-2-develop-using-custom-domain-names-and-ssl-using-iisexpress
=====================
TODO
=====================
Add Swager						DONE 4/11/18
Add Logging						DONE 4/13/18
Add.Email						DONE 4/13/18
Add save to Excel				TBD
Add Angular front end (BIG)		TBD
Add Product table				DONE 4/8/18
Product API filter				DONE 4/9/18
Table paging and paginating		DONE 4/9/18
Exclude json seed data files	TBD
Deploy to Amazon or Azure		TBD

Mail servers:
=====================
Sl.No 	Mail Server 	SMTP Server( Host ) 	Port Number
1 	Gmail 	smtp.gmail.com 	587
2 	Outlook 	smtp.live.com 	587
3 	Yahoo Mail 	smtp.mail.yahoo.com 	465
4 	Yahoo Mail Plus 	plus.smtp.mail.yahoo.com 	465
5 	Hotmail 	smtp.live.com 	465
6 	Office365.com 	smtp.office365.com 	587
=====================

Ref#1:
https://dotnetcoretutorials.com/2017/08/20/sending-email-net-core-2-0/
Ref#2:
https://docs.microsoft.com/en-us/dotnet/api/System.Net.Mail.SmtpClient?view=netframework-4.7
Mail Server:
https://www.mailgun.com/
https://sendgrid.com/







