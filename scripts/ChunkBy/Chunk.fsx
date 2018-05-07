open System
[1;2;3;4;45]
|> List.chunkBySize 2
|> printfn "%A"