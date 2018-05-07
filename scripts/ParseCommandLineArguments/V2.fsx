type OrderByOption = OrderBySize | OrderByName
type SubdirectoryOption = IncludeSubdirectories | ExcludeSubdirectories
type VerboseOption = VerboseOutput | TerseOutput

type CommandLineOptions = { 
    Verbose: VerboseOption
    Subdirectory: SubdirectoryOption
    OrderBy: OrderByOption
}

let rec parseCommandLineRec args options = 
    match args with
    | [] ->
        options
    | "/v" :: xs ->
        let newOptions = { options with Verbose = VerboseOutput }
        parseCommandLineRec xs newOptions
    | "/s" :: xs ->
        let newOptions = { options with Subdirectory = IncludeSubdirectories }
        parseCommandLineRec xs newOptions
    | "/o" :: xs ->
        match xs with
        | "S" :: xss ->
            let newOptions = { options with OrderBy = OrderBySize }
            parseCommandLineRec xss newOptions 
        | "N" :: xss ->
            let newOptions = { options with OrderBy = OrderByName }
            parseCommandLineRec xss newOptions 
        | _ ->
            printfn "OrderBy needs a second argument"
            parseCommandLineRec xs options
    | x :: xs ->
        printfn "Option %s is unrecognized " x
        parseCommandLineRec xs options

let parseCommandLine args = 
    let defaultOptions = {
        Verbose = TerseOutput
        Subdirectory = ExcludeSubdirectories
        OrderBy = OrderByName
    }

    parseCommandLineRec args defaultOptions