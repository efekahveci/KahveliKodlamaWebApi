

# Kahveli Kodlama Web Api

This is a solution template for building an ASP.NET Core Web API following the Clean Architecture principles. Our scenario is to create a forum site. We have our topics, users and content. 

Hope it will be a useful resource for those interested.

Give a Star! ⭐
If you like this project, learn something or you are using it in your applications, please give it a star. Thanks!
## Clone the project

Run the command to clone this project

```bash
  git clone https://github.com/efekahveci/KahveliKodlamaWebApi.git
```

  
# Project Structure

## API
  
* ASP.NET Core Web API application
* REST API principles, CRUD operations  
* Repository Pattern Implementation
* Using Microsoft Identity with JWT
* Using EFCORE for micro-orm implementation to simplify data access and ensure high performance
* Implementing DDD, CQRS, and Onion Architecture with using Best Practices
* Developing CQRS with using MediatR, FluentValidation,AutoMapper and SeriLog packages
* Swagger Open API implementation
  
## CLIENT

* Angular 

  
## DATABASE

* POSTGRESQL is used as database. The appsettings.json file of the projects should be edited for the local server.

And run on package manager console 

```bash
   update-database -Context KahveliContext
   update-database -Context IdentityContext
```

## For What

I have a goal of creating a resource for friends who are just starting out and want to 
follow current structures. You can stay tuned to see the formation of similar libraries 
or innovations.
## API Usage

#### Fetch all items

```http
  GET /api/Category/getAllDto
```

| Parameter | Type     | Desc                |
| :-------- | :------- | :------------------------- |
| `api_key` | `string` | **Necessary**. Your API key. |

#### Fetch item


```http
  GET api/Category/getByIdDto/${id}
```

| Parameter | Type     | Desc                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Necessary**. Key value of the item to be called |


  
