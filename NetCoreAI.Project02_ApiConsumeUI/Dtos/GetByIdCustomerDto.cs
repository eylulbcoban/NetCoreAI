namespace NetCoreAI.Project02_ApiConsumeUI.Dtos
{
    public class GetByIdCustomerDto
    {
        public int CustomerId { get; set; }
        public required string CurtomerName { get; set; }
        public required string CustomerSurname { get; set; }
        public decimal CustomerBalance { get; set; }
    }
}
