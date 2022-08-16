
using SQLite;
namespace AppMinhasCompras.Model
{

   
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public double Preco { get; set; }
    }
}
