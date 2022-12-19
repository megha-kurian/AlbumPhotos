# AlbumPhotos
Design and create a RESTful API in ASP.NET Core. The API should call, combine, and return these 2 API endpoints into a single HTTP response. The response should show the combined collection so that each Album contains a collection of its Photos. 
**Built with**
API builts with .Net Core 3.1
Nunit testing included.
**Prerequisites**
VisualStudio 2019
**Architecture**
--Dependency Injection-allows usto have the best experience decoupling our architecture layers
--Interfaces and Implementations-allows the Controllers in my API project to adhere to another established contract for getting the correct methods to process the API methods in the domain project
--Domain Layer
 *Defines the Entities objects that will be usedthroughout the solution
 *Defines the interfaces through which our Data layer can implement the data access logic
 *Implements Services
 --Data Layer
 * This project doesnt have data base intraction, so reads jsonplaceholder in this layer
 --API layer
 *Thislayer contains the cntroller with 2 endpoints
**Content**
 API  consist of 2 operations; 
 One to return all the data from the given endpoints-GetAllData-To handling the large data performance issues paging added.
 One to return data relating to a single User Id-GetData with userid
 
 **Improvements Required**
 Code cleaup
 Exception Handling can be improve by using Exception Filters
 Unit Testing- Test Coverage can be increase
 Performance improvement
  **TODO**
  Logging
  Authentication
 
