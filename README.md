# Product API - .NET Core

## Descripción

Esta API RESTful en **.NET Core** permite gestionar productos mediante operaciones **CRUD** (Crear, Leer, Actualizar y Eliminar). Se ha desarrollado con **arquitectura MVC** y utiliza **Swagger** para documentación.

---

## Tecnologías Utilizadas

- **.NET Core** (ASP.NET Web API)
- **C#**
- **Swagger** (Documentación automática)
- **Inyección de dependencias**

---

## Instalación y Configuración

### 1️⃣ Clonar el Repositorio

```sh
git clone https://github.com/juansapi/ProductApi.git
cd ProductApi
```

### 2️⃣ Restaurar Dependencias

```sh
dotnet restore
```

### 3️⃣ Ejecutar el Proyecto

```sh
dotnet run
```

Por defecto, la API estará disponible en:

```
https://localhost:5001
```

---

## Documentación con Swagger

Para acceder a la documentación interactiva, abre en tu navegador:

```
https://localhost:5001/swagger
```

Aquí puedes probar los endpoints de la API de forma visual.

---

##  Endpoints

###  Obtener todos los productos

**GET** `/api/products`

###  Obtener un producto por ID

**GET** `/api/products/{id}`

###  Crear un nuevo producto

**POST** `/api/products`

####  JSON Body:

```json
{
  "name": "Laptop",
  "price": 1200.99,
  "quantity": 5
}
```

###  Actualizar un producto

**PUT** `/api/products/{id}`

####  JSON Body:

```json
{
  "name": "Laptop Pro",
  "price": 1500.99,
  "quantity": 3
}
```

### Eliminar un producto

**DELETE** `/api/products/{id}`
