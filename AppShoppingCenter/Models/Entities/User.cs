namespace AppShoppingCenter.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? AccessCode { get; set; }
        public DateTimeOffset AccessCodeValid { get; set; }
    }
}
