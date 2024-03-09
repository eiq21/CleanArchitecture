# Métodos CRUD para la entidad Article

En este archivo se describen los métodos CRUD (Create, Read, Update, Delete) para la entidad `Article`.

## Crear un artículo

### Descripción

Este método permite crear un nuevo artículo en la base de datos.

### Request

- Método: POST
- Ruta: `/articles`
- Headers:
  - Content-Type: application/json
- Body:
  ```json
  {
    "title": "Título del artículo",
    "content": "Contenido del artículo"
  }
  ```

### Response

- Código de estado: 201 (Created)
- Body:
  ```json
  {
     "articleId": "cfa66ea1-a7d5-47d1-9465-bcdac6d571e8"
    "title": "Título del artículo",
    "content": "Contenido del artículo"
  }
  ```

## Obtener un artículo

### Descripción

Este método permite obtener los detalles de un artículo existente.

### Request

- Método: GET
- Ruta: `/articles/{id}`

### Response

- Código de estado: 200 (OK)
- Body:
  ```json
  {
    "articleId": "cfa66ea1-a7d5-47d1-9465-bcdac6d571e8"
    "title": "Título del artículo",
    "content": "Contenido del artículo"
  }
  ```

## Actualizar un artículo

### Descripción

Este método permite actualizar los datos de un artículo existente.

### Request

- Método: PUT
- Ruta: `/articles/{id}`
- Headers:
  - Content-Type: application/json
- Body:
  ```json
  {
    "title": "Nuevo título del artículo",
    "content": "Nuevo contenido del artículo"
  }
  ```

### Response

- Código de estado: 200 (OK)
- Body:
  ```json
  {
     "articleId": "cfa66ea1-a7d5-47d1-9465-bcdac6d571e8"
    "title": "Nuevo título del artículo",
    "content": "Nuevo contenido del artículo"
  }
  ```

## Eliminar un artículo

### Descripción

Este método permite eliminar un artículo existente.

### Request

- Método: DELETE
- Ruta: `/articles/{id}`

### Response

- Código de estado: 204 (No Content)
