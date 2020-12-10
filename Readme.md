#Tell a joke WebApi

#Url : http://<ServerName/ip>:<Port>/api/tellajoke
eg: [link name] http://localhost:53735/api/tellajoke

#Description:
This Web API returns a joke with random names. 
RestSharp Nuget Package is used to call the external webservices. 

# Publishing and hosting
TellaJoke API was published to a local folder with name "TellAJoke_Deploy".
Either this folder can be copied to a server location and added in the IIS as a website by adding the physical location as the server path name.
TellAJoke API can be published directly to IIS or Azure using Visual Studio publish option. 

#Sample response
"{\"type\":\"success\",\"joke\":\"Name Surname doesn't need a keyboard he tells the computer to write something and it does.\"}"



