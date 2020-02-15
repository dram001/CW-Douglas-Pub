Coursework Douglas Pub
==================

Links of the Application for reference

GitHub repository link: 
https://github.com/dram001/CW-Douglas-Pub

YouTube Demo Video (1080p):
https://youtu.be/L6eIpiU0yxE

RESTful API Middleware for Items:
https://localhost:44300/api/itemsapi

RESTful API Middleware for Orders:
https://localhost:44300/api/ordersapi

Please first run the package manager console to Seed the Database: 

    update-database
	
Please run the sql file for database picture initialization: 

    1) select New Query at Server Explorer
	2) run the sql queries (included in the SQL folder) for creating a view 
	3) run the sql queries (Please see the sql folder and revise the drive of the suitable path *D:\): 
	*****************************
	UPDATE  dbo.Items   
	SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-coursework\DougPub2\Content\img\pork-scratchings.jpg', 		SINGLE_BLOB) 
	AS InternalImage)
	WHERE ID=1 ;
	*****************************
	Etc.


Admin login

    user: admin@gmail.com
    password: Admin@123    

Key Features:

1) The application follows the W3C Web Accessibility Initiative (WAI) Guidelines and tested with multiple browsers such as Chrome, Firefox and IE.

2) The database is initialized for the first run of the application. This project is using Entity Framework Code-First approach. Therefore, limited SQL is required. Security features such as using @Html.AntiForgeryToken() to protect the application against cross-site request forgery.

3)The homepage will automatically shows top-selling items for customers to place an order quickly. 

4) The administrator can manage users, shop items and orders. Customers can place, review and modify foods and drinks order.

5) RESTful API allows the admin user to access and manipulate database items and orders.

******************************************
Reference links for the application:

Web Accessibility Handbook:
https://www.ogcio.gov.hk/en/our_work/community/web_mobileapp_accessibility/promulgating_resources/handbook/

The W3C Web Accessibility Initiative (WAI) Guidelines 
https://www.w3.org/WAI/

The W3C Web Content Accessibility Guidelines (WCAG):
https://www.w3.org/WAI/standards-guidelines/wcag/

The ASP.NET MVC 3 music store: 
https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store/mvc-music-store-part-1

CSS framework Bootstrap:
https://bootswatch.com/3/

The pictures used in the application:
Home image:
https://www.mott32.com/home
Food images: 
https://britishgrubhub.com/british-pub-food/


