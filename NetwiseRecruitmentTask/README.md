# Netwise Recruitment Task - Cat Facts App

This project is a simple ASP.NET Core MVC web application that fetches random cat facts from an external API and stores them in a text file. Users can view these stored cat facts on the homepage.

## Prerequisites

Before you begin, ensure you have the following installed on your development machine:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio](https://visualstudio.microsoft.com/)/[Visual Studio Code](https://code.visualstudio.com/)/Other IDE (optional)
- [Docker](https://www.docker.com/) (optional, for Docker deployment)

## Getting Started

### Running Locally

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/netwise-recruitment-task.git
   cd netwise-recruitment-task
    ```
### Open the solution:

Open NetwiseRecruitmentTask.sln or navigate to the project folder and open it.

## Run the application:
Use your IDE to build and run the application.
Alternatively, run the following .NET CLI commands:

```bash
dotnet build
dotnet run --project NetwiseRecruitmentTask
```

## Running with Docker
Build the Docker image:

Ensure you have Docker installed and running on your machine. Run the following command from the project root directory:

```bash
docker build -t netwise-recruitment-task .
```
### Run the Docker container:

Execute the following command to start a Docker container from the built image, mapping port 5000 (or any other exposed port in your Dockerfile) on your local machine to port 5000 inside the container:

```bash
docker run -d -p 5000:5000 netwise-recruitment-task
```

## Access the application

### IDE/.NET CLI
App should open itself at the start. If not go to the link shown in terminal.

### Docker
Open your web browser and navigate to http://localhost:5000 to view the application.

## Technologies Used:

- ASP.NET Core MVC
- C#
- Bootstrap (for styling)

## Additional Notes
- The application uses Dependency Injection for managing services.
- Logging is implemented to track errors and events.
- The layout and styling can be further customized in Views/Shared/_Layout.cshtml and wwwroot/css/site.css.
