
module Car

open System
open System.Text

/// Drives to a given destination given a starting amount of petrol
/// If they cant get there then it returns the orinal amount of petrol
let driveTo (petrol, destination) = 
    if destination = "p" then petrol + 10
    elif destination = "Work" then petrol - 50
    elif destination = "Home" then petrol - 25
    elif destination = "Stadium" then petrol - 25
    else petrol
