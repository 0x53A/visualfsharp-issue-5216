#r "paket:
nuget Fake.IO.FileSystem
nuget Fake.DotNet.MSBuild
nuget Fake.DotNet.NuGet
nuget Fake.DotNet.Paket
nuget Fake.Tools.Git
nuget Fake.DotNet.Testing.NUnit
nuget Fake.DotNet.Testing.MSTest
nuget Fake.Core.Target //"
#load "./.fake/build.fsx/intellisense.fsx"

#if !FAKE
#r @"C:\Users\rieluk\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\netstandard.dll"
#endif

open System
open System.IO

let _ = "".IndexOf("", StringComparison.OrdinalIgnoreCase)

try
    ()
with :? DirectoryNotFoundException -> ()