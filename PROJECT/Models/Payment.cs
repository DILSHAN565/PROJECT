namespace PROJECT.Models
{
    public class Payment
    {

        public int PaymentID { get; set; }
        public DateTime Paymentdate { get; set; }
        public DateTime Paymenttime { get; set; }
        public int OrderID { get; set; }

    }
}
