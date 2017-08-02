// include Fake lib
#r "System.Xml.Linq"
#r @"packages\FAKE\tools\FakeLib.dll"
open Fake
open System.Xml.Linq

RestorePackages()


let buildDir  = @".\build\"


Target "Clean" (fun _ ->
    CleanDirs [buildDir]
)

Target "Build" (fun _ ->
    !! @"src\TestApp.sln"
      |> MSBuildRelease buildDir "Build"
      |> Log "AppBuild-Output: "
)


"Clean"
  ==> "Build"
  


// start build
RunTargetOrDefault "Build"