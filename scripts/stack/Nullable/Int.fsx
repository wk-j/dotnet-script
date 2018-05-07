open System

let inline int32 (value: ^T) = 
    (^T : (static member ToInt: ^T -> int32) (value))


type A<'T>() = 
    static member ToInt(t: 'T) = 100

