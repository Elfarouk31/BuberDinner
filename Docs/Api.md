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

