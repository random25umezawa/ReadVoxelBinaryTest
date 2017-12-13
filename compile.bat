set CSCPATH=C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe
%CSCPATH% /target:library ReadVoxelBinary\BinaryReader.cs
%CSCPATH% /target:library /reference:BinaryReader.dll ReadVoxelBinary\VoxData.cs
%CSCPATH% /reference:BinaryReader.dll,VoxData.dll MainProgram.cs
