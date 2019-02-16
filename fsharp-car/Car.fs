/// Contains all the driving logic
module Car

open System

/// Converts the destination to its name.
/// The input is already validatied, so we dont need to do that here.
let convertDestinationToName(destination) =
    if destination = "h" then "Home"
    elif destination = "w" then "Work"
    elif destination = "s" then "Stadium"
    else "Petrol Station"

/// Determines if the car has enough petrol to get to work.
/// Won't let the user go lower than 10 units so that they can get petrol.
let hasEnoughPetrolForWork(petrol) = 
    if petrol >= 60 then true
    else false

/// Determines if the car has enough petrol to get to the petrol station.
let hasEnoughPetrolForPetrolStation(petrol) =
    if petrol >= 10 then true
    else false

/// Determines if the car has enough petrol to get home.
/// Wont let the user go lower than 10 units so that they can get petrol.
let hasEnoughPetrolForHome(petrol) = 
    if petrol >= 35 then true
    else false

/// Determines if the car has enough petrol to get to the stadium.
/// Won't let the user go lower than 10 units so that they can get petrol.
let hasEnoughPetrolForStadium(petrol) = 
    if petrol >= 35 then true
    else false

/// Drives to a given destination given a starting amount of petrol
/// If they cant get there then it returns the orinal amount of petrol
let driveTo (petrol, destination) = 
    if destination = "p" && hasEnoughPetrolForPetrolStation(petrol) then 
        printfn "Made it to %s!" (convertDestinationToName(destination))
        petrol + 50
    elif destination = "w" && hasEnoughPetrolForWork(petrol) then 
        printfn "Made it to %s!" (convertDestinationToName(destination))
        petrol - 50
    elif destination = "h" && hasEnoughPetrolForHome(petrol) then 
        printfn "Made it to %s!" (convertDestinationToName(destination))
        petrol - 25
    elif destination = "s" && hasEnoughPetrolForStadium(petrol) then 
        printfn "Made it to %s!" (convertDestinationToName(destination))
        petrol - 25
    else
        printfn "You dont have enough petrol to make it there!"
        printfn "Go to the petrol station."
        Threading.Thread.Sleep(1500)
        petrol
        