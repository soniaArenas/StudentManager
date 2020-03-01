# StudentManager

It is a task of the Vueling University. I have to make a program that allows to manage students in different files, formats .xml, .json and .txt.

## Implementation

To implement this project I must to use the Abstract Factory Pattern and 3 layers architecture.
I have been studying the pattern and its possible implementations to be able to develop the program correctly.

## Planing the project development
First I must make a form to enter the data of the students I want to insert or check, here will also be chosen the type of file we want.
Below I must create folders and files corresponding to each of the classes and factories.
	

 - For Implent the 3 layers architecture I have to create the nexts folders:
	 		 - Common.Layer
	 		 - Data Acces
	 		 - Presentation
 - I have to do the folder for the tests too.
 - For imlement the Abstract Factory Pattern I must create the nexts folders:
			 - Abstract Factory, with the interface IFileFactory.
			 - Concret Factory, with the classes, Xml, Txt and Json.
			 - Abstract Product, with the interfaces ICreate, IRead,IUpdate,IDelete.
			 - Product,with the classes, CreateXml, CreateJson,CreateTxt, 
ReadXml, ReadJson, ReadTxt, UpdateXml, UpdateJson, UpdateTxt, DeleteXml,DeleteJson, DeleteTxt.

I must attach the necessary libraries to be able to create, read, update and delete files of the different formats
