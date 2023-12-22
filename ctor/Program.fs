open Codingteam.Ctor
open Fabricator.Console
open Fabricator.Core

let private cluster mode =
    let connectionsFileName = if mode = RunMode.Verify then "connections.stub.json" else "connections.private.json"
    [|
        {
            Name = "ctor"
            Designator = Designators.fromConnectionsFile connectionsFileName "ctor"
            Resources = GreenCaptchaBot.resources
            Type = MachineType.Linux
        }
    |]

let main (args: string[]): int =
    EntryPoint.main args cluster
