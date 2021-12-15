// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

//  Types of numbers
let TypesOfNumbers() = 
    let number1 = 5                             // usual int
    let number2: byte = 37uy                    // [0,255]
    let number3: sbyte = 13y                         // [-128,127]
    let number4: int16 = 278s                   // [-32768,32767]
    let number5: uint16 = 60000us               // [0,65535]
    let number6: int = 123456789                // [-2 147 483 648, 2 147 483 647]
    let number7: uint = 4123456789u             // [0, 4 294 967 295]
    let number8: int64 = 9223372036854775800L   // [-9 223 372 036 854 775 808, 9 223 372 036 854 775 807]
    let number9: uint64 = 12_223_372_036_854_775_800UL// [0, 18 446 744 073 709 551 615]
    let number10: nativeint = nativeint 13      // native pointer on int with sign
    let number11: unativeint = unativeint 13    // native pointer on int without sign
    let number12: float = 13.6                  // float: 64 bit
    let number13: float32 = 13.2f               // float: 32 bit
    let number14: decimal = 13.6m               // float with at least 28 significant digits
    let undefined: unit = ()                    // an undefined value
    let bin = 0b1011                            // binary number
    let oct = 0o75                              // octal number
    let hex = 0xff                              // hexadecimal number
    printfn "Integers use %%d specificator: %d" number1
    printfn "Floats use %%f specificator: %f" number12
    // also we can do this
    printfn $"Another way to write any number: {number14}\n"

//  Parsing and type conversions
let ParserStrToInt str = str |> int
let ParserStrToFloat str = str |> float

//  Constants
let MathConstants() =
    printfn $"Pi equals {Math.PI}"
    printfn $"E equals {Math.E}"
    printfn $"Tau equals {Math.Tau}"

//  Power
let MathPow x exp = 
    pown x exp
    // or x ** exp

//  Rounding functions
let Round x = Math.Round(x: float)
let Ceil x = Math.Ceiling(x: float)
let Floor x = Math.Floor(x: float)

//  Absolute value
let MathAbs x = abs x

//  Logarithms
let Log a b =
    Math.Log(a, b)

//  Trigonometry
let Sin x =
    Math.Sin(x)

[<EntryPoint>]
let main argv =
    TypesOfNumbers()
    MathConstants()

    let strToInt = ParserStrToInt "56"
    printfn $"{strToInt}\n"

    let strToFloat = ParserStrToFloat "1.5"
    printfn $"{strToFloat}\n"

    let pow = MathPow 5 3
    printfn $"5 in power of 3 is {pow}\n"

    let notInt = 3.5
    let roundedInt1 = Round notInt
    let roundedInt2 = Ceil notInt
    let roundedInt3 = Floor notInt
    printfn $"3.5:\nRound = {roundedInt1},\nCeil = {roundedInt2},\nFloor = {roundedInt3}\n"

    let neg = -62
    let absValue = MathAbs neg
    printfn $"Absolute value of {neg} is {absValue}\n"

    let logValue = Log 3. 5.
    printfn $"Log3(5) is {logValue}\n"

    let sinValue = Sin 0.67
    printfn $"Sin(0.67) is {sinValue}\n"
    0 // return an integer exit code