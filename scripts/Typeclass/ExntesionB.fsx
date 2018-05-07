let inline show (a : ^A) = ( ^A : (static member Show : ^A -> string) a )

type System.String with 
    static member Show(a : System.String) = sprintf "{String: %A}" a

type System.Boolean with 
    static member Show(a : System.Boolean) = sprintf "{Boolean: %A}" a

type Stop = 
    | Stop
    with
        static member Show(v: Stop) = "{Stop}"


show (Stop)
show ("100")