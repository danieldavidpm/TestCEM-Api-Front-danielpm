namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Domain
{
    public class Ubigeo
    {
        public string UbigeoCode { get; set; }
        public string ProvinceCode { get; set; }
        public Province? Province { get; set; }
        public string RegionCode { get; set; }
        public Region? Region { get; set; }
        public string UbigeoDescription { get; set; }
        public virtual ICollection<LibeyUser>? LibeyUsers { get; set; }
        public Ubigeo(string ubigeoCode, string provinceCode, string regionCode, string ubigeoDescription)
        {
            this.UbigeoCode = ubigeoCode;
            this.ProvinceCode = provinceCode;
            this.RegionCode = regionCode;
            this.UbigeoDescription = ubigeoDescription;
        }
    }
}
