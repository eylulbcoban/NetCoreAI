namespace NetCoreAI.Project02_ApiConsumeUI.Dtos
{
    public class CreateCustomerDto
    {
        public required string CurtomerName { get; set; }
        public required string CustomerSurname { get; set; }
        public decimal CustomerBalance { get; set; }
    }
}
