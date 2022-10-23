namespace Api_Web.Model
{
    public class Region
    {
        public int Id { get; set; }

        public string Titlle { get; set; }

        public string Short_title { get; set; }

        public string Code { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
