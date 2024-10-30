# TicketWise

TicketWise is a Ticket Management System built with .NET 8 and Blazor. This application is designed to manage support tickets, track their statuses, prioritize them, and assign them to the appropriate users. TicketWise includes entities for tickets, products, users, categories, priorities, discussions, and attachments.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Database Models](#database-models)
- [License](#license)

## Features

- **Ticket Management**: Create, assign, and manage tickets with priority levels and expected completion dates.
- **User Authentication and Role Management**: Leveraging ASP.NET Identity to manage users, roles, and permissions.
- **Categorization**: Organize tickets by categories for better tracking and reporting.
- **Discussion Threads**: Allow users to discuss each ticket, with the ability to add attachments.
- **Priority System**: Define priority levels to control expected resolution times.
- **Attachments**: Upload files to tickets and discussions for better communication.

## Technologies Used

- **.NET 8** - Back-end framework
- **Blazor** - Front-end framework
- **Entity Framework Core** - ORM for database operations
- **ASP.NET Identity** - User authentication and authorization
- **SQL Server** - Database

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or an equivalent database)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or another compatible IDE)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/TicketWise.git
   cd TicketWise
