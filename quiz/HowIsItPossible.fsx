let (|Sample|_|) (a: int) : int option =
    printfn "%s" (Sample(Sample("Unit")))
    if a = 0 then Some a else None

match 100 with
| Sample a ->
    printfn "%A" a
| _ ->
    printfn "?"