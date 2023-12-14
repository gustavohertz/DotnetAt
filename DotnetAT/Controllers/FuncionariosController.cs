using DotnetAT.Dados;
using DotnetAT.Models;
using DotnetAT.Models.Dominio;
using Microsoft.AspNetCore.Mvc;

namespace DotnetAT.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;

        public FuncionariosController(MVCDemoDbContext mvcDemoDbContext) 
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddFuncionarioViewModel addFuncionarioRequest)
        {
            var funcionario = new Funcionario()
            {
                ID = Guid.NewGuid(),
                Name = addFuncionarioRequest.Name,
                Email = addFuncionarioRequest.Email,
                Salario = addFuncionarioRequest.Salario,
                DataDaContratacao = addFuncionarioRequest.DataDaContratacao,
                Cargo = addFuncionarioRequest.Cargo
            };
            await mvcDemoDbContext.Funcionarios.AddAsync(funcionario);
            await mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
