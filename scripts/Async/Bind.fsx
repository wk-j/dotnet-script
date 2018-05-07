
let getData() = async { 
    return 100
}

let getMoreData a = async { 
    return a + 1
}

let print x = async { 
    printfn "%A" x
}

let (>>=) x f = async.Bind(x,f) 

getData() 
    >>= getMoreData 
    >>= getMoreData 
    >>= getMoreData  
    >>= getMoreData 
    >>= print
|> Async.RunSynchronously 

