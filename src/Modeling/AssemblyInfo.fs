﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Modeling")>]
[<assembly: AssemblyProductAttribute("Modeling")>]
[<assembly: AssemblyDescriptionAttribute("Modeling toolkit")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
