
Unit Testing Tutorial for C# Developers
https://www.youtube.com/watch?v=HYrXogLj7vg

#### Used

Native VS Unit Tests - Unit Test added (via Add New Project > Installed > Visual C# > Test > Unit Test Project (.NET Framework)).

mstest - https://en.wikipedia.org/wiki/Visual_Studio_Unit_Testing_Framework

IDE0017	Test C# Object initialization can be simplified

| Original Code            | Simplified Code                            |
| ------------------------ | ------------------------------------------ |
| `var user = new User();` |  `var user = new User { IsAdmin = false }` |
| `user.IsAdmin = false;`  |                                            |
