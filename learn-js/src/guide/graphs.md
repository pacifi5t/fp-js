
# Plots in JavaScript

## What are graphics

Graphics concept
A function is the dependence of `y` on `x`, where `x` is the dependent variable or function of the function and `y` is the dependent variable or function of the function.

To define a function means to define a rule in accordance with the independent values ​​of the independent evaluation. Here are the ways in which you can set it:

- Tabular method - helps to quickly determine specific values - ​​without additional measurements or calculations.
- The graphical way is clear.
- The analytical way is through formulas. It is compact, and you can calculate the function for an arbitrary value of the argument from the domain.
- Verbal way.

## How do we actually build graphics in JavaScript

The Canvas API is an interface for rendering graphics in the browser. Using the HTML `<canvas>` element, you can create a canvas (this is how canvas is translated from English) and draw graphics inside it using JavaScript code.

## About some primitives

### LineTo

`lineTo()` - CanvasRenderingContext2D method, part of **Canvas 2D API**, line point to the current sub path with an endpoint with coordinates (x, y).

The method itself does not draw anything, it only covers the subpath to the current path, leaving it to methods such as `fill()` and `stroke()` to draw the path itself.

### Arc

The `CanvasRenderingContext2D.arc()` method of the **Canvas 2D API** adds a circular arc to the current sub-path.

The `arc()` method creates a circular arc centered at `(x, y)` with a radius of radius. The path starts at startAngle, ends at endAngle, and travels in the direction given by counterclockwise (defaulting to clockwise).

[More information](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/arc)

### Rectangle

The `CanvasRenderingContext2D.fillRect()` method of the **Canvas 2D API** draws a rectangle that is filled according to the current fillStyle.

This method draws directly to the canvas without modifying the current path, so any subsequent `fill()` or `stroke()` calls will have no effect on it.

> void ctx.fillRect(x, y, width, height);

The `fillRect()` method draws a filled rectangle whose starting point is at `(x, y)` and whose size is specified by width and height. The fill style is determined by the current fillStyle attribute.

### Text

The `CanvasRenderingContext2D` method `fillText()`, part of the **Canvas 2D API**, draws a text string at the specified coordinates, filling the string's characters with the current fillStyle. An optional parameter allows specifying a maximum width for the rendered text, which the user agent will achieve by condensing the text or by using a lower font size.

This method draws directly to the canvas without modifying the current path, so any subsequent `fill()` or `stroke()` calls will have no effect on it.

The text is rendered using the font and text layout configuration as defined by the font, **textAlign**, **textBaseline**, and direction properties.

> CanvasRenderingContext2D.fillText(text, x, y [, maxWidth]);

<plots-primitives />

## Graphic by dots

When you build a plot with two axes, you actually make points with coordinatex `x` and `y`.
And then, connecting them with line, you create a plot!
Unfortunately, there is no built-in functional to create chart scale, but you can write your own!
Here we`ll show you an examle of simple line plot on raw js
<plots-dots />

## Function plot

You can also build some functions with it! Here is the example

<plots-sinusoid />

## Bar plot

And how to use rectangle primitive for building bar plots

<plots-legend-example />

## Quiz
<quizes-quiz-component questions ="plots" />

## Materials

[HTML academy](https://htmlacademy.ru/blog/boost/tutorial/canvas-chart)

[MDN documentation](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D)

[More examples od charts building](http://www.tutorialspark.com/html5/HTML5_Canvas_Graphs_Charts.php)
