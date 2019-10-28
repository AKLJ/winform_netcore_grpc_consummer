# winform_netcore_grpc_consummer
Quick project to see a Winform application using Net Core 3.0 consumming a gRPC server

# What's this project about ?

A quick demo about Winform and gRPC on Core at the same time.
The idea is having stock movements which are available through a gRPC service and displayed by a Winform application. 

# Before starting
Please make sure to download the [preview version of Net Core Winform designer](https://devblogs.microsoft.com/dotnet/introducing-net-core-windows-forms-designer-preview-1/) 

# Usage
Start the project selected main project WNGC.Winform. 
Click on create button to create a stock list then click on the read button to call the gRPC service and display the results.

# So what about Winform and .NET Core ?
First and foremost the usage is OK. Now let's say the Winform designer (a preview version) is shaky at best. It's definitely worth mentionning I had to kill Visual Studio multiples times when I tried to do some fancy stuffs as... deleting or renaming a button on the designer.
IMHO, the easiest way to do some quick Winform UI is to use panel tool and do modification directly in cs file.
Truth to be told, as of now, Microsoft has explained Winform on NET Core is at experimentation phase.

# So what about gRPC and .NET Core ?