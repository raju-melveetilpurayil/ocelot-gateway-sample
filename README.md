# .NET Microservices with Ocelot API Gateway

This project demonstrates a simple microservices architecture using **ASP.NET Core** and **Ocelot** as an **API Gateway**. It includes:

- A dedicated **API Gateway** using Ocelot
- Two backend services: **Products API** and **Orders API**
- Routing requests from the gateway to the respective services
- Configurable, scalable, and modular structure

---

## 🧱 Architecture Overview

Client → Ocelot Gateway → [Products API, Orders API]


- `OcelotGateway`: Serves as the entry point using Ocelot to route HTTP requests.
- `ProductsApi`: Handles product-related endpoints.
- `OrdersApi`: Handles order-related endpoints.

Each service runs independently and communicates only through the API Gateway.

---

## 📁 Project Structure

MySolution
OcelotGateway → Ocelot configuration & entry point

ProductsApi → Product microservice

OrdersApi → Order microservice

OcelotGatewaySample.sln → Solution file

---

## 🔀 API Gateway Routing (ocelot.json)

```json
{
  "Routes": [
    {
      "DownstreamPathTemplate": "/api/products",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7033
        }
      ],
      "UpstreamPathTemplate": "/products",
      "UpstreamHttpMethod": [ "Get" ]
    },
    {
      "DownstreamPathTemplate": "/api/orders/",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7032
        }
      ],
      "UpstreamPathTemplate": "/orders",
      "UpstreamHttpMethod": [ "Get" ]
    }

  ],
  "GlobalConfiguration": {
    "BaseUrl": "https://localhost:7077"
  }
}

```
---
## 🚀 Getting Started
Clone the repo:
```
git clone https://github.com/raju-melveetilpurayil/ocelot-gateway-sample.git
```
Run each service independently:

- ProductsApi on port 7033

- OrdersApi on port 7032

- ApiGateway on port 7077

Send requests through the gateway:
```
GET http://localhost:7077/products

POST http://localhost:7077/orders
```
---

## 📦 Technologies Used
ASP.NET Core 8

Ocelot

REST APIs

Minimal API / Controllers

C#


---

## 🔧 Future Improvements
Add authentication using JWT

Register services via Consul or Eureka

Dockerize and orchestrate with Docker Compose

## 📝 License
This project is open source and available under the MIT License.

---
