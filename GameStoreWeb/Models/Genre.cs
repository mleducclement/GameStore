using System.ComponentModel;

namespace GameStoreWeb.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [DisplayName("Genre Name")]
        public required string Name { get; set; }
    }
}
