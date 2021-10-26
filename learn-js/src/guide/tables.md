# Tables in js

## Tables in the past

In the past tables was often used, for separate information, or for example for define a html page structure. Yeah, really, in the past we are used tables for page layout, and this is not surprise because tables can separate our page for logic blocks, that are in summary formed page structure.

Now we don’t need use tables for semantic layout. It’s already deprecated approach. But anyway tables are still important thing of our pages. They can positively affect our SEO (indexing robots prefer more structuring pages) and prepare information for users in more comfortable way. 

Okay, we decided that tables are important thing, let’s dive!



## Tables structure

For create table you need to use the `<table>` pair tag.

```
<table>
…
</table>
```

As we know, tables separates to multiple columns and rows. For creation this structure we must to use `<tr>` (table row) and `<td>` (table data) pair tags.


<tables-default />
<p align="center">Code example #1.</p>


As you can see, `<td>` tags must be located inside of `<tr>` tags. It is logically, because `<tr>`tags form rows, and rows must be fills by columns, that are consist of multiple `<td>` tags. 

To better understand the structure, let's highlight each column in a specific color

<tables-default-colorizied />
<p align="center">Code example #2.</p>

And what if we need to specify the headings of each column? For that, we use the `<th>` tag!

Let's try it:

<tables-headings />
<p align="center">Code example #3.</p>

These basic features are enough in most cases, but we'll take an in-depth look at tables in the next section.


## Deep dive into the Tables

In addition to the standard `<th>`, `<tr>`, `<td>` tags, tables have a lot of extra ones: `<caption>`, `<col>`, `<colgroup>`, `<tbody>`, `<tfoot>`, `<thead>`.

Let's study each of them by example.


## Heading

Caption.

This tag is for the title of the page and can only be used inside a table. Although it is used inside the `<table>` tag, the title will be displayed outside the table on the top center.

<tables-caption />
<p align="center">Code example #4.</p>

## Groups

Col, colgroup.

These tags are worth considering together. 
The `<colgroup>` tag specifies a group of one or more columns in a table for formatting.
The `<colgroup>` tag is useful for applying styles to entire columns, instead of repeating the styles for each cell, for each row.

The `<col>` tag specifies column properties for each column within an `<colgroup>` element.
The `<col>` tag is useful for applying styles to entire columns, instead of repeating the styles for each cell, for each row.
	
Let's use this knowledge to optimize a little bit when the example #4 

<tables-group />
<p align="center">Code example #5.</p>


## Sections

Tfoot, Thead, Tbody 
    
Using these tags is good practice because they divide our table into logical elements.

Browsers can use these elements to enable scrolling of the table body independently of the header and footer. Also, when printing a large table that spans multiple pages, these elements can enable the table header and footer to be printed at the top and bottom of each page.

<tables-sections />
<p align="center">Code example #6.</p>


## Additional information

Tables also have a lot of html-attributes, that can helps with stylization. In nowadays this approach seems like deprecated, but in some cases it's can be useful.

| Attribute      | Description |
| :---        |    ---:   | 
| align      | Specifies the table alignment.       |
| background   | Sets the background image in the table.  | 
| bgcolor   | The color of the table background.        |
| border   | The border thickness in pixels.        |
| bordercolor   | border color.        | 
| cellpadding   | Padding from the frame to the cell content.        | 
| cellspacing   | Cellspacing        |
| cols   | Number of columns in the table.        | 
| frame   | Tells the browser how to display borders around the table.        | 
| height   | The height of the table.        | 
| rules   | Tells the browser where to display the borders between cells.        | 
| summary   | A summary of the table.        | 
| width   | The width of the table.        |


## Sources

* [Htmlbook](http://htmlbook.ru/html/table)
* [W3schools](https://www.w3schools.com/)