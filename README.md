# Reposit
A simple personal code snippet repository that allows a user to create and group code snippets used to solve specific problems so that snippets can be easily found for reuse or review in the future.

This product seeks to provide a virtual repository that allows users to create and categorize code snippets deemed helpful. This facilitates keeping track of important and helpful solutions to small problems frequently encountered. For example, a user may want to remember an effective method to process an array of integers and removed all multiples of a given input, n.

The project comprises the RepositAPI and the Reposit Web Application, which are "standalaone" services hosted separately, though the Reposit Web Application makes calls to the RepositAPI.

[RepositAPI Docs](/RepositAPI/README.md)

## Planning
[Project Plan](/documents/Project-Plan.md)

## Deployed Site
https://reposit.azurewebsites.net/

## Usage
Our web app features a clean and easy to follow UI. Our home page shows a concept of what a single, logged-in user would see. At this point you will see all categories you have created.
![](assets/usage1.JPG)

Clicking on the create link or the empty card allows you create a new category. A category is what our app uses to orgaznie and store code snippets.
![](assets/usage2.JPG)

Click on a category name will permit you to see all snippets that have been stored to that category.
![](assets/usage3.JPG)

Clicking on Browse will show all snippets from our API.
![](assets/usage5.JPG)

Clicking on show details will bring up a modal and allows you to add that snippet to the category.
![](assets/usage6.JPG)

From the category details view, you can also create a new snippet, allowing you to add your own custom code. 
![](assets/usage4.JPG)


## Database Schema
![db-schema](assets/WebAppDBSchema.png)

## Tools used
Visual Studio, .NET MVC CORE, Entity Framework, CSS/HTML, SQL database, Azure, HighlightJS

## Contributors
* Jeremy Beck (mtncrawler)
* Kendra Ellis (ellisken)
* Allisa LeBeuf (allisa)
* Richard Jimenez (richjimdev)
* Jeff Weng (inkh)

## License
MIT
