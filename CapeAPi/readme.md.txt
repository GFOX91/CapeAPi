To connect to the database and test this project a the connection string should be added in the projects user secrets:

{
  "ConnectionStrings": {
    "LiveDatabase": "INSERT YOUR CONNECTION STRING HERE;"
  }
} 

Improvements:

1.I would change the api endpoint to a GET request as apposed to a HTTPOST due to it only retrieving data and not updating anything in the
database, the user's email and ID would be passed through as route parameters in the url.
2. I would change the name of the DB table "CUSTOMER" to "CUSTOMERS" for consistency with other table naming conventions 