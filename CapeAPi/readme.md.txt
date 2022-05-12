Apologies I only realised I could pull through the data via an excel file after I had set up the data layer with a connection to the DB. 

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
3. I would install Serilog packages with Sentry in order to log any unhandled exceptions produced by the OrderHelper during prodction phase.
4. I would set up two seperate unit testing projects for the client layer and business layer utilising a combination of xunit and Mock to perform units tests on the controller and helper classes.
5. I would configure xml comments for swagger in order to better document the API for devs needing to utilise it.
6. Possibly implement AutoMapper for mapping Models to DTO automatically.
7. Personal preference but I don't tend to use shared projects to store models, I usually create a common package that I publish to as an artifcat to azure to be utilized as a nuget package, (a bit beyond the scope of this particular excercise!)