# From backend to full stack

A repo with samples for the "from Backend to Full stack" session

## Blazor tips for getting started

### Step by step guide for the Blazor sample

#### Initial project creation

- Create new Blazor Project (ASP.NET Core - server side)
- Run/debug the project
- Project should work

#### Install MudBlazor components

- All details on [Mudblazor website](https://mudblazor.com/getting-started/installation)
- Install `MudBlazor` nuget package
- Add scripts & font references to `_Host.cshtml`
- Inject services with `builder.Services.AddMudServices();`

## MAUI : running with hot reload

dotnet watch build -t:Run -f:net7.0-ios -p:_DeviceName=:v2:udid=F80E4473-EE76-456E-B9E8-3C06CC1BD6E8

## Front end testing with Cypress.io

`npx cypress open`