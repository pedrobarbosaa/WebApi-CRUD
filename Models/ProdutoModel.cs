namespace WebApi_.NET_9.Models
{
    public class ProdutoModel
    {
        //atalho para criar atributos prop
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; } = string.Empty;
        public string DescricaoProduto { get; set; } = string.Empty;
        public int QuantidadeProduto { get; set; }
        public string CodBarrasProduto { get; set; } = string.Empty;
        public string MarcaProduto { get; set; } = string.Empty;
    }
}
