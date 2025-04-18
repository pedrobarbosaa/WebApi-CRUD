using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
