﻿open System
open Car

/// Displays the menu with the options for the user.
let displayMenu() = 
    Console.WriteLine("Please select a destination and press enter.")
    Console.WriteLine("(H)ome")
    Console.WriteLine("(W)ork")
    Console.WriteLine("(S)tadium")
    Console.WriteLine("(P)etrol Station")
    ()

/// Displays the possible destinations to the user and collects their input.
/// This will always return the lowercase value.
let getDestination(petrol) =
    Console.Clear()
    printfn "You have %d units of petrol." petrol
    displayMenu()
    let input = Console.ReadLine()
    let destination = input.ToLower()
    destination

/// Checks to make sure that the user has entered a valid destination.
let validateDestination(destination) = 
    if destination = "h" then true
    elif destination = "w" then true
    elif destination = "s" then true
    elif destination = "p" then true
    else false
        
let initialPetrol = 100
let mutable petrol = initialPetrol

[<EntryPoint>]
let main argv =
    while true do
        try
            let destination = getDestination(petrol)
            if validateDestination(destination) then
                printfn "Trying to drive to %s" (convertDestinationToName(destination))
                petrol <- driveTo(petrol, destination)
                printfn "You have %d units of petrol remaining." petrol
                Threading.Thread.Sleep(1300)
            else
                printfn "You didn't select a valid destination."
                printfn "You have %d units of petrol remaining." petrol
                Threading.Thread.Sleep(1300)
        with ex -> printfn "ERROR: %s" ex.Message
    0 // exit code that indicates that the program has ended properly.  