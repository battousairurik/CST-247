create procedure [dbo].[strlogin]  
(  
   @username varchar(100),
   @firstname varchar(40),
   @lastname varchar(40),
   @gender varchar(40),
   @age varchar(40),
   @state varchar(40),
   @email varchar(100),
   @password varchar(20)  
)  
as  
insert into registrationtab values(@username,@firstname, @lastname,
	@gender, @age, @state,@email,@password ) 