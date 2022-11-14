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
Added the Repository and 