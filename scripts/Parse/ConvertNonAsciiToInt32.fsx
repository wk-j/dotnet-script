open System

module Int32 = 
    let private (|Number|_|) character = 
        match Char.GetNumericValue character with
        | -1.0 -> None
        | other -> Some other

    let private value character = 
        match character with
        | Number n -> n.ToString()
        | _ -> character.ToString()

    let tryParseNonAscii text = 
        let digits = [for c in text -> c] |> List.map (value) 
        let sb = Text.StringBuilder()
        digits |> Seq.iter (sb.Append >> ignore)
        sb.ToString() |> Int32.TryParse 

// Usage 
"๑๒๓১১১123"
|> Int32.tryParseNonAscii |> printfn "%A" // (true, 123111123)  

"๑๒๓๔๖๗๘๙๐"
|> Int32.tryParseNonAscii |> printfn "%A" // (true, 123467890)