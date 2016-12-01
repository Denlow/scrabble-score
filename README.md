# _Scrabble Score_

#### _Calculate the Scrabble Score of a Word, 12/1/16_

#### By _**Erik Killops & Dave Denlow**_

## Description

_This program will be a simple Scrabble score calculator. Enter a word and calculate the score!_

## Specs

_Specs for main program function LetterValues()_

| BEHAVIOR                                | INPUT       | OUTPUT |
|-----------------------------------------|-------------|--------|
| Calculate the score of a single letter  | "a"         | 1      |
| Calculate the score of multiple letters | "yz"        | 14     |
| Do not score punctuation                | "don't"     | 5      |
| Do not score numbers                    | "1"         | 0    |
| Calculate score for mixed case words    | "SPaghETti" | 15     |

## Setup/Installation Requirements

*Requires Windows*

1. _Clone repository from GitHub_
2. _In PowerShell run ">dnx kestrel" and visit "localhost:5004" in your browser!_

## Technologies Used

_C#, Nancy, Razor, Xunit_

### License

*GPL*

Copyright (c) 2016 **_Erik Killops, Dave Denlow_**
