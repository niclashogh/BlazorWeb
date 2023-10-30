namespace BlazorWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string? Desc { get; set; }

        #region Data
        public double Length { get; set; }
        public double Width { get; set; }
        public double Thickness { get; set; }
        public double Volume { get; set; }
        public BoardType Type { get; set; }

        public List<string>? Equipments { get; set; }
        public string? ImageUrl { get; set; }
        #endregion

        public byte[]? RowVersion { get; set; }
    }
}
