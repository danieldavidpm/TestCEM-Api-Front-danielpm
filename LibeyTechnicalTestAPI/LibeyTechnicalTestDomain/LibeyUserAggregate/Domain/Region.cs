namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Domain
{
    public class Region
    {
        public string RegionCode { get; set; }
        public string RegionDescription { get; set; }
        public virtual ICollection<Ubigeo>? Ubigeos { get; set; }
        public Region(string regionCode, string regionDescription)
        {
            this.RegionCode = regionCode;
            this.RegionDescription = regionDescription;
        }
    }
}
