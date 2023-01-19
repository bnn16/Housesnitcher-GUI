# Housesnitcher

## How to run

  - build the project
  - extract the .exe in a new folder
  - navigate 2 folders up; example structure: 
    - .env (with the DB connection and stuff)
    - Housesnithcer/bin/release/net7.0-windows/housesnitcher.exe
  - in the `.env` file you need the following vars:
    - `DATABASES__SQLSERVER__CONNECTIONSTRING=DatabaseName`
    - `DATABASES__SQLSERVER__DATASOURCE=DatabaseSource`
  - if you want to change the structure required for the .env parsing, you can head to `Program.cs` and change the default .env parsing path.
  - you can find the migrations in the `Housesnitcher-GUI/migrations` folder

## Class Diagram
The class diagram is located in the `Housesnitcher-GUI/ClassDiagram.cs` file.

## MOSCOW table
Personally (Yordan), from what I have noted down for myself, the project has achieved most points:

  - Stable form separation
  - Controls-based design
  - Create-update(status) of Complaints, Tasks
  - Create announcements
  - rules page
  - admin page
  - user page
  - login
  - logout
  - separate forms for creating the different data entries
  - following mostly the SOLID principles, not letting classes also get too big, and/or bloated with functionality.

Nice to haves (not present):
  - Used the EntityFramework for the SQL part of the project. That would have made the work in SQL instead of 600+ lines of code, to maybe 200, or even less.
  - Had a WebAPI backend, preferrably using the ASP.NET framework (C#), but it proved to be too complex of an endeavor for the team.
  - Better GUI design. We have a very poor design, as most of the resources that were available were funneled into creating the back-end systems on a time crunch, and researching use of custom user controls, so our design was very low-quality.
  - Better synchronisation of behaviour between forms, buttons and spots. Having a lackluster focus on design did not contribute favourably to this.