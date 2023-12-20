module internal Codingteam.Ctor.GreenCaptchaBot

open Fabricator.Core
open Fabricator.Resources.Files

let private hostConfigDirectory = "/opt/green-captcha-bot/"
let private docker = docker {
    let version = "v1.15.1"
    fromSources <| sources {
        gitRepository "https://github.com/ImoutoChan/GreenCaptchaBot.git"
        reference $"tags/{version}"
    }
    withDockerfile "CaptchaBot/Dockerfile"
    withTag version
    withName "green-captcha-bot"
    withVolume(hostPath = hostConfigDirectory, containerPath = "/app/Configuration")
}

let private configFile = FileResource(templatedFile "GreenCaptchaBot.template.json", $"{hostConfigDirectory}/appsettings.json")

let resources: IResource[] = [| configFile; docker |]
