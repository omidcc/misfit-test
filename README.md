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
```
"MisfitConnection": "data source=localhost; initial catalog=KhairulMisfitTestDB;persist security info=True; User ID=YourDBUserID;Password=YourDbPassword;"
```
Replace the "localhost" whith your host name or ip, "YourDBUserID" with your database userid and "YourDbPassword" with your datbase users password. Finally save changes.

#### 4. Install node packages
Go to inside misfit/Misfit.Web/ClientApp and run following command in console. This will install necessary node packages to run the angular project. Make sure you have node v10.13.0 or higher installed. Incase node not installed [download here](https://nodejs.org/en/download/).
```
npm install
```
### 5. Run the project
Go to inside misfit/Misfit.Web and run following command in console. 
```
dotnet run
```
This will build and start both angular and .NET Core API project. Make sure you have .NET Core SDK V2.2. Incase .NET Core SDK  2.2 is not installed [download here](https://dotnet.microsoft.com/download/dotnet-core/2.2). If successfully build then the there willbe a message showing in the console stating the below lines.
```info: Microsoft.AspNetCore.SpaServices[0]
      Starting @angular/cli on port 53885...
Hosting environment: Development
Content root path: D:\misfit\Misfit.Web
Now listening on: https://localhost:5001
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
info: Microsoft.AspNetCore.SpaServices[0]
      > Misfit.Web@0.0.0 start D:\misfit\Misfit.Web\ClientApp
> ng serve "--port" "53885"

** Angular Live Development Server is listening on localhost:53885, open your browser on http://localhost:53885/ **

info: Microsoft.AspNetCore.SpaServices[0]
      Date: 2019-10-01T14:54:25.591Z
Hash: 579bb51d84f56460ee21
Time: 17332ms
chunk {main} main.js, main.js.map (main) 35.1 kB [initial] [rendered]
chunk {polyfills} polyfills.js, polyfills.js.map (polyfills) 227 kB [initial] [rendered]
chunk {runtime} runtime.js, runtime.js.map (runtime) 5.22 kB [entry] [rendered]
chunk {styles} styles.css, styles.css.map (styles) 280 kB [initial] [rendered]
chunk {vendor} vendor.js, vendor.js.map (vendor) 6.11 MB [initial] [rendered]
i ｢wdm｣: Compiled successfully.
```
Now open the following link in the browser.
```
https://localhost:5001/
```
NOTE: IF the project refused to run on port 5001 or there is already running a process on that port, then go to misfit/Misfit.Web/Properties. There is a json file named "launchSettings.json". Open the file in a text editor. Find The following line.
```
"applicationUrl": "https://localhost:5001;http://localhost:5000"
```
Now replace your desired port with 5001 and save changes. And then again run the project follwoing step 5 first paragraph.

For the application demonstration see the images in [HomePage](https://github.com/omidcc/misfit-test/blob/master/home.png) and  [Results Page](https://github.com/omidcc/misfit-test/blob/master/results.png). To see the image scroll horizontally or download.

If there is any issue occured running the project setup contact me through -
Email & Skype - khairulomi@gmail.com. 

**Please Don't get confused seeing one other contributor.That khairulislamsp is also me.Had to update from that account due to permission issue on that particular network.


