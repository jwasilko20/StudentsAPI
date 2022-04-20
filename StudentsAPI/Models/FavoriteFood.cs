namespace StudentsAPI.Models
{
    public class FavoriteFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public bool GlutenFree { get; set; }
        public bool Vegan { get; set; }
    }
}
