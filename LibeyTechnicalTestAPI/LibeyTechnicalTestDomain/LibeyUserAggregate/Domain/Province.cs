namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Domain
{
    public class Province
    {
        public string ProvinceCode { get; set; }
        public string RegionCode { get; set; }
        public string ProvinceDescription { get; set; }
        public virtual ICollection<Ubigeo>? Ubigeos { get; set; }

        public Province(string provinceCode, string regionCode, string provinceDescription)
        {
            this.ProvinceCode = provinceCode;
            this.RegionCode = regionCode;
            this.ProvinceDescription = provinceDescription;
        }
    }
}
