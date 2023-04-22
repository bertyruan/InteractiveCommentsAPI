namespace InteractiveComments.Models
{
    public class Thread
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public int Likes { get; set; }
        public IEnumerable<Comment> Comments { get; set;}
    }
}
