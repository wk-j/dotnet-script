open System.Threading

let testLoop = async { 
    for i in [1..100] do
        printfn "%i before.." i
        do! Async.Sleep 10
        printfn "..after"
}

//Async.RunSynchronously testLoop

let cancellationSource = new CancellationTokenSource()
Async.Start(testLoop, cancellationSource.Token)
Thread.Sleep(200)

cancellationSource.Cancel()