﻿2023-03-02


1505

started ass2 in-class on the lab computer

set up the ASP.NET MCV w/core 1.3 (out of support)

HTTPS enabled, individual account authencation

Reviewed the areas folder

AND
1506 in startup.cs on line 13

removed options for default identy

(options => options.SignIn.RequireConfirmedAccount = true)

1510



Tested the app...ran it good...tested links

action items
-modify the navigation


-update the copyright...from 'static''to''dynamic':)

1516
modified the default welcome message...tested..
got error... the project is not running on browser(google chrome,firefox,microsoft edge)

wow its running on firefox

review the route pattern in startup.cs



--> 2023-02-03 <--
1510
clone the repository PargatBookStore in Github..test it ... done
1525
Created the .md File and pulled it.

1547
ceeated the README.md file in the gitHub 

1551
and pull it in VS Codes


OHH.. commit was not pushing to the github
Then make some changes on GIt setting   (Git/Settings/Git Repository settings) inside this
make the Prune remote Branches during fetch andRebase local branch when pullling both  set true. 





*****2023-02-09*****
1420
open the project and clone the repository on GitHub


1422
Download the Bootstrap font(LUX) from google 

1442
Replace the Bootstrap.css into the bootstrap.css file 
1447

edit the _layout.cshtml file 
1500

remove the text-dark from _LoginPartial.cshtml 
2015
Add dropdown in _Layout.cshtml





*******2023-04-06
1935

add a new project for testing wowww!!! its working

1940
add a new project as PargatsBooks.DataAccess

1950
add the another project as PargatsBooks.Models and run the project 

1955
just run the project . Ohh!! saw dark text in nav bar it looks bad so 
I remove the dark text from both _layout.cshtml and _layoutPartial.cshtml and 
check it again . test in wow now its look nice

2015
cut the data folder and paste it in the PargatBooks.DataAccess
Delete the migration Folder from data


2015
modify the DbContext file 

2020
delete the class.cs folder from three projects

2022
Cut the models folder and paste it into thee PargatBooks.Models
edit the name of models ro ViewModels

2030
Edit the error.csHtml 
add a new SD class in the utility folder

2040
add new area as Customer in the area folder
edit the HomeControllers.cs 
2052
Drag the home folder into the folder 
edit the _viewstart.cshtml @{
    Layout = "~/Views/Shared/_Layout.cshtml";

}



2101
ohh god Assignment 2 part 1 is completed finally ohh yesssss


*********2023-04-06*********
2111
start work on the assignment 2 part 2
edit the appsetting.json file 
2113
Add Migration in the Power manager Console
add-migration AddDefaultIdentityMigration
update the database using 
update-database


2121
Added the Category.cs class in the models folder.
add-migration AddCategoryToDb
update-database
2058
****************


added the  Repository folder in the dataaccess folder 
and created the IRepostory folder in the repostory folder
 
 2023-13-04
 1430
 started the work again
 clone the github with file pargatbooksw23
 test the project ohhhhhhhhhhhh! got error links are not working
 1500
 ohh  yesssss find the solution 
 I was missing two files in the main project 
 _viewImport.cshtml
 _viewstart.cshtml

 1533
 delete the dynamicparameter files
 and edit the ISP_Call.cs

 1545
 Created IunitofWork.cs file in the Repository folder

 1805
 Created the UnitOfWork.cs file in the repositort folder and edit it 

 1809
 edit the startup.cs file and 
 created public classes and interfaces

 1822
 add a new controller in the area>admin>controller as CategoryController.cs
 edit the CategoryController

 1830
 edit the ICategoryResopitory file 
 edit the code as given instructions.

 1841
 created a new folder as Category in the area>admin>views
 created a class in category folder named index.cshtml
 
 ~/Views/Shared/_Layout.cshtml
 update the Navigation bar in the Layout.cshtml

 1905
create the category.js file in the wwwroot>js folder
added two icons , Edit, Create and Delete in the category files
Added new view as Upsert.cshtml
Created partial view fot the Edit/back in the view>Shared folder
* _CreateAndBackToListButton.cshtml
*_EditAndBackToListButton.cshtml


 1920
edit the asp-action in the index.cshtmal file 
edit these as per the instructions

1950
edit dataAccess
using PargatBookStore.DataAccess.Data;
Repository.cs
CategoryRepository.cs
SP_Call.cs


2023
edit the catejory.js file 
regarding instructions
replace the Upsert with Delete in line 23 in Category.js



2030
add the delete Method CatagoryController.cs file and
test the project ....... wowwwww its running
for testing 
add the categories and edit them amd delete them all things are good 
yes!!!!!!!
Successfully compeleted the Assignment 2 part 2

moved to the next part


**********2023-04-13*********

Assignment 2 Part 3


 2130
 aded the class in the model folder
 added a class to the models folder named CoverType.cs

 **********2023-04-14*********
 Start the project again run it
 edit the applicationDbContext.cs file 

 add the migrations and update the database
 20230414192250_AddCoverTypeToDb

 **********2023-04-14*********
 1924
 Start the work on project again
 

 Create a new Class into the Repository Folder as CoverTypeRepository
 edit the CoverTypeRepository as per instructions

 
 create a new interface into the IRepository folder as ICoverTypeRepository
 and edit it as per instructions

 1940
 Modify the IUnitOfWorks.cs file 
 ICoverTypeRepository CoverType { get; }

 Modify the UnitOfWorks.cs file 
 public ICoverTypeRepository CoverType { get; private set; }

 1945
 Updated the database Successfully!!!!!!

 1950
 edit the layout.cs with
 <a class="dropdown-item" asp-area="Admin" asp-controller="Category" asp-action="Index">CoverType</a>

 1957
 create a new folder in Area>Admin>View as CoverType
add the view into the Covertype Folder as Index.cshtml
Run the project wow Everything is good No issue found

2000
add a new class covertype.js into wwwroot folder and run the project no issue found

2012
add a new controller in areas>admin>controller as CoverTypeController
edit the code as per instructions

2025
added new view as Upsert.cshtml in the area >> admin >> view >> covertype folder

2055
add a new class into the PargatBooks.Models as Product.cs
edit Product.cs as per instructions

edit the ApplicationDbContext.cs as per instructions 

2105
added migrations
20230415010514_AddProductToDb
20230415010514_AddProductToDb.Designer

update the database
successfully

2110
Create a new Class into the Repository Folder as ProductRepository
 edit the ProductRepository as per instructions

 
 create a new interface into the IRepository folder as ProductRepository
 and edit ProductRepository as per instructions

 2115
 Modify the IUnitOfWorks.cs file 
 ProductRepository CoverType { get; }

 Modify the UnitOfWorks.cs file 
 public ProductRepository CoverType { get; private set; }

 2140
create a new folder in Area>Admin>View as Product
add the view into the Product Folder as Index.cshtml
Run the project wow Everything is good No issue found

reate a new Class into the Repository Folder as ProductRepository
 edit the ProductRepository as per instructions

 
 create a new interface into the IRepository folder as ProductRepository
 and edit ProductRepository as per instructions

 2023-04-20
 1435
 start again 

 modification in unitofwork
 make the file of upsert.cshtml for product
 1444
 edit the Upsert.cshtml
 oops!!! the product page is not opening
