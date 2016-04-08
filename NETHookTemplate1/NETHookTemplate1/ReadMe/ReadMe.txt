


This template is a standard C# class library project for use with Mastercam X8. The project 
has a reference to the NETHook3_0.dll located in the root directory of your Mastercam X8 installation. 
However, if you installed into a directory other than the default installation directory you may need to update the project reference to the NETHook3_0.dll 
in order for your project to compile.


The included ProjectSetup documents detail setup for building debuging a NETHook.

**NOTE: This NETHook class library targets the .NET 4.0 Framework x64 build.
**NOTE: Building will give a command copy error until you rename the FT file to match that of your project
**NOTE: Make sure you are running Visual Studio in Adminstrator mode, see the ProjectSetup documents for instructions.


Visual Studio Free Community Edition is recommended if you are using the previous Visual Studio Express Edition.
https://www.visualstudio.com/en-us/news/vs2013-community-vs.aspx


Recommend Visual Studio Add-ons:

StyleCOP is free and recommended (we use it here at CNC Software)

https://stylecop.codeplex.com
StyleCop analyzes C# source code to enforce a set of style and consistency rules.
StyleCop provides value by enforcing a common set of style rules for C# code. 
StyleCop will continue to ship with a single, consistent set of rules, with minimal rule configuration allowed. 
Developers can implement their own rules if they so choose.