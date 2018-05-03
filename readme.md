Unit Testing Tutorial for C# Developers
https://www.youtube.com/watch?v=HYrXogLj7vg

Purpose: Demonstrate Unit Testing with each MSTest and NUnit test in Visual Studio, using the NuGet package manager.


#### C# Code 


| Original Code            | Simplified Code                            |
| ------------------------ | ------------------------------------------ |
| `var user = new User();`<br>`user.IsAdmin = false;` |  `var user = new User { IsAdmin = false }` |

- `IDE0017	Test C# Object initialization can be simplified` - recommendation made by IDE.


### Info 

MSTest - https://en.wikipedia.org/wiki/Visual_Studio_Unit_Testing_Framework

NuGet - https://en.wikipedia.org/wiki/NuGet

TDD 

#### Visual Studio Gotchas

- Native Unit Tests - Unit Test added 
	- via Add New Project > Installed > Visual C# > Test > Unit Test Project (.NET Framework).

- Package Manager Console 
	- via View > Other Windows > Package Manager Console 

- `Install-Package NUnit -Version 3.8.1` in PM
	- when Default Project droplist is `...`.`UnitTests` selected.



