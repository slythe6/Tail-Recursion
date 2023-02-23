let AssertEquality a b = if a<>b then printfn "Fail!" else printfn "Test Success!"



let rec compare_lists x y =
  match x, y with
  | [], [] -> true
  | x::xs, y::ys -> x = y && compare_lists xs ys
  | _ -> false

let list1: int list = [1;2;3];
let list2: int list = [1;2;3];

let list3: int list = [1;2];
let list4: int list = [3;4];

//let result = compare_lists list1, list2
let result :bool = compare_lists list1 list2;
let result2 :bool = compare_lists list3 list4;

printfn "Test 1: (true expected), result is %b" result
printfn "Test 2: (false expected), result is %b" result2