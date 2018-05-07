open System
open System.Linq

let items = [1;2;3]

type Items = { 
    Field : Nullable<int>
}

let data = [
    { Field = Nullable 1 }
    { Field = Nullable() }
]

data.Any(fun c -> items.Contains(int c.Field))
|> printfn "%A"

"1008" |> int |> printfn "%A"
