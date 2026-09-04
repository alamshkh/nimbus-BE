namespace NimbusBank.Backend.Models
{
    public class LoanApplication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string PAN { get; set; }
        public string Aadhaar { get; set; }
    }
}