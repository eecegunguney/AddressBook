# AddressBook
This project developed for Yasar University - SE4458 Assignment2.  
The **Goal** is using the to-do app template, create and deploy a simple REST API application.

## Description
This Address Book API allows
* Create contact
* Edit existing contact
* Delete contact
* Search by name, email or tag.

## Tech Stack
Tech stacks I use when developing
* **Framework:** ASP.NET Core Web API (.NET 8)
* **Language:** C#
* **Database:** In-Memory Database
* **API Documentation:** Swagger UI
* **Deployment:** Azure App Service

## Design
```
AddressBook/
│
├── Controllers/
│   └── AddressBookItemsController.cs
│
├── Models/
│   └── AddressBookContext.cs
│   └── AddressBookItem.cs
│
└── Program.cs
```

## API Endpoints
|  **Method**  |         **Endpoint**         |       **Description**        | 
|--------------|------------------------------|------------------------------|
|     GET      |     /api/AddressBookItems    |       Get all contacts       |
|     GET      |  /api/AddressBookItems/{id}  |      Get a contact by id     |
|     GET      | /api/AddressBookItems/search | Search by name, email or tag |
|     PUT      |  /api/AddressBookItems/{id}  |  Update an existing contact  |
|     POST     |    /api/AddressBookItems     |       Create a contact       |
|    DELETE    |  /api/AddressBookItems/{id}  |       Delete a contact       |

## Deployment
[Swagger](https://addressbook21070001014-fshadvdcecaaazf7.francecentral-01.azurewebsites.net/swagger/index.html)

## Source Code
[Github](https://github.com/eecegunguney/AddressBook)

## Assumptions
* Each contact has it's own unique ID.
* Data is kept in in-memory database.
* A simple system that does not require authentication.
* There are only CRUD and search operations.

## Issues Encountered
* The development process went smoothly overall. Only minor package compatibility adjustments were needed, and no other issues were encountered.
