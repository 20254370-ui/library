namespace library.Models;

public class Note
{
    public long NoteId { get; set; }            // note_id     BIGINT
    public string Title { get; set; } = "";     // title       NOT NULL
    public string? Body { get; set; }           // body        may be NULL
    public DateOnly CreatedOn { get; set; }     // created_on  DATE, filled by the database
}