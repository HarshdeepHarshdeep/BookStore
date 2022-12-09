Date :- 11-04-2022
Name:- Harshdeep Harshdeep



Time:- 1200

1. Started building the application using create a new project.

2. Click on the ASP.net Core Web application (Model View COntroller).

3. Changed the Authentication to the Indvidual User Account.

4. Enabled Razor Runtime Compilation.
	
5. After Setting up the appilcation then I added two break points to HomeController.cs file.

6. To add the breakpoints, select the text where you want to get the breakpoint then click on the Debug and selsct the Breakpoint option to add the breakpoint.

7. Then I run the application and It worked well. 

Time:- 1230

8. Setting Up the Bootsstrap

9. I went to Bootswatch.com and Selected Yeti Them.

10. I Downloaded bootstap.css file and replace it with the existing bootstap.css 
	which can be found in the lib>bootstrap>dist>css

11. Replaced the existing site.css file.

12. I open the Views>Shared>_layout.cshtml file and change the file name from bootstrap.min.css to bootstrap.css.

13. Changed the nav class from nvbar-light to navbar dark and bg-white to bg-primary.

14. where where I found the text-dark, I removed it from the _layout.cshtml and _loginPartial .cshtml files.

15. added to the _Layout.cshtml page the additional stylesheets and scripts from the CSS_JStxt file.

16. Added the links to file.
17. Then I tried to add the dropdown to the Navbar but Its not working properly.

18. I successfuly created the dropdown menue.

Time :- 1400

19. Added three projects in it main bookstore file.

20 	Added project referrences t othe view/modal page og the 

1100
21.	Got error during building of the app. 

1105
Added project Reference to the main project.

1110
Changs the rouites in Startup.cs

1115
Move the homw controller to the Controller folder but accendentialy moves to the area folder which gives me the error.

1120
edit home controller

1125
Move view from home and modify the home controller namespaces.

1130
Took break of 10mins and started again to continue the the file.

1140
I run the application and it workes correctly.

1145
Part 1 completed.



2022-11-12

1000
see the next part 2

1030
Overview the last part one 

1045
Started creating DB 

1100
Use NuGet packages manger console to add the migration.

1110 did not select the project on which i want migration which gives me the error

correct error

Select the correct default project do migration.

1115
When the migration is done to update the data base

To update the database, In console I wrote update-database.

1120
I reviewed the update data base.

1125
Created the repository folder in the data base

And ad Irepository folder laso to add the interfaces

1130
Create the Constructors and dependency injection

1140
Created CategoryRespository.cs and ICategoryRepository

1200
Modify the CategoryRespository.cs and ICategoryRepository file according to the ppt provided.

it took me some time because I am facing errors while adding the data.

1230
Then I build it up which gives me no error.

1240
Added the new interface in the IRepository called ISP_Call.cs 

1300
added the method as given and instal Nuget packages for dapper.

Then I star building the application but I got error in the ISP_Call.cs file 

because I forget to instal the Dapper in the project which gives me the error.

Error Correction :- 

I right click on the text where the error is and Instal the dapper Nuget Package in the project which clear my error and I successful build the project.

1330
Moved on the Category curd Part 2.3

Added the new MVC Controller- Empty Inside Area/Admin.

I named It CategoryController.cs

1400
Added the new floder in the Area/View with same as controller.

Add index view to the folder.

Added the file which was given by professor called IndexView.txt

Then I run the application.

1430
I moved the Category link in the Layout file to the Drop-down.

1500
To modify the icon of the index.cshtml file in the category section I added the icon from the font awesome, but the icon was given in the files 
provied.

I delete it and the Javascript from the Assignment 2 files folder in the wwwroot file to the js file. 

In the Index.cshtml add the @section call to the Category.js script.

1600 

Added the edit and delete button and create new category using the Upsert action.

Add the Iaction Result to the controller and Add a view 

I removed the db.savechnage() method in the CategoryRepository.cs and move the _UnitOfWork.save() Method with the return.

1700

Added  the delete(url) function code.

I build the application which gave me some errors of not using statements, after that I added them in the files in which I am facing the errors 
.
Then I again start building the application which successful started building and My application works.

Part 2 completed.


2022- 20-11
Started part 3 :-

1430
created CoverType.cs file in Models
1500
	added ICoverTypeRepository interface for covertype
1530
	created CoverTypeRepository class
	Added CoverType In UnitOfWork and IUnitOfWork
`1600
	Added new migration for CoverType "20221209163156_AddProductToDb].cs";
	database  and the new table

	20221209163315_AddValidationToProduct
	20221209163315_AddValidationToProduct

	Done part 5th 


	tarting section 2 by adding product controller
1700
	


	Created required methods of product controller and Api calls

