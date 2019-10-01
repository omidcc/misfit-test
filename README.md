# misfit-test

Misfit-test is a demo project for adding two big number that doesn't fit in .NET data type. This project is built on top of .NET Core 2.2, Angular 8 and MSSQL. Sql Server version is 2019.
Angular grid is implemented using ag-grid. Bootstrap v4.3.1 is used to style the markup. 
Please follow the bewlow steps to clone, setup and run the project

#### 1. Download repository
Create a folder in your machine and clone the repo using the following command through command prompt/git bash/console

    $ git clone https://github.com/omidcc/misfit-test.git

#### 2. Database preperation
Inside misfit folder there is another folder called "DbScript". Open the script in sql server management studio. press ctrl+a to select the entire script and execute the query. Now refresh the database names. There will be a new database appearing named "KhairulMisfitTestDB".

#### 3. Connection string change
Inside misfit>Misfit.Web project there is a appsettings.json file. 
Open the file in a text editor. That looks like below:
````json"MisfitConnection": "data source=localhost; initial catalog=KhairulMisfitTestDB;persist security info=True; User ID=YourDBUserID;Password=YourDbPassword;"
`````
Replace the "localhost" whith your host name or ip, "YourDBUserID" with your database userid and "YourDbPassword" with your datbase users password
