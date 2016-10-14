namespace _07.SalesReport
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal SinglePrice { get; set; }
        public decimal Profit => Quantity * SinglePrice;
    }
}
