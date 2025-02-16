using System.Dynamic;
using Spectre.Console;

namespace GuitarFretboard
{
	internal class GuitarString
	{
		public string Name { get; set; } = "E";
		public int[] Frets { get; set; } = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
		public string[] NoteNames;

		public GuitarString(string name)
		{
			if (name == null)
			{
				AnsiConsole.MarkupLine("[red] Provide a valid note name for the string [/]");
				throw new ArgumentException("Provide a valid note name for the string");
			}

			Name = name;
			switch (Name)
			{
				case "e":
					NoteNames = ["E", "F", "F#", "G", "Ab", "A", "Bb", "B", "C", "Db", "D", "Eb"];
					break;
				case "B":
					NoteNames = ["B", "C", "Db", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb"];
					break;
				case "G":
					NoteNames = ["G", "Ab", "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "F#"];
					break;
				case "D":
					NoteNames = ["D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B", "C", "Db"];
					break;
				case "A":
					NoteNames = ["A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "F#", "G", "Ab"];
					break;
				case "E":
					NoteNames = ["E", "F", "F#", "G", "Ab", "A", "Bb", "B", "C", "Db", "D", "Eb"];
					break;
				default:
					NoteNames = ["E", "F", "F#", "G", "Ab", "A", "Bb", "B", "C", "Db", "D", "Eb"];
					break;
			}
		}

		public override string ToString()
		{
			return String.Join(" ", NoteNames);
		}
	}
}
