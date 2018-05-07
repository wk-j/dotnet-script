open System.Runtime.Remoting.Messaging

let getData() = async { 
    return 100
}

let getMoreData a = async { 
    return a + 1
}

async { 
    let! a = getData()
    let! b = getMoreData a
    let! c = getMoreData b
    let! d = getMoreData c
    let! e = getMoreData d
    return e
}

|> Async.RunSynchronously
|> printfn "%A"

let bind f a = async.Bind (a, f)

let (>>=) x f = bind f x

getData() >>= getMoreData >>= getMoreData >>= getMoreData |> Async.RunSynchronously 

