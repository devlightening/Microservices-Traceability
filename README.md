# Microservices-Traceability

This repository demonstrates a **microservices traceability architecture** built with .NET.  
It covers **centralized logging, correlation tracking, and message-based communication**.  
The solution integrates **NLog** for structured logging and persists logs to **SQL Server**.  

---

## 📂 Project Structure

- **AspNetCore.Application**  
  ASP.NET Core application with middleware for correlation IDs and request tracing.  
<img width="1476" height="415" alt="AspNetCore Application" src="https://github.com/user-attachments/assets/56eb7c85-7d87-4c0a-9973-1ce0581e48c1" />

- **Console.Application**  
  Console app that demonstrates sequential task execution with correlation-aware logging.  
<img width="1400" height="111" alt="ConsoleApp NLog Triggered" src="https://github.com/user-attachments/assets/b6611fe9-9fa6-4440-8155-096aecca964f" />

- **MessageBroker.Scenario**  
  - **Publisher**: Publishes events/messages.  
  - **Consumer**: Consumes events/messages.  
  - **Shared**: Shared contracts (e.g., DTOs).  
<img width="1427" height="1005" alt="MessageBroker Scenario" src="https://github.com/user-attachments/assets/7b6a2cdc-9f6f-4b23-a055-ab52f880d0d6" />
<img width="1472" height="701" alt="MessageBroker ScenarioDatabase" src="https://github.com/user-attachments/assets/85b96bda-df57-40d7-b40f-abdf98f0587f" />


---

## ⚙️ Features

- Centralized logging with **NLog**  
- Logs persisted into **SQL Server**  
- **CorrelationId** support for end-to-end traceability  
- Middleware for ASP.NET Core request tracking  
- Publisher/Consumer messaging scenario (RabbitMQ-like simulation)

---

## 🚀 Getting Started

1. Clone the repository:
   ```sh
   git clone https://github.com/<DevLightening>/Microservices-Traceability.git
