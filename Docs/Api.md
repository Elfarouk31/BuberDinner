# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
    - [Register Request](#register-request)
    - [Register Response](#register-response)
    - [Login](#login)
    - [Login Request](#login-request)
    - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

### Register Request

```json
{
    "firstName": "Alfarouk",
    "lastName": "Aboouf",
    "email": "AlfaroukAboouf@Domain.com",
    "password": "AlfaroukAboouf@Domain.com"
}
```

### Register Response

```js
200 OK
```

```js
{
    "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "Alfarouk",
    "lastName": "Aboouf",
    "email": "AlfaroukAboouf@Domain.com",
    "token": "eyJhb..z9dqcnXoY"
}
```

### Login

```js
POST {{host/auth/login}}
```

### Login Request

```js
{
    "email": "AlfaroukAboouf@Domain.com",
    "password": "AlfaroukAboouf@Domain"
}
```

### Login Response

```js
{
    "email": "AlfaroukAboouf@Domain.com",
    "password": "AlfaroukAboouf@Domain",
    "token": "qjkksjH558...adjvk58785"
}
```



