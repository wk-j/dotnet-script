type Foo() =
    static let test (t : 'T) : 'T list = 
        let b = new Bar<'T>(t)
        [b.Value]

    static member Test(t : int) = test t

and Bar<'T>(value : 'T) =
    member __.Value = value

printfn "%A" (Foo.Test 42)