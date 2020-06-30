module Cal

let add(first_num, second_num) = 
    first_num + second_num

let sub(first_num, second_num) = 
    first_num - second_num

let mul(first_num, second_num) =
    first_num * second_num

let div(first_num, second_num) =
    first_num / second_num

let rec fac(num) =
    if num = 1 then
        1
    else 
        num * fac(num)


(*
let find(n) = 
    match n with
    | "+" -> printfn "%d" (add())
    | "-" -> printfn "%d" (sub())
    | "*" -> printfn "%d" (mul())
    | "/" -> printfn "%d" (div())
    |_ -> printfn "다시 입력하세요"
 *)