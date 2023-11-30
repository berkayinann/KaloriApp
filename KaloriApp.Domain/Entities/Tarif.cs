namespace KaloriApp.Domain.Entities
{
    public class Tarif : BaseEntity
    {
        //Besinlerden gelecek
        public string YemekAdi { get; set; }
        // Besinin kategorisinden gelecek
        public double KaloriMiktari { get; set; }
        public string YapilisTarifi { get; set; }
    }
}
