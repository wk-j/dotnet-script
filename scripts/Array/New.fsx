open System

Array.create 10 0 
|> printfn "%A"

Array.create 10 "A"
|> printfn "%A"


Array.create 5 (DateTime.Now.Year) |> Array.mapi (+)
// [|2018; 2019; 2020; 2021; 2022|]


|> printfn "%A"
