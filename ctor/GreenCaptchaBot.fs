module internal Codingteam.Ctor.GreenCaptchaBot

open Fabricator.Core
open Fabricator.Resources.Files
open Fabricator.Resources.Docker

let private hostConfigDirectory = "/opt/green-captcha-bot/"
let private docker =
    let version = "v1.15.1"
    dockerContainer {
        Sources = {
            GitRepository = "https://github.com/ImoutoChan/GreenCaptchaBot.git"
            GitReference = $"tags/{version}"
        }
        DockerfilePath = "CaptchaBot/Dockerfile"
        Tag = version
        Name = "green-captcha-bot"
        Options = [|
            Volume(hostPath = hostConfigDirectory, containerPath = "/app/Configuration")
        |]
    }

let private configFile = FileResource(templatedFile "GreenCaptchaBot.template.json", $"{hostConfigDirectory}/appsettings.json")

let resources: IResource[] = [| configFile; docker |]
