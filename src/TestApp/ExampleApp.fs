// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

module Example


let httpApp : HttpApp.HttpApplication<string> = 
    (fun state req -> 
        HttpApp.Response.text 
            (sprintf "Okey, the app state is '%s', and the time is %s" state (System.DateTime.Now.ToString())) 
        |> Some)

let httpExposeApp = { HttpApp.Expose.HttpApplication.HttpApplication = httpApp }