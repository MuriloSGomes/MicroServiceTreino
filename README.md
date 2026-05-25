# 🛒 E-Commerce Microservices

A microservices-based e-commerce training project built with **.NET 10**, **Docker**, and **Docker Compose**.

---

## 🏗️ Architecture

```
┌─────────────────┐   ┌─────────────────┐   ┌─────────────────┐
│   Catalog API   │   │   Basket API    │   │  Discount API   │
│   (MongoDB)     │   │    (Redis)      │   │  (PostgreSQL)   │
│   :8000         │   │   :8001         │   │   :8002         │
└─────────────────┘   └─────────────────┘   └─────────────────┘
                                                      │
                                             ┌────────▼────────┐
                                             │  Discount gRPC  │
                                             │   (internal)    │
                                             └─────────────────┘
```

### Services

| Service        | Description                              | Database   |
|----------------|------------------------------------------|------------|
| Catalog API    | Product catalog management               | MongoDB    |
| Basket API     | Shopping cart management                 | Redis      |
| Discount API   | Coupon/discount management (REST)        | PostgreSQL |
| Discount gRPC  | Coupon/discount management (gRPC)        | PostgreSQL |

---

## 🚀 Getting Started

### Prerequisites

- [Docker Desktop](https://www.docker.com/products/docker-desktop/) (running)
- [.NET 10 SDK](https://aka.ms/dotnet/download) (for local development)

### Running with Docker Compose

Open a terminal, navigate to the `src` folder and run:

```bash
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

> **Tip:** Use `--build` to force a rebuild of the service images after code changes:
> ```bash
> docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d --build
> ```

---

## 🌐 Service URLs

| Service        | URL                                              |
|----------------|--------------------------------------------------|
| Catalog API    | http://localhost:8000/swagger                    |
| Basket API     | http://localhost:8001/swagger                    |
| Discount API   | http://localhost:8002/swagger                    |
| Portainer      | http://localhost:9000                            |
| pgAdmin        | http://localhost:5050                            |

**pgAdmin credentials:**
- Email: `admin@aspnetrun.com`
- Password: `admin1234`

---

## 🛠️ Tech Stack

- **.NET 10** — Web APIs & gRPC
- **MongoDB** — Product catalog storage
- **Redis** — Distributed cache for shopping cart
- **PostgreSQL** — Discount/coupon storage
- **Dapper** — Lightweight ORM for PostgreSQL
- **gRPC** — Internal service communication
- **Swashbuckle** — Swagger / OpenAPI documentation
- **Docker & Docker Compose** — Containerization

---

## 🧹 Cleanup

Stop all containers:
```bash
docker-compose -f docker-compose.yml -f docker-compose.override.yml down
```

Remove all containers, images and volumes (full reset):
```bash
docker rm -f $(docker ps -a -q)
docker rmi -f $(docker images -a -q)
docker volume rm $(docker volume ls -q)
```
