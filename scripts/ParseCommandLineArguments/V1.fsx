let orderByName = "N"
let orderBySize = "S"

type CommandLineOptions = { 
    Verbose: bool
    Subdirectories: bool
    OrderBy: string
}

let rec parseCommandLineRec args optionsSofar = 
    match args with
    | [] ->
        optionsSofar
    | "/v" :: xs ->
        let newOptions = { optionsSofar with Verbose = true }
        parseCommandLineRec xs newOptions
    | "/s" :: xs ->
        let newOptions = { optionsSofar with Subdirectories = true }
        parseCommandLineRec xs newOptions
    | "/o" :: xs ->
        match xs with
        | "S" :: xss ->
            let newOptions = { optionsSofar with OrderBy = orderBySize}
            parseCommandLineRec xss newOptions 
        | "N" :: xss ->
            let newOptions = { optionsSofar with OrderBy = orderByName}
            parseCommandLineRec xss newOptions 
        | _ ->
            eprintfn "OrderBy needs a second argument"
            parseCommandLineRec xs optionsSofar 
    | x :: xs ->
        eprintfn "Option %s is unrecognized" x
        parseCommandLineRec xs optionsSofar

let parseCommandLine args = 
    let def = { Verbose = false; Subdirectories = false; OrderBy = orderByName }
    parseCommandLineRec args def

parseCommandLine []
|> printfn "%A"