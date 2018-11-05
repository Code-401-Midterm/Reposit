# Project Plan

## Contents
1. [Vision](#vision)
2. [Scope](#scope)
3. [Requirements](#requirements)
4. [User Stories](#user-stories)
5. [Wireframes](#wireframes)
6. [Dataflow Diagram](#dataflow-diagram)
7. [Database Schema](#database-schema)

## Vision
This product will provide a virtual repository that allows users to categorize 
and catalogue code snippets that they find helpful. 
This helps users to keep track of important and helpful solutions to problems they may encounter frequently. 
For example, a user may want to remember how they effectively processed an array of integers and removed all multiples of 5. 

## Scope
* IN:
  - The web app will allow users to save snippets of code.
  - The web app will allow users to categorize their saved snippets by code language.
  - We will allow users to associate snippets with tags like “binary tree” or “search.”
  - We will allow users to search for saved code snippets by tag or category.
  - Each snippet will require a user to add the snippet’s source upon creation.
  - We will allow users to create a “study deck” from a filtered list of snippets where each card in the deck shows the full details associated with a given snippet.

* OUT:
  - We will not allow users to save any other type of data besides text.
  - We will not be creating a mobile app version of this app.
  - We will not require developers to use an API key to acquire or use our API.
  - We will not require users to create accounts with logins.
  
### MVP
A user can create, edit, and delete a snippet and will have the ability to create and delete category tags. There will also be a page where a user can see a list of all their snippets and filter that list by language, category, etc. Either prior to or after filtering, a user can click on a button to review a set of snippets as flash cards.

### Stretch
  - The website will create a new endpoint for unique users so that individual snippet repositories are accessible by a unique URL.
  - The user will see a list of suggested “study decks” on their homepage for quick access to particular decks.
  - The website will be mobile-friendly (responsive)

## Requirements
### Functional Requirements
 - The user can add and delete code snippets.
 - The user can search for code snippets by category or tag.
 - The web app will display code snippets and details. 
 - The web app will have create, update, and delete views.
### Non-Functional Requirements
* Usability
  - Intuitive Design: The UI will be designed in a way where users do not have to rely on external or extra instructions to use the web app.
  - Clean & Concise: The UI will be uncluttered and easy to follow and understand.
* Testability
  - Unit Tests: CRUD Operations 
  - The site will have a small total number of user “paths” (associated with CRUD operations) which makes it easier to test that each user path works as intended.
  - Unit Tests: Routes, Controllers & Views
  
## User Stories
### Web App  
* SEARCH: As a user, I want to search for code snippets based on language or category to find an applicable solution to my issue.
  - Features
    - User can search by language or category
    - Display search results
    - Ability to get more details from results
  - Acceptance
    - Ensure the search terms retrieve the correct data
    - Provide a message if no results are found
* DESIGN: As a user, I want a clean design and intuitive navigation for good user experience.
  - Features
    - User can clearly navigate
    - Navigation menu present on all views
  - Acceptance
    - Hallway testing
* VIEW: As a user, I want to view code snippets and details on a page so I can review all the useful code snippets available on the app.
  - Features
    - Code snippet and details displayed on page
    - Organized and ease of reading
  - Acceptance
    - All details render on page
    - Multiple results render
* ADD: As a user, I want to add code snippets and details so that I can retrieve them later.
  - Features
    - Forms for user to input all data
    - Confirmation that data was saved
  - Acceptance
    - All details are saved
    - Data can be retrieved
### API  
* CREATE: As a developer, I want to allow users to create code snippets to add to the database.
  - Features
    - User will enter title, category, code snippet, and source of snippet.
    - Created snippets will save to database.
    - Each snippet is a unique record in the database.
  - Acceptance
    - Ensure required fields are completed in order to create snippet.
    - Ensure a unique id is created when snippet is created.
    - Ensure code snippet can be retrieved after creating.
* READ: As a developer, I want to allow users to retrieve or search for code snippets.
  - Features
    - Requested information will be returned to user based on the search criteria.
    - A status message will be returned if there is no matching data.
    - Multiple results will be returned if there is more than one match.
  - Acceptance
    - Ensure information can be retrieved matching search criteria.
    - Ensure multiple results can be returned when requested.
    - Ensure a message is returned if there is no matching data.
* UPDATE: As a developer, I want to allow users to make updates to code snippets.
  - Features
    - Updated snippet will save over original snippet in database.
    - Allow updates to category tags and language.
  - Acceptance
    - Ensure users have required fields entered
    - Ensure updated information is saved to database
    - Ensure request failed message is sent if information was not updated.
* DELETE: As a developer, I want to allow a user to delete a code snippet.
  - Features
    - Code snippet can be deleted when selected.
  - Acceptance
    - Ensure snippet is deleted from database.
    - Ensure a request failed message is sent if snoppet was not deleted.
    - Ensure only one snippet is deleted.
    - Public: As a developer, we want the api to provide consistent 

## Wireframes

## Dataflow Diagram
![dataflow](../assets/DataFlowDiagram.png)

## Database Schema
![db-schema](../assets/DBSchema.png)

### Description
* Snippet: This table will hold the data for each individual snippet, such as the name, date, and code snippet body of text. This table also features an Enum for code languages.
* Tag: This table contains the tags that will pertain to snippets created in our database
* Snippet Tags: This is a pure join table that will join snippets and tags, emulating a many to many relationship.
