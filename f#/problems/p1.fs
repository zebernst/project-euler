module Project_Euler.problems.p1

let MultipleOf3Or5 x = x % 3 = 0 || x % 5 = 0

let MultipleSum input = 
    [1..input-1] 
    |> List.filter MultipleOf3Or5 
    |> List.sum
    
