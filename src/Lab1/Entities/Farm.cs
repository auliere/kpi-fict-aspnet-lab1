namespace Lab1.Entities
{
    public class Farm
    {
        public int Id { get; set; }
        public string Culture { get; set; }
        public double Amount { get; set; }

        public int CompanyId { get; set; }
    }
}
