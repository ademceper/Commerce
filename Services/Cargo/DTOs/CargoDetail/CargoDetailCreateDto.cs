public class CargoDetailCreateDto
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public int Barcode { get; set; }
        public Guid CompanyId { get; set; }
    }