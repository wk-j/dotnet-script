
let values = [
    "k1", ["v1"; "v2"]
    "k2", ["v3"]
    "k3", ["v4";"v5";"v6"]
]

let tp a v = a, v
let pair (k, values) = List.map (tp k) values

let rec cart = function
    | [] -> Seq.singleton []
    | h::t -> seq { for x in h do for xs in cart t -> x::xs }

values |> List.map pair |> cart |> Seq.toList
