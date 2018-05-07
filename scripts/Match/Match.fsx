module A = 
    let (Some v1) = Some 11
    v1 = 11 |> printfn "%A"


module B = 
    type ('a, 'b) Either = This of 'a | That of 'b

    let this10 = This 10
    let that10 = That 10 

    let (This a | That a) = this10

    a |> printfn "%A" 

module C = 
    let [1],a,b,c = List.map id [1],11,12,13
    (a,b,c) |> printfn "%A"