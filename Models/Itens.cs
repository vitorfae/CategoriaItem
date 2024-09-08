using System.ComponentModel.DataAnnotations.Schema;

namespace categoriaItem.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string? NomeItem { get; set; }

        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }
    }
}