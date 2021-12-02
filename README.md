# Microsoft's Music Store in MVC 5 using Visual Studio 2019 (Framework 4.7.2) #

* MS Tutorial: <https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store>
* Music Store Assets: <https://github.com/evilDave/MVC-Music-Store>
* User Role Management Tutorial: <https://www.c-sharpcorner.com/UploadFile/asmabegam/Asp-Net-mvc-5-security-and-creating-user-role>

## IMPORTENT DIFFERENCE between MS's tutorial and Visual Studio 2019 ##

Part 1 (Creating Project):
* Create a `ASP.NET Web Application (.NET Framework)` project. Next.
* Give your solution a name. Next.
* Select `MVC`. Under "Authentication", the default is `No Authentication`. Change it to **`Individual User Accounts`**. Create.
    * Reason: Visual Studio 2015+ does not support section 7 in MS Tutorial (Membership and Authorization).

Part 2 - 6:
* have different UI but the everything are essentially the same.

Part 7 (Membership and Authorization):
* use "User Role Management Tutorial" as a reference

Part 8 - 10: 
* TBA. Haven't gotten this far.
