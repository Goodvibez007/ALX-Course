namespace ALXCourseHomework.MaterialAssignments.Task04
{
    public class Product
    {
        public int Id;
        public double PriceNetto;
        public double Tax;
        public int QuantityInBox;
        public int BoxCount;
        public double PriceBrutto;

        public Product(int id, double priceNetto, double tax, int quantityInBox, int boxCount)
        {
            Id = id;
            PriceNetto = priceNetto;
            Tax = tax;
            QuantityInBox = quantityInBox;
            BoxCount = boxCount;        
        }

        public void Brutto()
        {
            PriceBrutto = Math.Round(PriceNetto + PriceNetto * Tax, 2);
        }
    }
}
