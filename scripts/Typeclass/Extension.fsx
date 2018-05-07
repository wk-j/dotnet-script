 let inline show (a : ^A) = ( ^A : (static member Show : ^A -> string) a )

type System.String with 
    static member Show(a : System.String) = sprintf "{String: %A}" a

type System.Boolean with 
    static member Show(a : System.Boolean) = sprintf "{Boolean: %A}" a

type Stop = 
    | Stop
    with
        static member Show(v: Stop) = 
            printfn "{Stop}"
            "{Stop}"

type MyType<'A> = 
    | MyType of 'A
    with
    static member inline Show(v: MyType< ^B >) = 
        match v with
        | MyType a -> sprintf "{MyType: %A}" (show a)

let p = show (MyType Stop)
let s = show (MyType (MyType Stop))
//let s = show (MyType (MyType "foo")) // error as extension methods are not picked up atm
