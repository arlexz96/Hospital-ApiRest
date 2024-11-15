
# Hospital-ApiRest

This project is a medical appointment management platform where users can register, log in, and interact with the system based on their assigned role. Users can schedule appointments with doctors, but the system ensures that no double booking occurs for the same doctor at the same time.

Key features include:

* Registration and Authentication: Users can register and log into the platform, with access controls based on their role.
* Appointment Management: The system allows users to schedule appointments, updating availability in real time. It also provides warnings when attempting to book an appointment during an already booked time slot.
* Filters and Search: Users can filter appointments by date, specialty, or reason.
* Notes and Comments: Users can add notes or comments to each appointment for additional information.
* Role-Based Access Control: Users can only view information relevant to their role, whether they are a patient, doctor, or administrator.
This system aims to improve the efficiency of medical appointment management, ensuring a smooth user experience without scheduling conflicts, while maintaining proper control over roles and access.
## Requiariments
+ .NET 8 SDK or higher.
+ MySQL server.
+ Swagger is integrated, so no need for Postman or external API testing tools.
+ Environment Variables Ensure you set the following environment variables
 
DB_HOST = your_host
DB_NAME = your_database_name
DB_PORT = your_port
DB_USERNAME = your_username
DB_PASSWORD = your_password

JWT_KEY = your_jwt_key
JWT_ISSUER = your_jwt_issuer
JWT_AUDIENCE = your_jwt_audience
JWT_EXPIRES_IN = time_in_minutes
## Restore Dependencies

```bash
Restore NuGet packages:

dotnet restore
```
    
## Authors

- [Arlex Mauricio Zapata Mesa](https://github.com/arlexz96)

