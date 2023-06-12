namespace ExProvaWebIII.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public string CodigoBarras { get; set; }
    }
}
