
# C# Hand-ons exercise: Chat History API 

This is a simple chat history API that allows you to store and retrieve chat messages. The API is implemented in C# with .NET 8.

# Overview

- The API has two endpoints: one to store a chat message and another to retrieve chat messages.
- The API stores chat messages in an Azure SQL Service.
- The API use Entity Framework Core to interact with the database.

# How to run the API

1. Clone the repository.
2. Setup your Azure SQL Service, then run following SQL script to create the database's schema:
   
```sql
CREATE TABLE Topics (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Name NVARCHAR(255),
    UserID NVARCHAR(255)
);

CREATE TABLE Messages (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Content NVARCHAR(MAX),
    Timestamp DATETIME2,
    TopicId UNIQUEIDENTIFIER,
    FOREIGN KEY (TopicId) REFERENCES Topics(Id)
);
```
3. Add the connection string to the database in the `appsettings.json` file and `appsettings.Development.json` file.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "AZURE_SQL_CONNECTIONSTRING": "your connection string"
  }
}
```
4. restore the dependencies and run the API.

```bash
dotnet restore
dotnet run
```

# Testing the insert endpoint

To test the insert endpoint, you can use the following curl command:

> Note: replace the localhost's port number with the port number you are using.

```bash
curl -X 'POST' \
  'http://localhost:5035/api/chat/histories' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "Name": "Topic Name",
  "UserID": "User1",
  "Messages": [
    {
      "Sender": "User2",
      "Content": "Hello, this is the first message",
      "Timestamp": "2022-01-01T00:00:00"
    },
    {
      "Sender": "User3",
      "Content": "Hello, this is the second message",
      "Timestamp": "2022-01-01T01:00:00"
    }
  ]
}'
```

## Testing the retrieve endpoint

To test the retrieve endpoint, you can use the following curl command:

> Note: if you insert new topic with different username, you need to replace the username in the URL. The example use `User1` as the username.

```bash
curl -X 'GET' \
  'http://localhost:5035/api/chat/histories/User1/topics' \
  -H 'accept: */*'
```

