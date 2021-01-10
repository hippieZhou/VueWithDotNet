namespace VueWithDotnet.Models
{
    public class China
    {
        public Province[] Provinces { get; set; }
    }

    public class Province
    {
        public string Name { get; set; }
        public City[] City { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public string[] Area { get; set; }
    }
}
