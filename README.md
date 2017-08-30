# Microservices Done Right - Demos

## How to get the sample working locally

### Get a copy of this repository

Clone or download this repo locally on your machine. If you're downloading a zip copy of the repo please be sure the zip file is unblocked before decompressing it. In order to unblock the zip file:

- Right-click on the downloaded copy
- Choose Property
- On the Property page tick the unblock checkbox
- Press OK

### Check your machine is correctly configured

In order to run the sample the following machine configuration is required:

- PowerShell execution policy to allow script execution, from an elevated PowerShell run the following:

```
Set-ExecutionPolicy Unrestricted
```

- Visual Studio 2015 Update 3 (Community Edition is supported), available for download at [https://www.visualstudio.com/downloads/](https://www.visualstudio.com/downloads/)

- .Net framework 4.6.1 Targeting pack for Visual Studio, available for download at [https://www.microsoft.com/en-us/download/details.aspx?id=49978](https://www.microsoft.com/en-us/download/details.aspx?id=49978)

- A SQL Server edition or the `LocalDb` instance installed by Visual Studio, in case of a clean machine with `LocalDb`only please install:
  - Microsoft ODBC Driver 11 for SQL Server, available for download at [https://www.microsoft.com/en-us/download/details.aspx?id=36434](https://www.microsoft.com/en-us/download/details.aspx?id=36434)
  - Microsoft ODBC Command Line Utilities 11 for SQL Server, available for download at [https://www.microsoft.com/en-us/download/details.aspx?id=36433](https://www.microsoft.com/en-us/download/details.aspx?id=36433)

NOTE: On a clean machine do not install latest version, as of this writing 13.1, of Microsoft ODBC Driver and Microsoft ODBC Command Line Utilities as the latter is affected by a bug that prevents the `LocalDb` instance to be accessible at configuration time.

### Databases setup

To simplify `LocalDB` instance setup 2 PowerShell scripts, in the [scripts](scripts) folder, are provided for your convenience. Both need to be run from an elevated PowerShell console.

- Run `Setup-Databases.ps1`, with elevation, to create the `LocalDB` instance and all the required databases
- Run `Teardown-Databases.ps1`, with elevation, to drop all the databases and delete the `LocalDB` instance

The created `LocalDB` instance is named `(localdb)\microservices-done-right`.

NOTE: If you receive errors regarding "Microsoft ODBC Driver", you can work around these by connecting to the `(localdb)\(localdb)\microservices-done-right` database using, for example, Visual Studio or SQL Managerment Studio, and running the SQL contained in the `.sql` file (`Setup-Databases.sql` or `Teardown-Databases.sql`) corresponding to the `.ps1` file which raised the error.

NOTE: In case the database setup script fails with a "sqllocaldb command not found" error it is possible to install `LocalDb` as a standalone package by downloading it separately at [https://www.microsoft.com/en-us/download/details.aspx?id=29062](https://www.microsoft.com/en-us/download/details.aspx?id=29062)

## NServiceBus configuration

This sample has no [NServiceBus](https://particular.net/nservicebus) related pre-requisites as it's configured to use the new [Learning Transport](https://docs.particular.net/nservicebus/learning-transport/) and [Learning Persistence](https://docs.particular.net/nservicebus/learning-persistence/) explicitly designed for short term learning and experimentation purposes.

They should also not be used for longer-term development, i.e. the same transport and persistence used in production should be used in development and debug scenarios. Select a production [transport](https://docs.particular.net/transports/) and [persistence](https://docs.particular.net/persistence/) before developing features. 

NOTE: Do not use the learning transport or learning persistence to perform any kind of performance analysis.