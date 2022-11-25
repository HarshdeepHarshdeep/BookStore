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

19. Added three projects in it.

1255

20.	renamed models folder to ViewModels
	Added project references

1259
21.	Build completed with 1 succeeded 1 failed, finally got an error 

0104
	-editied homecontrolles to add viewModels and built now got 2 other errors
0105
22.	It was same error as the last time, i hope it doesn't go on loo like last time.
	 for now it built with 1 succeeded 0 failed,
0156
	Created SD.cs class in utility project, can't understand what properties to change in this file
0200
	Added project references
0203
	got same error in that same file Error.cshtml.g.cs for the 7th time and it gets on repeated


0441
	edited error viewmodel path to solve the last error that i got more that 8 times



2022-11-12

0144
	Reviewing the project and next task
0207
	Added Customers area and edited startup.cs to add appmvc area routes.
0222
	Moved HomeController.cs to new customers area and added area refeerence

	woho now showing nothing on browser. let's find out in next steps

	Moved views and viewstart, viewimport file to new customer area rebuild succeeded.
	But still showing blank page on browser.
0310
	INdex page showing in browser when i add /Customers in url but not on base route
0331
	Copied back viewstart and viewimport file because lastime i moved them instead of copying,
0342
	Still couldn't figure out why route are not working correctly
	Now trying to add admin area
0347
	Added Admin area and copied same view files as last Area, not showing errors , actually not showing anything
0349
	I doubt the last slide when it says delete controllers folder, but deleting it anyway because its clearly written their 
0510
	Added route attribute to home controller in customer area to access index page from base url in the browser
	this is the solution of that blank page in browser
0512
	Heading for part-2



2022-11-12

1600 :- 

created migration in bookstore 

1605 :- 

I got the error while migration  because of the wrong project Selected.

1610 :- Error solved

Changed the default Project and the Migration successful.

Time :- 1615 

Checked SQL Syntax, Statements 

After completion the Migration I update the database in SQL Server Object Explorer.

I got no errors after running the database.

Time :- 1630

I added the class file to the .models project

Time :- 1700

Added the migration with the PM Console.

Time :- 1750
Added the Repository files

2022-11-12

0144
	-Reviewing the project and next task
0207
	-Added Customers area and edited startup.cs to add appmvc area routes.
0222
	-Moved HomeController.cs to new customers area and added area refeerence
0223
	-woho now showing nothing on browser. let's find out in next steps
0237
	-Moved views and viewstart, viewimport file to new customer area rebuild succeeded.
	-But still showing blank page on browser.
0310
	-INdex page showing in browser when i add /Customers in url but not on base route
0331
	-Copied back viewstart and viewimport file because lastime i moved them instead of copying,
0342
	-Still couldn't figure out why route are not working correctly
	-Now trying to add admin area
0347
	-Added Admin area and copied same view files as last Area, not showing errors , actually not showing anything
0349
	-I doubt the last slide when it says delete controllers folder, but deleting it anyway because its clearly written their 
0510
	-Added route attribute to home controller in customer area to access index page from base url in the browser
	-this is the solution of that blank page in browser
0512
	-Heading for part-2



2022-11-13

0140
	-Reviewing complete previous assignment.
0145
	-Changing some left over things that i think i missed in part-1
0147
	-Modifying properties of sd.cs class
0211
	-Modified area routing in startup.cs and namespace of homeController, after reviewing slides again

0227
	-deleted the controller folder from root, previously i deleted from admin area, now is the correction time
0234
	-just found out that i copied HOme folder in admin area which was not mentioned in the slides , so deleted it

0238
	-Now the time to really heading towards Part-2

0244
	- I ran add-migration command in root folder and it was success than i saw error in slide and got to know that i did not delete data folder from root.
	- That's why i didn't get error that i should've got. 
	- Now i know what project to select 

0249
	- Build failed :(
0251
	-got errors after deleting data folder from root, i shoul've counter these error before but no worries now
0252
	-Changed using statement for dataAccess in startup and errors are gone.
0256
	-rebuilding success thankfully no errors now.
0257
	-Thanks to no errors new migration file (20221113195650_AddDefaultIdentityMigration.cs) added in dataAccess.
0301
	-update database success
0304
	-Rebuild success, no errors working well on browser
0321
	-Added new model class in Models project Category.cs and updated ApplicationDbContext file to help migration
	-Ran add-migration command to push to database
0333
	-Updated database
0334
	-Checked sql database, new table for categories added
0433
	-After wasting time on insta-reels now i have made iRepo interface and added properties and methods in it.
0547
	-Created New category interface and class in repository
	-plus added properties and methods
0628
	-Created ISP_Call repository and added methods

1037
	-After a long break i'm back, and created SP_Call interface and its class.
	-Updated implementation of the interface.
1123
	- created UnitOfWork class and interface but getti two similar errors
		-Inconsistent accessibility: property type 'ICategoryRepository' is less accessible than property 'UnitOfWork.Category'

1240
	-after too many google serches found out that "The simplest fix for this issue is to add or remove the public access modifier to the class or interface".
1251
	-Registered UnitOfWork class and interface in startup.cs file and getting different errors
		-'IUnitOfWork' is inaccessible due to its protection level
		-'UnitOfWork' is inaccessible due to its protection level
	-And if i put public in these files they give prevous error again that is on line 226 if not thenit gives error of above line
0103
	-These errors are too confusing, if if solve one error it gives another and if solve that one it gives the first one back.
			-These errors are on loop
0110
	-for now i am commenting the line of error in startup.cs file which was registering Unitofwork class and interface, and trying to move on next step
0158
	-same files and error are disturbing in processNo more energy now. packup for now


2022-11-14


1244
	-Commented the file i created after error to run the project once.
1246
	-commented sslport in launch settings
0143
	-Updateded database via command line now showing all tables in class's desktop pc


2022-11-16

0406
	-I think i figured out how to solve that error in Unit of Work files, let's try
0426
	- Now i noticed every class and interface in repositry folder was set to internal and protected so they inaccessible to other files.
	-now that i set them to public all errors are gone.

0432
	- Uncommented CategoryController file becoause i added it previouly and commented it due to UnitofWork files errors, now it is in use
0440
	- Added index view for category in admin area and pasted given html code from blackboard
0445
	- Added link of this index view of Category in the navbar inside of dropdown
0451
	- Added fontAwesome icons in CategoryIndedx page
0452
	- Added bootstrap's class to center icons
0456
	-Okay so now i need to delete icons.
0459
	-Deleted Icons and added script file category.js at that place
	-so via this javascript file it implemented datatables in the page
0502
	-Now its a maggie break;



2022-11-17

0350
	- It was a very long maggie break :)
	-now further work is continued
0358
	-Added IActionResult of Upsert method in CAtegoryController and created view file for it
0403
	-pasted form in upsert view, that was given
0429
	-created a partial file for create and back to list buttons
0502
	-created another partial file for edit and back buttons



2022-11-18

1219
	-Modified Upsert.cshtml file added some asp attributes to form elements
1232
	-Added asp-action for upser file in index
1243
	-Added added script file for validation
1253
	-Added Upsert method for post request in category controller.
	- Also added save method in IUnitOfWork
1257
	-Moved Save method calling and added return satatement with redirection to index below the save method calling.
	-Removed _db.saveChanges method from category repo
0100
	-Here is the encounter with errors
		-'UnitOfWork' does not implement interface member 'IUnitOfWork.save()'
		-The result of the expression is always 'true' since a value of type 'int' is never equal to 'null' of type 'int?'
0101
	-I think solution for one of the is given in slides
	-Yup, changed null to 0 in the Model.Id conditional statement.
	-Now let's the other error
0104
	-Got it, I had Save method in UnitOfWork file with a capital S but it wanted with Small one, now fixed
0111
	-Got this error on browser while trying to add new category.
		-NotImplementedException: The method or operation is not implemented.
			-MohitsBooks.DataAcces.Repository.Repository<T>.Add(T entity) in Repository.cs, line 23
	-let's see whats the problem with repository file.
0113
	- okay, i didn't copy the repository file from black board, so all the methods are left as they was ,just throwing the exception. fixing now
0117
	-replaced repository file with the one on blackboard 
0119
	-ohho got 9 errors because of new repo file, so i undid last commit and adding methods one by one
0127
	- Added methods inside code one by one instead of just replacing whole file at once
0128
	-Now we are talking, successfully created new category;
0138
	-Added Api call method for deleting the category in category controller
0141
	-Added the onclick event in js file to call the api delete endpoint
0150
	-created Delete function to make an api call using ajax and showing alerts withswal and toastr
0154
	-delete button isn't responding, something is wrong
0200
	-okay its working just after restarting the build and iiS
	-now i just wanna change some css for data table, font color having some mixmatch with background color
0220
	-Changed background color of all table rows <Tr> and font color of text around table inside of datatable border
0325
	- Noticed that edit was not working , so added category parameter to the returning view method in upsert iactionresult of category controller




2022-11-21


	-Created CoverTypeController with all required methods
0907
	-Created view for index and Upsert action methods
	-Created CoverType.js javascript file to add datatable to index page of CoverType
0945
	-Added coverType link in navbar
0957
	-testing done, create, edit and delete methods are working fine for CoverType
1137
	-created Product class in Models project and added reference to the db context file;
	-Added migration for products table "20221122053523_AddProductToDb.cs"
	-products table created



2022-11-24



1245
	-Created Repository and IRepository file for Product class
1248
	-Added product repo files to UnitOfWork and IUnitOfWork
1253
	-Build errors