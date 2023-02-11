namespace CustomerInformation.Infrastructure.BusinessObjects
{
    public class CustomerAddress
    {
        public int Id { get ; set; }
        public string Address { get; set; }
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
    }
}
