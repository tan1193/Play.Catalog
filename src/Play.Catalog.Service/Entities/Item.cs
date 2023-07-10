namespace  Play.Catalog.Service.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty; // default value
        public string Description { get; set; } = string.Empty; // default value
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}