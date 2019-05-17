# Ontellus Assessment

## Requirements
Need dotnet cli installed and .netcore

## Running program
cd into the solution folder.

dotnet run Romeo Juliet --project ./Ontellus.Console/Ontellus.Console.csproj

## Running unit tests
From the solution folder.
dotnet test

### Test Coverage
These unit tests don't cover everything but they cover enough for me to be satisfied.

## Assumptions
The phonenumber needs some type of formatting to it.
Either
`(555)555-5555`
`555-555-5555`
`555-5555`

If the phonenumber is only numbers, it will be interpreted as a number instead.

## MergeSort
The merge sort was copied and modified from https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-7.php
I just modified it to use Generics and to eliminate duplicates while sorting

## Formatting
The formatting and spacing might be a little off because I did this all on a linux machine with vim.
Made it more fun that way.
