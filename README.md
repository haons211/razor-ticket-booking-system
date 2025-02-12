# Razor Ticket Booking System

## Introduction
The **Razor Ticket Booking System** is a web-based application built with ASP.NET Core and Razor Pages. This system allows users to book tickets for events, manage reservations, and handle payments efficiently.

## Prerequisites
Before running the project locally, ensure you have the following installed:

- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)
- [.NET SDK 6.0+](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) (recommended)

## Getting Started

### 1. Clone the Repository
```sh
git clone https://github.com/haons211/razor-ticket-booking-system.git
cd razor-ticket-booking-system
```

### 2. Run with Docker
Ensure Docker is running, then execute the following command:
```sh
docker-compose up --build -d
```
This will start the necessary services including the database and the application.

### 3     . Start the Application
Ensure in the project folder:
```sh
cd razor-ticket-booking-system
```
Start migration:
```sh
dotnet ef database update
```
Load my project:
```sh
http://localhost:8080/
``` 
### 4     . Set up SQL Server Management




## Comand For Migration
```
dotnet ef migrations add ...
```

```
dotnet ef database update
```

## Troubleshooting
- If the application fails to start due to database issues, ensure SQL Server is running and the connection string is correct.
- Run `docker-compose logs` to check logs for errors.
- Check `.env` settings if environment variables are missing.

## Contributing
Feel free to submit issues and pull requests to improve the project.

## License
This project is licensed under the [MIT License](LICENSE).
