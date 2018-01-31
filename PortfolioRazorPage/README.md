# Task List API

**Author**: Ariel R. Pedraza <br />
**Version**: 1.0.0

## Overview
<b>Purpose:</b><br />
This application is a MVC ASP.NET API to test Get, Post, Put and Delete routes. 

<b>How to use:</b><br />
Use the following routes to access the Tasks API: 
https://taskapi2.azurewebsites.net/
```
[HttpGet] api/Tasks
[HttpGet] api/Tasks/{id}
[HttpPost] api/Tasks
[HttpPut] api/Tasks/{id}
[HttpDelete] api/Tasks/{id}
```
Use the following routes to access the Lists API: 
https://taskapi2.azurewebsites.net/
```
[HttpGet] api/List
[HttpGet] api/Task/{id}
[HttpPost] api/Task
[HttpPut] api/Task/{id}
[HttpDelete] api/Task/{id}
```
<b>Example:</b><br />
http://taskapi2.azurewebsites.net/api/List/1
```
{
    "id": 1,
    "name": "List 1",
    "taskList": [
        {
            "id": 1,
            "title": "Task 1",
            "notes": "Notes for task 1",
            "time": "2018-01-30T06:04:14.2209074",
            "listClassId": 1
        },
        {
            "id": 2,
            "title": "Task 2",
            "notes": "Notes for task 2",
            "time": "2018-01-30T06:04:28.2104058",
            "listClassId": 1
        }
    ]
}
```
## Getting Started
The following is required to run the program locally.
1. Visual Studio 2017 
2. The .NET desktop development workload enabled
3. Ensure appsettings.json connection string is set to:
```
"ConnectionStrings": {

    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=TaskDB;Trusted_Connection=True;MultipleActiveResultSets=true"
```
4. Install Entity Framework, and build database with the following commands in the Package Manager Console:
```
Install-Package Microsoft.EntityFrameworkCore.Tools
Add-Migration Initial
Update-Database
```

## Architecture
This application is created using ASP.NET Core 2.0 Web applications. <br />
*Language*: C# <br />
*Type of Applicaiton*: API <br />