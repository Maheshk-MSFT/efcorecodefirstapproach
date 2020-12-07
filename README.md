# efcorecodefirstapproach
CreateModel first then DB approach. Sample using C# .NET Core and EF Core connecting to SQL Server 

For VS 2019, Package manager commands to generate the model class and context:
PM> Add-Migrate InitialCreate (generate code)

PM> Update-Database (Creates the db tables)

PM> Add-Migration AddEmail (for code update to DB change)

PM> Update-Database

src: https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=vs

For VS Code
dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet ef migrations add AddBlogCreatedTimestamp

dotnet ef database update

src: https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli

![image](https://user-images.githubusercontent.com/61469290/101336962-18afda00-38a1-11eb-857f-f4a85a182018.png)

![f2](https://user-images.githubusercontent.com/61469290/101337054-39782f80-38a1-11eb-918a-7348e5e7dee9.PNG)

![mk1](https://user-images.githubusercontent.com/61469290/101345817-a396d180-38ad-11eb-9f86-5e22aaa4efac.PNG)


