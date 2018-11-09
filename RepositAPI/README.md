# RepositAPI
The RepositAPI primarily serves a list of code snippets from the RepositAPI database. The API also supports POST requests
to create new Snippets and new Authors. For more info, please visit the [docs](https://repositapi.azurewebsites.net/swagger). 

## Main Endpoint
https://repositapi.azurewebsites.net/api

## Documentation
[RepositAPI Documentation](https://repositapi.azurewebsites.net/swagger)

## Usage
Example request to get all snippets:

1. Send a GET request to https://repositapi.azurewebsites.net/api/snippet via Postman or use the following CURL command ```curl -X GET "https://repositapi.azurewebsites.net/api/Snippet" -H "accept: text/plain"```
2. You'll receive a response like the following partial list:
	![partial-snippet-list](../assets/GETSnippet.png)

## Database Schema

## Tools used
Visual Studio, .NET MVC Core, Entity Framework, Swagger, Azure

## Contributors
Kendra Ellis (ellisken)
Jeff Weng (inkh)

## License
MIT