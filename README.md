# Bookstore
A web application for online book store. Built using ASP.NET Core 2.1 (MVC).


## How to run the application
BookStore requires MSSQL Server running. You should enter connection info about MSSQL Server in `appsettings.json` file. In this file you should modify `BookStoreContextConnection` value and replacing it with you MSSQL Server connection info.

After that you have to use cli commands of EntityFramework in order to create all tables in MSSQL. Then you execute this command:

```
Update-Database
```

Now you build your application as any other .NET Core applications. For e.g. if you're using VS Studio: `Debug > Start without debugging`, or if you're using VS Code you can use dotnet cli and run this command: `dotnet run --project "<full path>\BookStore.csproj"`.

You can then visit this URL in your browser: `https://localhost:5001`.

## Using web application
BookStore have a UI for browsing all books in database, filter books by different attributes, view user's orders (if logged in), add/remove books from a session shopping cart. In order to add to your cart you must be logged in. BookStore uses IdentityAPI in order to manage users. BookStore have two roles of users "Administrator" and "NormalUser". At startup of application we seed one administrator user and one normaluser. You can also use Register page to create a new user (keep in mind that this will be created as a NormalUser). 

Initial created administrator user:
```
Email: admin@bookstore.com
Password: Admin123!
```

---
After logging in you will see different pages you can visit. If you're logged in as a normaluser, you can browser different books, rate them, write/edit comments for specific books. You can add books to your shopping carts and then "purchase" them. You can view your order's history. If you're logged in as a administrator user, you can make all what a Normaluser does but also have access in Admin Dashboard. In Admin Dashbord administrator can view all of application's data (Books, Users, Comments, Orders, Top sold books etc.).
