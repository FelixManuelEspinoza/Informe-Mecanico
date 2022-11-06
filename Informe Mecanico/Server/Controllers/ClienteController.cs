using InformeBD.entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Informe_Mecanico.Server.controllers
{
    [ApiController]
    [Route("Api/Informe_Mecanico")]

    public class Informe_mecanico_controller : ControllerBase
    {
        private readonly DbContext dbcontext;

            public Informe_mecanico_controller(DbContext dbContext)
            {
             this.dbcontext = dbContext; 
            }

        [HttpGet]
        
        public async Task<ActionResult<int>> Post (Cliente cliente)
        {
            try
            {
                Cliente Cliente = new(cliente);
                Cliente.DNI = Cliente.DNI 

            }
        }
    }
}