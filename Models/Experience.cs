namespace CV_Webbutveckling.Models
{
    public class Experience
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
