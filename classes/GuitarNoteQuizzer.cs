namespace GuitarFretboard
{
    class GuitarNoteQuizzer
    {
        GuitarString[] GuitarStrings {get; set;}
        string[] Tuning {get; set;} = ["E", "A", "D", "G", "B", "e"];

        public GuitarNoteQuizzer()
        {
            for (int i = 0; i < Tuning.Length; i++)
            {
                GuitarStrings[i] = new GuitarFretboard.GuitarString(Tuning[i]);
            }
        }

       
    }
}

/*
 
public void PrintStrings()
{
    foreach (string note in GuitarStrings)
    {
        Console.WriteLine($"{note.NoteNames}");
        
    }
}
*/