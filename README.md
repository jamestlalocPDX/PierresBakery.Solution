# Pierre's Bakery Vendor Database

#### _Code Review for Week 10 - 3/13/2020_

#### _By Jonathan Carlos_

## **Description**

_This C# codebase will build a user-friendly application for Pierre's Bakery, allowing him to keep track of his vendors that purchase baked goods from him, as well as the orders belonging to those vendors._

## Preview


## **Behavior Driven Development**

| Behavior | Input | Output |
|----------|:-----:|--------|
| Pierre enters vendor name. | "Suzie's Cafe" | newVendor.name == "Suzie's Cafe" |
| Pierre enters vendor description. | "Newest cafe in town." | newVendor.description == ""Newest cafe in town."|
| Pierre adds an order title to a vendor. | "Croissants." | newVendor.order.title == "Croissants." |
| Pierre adds an order description to a vendor. | "Cream filled croissants." | newVendor.order.title == "Cream filled croissants."
| Pierre adds an order price to a vendor. | "20" | newVendor.order.price == 20 |
| Pierre adds an order date to a vendor.| "05/01/2020" | newVendor.order.date == "05/01/2020" |
| Pierre is greeted with a welcome splash page. | localhost:5000/ | route == "/" |
| Pierre clicks on a link that sends him to a form where he can add a vendor. | "click" | route == /form |
| Pierre clicks on a vendor's name and it goes to a page that displays all of that vendor's orders. | "click" | route == /vendors/orders/ |
| Pierre clicks on a link that presents a form for a new order for a particular vendor. | "click" | route == /vendors/1/orders/new |


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