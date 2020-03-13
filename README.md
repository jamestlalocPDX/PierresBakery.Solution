# Pierre's Bakery

#### _Code Review for Week 10 - 3/13/2020_

#### _By Jonathan Carlos_

## **Description**

_This C# codebase will build a user-friendly application for Pierre's Bakery, allowing him to keep track of his vendors that purchase baked goods from him, as well as the orders belonging to those vendors. _

## Preview


## **Behavior Driven Development**

| Behavior | Input | Output |
|----------|:-----:|--------|
| Pierre enters the name of a vendor. | "Suzie's Cafe" | newVendor.name == "Suzie's Cafe" |
| Pierre enters the description of a vendor. | "Newest cafe in town." | newVendor.description == ""Newest cafe in town."|
| Pierre adds an order to a vendor. | "Croissants" | newVendor.order.name == "Croissants" |
| Pierre adds a description to the order. | 
| Customer enters an amount for 2 hearty loaves of bread. | 2 | $10, 3 hearty loaves. |
| Customer enters an amount for 3 tasty pastries. | 3 | $5, 3 tasty pastries. |
| Customer enters an amount for both bread and pastry. | 2, 3 | $15, 2 hearty loaves and 3 tasty pastries. |

## **Minimum Viable Product (MVP)**

The MVP of this project is to allow Pierre to keep track of his vendors and their orders through a user-friendly MVC web aplication.

Stretch goals include:

* Allow Pierre to click an rrder's name to go to a separate page to view its details.
* Add the ability to delete individual Vendors, all Orders belonging to a Vendor, individual Orders, or all Vendors.
* Add the ability for Pierre to note whether an order has been paid for or not.
* Add search functionality.

## **Setup/Installation**

*Cloning this repository:*
1. Open up your terminal.
2. Navigate to the desired directory in which you want to clone this repository.
3. Use the command `git clone https://github.com/jonathancarlos21/PierresBakery.Solution` to clone this repository.
4. Open this repository from within your terminal.
5. Use `dotnet run` to generate a local server.
6. Copy and paste the given `localhost:5000` onto your URL.

*Downloading this repository:*
1. On the top right of this page, click the "Clone or download" button.
2. Click on "Download ZIP."
3. Click the downloaded file to unzip and extract this repository to your desired directory.
4. Within your terminal, navigate to the directory where you saved this repository.
5. Open the repository within your terminal.
6. Use `dotnet run` to generate a local server.
7. Copy and paste the given `localhost:5000` onto your URL.

## **Known Bugs**

There are no known bugs at this time.

## **Support and contact details**

If you have any questions, comments, or concerns, please feel free to contact the content creator at examplemail@company.net 

## **Technologies used**

* .NET Core

* ASP.NET Core MVC

* Razor

* C#

* Visual Studio Code

* GitBash

## **License**

Copyright (c) 2020 **_Pierre's Bakery_**

This software is licensed under the MIT license.