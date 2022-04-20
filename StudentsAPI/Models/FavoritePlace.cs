namespace StudentsAPI.Models
{
    public class FavoritePlace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public bool MustVisit { get; set; }
        public bool Visited { get; set; }
    }
}
