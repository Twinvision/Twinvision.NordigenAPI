

# NordigenAPI
A C# .NET Standard class library of all the endpoints for the [NORDIGEN API](https://nordigen.com/en/account_information_documenation/api-documention/overview/)

This project aims at creating a library which lets you to fill out all required information to perform each request.
It then handles all the more detailed HttpClient configurations, and will deal with serialization and deserialization.
The library also handles recreation of timed out authentications so you don't have to bother.

# Supported:
 - Accounts
 - Agreements
 - Institutions
 - Requisitions
 - Token

# Examples:

List all institutions for The Netherlands:
```cs
var nac = new NordigenAPICaller(secretId, secretKey);
var result = await nac.Institutions.GetInstitutions("nl");
```

# Tests

For more examples look at the Test project, which contains an implementation for every supported end point.

P.S.
If you want to run all the unit tests yourself you will have to use your own secretId and secretKey.
For more information about this check the "CheckCredentialsSetupSecretsPresent" TestMethod in the "CheckCredentialSetup" TestClass
