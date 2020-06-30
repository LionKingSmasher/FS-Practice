open System
open Cal

let find(n, a, b) = 
    match n with
    | "+" -> printfn "%d" (add(int(a), int(b)))
    | "-" -> printfn "%d" (sub(int(a), int(b)))
    | "*" -> printfn "%d" (mul(int(a), int(b)))
    | "/" -> printfn "%d" (div(int(a), int(b)))
    |_ -> printfn "다시 입력하세요"

let find_2(n, a) =
    match n with
    | "fac" -> printfn "%d" (fac(int(a)))
    |_ -> printfn "다시 입력하세요"


[<EntryPoint>]

let main argv =
    while true do
        printfn "부호를 입력하세요"
        let n = System.Console.ReadLine()
        printfn "수를 입력하세요"
        let i = System.Console.ReadLine()
        find_2(n, i)
        //find(input_calc)
    0 // return an integer exit code
