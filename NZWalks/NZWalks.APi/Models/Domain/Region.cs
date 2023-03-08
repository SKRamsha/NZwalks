namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public long population { get; set; }

        //navigation property
        public IEnumerable<Walk> walks { get; set; }
    }
}
