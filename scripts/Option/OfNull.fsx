open System
["a"; null;null]
|> List.map (Option.ofObj)
|> printfn "%A"

[Nullable 1; Nullable() ; Nullable 1]
|> List.map (Option.ofNullable)
|> printfn "%A"
