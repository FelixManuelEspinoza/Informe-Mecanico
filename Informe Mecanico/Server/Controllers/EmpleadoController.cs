using InformeBD.Data.entidades;
using InformeBD.entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Informe_Mecanico.Controllers.server
{
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

            public async Task<ActionResult<int>> Post(Empleado Empleado)
            {
                try
                {
                    Empleado Empleado = new Empleado ();
                    Empleado.Nombre = Empleado.Nombre;
                    Empleado.Apellido = Empleado.Apellido;
                    Empleado.DNI = Empleado.DNI;
                    Empleado.Cargo = Empleado.Cargo;
                    Empleado.NumTelefono = Empleado.NumTelefono;

                    DbContext.Empleados.add(Cliente);
                    await DbContext.SaveChangesAsync();
                    return Empleado.DNI;
                }
                catch (Exception error)
                {
                    return BadRequest(error.GetBaseException + error.Message);
                }
            }


        }
    }
}
