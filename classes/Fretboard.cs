using Spectre.Console;

public class Fretboard(string path)
{
    public string[] Rows {get; set; } = File.ReadAllLines(path);

    public void PrintFretboard()
    {
        foreach (string row in Rows) {
            AnsiConsole.MarkupLine(row);
        }
    }
}