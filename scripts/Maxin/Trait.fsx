open System

type Phonograph(id, name) = 
    member x.Id : int = id
    override x.ToString() = name

type EightTrack(id, name) = 
    member x.Id : int = id
    override x.ToString() = name

module Debug = 
    let inline whoAmI x = 
        sprintf "%s (%d) : %s"
            (^T: (member GetType : unit -> Type) x).Name
            (^T: (member Id: int with get) x)
            (^T: (member ToString : unit -> string) x)

let ph = Phonograph(537766170, "West End Blues")
let et = EightTrack(537765860, "Surrealistic Pillow")

Debug.whoAmI ph
|> printfn "%A"

Debug.whoAmI et
|> printfn "%A"

