open Fabricator.Console
open Fabricator.Core
open Fabricator.Templates.FileTemplates

open Codingteam.Ctor

let private cluster mode = task {
    let connectionsFileName = if mode = EntryPoint.RunMode.Verify then "connections.stub.json" else "connections.private.json"
    let! parameters = readParameterFile "parameters.json"
    return [|
        {
            Name = "ctor"
            Designator = Designators.fromConnectionsFile connectionsFileName "ctor"
            Resources = GreenCaptchaBot.resources parameters
            Type = MachineType.Linux
        }
    |]
}

let main (args: string[]): int =
    EntryPoint.main args (fun m -> (cluster m).GetAwaiter().GetResult())
