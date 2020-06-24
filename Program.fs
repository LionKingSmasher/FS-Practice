// Learn more about F# at http://fsharp.org

open System

let add() = 
    let first_num = int64(Console.ReadLine());
    let second_num = int64(Console.ReadLine());
    first_num + second_num

let sub() = 
    let first_num = int64(Console.ReadLine());
    let second_num = int64(Console.ReadLine());
    first_num - second_num

let mul() =
    let first_num = int64(Console.ReadLine());
    let second_num = int64(Console.ReadLine());
    first_num * second_num

let find(n) = 
    match n with
    | "+" -> printfn "%d" (add())
    | "-" -> printfn "%d" (sub())
    | "*" -> printfn "%d" (mul())
    |_ -> printfn "다시 입력하세요"

[<EntryPoint>]

let main argv =
    while true do
        let input_calc = System.Console.ReadLine();
        find(input_calc)
    0 // return an integer exit code
