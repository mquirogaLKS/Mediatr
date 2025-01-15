namespace MediatrTest.Domain
{
    public class Newsletter
    {
        public DateTime? DateProcessed { get; set; }
        public DateOnly DatePublication { get; set; }
        public int Id { get; set; }
        public bool IsProcessed { get; set; }
        public string Name { get; set; } = default!;
        public string Text { get; set; } = default!;
        public string Url { get; set; } = default!;
    }
}
