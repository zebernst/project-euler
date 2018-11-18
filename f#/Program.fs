module Program
open Project_Euler.problems

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    
    
    let sum = p2.evenFibSum
    printfn "%A" sum
    0 // return an integer exit code
