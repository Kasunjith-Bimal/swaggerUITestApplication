# swaggerUITestApplication
Asp .net Core 2.0
### Create Database using Sql Server 

```Database name - "YourDatabaseName"```

### Change Coonection String According Your 

```var connectionString = "Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True";```
```services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(connectionString));```

### Add migreation cmd using package manager console

```Add-Migration InitialCreate```
```Update-Database```

### Run Application 

``` Go localhost:http://localhost:62560/swagger```
