using AppShoppingCenter.Models.Enums;

namespace AppShoppingCenter.Models
{
    public class Establishment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public EEstablishmentType Type { get; set; }
        public string Cover { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;
   
    }
}
