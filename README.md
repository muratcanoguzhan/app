# App

- This project is based on .Net5 and endpoint is AspnetCore5. It uses in-memeory SqlServer db.
- EntityframeworkCore used as an ORM.
- Repository pattern used for abstracting CRUD or base operations to db. Note: I can add MongoDb also in this project regarding our structure.
- [Swashbuckle v5](https://github.com/mattfrear/Swashbuckle.AspNetCore.Filters) used for UI.
- Validations are provided by [fluentvalidation](https://fluentvalidation.net/)
- Created a serilog for listening each filtered request to endpoint. (`"Microsoft", LogLevel.Information and "System", LogLevel.Error`)
- Added AutoMapper to easily map our db models to dtos and dtos to our db models.
- Added CORS for preventing unwanted requests. It accepts only our predefined host as you can see in our `StartUp` class `builder.WithOrigins("http://localhost:8080")`
- Used IHttpClientFactory to request request to [restcountries.eu](https://restcountries.eu/rest/v2/name/aruba?fullText=true)

## Usage

Just open project. If Web project is not selected as startup project, select it and click to run. Then it serves you as just you want.
