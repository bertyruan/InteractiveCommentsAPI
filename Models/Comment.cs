namespace InteractiveComments.Models
{
    public class Comment
    {

        public int Id { get; set; }
        public Thread Thread { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Likes { get; set; }
        public User User { get; set; }


    }
}
