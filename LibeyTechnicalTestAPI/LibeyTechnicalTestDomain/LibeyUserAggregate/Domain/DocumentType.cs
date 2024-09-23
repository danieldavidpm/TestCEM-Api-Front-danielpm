namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Domain
{
    public class DocumentType
    {
        public int DocumentTypeId { get; set; }
        public string DocumentTypeDescription { get; set; }
        public virtual ICollection<LibeyUser>? LibeyUsers { get; set; }

        public DocumentType(int documentTypeId, string documentTypeDescription)
        {
            DocumentTypeId = documentTypeId;
            DocumentTypeDescription = documentTypeDescription;
        }
    }
}
