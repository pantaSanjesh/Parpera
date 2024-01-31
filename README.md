  # Overview

This is a parpera-code-challenges. 

we have created 3 Projects:
1. TransactionUpdate: 
There are  2 Controller with following Apis:

     1. AuthController
        
        a.  GetToken- This will provide us token to for authorization(Have client key predefined as per given requirenment)
    
     3. Transaction Controller
        
        a. Get the list of Transaction - this will so the list of transaction available
        
        b. Update the Transaction Status - After getting token we will be authorized to update the status
2. TransactionUpdate.DalLayer
    - It contains the Model , Interface , DbContext and Repositories which is interact with database.
    - We have use sqllite for database as in memory database is stored in .db file 
    - We have use Repository pattern which interact with Database and controller.

3. TransactionUpdate.Tests
      - We have created Xunit test project and Moq has been add for mocking data statically for test.
      - There are 4 test cases as follows:
        
          1.GetAll_ReturnsListOfTransactions
        
          2.UpdateTransactionStatus_WithValidId_ReturnsOkResult
        
          3.UpdateTransactionStatus_WithInvalidId_ReturnsNotFoundResult
        
          4.UpdateTransactionStatus_ThrowsException_ReturnsStatusCode500

## Getting Started
Run the project on visual studio. The swagger is enabled for now.

### Prerequisites
Packages required with project details:

1.TransactionUpdate
- Microsoft.AspNetCore.Authentication.JwtBearer
- Swashbuckle.AspNetCore
- Microsoft.EntityFrameworkCore.Design
2. TransactionUpdate.DalLayer
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Sqlite
3. TransactionUpdate.Tests
- coverlet.collector
- Microsoft.Net.Test.Sdk
- Moq
- xunit
- xunit.runner.visualstudio

### For Database
   - We have use sqlite for data storage
     
   - To access check the data i have added separate folder for database named Db:

      
        1. Firstly go into command prompt and in cmd checked in the Db path,then write command sqlite3 Transaction.db(databasename with .db extension )
          
        2. Finally write select query ,then you will get the result(eg.  select * from Transactions;)as Transactions is my table name.
### More Features
- Use TransactionDbContext to add contents to import to table.
- Enable Authorize to make the api secured in the Controller.
- JwtBearer package is installed to add security to api.

#### File and Folders
- TransactionDbContext : The dbContext class to add DB related tables and contents.
- Repository  : Interface is created with implementation by injecting controller to access data from database
- Interface : Interface to add functions to be used in API.

##### Bonus

- JWT token authorization is enable which required you to add token while you try to update transaction.
- To get JWT token, run the Auth Controller api from the swagger. Copy the api code and paste it in the Authorization code box of the update api that is Transaction/{id}/update-status.
- While model is created the contents has been added to tables for transaction data. You can find it in the TransactionDbContext file. 
- Connection string is added but that requires [configuration to be done on running machine]. However, db class is generated inside the project as transaction.db.
