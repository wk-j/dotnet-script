open System.IO

let stream = new System.IO.FileStream("README.md", FileMode.Open)

let result = stream.BeginRead(Array.empty, 0, 0, null, null)

let async = Async.AwaitIAsyncResult(result)

Async.RunSynchronously async |> printfn "%A"