﻿CREATE PROCEDURE dbo.spAddTest

@Value0 NVARCHAR(255),
@Value1 NVARCHAR(255)

AS

INSERT INTO Test (Value0, Value1) VALUES (@Value0, @Value1)

SELECT SCOPE_IDENTITY() AS NewID

GO

CREATE PROCEDURE dbo.spDeleteTestByID

@ID INT

AS

DELETE FROM Test WHERE ID = @ID

GO

CREATE PROCEDURE dbo.spGetTest

AS

SELECT
	ID,
	Value0,
	Value1
FROM
	Test

GO

CREATE PROCEDURE dbo.spGetTestByID

@ID INT

AS

SELECT
	ID,
	Value0,
	Value1
FROM
	Test
WHERE
	ID = @ID

GO

CREATE PROCEDURE dbo.spUpdateTest

@ID INT,
@Value0 NVARCHAR(255),
@Value1 NVARCHAR(255)

AS

UPDATE
	Test
SET
	Value0 = @Value0,
	Value1 = @Value1
WHERE
	ID = @ID

GO
