﻿CREATE PROCEDURE [dbo].[P_GetOneUser]
	@IdUser INT
AS
BEGIN
	IF((SELECT IdUser FROM V_User WHERE IdUser = @IdUser) IS NULL)RETURN NULL
	SELECT * FROM V_User WHERE IdUser = @IdUser
END