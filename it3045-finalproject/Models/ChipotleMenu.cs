using System.ComponentModel.DataAnnotations;

namespace it3045_finalproject.Models
{
    public class ChipotleMenu
    {
        [Key]
        public int ItemId { get; set; }
        public required string ItemName { get; set; }
        public required string ItemType { get; set; }
        public required string Description { get; set; }
        public required double ItemCost { get; set; } = 0;
    }
}
