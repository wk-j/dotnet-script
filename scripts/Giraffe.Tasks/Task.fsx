open System.IO
#r "../packages/Giraffe.Tasks/lib/net461/Giraffe.Tasks.dll"

open Giraffe.Tasks

let readFileAndDoSomething (filePath: string) = 
    task  { 
        use stream = new FileStream(filePath, FileMode.Open)
        use reader = new StreamReader(stream)
        let! contents = reader.ReadToEndAsync()
        return contents
    }


let rs = readFileAndDoSomething("README.md")

rs 
|> Async.AwaitTask
|> Async.RunSynchronously
|> printfn "%A"