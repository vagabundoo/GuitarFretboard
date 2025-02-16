using Spectre.Console;
using GuitarFretboard;

/*
string[] lines = File.ReadAllLines("input/guitarFretboardEmpty.txt");

foreach (string line in lines) {
    System.Console.WriteLine(line);
}
*/
var fretboard = new Fretboard();
fretboard.PrintFretboard();

// GuitarString functionality
AnsiConsole.MarkupLine("[blue]Hello[/] [red] world![/]");
var estring = new GuitarString("E");

System.Console.WriteLine(estring.NoteNames[3]);
System.Console.WriteLine($"{String.Join(" ",estring.NoteNames)}");

string? givenAnswer = "";
do
{
    var randomFret = new Random();
    var chosenFret = randomFret.Next(0,12);
    
    var requiredNote = estring.NoteNames[chosenFret].ToLower();
    System.Console.WriteLine(requiredNote);

    AnsiConsole.MarkupLine($"Give the notename at fret {chosenFret}:");
    
    givenAnswer = Convert.ToString(Console.ReadLine());
    givenAnswer = givenAnswer.ToLower();

    if (givenAnswer == requiredNote) 
    {
        AnsiConsole.MarkupLine("[green] Correct![/]");
    } 
    else 
    {
        AnsiConsole.MarkupLine("[red] Wrong[/]. Try again.");
    }
    

}
while (givenAnswer != "exit");
