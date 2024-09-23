namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO
{
    public record RegionUpdateorCreateCommand
    {
        public string? RegionCode { get; set; }
        public string? RegionDescription { get; set; }
    }
}
