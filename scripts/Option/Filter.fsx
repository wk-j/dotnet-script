open System


(null : string)
|> Option.ofObj
|> printfn "%A"

Some null
|> Option.filter (isNull)
|> printfn "%A"