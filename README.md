<p>It is a desktop application created following modern software development principles. A solution supports a computer game - Richard Burns Rally and it is designed for individual users. It allows them to easily create online tournaments by selecting values from the lists, sending, receiving messages between users, and browsing through available tracks. 
It is designed using the MVVM pattern, which is supported by the CaliburnMicro framework. The UI library is based on WPF (XAML), with an additional material design library for styling and controls. User authorization and profile creation are based on the Entity framework. 
The UI library connects to relational SQL databases using web API. Additional design patterns which were used: dependency injection, singleton (only for logged in user data).</p>

<h2>Table of contents</h2>
<ul>
  <li>
    <a href="#rbr-datamanager">RBR Data Manager</a>
  </li>
  <li>
    <a href="#rbr-datamanagerlibrary">RBR Data Manager.Library</a>
  </li>
  <li>
    <a href="#rbrdesktopui">RBR Desktop UI</a>
  </li>
    <ul>
    <li>
      <a href="#shellviewmodel">Shell View Model</a>
    </li>
    <li>
      <a href="#tournamentviewmodel">Tournament View Model</a>
    </li>
    <li>
      <a href="#loginviewmodel">Login View Model</a>
    </li>
    <li>
      <a href="#messageviewmodel">Message View Model</a>
    </li>
    <li>
      <a href="#trackviewmodel">Track View Model</a>
    </li>
    <li>
      <a href="#userviewmodel">User View Model</a>
    </li>
    <li>
      <a href="#masterviewmodel">Master View Model</a>
    </li>
    <li>
      <a href="#registerviewmodel">Register View Model</a>
    </li>
    <li>
      <a href="#bootstrapper-class">Bootstrapper class</a>
    </li>
    </ul>
  <li>
    <a href="#rbrdesktopuilibrary">RBRDestopUI.Library</a>
  </li>
    <ul>
      <li>
        <a href="#api-endpoints">Api Endpoints</a>
      </li>
      <li>
        <a href="#models">Models</a>
      </li>
    </ul>
  <li>
    <a href="#rbrdriverhubdata">RBRDriverHub Data</a>
  </li>
  <li>
    <a href="#swagger">Swagger</a>
  </li>
  <li>
    <a href="#caliburnmicro">CaliburnMicro</a>
  </li>
</ul>

<br>

<h2>RBR DataManager</h2>
<a href="https://github.com/jakubsulej/RBRDriverHub/tree/master/RBRDataManager">Click here to see code</a>
<p>A .NET web API library, which connects the SQL Database with the UI. It contains the Entity framework with its database for user operations, like login, register, and others. For every database operation, there are web API controllers, which initialize operations from the DataManager.Library class to a web server.</p>

<br>

<h2>RBR DataManager.Library</h2>
<a href="https://github.com/jakubsulej/RBRDriverHub/tree/master/RBRDataManager.Library">Click here to see code</a>
<p>The DataManager.Library is a data access type class with database logic. It contains a connection with the database and all the logic that helps web API controllers making operations. In the library class, there are models, that keep the property for the web API operations. For each operation, there is one data model class. For easy managing through all the classes, the naming convention determinates that for database connection the names contain DB and for the other operations stays Models for List of models and ModelDetails for the properties.</p>

<br>

<h2>RBRDesktopUI</h2>
<a href="https://github.com/jakubsulej/RBRDriverHub/tree/master/RBRTrackFinder">Click here to see code</a>
<p>A user interface class, which has all the logic behind display data and get data from the user. It is designed following the MVVM pattern to easily manage the solution and make the application more flexible in the future. Due to a micro ORM - CaliburnMicro implementation of the MVVM design pattern was easy and efficient.
The UI is a WPF (XAML), which is a powerful tool, enough for the needs of the solution. It also contains a Material design library for extra styling and additional user controls.</p>

<h3>ShellViewModel</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/blob/master/RBRTrackFinder/ViewModels/ShellViewModel.cs">Click here to see code</a>
<p>The main view model, that holds all the other view windows inside. It has a drawer-style menu bar on the left and a control panel on the top of the window. It has a logic for opening all the views inside using logged in user authorization to check if a user has permission to enter various parts of the application.</p>

<h3>TournamentViewModel</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/blob/master/RBRTrackFinder/ViewModels/TournamentViewModel.cs">Click here to see code</a>
<p>It allows users to create their tournaments for the game. With an easy selection of the values from the listviews and typing the tournament name or description, the creation process is fast and efficient. 
The tournament view model loads two lists of data from SQL database - cars and tracks. Then when the user selects each of the values it appears on the right-side panel. That indicates which values are currently selected and what exactly will be sent to a database. 
Other values, which are needed to create a tournament are tournament name, description, and date when it will start. It just requires user input and selection date from a date picker, then a tournament is ready to be sent to a database.
Because only logged in users can create new tournaments, it allows saving userId, who created a particular event. It is also necessary to save tournament id, which is unique because the Id string contains the current date and time connected with a userId.</p>

<p>*Removing selected values from the list is currently not available. On a TODO list.</p>

<h3>LoginViewModel</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/blob/master/RBRTrackFinder/ViewModels/LoginViewModel.cs">Click here to see code</a>
<p>User authorization is done by using the Entity framework and directly connecting to the database from web API. The successful logging in raises a bearer type token, necessary for further actions in the application. It also saves logged in user data to a Singleton user model, needed for other operations in the application.</p>

<h3>MessageViewModel</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/blob/master/RBRTrackFinder/ViewModels/MessageViewModel.cs">Click here to see code</a>
<p>The solution allows users to send and receive messages or attachments. It is designed to let users connect and save messages in the database. Application loads all the messages, which were sent to a logged user. It can also reply to received messages, change message subjects.</p>

<p>*Selecting the addressee user from the list is on a TODO list.</p>

<h3>TrackViewModel</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/blob/master/RBRTrackFinder/ViewModels/TrackViewModel.cs">Click here to see code</a>
<p>The application displays all the available tracks for the game with information and shows the state of its installation. It uses a text file and compares it to a server file. The differences are displayed in the list as uninstalled.</p>

<p>*Comparison of the tracks from the server with installed on the local machine is still work in progress.</p>

<h3>UserViewModel</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/blob/master/RBRTrackFinder/ViewModels/UserViewModel.cs">Click here to see code</a>
<p>UserView form takes all the data from a relational database to display it for every logged-in user. It connects data from User and UserRallyInfo and shows it on the screen. It is also possible to change some of the data, like user name or password, but the UserRallyInfo data is unchangeable.</p>

<h3>MasterViewModel</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/blob/master/RBRTrackFinder/ViewModels/MasterViewModel.cs">Click here to see code</a>
<p>A view prepared to be shown when none of the menu items is selected. The main purpose of the view is to show all the possibilities of the application.</p>

<h3>RegisterViewModel</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/blob/master/RBRTrackFinder/ViewModels/RegisterViewModel.cs">Click here to see code</a>
<p>A form that allows the user to insert data and register to an application as a new member. The register form checks if the email address is currently in the database, before registering a new person. For a safety reason, it also checks if the password field is equal to a confirm password field.</p>

<h3>Bootstrapper class</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/blob/master/RBRTrackFinder/Bootstrapper.cs">Click here to see code</a>
<p>An MVVM caliburnMicro class, which is a program.cs type class, necessary for executable methods and containers. There are container pattern objects with different types of access. Implemented container with a per request access, that helps the dependency injection execute one per every application request. The other type container in the bootstrapper class is a Singleton type, which is globally the same function for the whole application.</p>

<br>

<h2>RBRDesktopUI.Library</h2>
<a href="https://github.com/jakubsulej/RBRDriverHub/tree/master/RBRDesktopUI.Library">Click here to see code</a>
<p>The in-between class for DataManager and user interface, which holds data models and API endpoints.</p>

<h3>API Endpoints</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/tree/master/RBRDesktopUI.Library/Api">Click here to see code</a>
<p>The Endpoint class is designed to maintain API controllers, such as post and get. By using the Http protocol from .Net Http, it can synchronically make operations on Lists and JSON files and connect directly to a web API path which does the rest of the operation.
It also contains the ApiHelper class, which is generally a class for data operations needed for both side data operations  - send and receive.</p>

<h3>Models</h3>
<a href="https://github.com/jakubsulej/RBRDriverHub/tree/master/RBRDesktopUI.Library/Models">Click here to see code</a>
<p>Every operation needs to have data models, one for each way of data operations. There are also multiple model classes with only list property of other classes. It is designed to easily send data using the list of Details classes, which holds all the information.</p>

<br>

<h2>RBRDriverHubData</h2>
<a href="https://github.com/jakubsulej/RBRDriverHub/tree/master/RBRDriverHubData">Click here to see code</a>
<p>A SQL database for the solution, where is stored all the data needed for the application to work. For easy managing the solution, there is implemented a Stored procedure with all the SQL logic needed to be initialized from DataManager.Library. class. Some of the tables in the database are relational, which saves the space needed for storage.</p>

<br>

<h2>Swagger</h2>
<p>With the swagger framework ecosystem, testing the web API controllers was easier and more efficient. To access swagger, there needs to be IIS and Debug running, then after the IP number, the access path in the browser should be <IpNumber>/swagger.</p>

<br>

<h2>CaliburnMicro</h2>
<p>A micro ORM software that helps to map the MVVM pattern by exact file naming with its documentation.</p>
