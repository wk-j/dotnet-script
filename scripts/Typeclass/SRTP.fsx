
let inline item1 (t :'a ) = 
    ((^a) : (member Item1: _ ) t)

type A(a) = 
    member __.Item1 = sprintf "A(%A)" a 

type B(b) = 
    member __.Item1 = sprintf "B(%A)" b

A(100) |> item1 |> printfn "%A"
B(true) |> item1 |> printfn "%A"