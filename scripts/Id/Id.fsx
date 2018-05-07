open System.Linq

type Shop = { 
    Products : Product list
} and Product = { 
    Name: string
}

let shops = [
    { Products = [
        { Name = "AA" }
        { Name = "BB" }
        { Name = "CC" }
    ] }
    { Products = [
        { Name = "DD" }
        { Name = "EE" }
        { Name = "FF" }
    ] }
]

let a = [12;3;3;4;44;44]

a.OrderBy(fun x -> x) |> printfn "%A"

a |> List.sortBy id |> printfn "%A"
