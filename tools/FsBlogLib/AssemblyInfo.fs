﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FsBlogLib")>]
[<assembly: AssemblyProductAttribute("FsBlogLib")>]
[<assembly: AssemblyDescriptionAttribute("Blog aware, static site generation using F#.")>]
[<assembly: AssemblyVersionAttribute("0.3.1")>]
[<assembly: AssemblyFileVersionAttribute("0.3.1")>]
()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3.1"
