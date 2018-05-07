open Microsoft.FSharp.Quotations

type Calc = 
    [<ReflectedDefinitionAttribute>]
    static member Multiply x y = x * y


let expr3 = 
    typedefof<Calc>.GetMethod("Multiply")
    |> Expr.TryGetReflectedDefinition

expr3.Value |> printfn "%A"