# fsharp-car

## Introduction

The following is my implementation of Capstone 1 from "Get Programming With F#" by Issac Abraham. The main goal is to create a small application that uses functional programming principles.

## Requirements

1. The car starts with 100 units of petrol
2. The user can drive to one of four destinations:
    - Home - 25 units
    - Work - 50 units
    - Stadium - 25 units
    - Gas Station - 10 units
3. If the user tries to drive anywhere else, the system will reject the request
4. If the user tries to drive somewhere and doesn't have enough petrol, the system will deny the request.
5. If the user travels to a gas station, the amount of petrol should be increased by 50 units.
6. The maximum amount of petrol the car can hold is 300 units.
7. If the user tries to add more than 300 units, the system will deny the request.
8. The car starts at home.
9. If the user tries to travel to where they are, the system will deny the request.

**NOTE: I added requirements 6, 7, 8 and 9 as I thought they made the challenge more realistic and expanded beyond the expectations of the exercise.**
