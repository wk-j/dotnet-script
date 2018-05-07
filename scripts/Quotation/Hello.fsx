open FSharp.Quotations

let expr : Expr<int> = <@ 1 + 1 @>
let expr2 : Expr = <@@ 1 + 1 @@>

module A = 
    <@@ 1 + 1 @@>
    |> printfn "%A"

    <@@ 1 + 10 / 5 @@>
    |> printfn "%A"

