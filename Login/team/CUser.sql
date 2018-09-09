create PROCEDURE CUser  
(  
   @username as varchar(50),  
   @password as varchar(50)  
)  
AS  
SELECT * FROM registrationtab WHERE username=@username AND password=@password  