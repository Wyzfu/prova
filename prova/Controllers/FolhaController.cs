using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 
using API.Models; 

namespace API.Controllers
{
    [ApiController]
    [Route("api/folha")]
    
    public class FolhaController : ControllerBase
    {
        private static List<Folha> folhas = new List<Folha>();
        private DataContext _context;

        public FolhaController(DataContext context)
        {
            _context = context;
        }

        //cadastro
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody]Folha folha) 
        {
           _context.Folhas.Add(folha);
           _context.SaveChanges(); 
           return Created("",folha);
        }


        //listar
        [HttpGet] 
        [Route("listar")] 
        public IActionResult Listar()
        {
            return Ok(_context.Funcionarios.ToList());
        }


        [HttpGet]
        [Route("buscar/{cpf}{mes}{ano}")]

        public IActionResult Buscar([FromRoute] string cpf, string mes, string ano)
        {
            Funcionario funcionario = _context.Funcionarios.FirstOrDefault
            (
                 f => f.CPF.Equals(cpf)
            );
            return funcionario != null ? Ok(funcionario) : NotFound();

            Folha folha = _context.Folhas.FirstOrDefault
            (
                f=> f.mes.Equals.(mes)
            );
            return folha !null ? Ok(folha) : NotFound();
        }



    }     
} 
        
        