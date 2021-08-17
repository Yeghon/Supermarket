namespace SuperMarket.Domains.Model
{

    public class Product
    {
        public int Id {get; set;}

        public string Name {get; set;}

        public short QuantityInPackage {get; set;}
        
        public EUnitOfMeasurement UnitsOfMeasurement {get; set;}

        public int CategoryId {get; set;}

        public Category Category {get; set;}
    }
    
}