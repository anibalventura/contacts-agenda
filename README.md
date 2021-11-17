# Contacts Agenda

[![.NET](https://img.shields.io/static/v1?label=.NET&message=3.1&color=purple)](https://dotnet.microsoft.com)
[![SQL Server](https://img.shields.io/static/v1?label=SQL%20Server&message=15.0.2&color=CC2927)](https://dotnet.microsoft.com)
[![License](https://img.shields.io/static/v1?label=License&message=MIT&color=blue)](LICENCE.md)

<p align="center">
  <img src="Screenshots/login-screen.png" height=250px/>
  <img src="Screenshots/register-user-screen.png" height=250px/>
  <img src="Screenshots/contacts-screen.png" height=250px/>
  <img src="Screenshots/add-contact-screen.png" height=250px/>
</p>

WinForm app to manage a contacts agenda by user, written in .NET with SQL-Server using OOP.

## Features

- Data persistence with SQL Server.
- Login with username and password.
  - Verify in the database if the data entered is correct.
- Create new users to login.
  - Check if username exists.
  - Check if passwords match.
  - Check if all the data has been completed.
- Shows contact list only of the user who created it.
- Create, edit and delete contacts.
  - Check if all the data has been completed.
- Option in menu strip to logout.

## Database Diagram

<p align="left">
  <img src="Screenshots/database-model.png" height=190px/>
</p>

## Dependencies

- [System.Data.SqlClient - Version 4.8.3](https://www.nuget.org/packages/System.Data.SqlClient)

## Build

1. Open and run the following SQL script file `../Database/ContactsAgendaDB.sql` to generate the database structure used in this project.

2. In the file `../ContactAgenda/App.config` find this line and change `source` parameter:

```xml
connectionString="data source=<SQL SERVER NAME>;initial catalog=ContactsAgenda;integrated security=True;"
```

## License

```xml
MIT License

Copyright (c) 2021 Anibal Ventura
```
