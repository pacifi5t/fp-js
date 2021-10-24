# Mathematics in JavaScript

## Everybody loves math 
Okay, maybe not. But none of us can deny that math is a fundamental part of life and IT-sphere in particular. This is especially true when we are learning to program JavaScript (or any other language) — so much of what we do relies on processing numerical data, calculating new values, and so on, that you won't be surprised to learn that JavaScript has a full-featured set of math functions available.

This article discusses only the basic parts on the level of 11-th school (lyceum or gimnasium) grade.

## Types of numbers
In programming we use different terms to describe different types of decimal numbers, for example:

* Integers are floating-point numbers without a fraction. They can either be positive or negative, e.g. `10`, `400`, or `-5`.
* Floating point numbers (floats) have decimal points and decimal places, for example `12.5`, and `56.7786543`.
* Doubles are a specific type of floating point number that have greater precision than standard floating point numbers (meaning that they are accurate to a greater number of decimal places).

We even have different types of number systems! Usually, when we write a number, `1011`, we don't specify the base. But we can do this both in real life (`1011`&#x2082;) and in ~~fantasy life~~ programming (`0b1011`). Decimal is base 10 (meaning it uses 0–9 in each column), but we also have things like:

* Binary — The lowest level language of computers; 0s and 1s. Example: `0b1101`
* Octal — Base 8, uses 0–7 in each column. Example: `0o27`
* Hexadecimal — Base 16, uses 0–9 and then a–f in each column. You may have encountered these numbers before when setting colors. Example: `0xff`

And, of course, due to some things there are some unexpected values. For example, if user inputs not a number in a prompt form. But we want to use this value as a number. Yes, it's `NaN` in JS.

> ### _Off topic 1_
>
> You can also use exponential notation to write some big numbers, and this number will automatically be converted to a usual number. Like `2.4e3 + 5` equals `2405`

<math-number-variations />

Well, _phew_, we have discussed numbers! Wait, is a number this string: `'123'`?..

## Parsing and type conversions

> ## Jokes are good, aren't they?
> This is one of the most valuable topics in JS. It produces so many jokes. _A lot of jokes_. ___TELL ME ONCE AGAIN ABOUT `'1' + 1`___
>
> ## (c) Herman Mossur

Yes, JS has very _interesting_ conversions that you will use. Sometimes you might end up with a number that is stored as a string type, which makes it difficult to perform calculations with it. This most commonly happens when data is entered into a form input, and the input type is text. There is a way to solve this problem — passing the string value into the Number() constructor to return a number version of the same value.

For example, try typing these lines into your console: `let myNumber = '74'; myNumber + 3;`

You end up with the result 743, not 77, because myNumber is actually defined as a string. You can test this by typing in the following: `typeof myNumber;`

To fix the calculation, you can do this: `Number(myNumber) + 3;`. Or this: `+myNumber + 3`. The last way is more preffered due to it's size. _Developers are such lazy people._

<math-number-conversion />

> ### _Off topic 1_
>
> The last way uses `+` sign not as binary operator (_that uses two values_), but as unary operator (_that uses one value_).

> ### _Off topic 2_
>
> You can also do _vice versa_: convert number to string just by using `String(123)` or `'' + 123` (or `123 + ''`).

## Constants

There are some numbers, that are used literally everywhere. They are called **constants**. They are: _`π, e, √2, √(1/2)`_... They are also present in Math module. Use can use it without any imports - just type `Math.` in console! For example, to count an area of a circle with radius `r`, you just need to type `Math.PI * r * r`. Or, you can use the `Math.pow(base, exponent)` function.

<math-number-constants />

## Power

> ## Misunderstandings
> To achieve total power over world, you need to summon the _Godzilla_
>
> ## (c) Herman Mossur

A power, or a _exponentiation_, is a repeated multiplication. `5`&#179; = `5 * 5 * 5`, where 5 is a _base_ and 3 is an _exponent_.

So, the function `Math.pow(b, e)` is an easy way to perform this operation. It's first parameter `b` can be any number, second - `e` - also any number. 

Yes, you might remember that _`√n`_ can also be written as _`n`&#189;_. So, to achieve root you can use `Math.sqrt` and `Math.cbrt` or just use `Math.pow(x, y)`, where y lies between 0 and 1.

You can also use negative value of y instead of writting `1 / Math.pow(x, y)`. It is equal to `Math.pow(x, -y)`. Of course, you need to remember that negative numbers don't have a real square (or any even) root, so `Math.pow(-7, 0.5)` produces a `NaN` value.

The very separate example is exponential. You can use `Math.pow(e, x)` or `Math.exp(x)` for that purpose.

<math-power />

> ### _Little hint_
>
> You can also use operator `**` to achive the same result as `Math.pow(x, y)`. Just `5 ** 3`. Easy. And _lazy_.

***But beware!*** Whilst computing not integer numbers you can meet strange values like `0.1 + 0.2 = 0.30000000000000004`. I can highly recommend you using some rounding functions to get really expected answer like `0.3`.

## Rounding functions

Main purpose of rounding function is to return a value with fixed signs after dot. Actually, there are several rounding functions:

* `Math.floor(x)` always returns the low integer bound of x 
* `Math.round(x)` returns a low bound or a high bound depending on what is 'closer' to original x
* `Math.ceil(x)` always returns the high integer bound of x
* `Number.toFixed(x)` uses round function and cuts a number to x signs after dot.

<math-round />

## Absolute value

To be honest, it's not very necessary to know, which function returns the absolute value, because this function is easy-to-write in 1 minute. You need just to invert the value of number, if it's negative. But it becomes only 10 seconds if you're using `Math.abs(x)`.

<math-absolute />

## Logarithms

Do you still remember the content of the **Constants** chapter? Well, sometimes you're gonna need something more than just `Math.LN2`, `Math.LN10`, `Math.LOG2E` or `Math.LOG10E`.

This is the time when `Math.log(x)` (which is a natural log <=> ln(x)), `Math.log2(x)` and `Math.log10(x)` enter the game. _Last two functions, '2' and '10', exist because they are often used_. But you can also implement your own logarithm function, for example, _log3_ or _log24_. Just use `Math.log(x) / Math.log(otherBase)` to achieve this effect.

<math-log />

## Trigonometry

Well, we're at the very end. Trust me! But ♂ass♂ well it's the hardest part in a school math because you need to remember a lot of functions and values they consume and produce. The good news about JS are... you don't need to remember the values.

Good news end at this step. At this paragraph.

Firstly, you still need to remember the list of functions to call. It is quite big:
* `Math.sin(x)`
* `Math.cos(x)`
* `Math.tan(x)`
* `Math.asin(x)`
* `Math.acos(x)`
* `Math.atan(x)`
* `Math.atan2(x, y)` - _oh my, second arctangent_. Well, it returns the angle in the plane (in radians) between the positive x-axis and the ray from (0,0) to the point (x,y), for Math.atan2(y,x). You may better understang it with this image:

![Atan2 image](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Math/atan2/atan2.png "Atan2 image")

Secondly, you need to remember that x represents an angle not in degrees, but in radians.

<math-trigonometry />

## Sources: 
* [Math article](https://developer.mozilla.org/en-US/docs/Learn/JavaScript/First_steps/Math)
* [Operators article](https://javascript.info/operators)
* [Documentation of everything standard in js](https://developer.mozilla.org/) 