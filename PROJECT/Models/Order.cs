namespace PROJECT.Models
{
    public class Order
    {


        public int OrderID { get; set; }
        public System.DateTime Orderdate { get; set; }
        public int Orderprice { get; set; }
        public int CustomerID { get; set; }
        public int EmpID { get; set; }


    }
}
