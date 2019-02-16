
module Car

open System
open System.Text

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
    if destination = "p" && hasEnoughPetrolForPetrolStation(petrol) then petrol + 50
    elif destination = "w" && hasEnoughPetrolForWork(petrol) then petrol - 50
    elif destination = "h" && hasEnoughPetrolForHome(petrol) then petrol - 25
    elif destination = "s" && hasEnoughPetrolForStadium(petrol) then petrol - 25
    else 
        Console.WriteLine("You haven't selected a valid destination.")
        petrol
        