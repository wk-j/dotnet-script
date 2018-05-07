#r "../../packages/JWT/lib/net46/JWT.dll"
#r "../../packages/Newtonsoft.Json/lib/net45/Newtonsoft.Json.dll"

open JWT
open JWT.Algorithms
open JWT.Serializers
open System.Collections.Generic
open Newtonsoft.Json
let payload = 
    [
        "claim1", "0"
        "clail2", "claim2-value"
    ] |> dict

let secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk"
let algo = HMACSHA256Algorithm()
let serializer = JsonNetSerializer()
let url = JwtBase64UrlEncoder()

let encoder = JwtEncoder(algo, serializer, url)
let token = encoder.Encode (payload, secret)

printfn "%A" token