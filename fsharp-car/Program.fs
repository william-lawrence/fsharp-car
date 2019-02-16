open System
open Car

/// Displays the menu with the options for the user.
let displayMenu() = 
    Console.WriteLine("Please select a destination and press enter.")
    Console.WriteLine("(H)ome")
    Console.WriteLine("(W)ork")
    Console.WriteLine("(S)tadium")
    Console.WriteLine("(P)etrol Station")

/// Displays the possible destinations to the user and collects their input.
/// This will always return the lowercase value
let getDestination(petrol) =
    Console.Clear()
    printfn "You have %d units of petrol." petrol
    displayMenu()
    let input = Console.ReadLine()
    let destination = input.ToLower()
    destination

let validateDestination(destination) = 
    if destination = "h" then true
    elif destination = "w" then true
    elif destination = "s" then true
    elif destination = "p" then true
    else false
        
let mutable petrol = 100

[<EntryPoint>]
let main argv =
    while true do
        try
            let destination = getDestination(petrol)
            if validateDestination(destination) = true then
                printfn "Trying to drive to %s" destination
                petrol <- driveTo(petrol, destination)
                printfn "Made it to %s!" destination
                Threading.Thread.Sleep(1500)
            else
                printfn "Trying to drive to %s" destination
                printfn "You don't have enough petrol to make it to %s!" destination
                Threading.Thread.Sleep(1500)
        with ex -> printfn "ERROR: %s" ex.Message
    0 // exit code that indicates that the program has ended properly.  