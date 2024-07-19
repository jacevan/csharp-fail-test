Simple Environment for Dotnet 8 and Updated NUnit Packages

#### Step 1: Run **SimpleApp**
- Navigate inside the **csharp-fail-test/SimpleApp** directory
- Run `dotnet restore`
- Run `dotnet build`
- Run `dotnet run`
- You should see `"Hello, World!"` output

#### Step 2: Run the tests
- Navigate to the test directory **csharp-fail-test/SimpleApp.tests**
- Run `dotnet restore`
- Run `dotnet test`
- You should see 1 failed test with output message `"FAILURE!!!!!"`