open System

let sleepWorkflow = async { 
    printfn "Starting sleep workflow at %O" DateTime.Now.TimeOfDay
    do! Async.Sleep 2000
    printfn "Finished sleep workflow at %O" DateTime.Now.TimeOfDay
}

// Async.RunSynchronously sleepWorkflow

let nestedWorkflow = async { 
    printfn "Start parent"
    let! childWorkflow = Async.StartChild sleepWorkflow
    do! Async.Sleep 100
    printfn "Doing something useful while waiting"

    let! result = childWorkflow
    printfn "Finished parent"
}

Async.RunSynchronously nestedWorkflow