module Project_Euler.problems.p2

let fibonacci = Seq.unfold(fun (a, b) -> Some(a+b, (b, a+b))) (1, 1)
let evenFibSum = 
    fibonacci 
    |> Seq.takeWhile (fun x -> x <= 4000000)
    |> Seq.where (fun x -> x % 2 = 0)
    |> Seq.sum
