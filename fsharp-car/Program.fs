open System
open Car

/// Displays the possible destinations to the user and collects their input.
/// This will always return the lowercase value
let getDestination() =
    Console.WriteLine("Please select a destination and press enter.")
    Console.WriteLine("(H)ome")
    Console.WriteLine("(W)ork")
    Console.WriteLine("(S)tadium")
    Console.WriteLine("(P)etrol Station")
    let input = Console.ReadLine()
    let destination = input.ToLower()
    destination
    
let mutable petrol = 100

[<EntryPoint>]
let main argv =
    while true do
        try
            let destination = getDestination()
            printfn "Trying to drive to %s" destination
            petrol <- driveTo(petrol, destination)
            printfn "Made it to %s! You have %d petrol left" destination petrol
        with ex -> printfn "ERROR: %s" ex.Message
    0 // exit code that indicates that the program has ended properly.