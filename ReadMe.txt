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
