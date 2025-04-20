using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_.NET_9.Data;
using WebApi_.NET_9.Models;

namespace WebApi_.NET_9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProdutoController(AppDbContext context) 
        {
            _context = context; 
        
        }

        [HttpGet]
        public ActionResult<List<ProdutoModel>> BuscarProdutos()
        {
            var produtos = _context.Produtos.ToList();
            return Ok(produtos);
        }

        [HttpGet("{IdProduto}")]
        public ActionResult<ProdutoModel> BuscarProdutosPorId(int IdProduto)
        {
            var produto = _context.Produtos.Find(IdProduto);
            if(produto == null)
            {
                return NotFound("Registro não encontrado.");
            }
            return Ok(produto); 
        }

        [HttpPost]
        public ActionResult<ProdutoModel> CriarProduto(ProdutoModel produtoModel)
        {
            if(produtoModel == null)
            {
                return BadRequest("Informe os dados do produto");
            }
            _context.Produtos.Add(produtoModel);
            _context.SaveChanges();

            return CreatedAtAction(nameof(BuscarProdutosPorId), new {IdProduto = produtoModel.IdProduto }, produtoModel);
        }

        [HttpPut("{IdProduto}")]
        public ActionResult<ProdutoModel> EditarProduto(ProdutoModel produtoModel, int IdProduto)
        {
            var produto = _context.Produtos.Find(IdProduto);

            if(produto == null)
            {
                return NotFound("Registro não localizado.");
            }

            produto.NomeProduto = produtoModel.NomeProduto;
            produto.DescricaoProduto = produtoModel.DescricaoProduto;
            produto.QuantidadeProduto = produtoModel.QuantidadeProduto;
            produto.CodBarrasProduto = produtoModel.CodBarrasProduto;
            produto.MarcaProduto = produtoModel.MarcaProduto;

            _context.Produtos.Update(produto);
            _context.SaveChanges();

            return Ok("Registro editado com sucesso");
           
        }

        [HttpDelete("{IdProduto}")]
        public ActionResult<ProdutoModel> ExcluirProduto(int IdProduto)
        {

            var produto = _context.Produtos.Find(IdProduto);

            if(produto == null)
            {
                return NotFound("Registro não localizado.");
            }

            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return Ok("Registro excluído com sucesso");
            
        }
    }
}
