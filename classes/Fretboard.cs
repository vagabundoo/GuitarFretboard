public class Fretboard
{
    public string[] Rows {get; set; } = File.ReadAllLines("input/guitarFretboardEmpty.txt");

    public void PrintFretboard()
    {
        foreach (string row in Rows) {
            System.Console.WriteLine(row);
        }
    }
}