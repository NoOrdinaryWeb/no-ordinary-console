# No Ordinary .NET Core Console
Templated .NET Core console application that includes dependency injection, logging and configuration. 

## Requirements
The latest [.NET Core][NetCore] tooling which is available in  Visual Sudio 2017 & up.

## How do I get it

### Nuget
Nuget package is hosted at [NoOrdinary.Console](#TODO) and can be installed by running the following...

```bash
dotnet new -i NoOrdinary.Console.Template::*
```

### Git 

```bash
https://github.com/NoOrdinaryWeb/no-ordinary-console.git
```

## How do I use it
Once the template is installed and available in  ```dotnet new```, you can run the following to scaffold your new project using this template.

```bash
dotnet new no-ordinary-console -n "MyName"
```

For additional information about config switches for the template, run the following...

```bash
dotnet new no-ordinary-console -h
```

### Configuration

| Config Parameter | Description |
| :---             | :---        |
| --title | Replaces title in console window header. |

## Built With

* [.NET Core](https://docs.microsoft.com/dotnet/core/) - The development platform used
* [Serilog](https://serilog.net/) - Provides diagnostic logging

## Authors

* **Chad Ramos** - *Initial work* - [PioneerCode]
* **Dan Elliott** - *Forked work* - [NoOrdinaryWeb]

See also the list of [contributors](https://github.com/NoOrdinaryWeb/no-ordinary-console/contributors) who participated in this project.

## Acknowledgments

* This project is a fork of the [Pioneer .NET Core Console Boilerplate](https://github.com/PioneerCode/pioneer-console-boilerplate)

[PioneerCode]: https://github.com/PioneerCode/ "Pioneer Code"
[NoOrdinaryWeb]: https://github.com/NoOrdinaryWeb/ "No Ordinary Web"
[NetCore]: https://docs.microsoft.com/dotnet/core/ ".NET Core"
