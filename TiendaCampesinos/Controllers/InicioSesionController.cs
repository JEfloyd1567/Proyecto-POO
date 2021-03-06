using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaCampesinos.Models;
using TiendaCampesinos.Services;

namespace TiendaCampesinos.Controllers
{
    [Route("[controller]")]
    public class InicioSesionController : Controller
    {
        #region test
        private readonly TiendaCampesinosDBContext dBContext;
        public InicioSesionController(TiendaCampesinosDBContext dBContext){
            this.dBContext = dBContext;
        }
        #endregion
        [HttpGet("")]
        public async Task<IActionResult> IniciarSesion(){
            try{
                List<ProductoModel> productos = await dBContext.Productos.ToListAsync();
                return Ok("Aqui debemos implementar el Inicio de Sesión.");
            }
            catch (Exception e){
                return Content(e.Message);
            }
            
        }
    }
}