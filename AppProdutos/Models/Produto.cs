using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppProdutos.Models
{
    public class Produto
    {
        [Key]
        [Column(TypeName = "int")]
        public int IdProduto { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string NomeProduto { get; set; }
        
        [Required]
        [Column(TypeName = "decimal")]
        public decimal ValorProduto { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string ImagemProdutoUrl { get; set; }


    }
}
