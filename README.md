![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")
# Sitecore Hackathon 2021

- MUST READ: **[Submission requirements](SUBMISSION_REQUIREMENTS.md)**
- [Entry form template](ENTRYFORM.md)
- [Starter kit instructions](STARTERKIT_INSTRUCTIONS.md)
  

### ⟹ [Insert your documentation here](ENTRYFORM.md) <<

# CSV to YML Generator for JSS application

# Module Sitecore Hackathon Category: 
Best use of Headless using JSS or .NET

# Module Purpose: 
Its very tedious jobs for front end developer to create bulk of en.yml files for creating route pages for angular or react based JSS application in disconnected approach. Our tool will automatically create en.yml files from provided CSV file based on template YML file.

# Approach:

1.	Basically front end developers create YML files manually then they deploy it to Sitecore as

![Normal Way Deployment](docs/images/Normal Way.png?raw=true "Normal Way Deployment") 

2.	Our tool will generate all these YML files in bulk from CSV files based on provided template of en.yml file which can be easily deploy to Sitecore as

![Tool Way Deployment](docs/images/Tool Way.png?raw=true "Tool Way Deployment")  

3.	This tool will save time, efforts of frontend developers.
4.	Once Sitecore items are created from these en.yml files, once can access items from running JSS application on localhost and at the same time one can also access it form Sitecore.

# Installation Instructions:
1.	Download zip file from 
2.	Unzip it.
3.	Run “\Hackathon\CSVToYMLConverter\CSVToYMLConverter\bin\Debug\ CSVToYMLConverter.exe”
How does the end user use the Module?
1.	Create a CSV file for which you want to create YML files as

![Sample CSV File](docs/images/CSV.png?raw=true "CSV") 

2.	Create a YML based template file in which specify placeholders for CSV fields as 

![Template YML File](docs/images/Template YML.png?raw=true "Template YML") 
 
3.	Run “\Hackathon\CSVToYMLConverter\CSVToYMLConverter\bin\Debug\CSVToYMLConverter.exe”

![CSV To YML Generator Tool](docs/images/CSV To YML Generator Tool Blank.png?raw=true "CSV To YML Generator Tool Blank")  

4.	Browse your CSV file, YML file template, location where you want to create YML files, language name and select field for item name.
5.	Click RUN

![CSV To YML Generator Tool](docs/images/CSV To YML Generator Tool.png?raw=true "CSV To YML Generator Tool")   


6.	After successful operation, this tool will create yml files at the specified Target folder as  

![File Location](docs/images/File Location.png?raw=true "File Location") 
  
7.	When you open it in VS Code, it should look similar to this

![In VS Code](docs/images/In VS Code.png?raw=true "In VS Code")  

5.	You can also deploy it to Sitecore using “jss deploy app -c -d” command. 
6.	On successfully deployed, your items should be available to Sitecore as 

![In Sitecore](docs/images/In Sitecore.png?raw=true "In Sitecore")  

Youtube Video: 
	https://youtu.be/EA8PZweoZ7U  


