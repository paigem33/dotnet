namespace FlashCardApp.Models
{
    public class Card
    {
        public int Id { get; set; }
        public required string Term { get; set; }
        public required string Definition { get; set; }
    }
}