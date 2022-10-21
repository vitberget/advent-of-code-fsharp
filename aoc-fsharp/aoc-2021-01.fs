open System.IO

printfn "Hello from F#"

let input =  File.ReadLines "/home/k/src/aoc-fsharp/puzzles/2021/01/puzzle.txt"
             |> Seq.map int

let resultP1 = input          
             |> Seq.pairwise
             |> Seq.filter (fun (n1,n2) -> n1 < n2)
             |> Seq.length

printfn $"Result p1! %i{resultP1} should be 1387" 

let resultP2 = input
             |> Seq.skip 3
             |> Seq.zip input 
             |> Seq.filter (fun (n1,n2) -> n1 < n2)
             |> Seq.length

printfn $"Result p2! %i{resultP2} should be 1362"
