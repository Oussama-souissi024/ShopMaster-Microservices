# ShopMaster

## Project Status
🚧 **In Development** 🚧

## Introduction
**ShopMaster**  is an e-commerce application based on a microservices architecture. Each microservice is independent and responsible for a specific functionality of the application, ensuring modularity and increased scalability.

## Project Architecture
The ShopMaster application is divided into several microservices that communicate with each other via HTTP calls. This architecture allows for a separation of concerns, better dependency management, and the ability to scale each service independently.

## Service Menu
- **ShopMaster.Web**
- **ShopMaster.Services.CouponAPI**
- **ShopMaster.Services.ProductAPI**
- **ShopMaster.Services.AuthAPI**
- **ShopMaster.MessageBus**
- **ShopMaster.Services.EmailAPI**
- **ShopMaster.Services.OrderAPI**
- **ShopMaster.Gateway**
- **ShopMaster.Services.RewardAPI**
- **Stripe**

### Services in the Project

1. **ShopMaster.Web**  
   This is the frontend of the ShopMaster application, developed with ASP.NET MVC. This component allows end-users to interact with the various services of the application, including authentication, product management, and shopping cart functionality. It consumes the APIs of the microservices to display information to users.

2. **ShopMaster.Services.CouponAPI**  
   This service manages the coupons within the ShopMaster application. Developed with ASP.NET Core, it allows users to create, read, update, and delete coupons. It uses Entity Framework to interact with the coupon database and AutoMapper to manage mappings between data models and DTOs. This service is secured by role-based permissions, allowing only administrators to create and modify coupons. Coupon information is exposed via a REST API, and the service connects to a SQL Server database for data storage.

3. **ShopMaster.Services.ProductAPI**  
   This service manages the products within the ShopMaster application. Developed with ASP.NET Core, it allows users to create, read, update, and delete products. It uses Entity Framework to interact with the product database and AutoMapper to manage mappings between data models and DTOs. This service is secured by role-based permissions, allowing only administrators to create and modify products. Product information is exposed via a REST API, and the service connects to a SQL Server database for data storage.

4. **ShopMaster.Services.AuthAPI**  
   This service handles user authentication in the ShopMaster application. Developed with ASP.NET Core, it allows users to register, log in, and assign roles. The service uses Identity Framework to manage users and roles, and Entity Framework to interact with the authentication database. JWT tokens are generated to ensure secure authentication and are configured based on options specified in the configuration file. The API endpoints are exposed via a REST API, allowing for smooth integration with other services within the application. This service connects to a SQL Server database for data storage and uses Swagger for API documentation.

5. **ShopMaster.MessageBus**  
   This service manages asynchronous communication between the various microservices within the ShopMaster application. Developed with .NET 8, it uses Azure Service Bus to publish messages to topics and queues. The IMessageBus interface defines the PublishMessage method, allowing services to send serialized JSON objects, ensuring secure and efficient data transmission. The service also generates a unique correlation ID for each message, facilitating tracking and debugging. Thanks to its modular design, the MessageBus integrates seamlessly into the microservices architecture, ensuring smooth and scalable communication between the application components.

6. **ShopMaster.Services.EmailAPI**  
   This service manages the sending of emails within the ShopMaster application. Developed with .NET 8, it uses Azure Service Bus to receive messages and trigger email-sending actions. The service includes an EmailService that handles the creation and sending of email messages, as well as logging sent emails. Incoming messages are processed using Service Bus consumers that manage different actions, such as sending a cart summary, user registration confirmation, and order notifications. Connection data for the SQL Server database and Service Bus information are configured through appsettings files. This microservice exposes functionalities via a REST API, providing asynchronous and scalable communication for the application.

7. **ShopMaster.Services.OrderAPI**  
   This service manages order processing within the ShopMaster application. Developed with ASP.NET Core, it allows users to create, read, update, and delete orders. The service uses Entity Framework to interact with the order database and AutoMapper to manage mappings between data models and DTOs. It supports order processing, including validation, total calculation, and order status management. Order information is exposed via a REST API, allowing other services, such as the payment service and authentication service, to consume order data. This service is secured by role-based permissions, ensuring that only appropriate operations can be performed by users. Data is stored in a SQL Server database, and the service uses Swagger for API documentation, facilitating integration and usage by other components of the application.

8. **ShopMaster.Gateway**  
   The ShopMaster.Gateway service serves as the main entry point for all microservices within the ShopMaster application. Developed with ASP.NET Core, this component plays a vital role in managing user requests by redirecting them to the appropriate services. It acts as a reverse proxy, allowing for smooth communication between the frontend and various microservices while providing an additional layer of security through centralized authentication and authorization.  
   The gateway also handles the collection and aggregation of responses from microservices, facilitating a seamless user experience. In addition to request management, it incorporates rule-based routing mechanisms, enabling API calls to be directed to the most appropriate services based on the provided URL and parameters.  
   This service is designed to be scalable and maintainable, allowing for the easy addition of new microservices without requiring significant changes to the existing architecture. With the use of Swagger, API documentation is automatically generated, providing developers with an interactive interface to explore the different available routes.

9. **ShopMaster.Services.RewardAPI**  
   The ShopMaster.Services.RewardAPI service is a key element of the loyalty system within the ShopMaster application, designed to enhance the shopping experience for users by allowing them to earn and redeem loyalty points. Developed with ASP.NET Core, this service aims to encourage user engagement and strengthen brand loyalty through attractive rewards.  

   With RewardAPI, users can easily accumulate points based on their interactions on the platform, whether through regular purchases or participating in special promotions. This service also provides an intuitive interface for checking point balances and a detailed transaction history, while offering flexible redemption options, such as discounts or exclusive products.  

   To ensure effective reward management, this service includes administrative features to configure point earning and redemption rules, as well as monitor user activities through a dedicated dashboard. RewardAPI is secured by role-based permissions, ensuring that only authorized users can perform loyalty point transactions.  

   By integrating Swagger for API documentation, ShopMaster.Services.RewardAPI facilitates integration with other microservices, providing maximum transparency and accessibility for developers and administrators.

10. **Stripe Payment Integration Overview**
    Stripe is used in two key services:

CouponAPI: Synchronizes coupon data with Stripe for discounts during checkout.
OrderAPI: Manages payment processing securely and efficiently.
Testing with Stripe:
To test Stripe functionality:

Set up your Stripe test account.

Use the provided API keys in your appsettings.json for both CouponAPI and OrderAPI.

json
Copier le code
{
  "Stripe": {
    "ApiKey": "sk_test_...",
    "PublishableKey": "pk_test_..."
  }
}
Test payments using Stripe's test card details:

Card Number: 4242 4242 4242 4242
Expiry Date: Any valid future date.
CVC: Any 3 digits.
Verify payments and discounts in your Stripe dashboard.
![ShopMaster-Project-Design](https://raw.githubusercontent.com/Oussama-souissi024/ShopMaster-/refs/heads/main/Microservices-project-architecture.png)
