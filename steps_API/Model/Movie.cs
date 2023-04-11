namespace steps_API.Model
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Rating { get; set; }

        public string ImageUrl { get; set; }

        public bool isFavorite { get; set; }
    }
}
