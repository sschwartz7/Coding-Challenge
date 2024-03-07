namespace Coding_Challenge.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        public string? Secret { get; set; }
    }
}
