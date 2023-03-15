# Book Microservice
This is a microservice that manages a list of books. It provides RESTful APIs for retrieving, creating, updating, and deleting books. The microservice is implemented using .NET Core, ASP.NET Core, Entity Framework Core, and Docker. The data is stored in a SQL Server database.

# Prerequisites
To run this microservice, you need to have the following software installed on your machine:

# Docker
.NET Core SDK 3.1
Running the Microservice
To run the microservice, follow these steps:

Clone this repository to your machine.
Open a terminal and navigate to the root of the cloned repository.
Build the Docker image by running the following command:
Copy code
docker build -t book-service .
Start a Docker container by running the following command:
css
Copy code
docker run -d -p 8080:80 --name book-service-container book-service
This will start the microservice in a Docker container and map port 8080 of the host machine to port 80 of the container. The container will be named book-service-container.
Open a web browser and navigate to http://localhost:8080/api/books. This should return a list of all books.
Testing the Microservice
To test the microservice, you can use a REST client such as Postman or the built-in functionality of your web browser. The following endpoints are available:

### GET /api/books: Get all books
### GET /api/books/{id}: Get a book by ID
### POST /api/books: Create a new book
### PUT /api/books/{id}: Update an existing book
### DELETE /api/books/{id}: Delete a book by ID