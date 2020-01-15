ISAD 251 Coursework Douglas Pub
==================

Please first run the package manager console to Seed the Database: 

    update-database
	
Please run the sql file for database picture initialization: 

    1) select New Query at Server Explorer
    2) run the sql queries (Please see the sql folder and revise the drive of the suitable path *D:\): 
    	UPDATE  dbo.Items   
	SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-coursework\DougPub2\Content\img\pork-scratchings.jpg', 		SINGLE_BLOB) 
	AS InternalImage)
	WHERE ID=1 ;
	*****************************
	UPDATE  dbo.Items   
	SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-coursework\DougPub2\Content\img\scotch-egg.jpg', 			SINGLE_BLOB) 
	AS InternalImage)
	WHERE ID=2 ;
	*****************************
	etc.

Admin login

    user: admin@gmail.com
    password: Admin@123    

Key Features:

  	1) Database is initialized for the first run of the application
	2) Customers can place, review and modify foods and drinks order
	3) Administrator can manage users, shop items and orders
	4) Homepage will automatically shows top selling items for customers
	5) RESTful API allow admin user to access and manipulate database items



Reference:
http://www.asp.net/mvc/tutorials/mvc-music-store - the ASP.NET MVC 3 music store.
