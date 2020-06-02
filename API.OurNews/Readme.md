### Our news
#### News Application: Asp.net core and React 

#### MS SQL Database


### Commands Dotnet

>> Add Migration using EF: dotnet ef migrations add InitialCommitSetupProject -p Persistence/ -s API.OurNews/
>> dotnet ef migrations add "AddedIdentity" -p Persistence/ -s API.OurNews/


>> Update Database: dotnet ef database update -p Persistence/ -s API.OurNews/

>> Remove Migration: dotnet ef migrations remove --project Persistence -s API.OurNews

>> Check user-secrets: dotnet user-secrets list

>> Watch Run: dotnet watch run (works only inside the startup project)


### Commands react app
>> Create application: npx create-react-app my-app --template typescript
>> Start: npm start




### Back end installation

* Microsoft.EntityFrameworkCore 2.2.6: Persistence
* Microsoft.EntityFrameworkCore.SqlServer 2.2.6: Persistence
* Mediator: MediatR.Extensions.Microsoft.DependencyInjection 8.0.0
* AutoMapper.Extentions.Microsoft.DependencyInjection - 7.0.0 - Application Business 

### Front end installation
* Axios: npm install axios@0.19.1
* Semantic UI: npm install semantic-ui-react@0.88.2
* Carousel: npm i semantic-ui-carousel-react@1.1.1
* Moment: npm install moment@2.26.0

## NOT YET

Logic

Microsoft.EntityFrameworkCore.Proxies - 2.2.6 Persistent Project (Lasizn loading) 

* To access secret.json file, click with the right button on the project and click on Manage User Secrets. The json file will open.


* Security: NWebSec.AspNetCore.Middleware 2.0


#### To do ####

### Front end installation
##### uuid for Guid
##### npm install mobx mobx-react-lite (5.14.2, 1.5.0)
##### npm install react-router-dom
##### npm install react-toastify
##### npm install react-final-form@6.3.0 final-form@4.16.1 (Form validations)
##### npm install react-widgets react-widgets-date-fns
##### npm install revalidate
##### npm install npm install --save react-dropzone@10.1.5
##### npm install --save react-cropper@1.2.0
##### npm install @microsoft/signalr@3.1.3
##### npm install react-infinite-scroller

### After security configuration on Startup, add following:
#### Semantic ui css: npm install semantic-ui-css 2.4.1