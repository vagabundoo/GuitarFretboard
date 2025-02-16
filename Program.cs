﻿using Spectre.Console;
using GuitarFretboard;
using System;

//Console.Clear();

var emptyFretboard = new Fretboard("input/guitarFretboardEmpty.txt");
//emptyFretboard.PrintFretboard();


// Functionality for printing a marked fretboard
//var fretboard = new Fretboard("input/guitarFretboardMarked.txt");

/*
var occurrence = fretboard.Rows[0].IndexOf('5');

fretboard.Rows[0] = fretboard.Rows[0].Replace("5", "[yellow]X[/]");
//System.Console.WriteLine(rep);
//AnsiConsole.MarkupLine(fretboard.Rows);
fretboard.PrintFretboard();
*/

void printFretboardNoteMarked(Fretboard fretboard, int stringNumber, int fretNumber)
{
    //fretboard = new Fretboard("input/guitarFretboardMarked.txt");
    //string stringNumberStr = stringNumber.ToString();
    string fretNumberStr = fretNumber.ToString();
    Fretboard fretboardCopy = fretboard;
    fretboardCopy.Rows[stringNumber] = fretboardCopy.Rows[stringNumber].Replace(fretNumberStr, "[yellow]X[/]");
    fretboardCopy.PrintFretboard();
}

System.Console.WriteLine();

//System.Console.WriteLine(fretboard.Rows[0]);

// GuitarString functionality
AnsiConsole.MarkupLine("[blue]Welcome to GuitarNote[/] [red] Trainer![/]");
var estring = new GuitarString("E");

//System.Console.WriteLine(estring.NoteNames[3]);
//System.Console.WriteLine($"{String.Join(" ",estring.NoteNames)}");

var tuning = new string[] { "E", "A", "D", "G", "B", "e" };
//List<List<string>> guitarStrings = new List<List<string>>();
/*
for (int i = 0; i < guitarStrings.Count(); i++)
{
    guitarStrings[i] = new GuitarString(tuning[i]).NoteNames;
}*/

Dictionary<string, string[]> standardStrings = new Dictionary<string, string[]>
{
    {"e", ["E", "F", "F#", "G", "Ab", "A", "Bb", "B", "C", "Db", "D", "Eb"]},
    {"B", ["B", "C", "Db", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb"]},
    {"G", ["G", "Ab", "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "F#"]},
    {"D", ["D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B", "C", "Db"]},
    {"A", ["A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "F#", "G", "Ab"]},
    {"E", ["E", "F", "F#", "G", "Ab", "A", "Bb", "B", "C", "Db", "D", "Eb"]}
};

//var rand = new Random();
//var randString = ;
//System.Console.WriteLine(randString);

string? givenAnswer = "";
do
{
    var fretboard = new Fretboard("input/guitarFretboardMarked.txt");
    var random = new Random();
    var randomFret = random.Next(0, 12);
    string randomGuitarString = standardStrings.ElementAt(random.Next(0, standardStrings.Count())).Key;
    int stringNumber = "eBGDAE".IndexOf(randomGuitarString);
    var randomNotes = standardStrings[randomGuitarString];

    var requiredNote = randomNotes[randomFret];

    printFretboardNoteMarked(fretboard, stringNumber, randomFret);
    AnsiConsole.MarkupLine("[blue]Give the note name [/]");
    System.Console.WriteLine($"Hint: {requiredNote}");
    AnsiConsole.MarkupLine($"String {randomGuitarString}, fret {randomFret}:");

    givenAnswer = Convert.ToString(Console.ReadLine());

    if (givenAnswer.ToLower() == requiredNote.ToLower())
    {
        AnsiConsole.MarkupLine("[green] Correct![/]");
    }
    else
    {
        AnsiConsole.MarkupLine($"[red] Wrong[/]. The correct answer was [blue]{requiredNote}[/].");
    }


}
while (givenAnswer != "exit");
