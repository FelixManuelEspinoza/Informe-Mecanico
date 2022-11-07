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
                Cliente Cliente = new Cliente ();
                Cliente.DNI = Cliente.DNI; 
                Cliente.Nombre = Cliente.Nombre;    
                Cliente.Apellido = Cliente.Apellido;    
                Cliente.NumTelefono = Cliente.NumTelefono;
                Cliente.MarcaVehiculo = Cliente.MarcaVehiculo;
                Cliente.ModeloVehiculo = Cliente.ModeloVehiculo;
                Cliente.Matricula = Cliente.Matricula;
                Cliente.DetallesDehiculo = Cliente.DetallesDehiculo; 
                Cliente.FechaDeEntrada = Cliente.FechaDeEntrada;    
                Cliente.FechaDeSalida = Cliente.FechaDeSalida;

                DbContext.Clientes.add(Cliente);
                await DbContext.SaveChangesAsynk();
                return Cliente.DNI;


            }
            catch (Exception error)
            {
                return BadRequest(error.GetBaseException + error.Message);
            }
        }
    }
}