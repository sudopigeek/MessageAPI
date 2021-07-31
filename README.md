# MessageAPI
##### Simple API for message logging.

## Features:
* Retrieve, create, update, and delete messages using GET, POST, PUT, and DELETE methods.
* Small footprint and is easily expandable.

### To build:
* Download the project by clicking Code->"Download ZIP" or open in Visual Studio directly by clicking "Open with Visual Studio".
* Build the project in Visual Studio by clicking Build->"Build Solution" or by pressing the keyboard shortcut Ctrl+B.
### To run:
* After downloading and opening MessageAPI in Visual Studio, simply navigate to Debug->"Start Debugging" or by pressing F5.
* That's it! The API should now be running in your browser at https://localhost:44343/Main
### Usage:
NOTE: Use a HTTP/HTTPS client with ability to call the API using different methods (GET,POST,etc.) such as [Postman](https://www.postman.com/downloads/).
* #### Get All Messages:
  Send the main page URL (using GET) to retrieve all messages (default).
* #### Get Message By Id:
  Specify the Id of the desired message by appending it to the URL (using GET). For example, if you wanted to get the message at index 1, send https://localhost:44343/Main/1.
  NOTE: The Id to give in the API URL is the Id of the message object itself, not the 'Id' value associated with the message value.
* #### Create New Message:
  Send the main page URL (using POST) and specify a new message by sending it and an Id of your choice as JSON in the request body (e.g. `{"Id": 653, "Message": "This is a test message." }`) On success, the API will return a JSON document containing the total word count of all stored messages and a success variable.
* #### Update Existing Message:
  Send the main page URL (using PUT) with the id at the end of the URL and the new message value, surrounded by quotes, in the request body.
* #### Delete Message:
  Send the main page URL (using DELETE) with the id at the end of the URL (e.g. `https://localhost:44343/Main/1`).
