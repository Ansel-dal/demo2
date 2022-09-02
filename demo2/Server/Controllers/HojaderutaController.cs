using demo2.Server.Context;
using demo2.Shared.Models;
using demo2.Shared.Response;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HojaderutaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Producto>> oRespuesta = new Respuesta<List<Producto>>();
            try
            {
                using (clicpaqdemo2Context db = new clicpaqdemo2Context())
                {
                    var lst = db.Productos.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta.List = lst;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpPost]
        public Respuesta<List<Producto>> Post(Hojaderutum ejemplo1)
        {
            var id = ejemplo1.Nombre;
            Respuesta<List<Hojaderutum>> oRespuesta = new Respuesta<List<Hojaderutum>>();
            Respuesta<List<Producto>> oRespuesta1 = new();
            List<Producto> list = new List<Producto>();

            try
            {
                using (clicpaqdemo2Context db = new clicpaqdemo2Context())
                {
                    var lst = db.Productos.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta1.List = lst;
                }
                foreach(var producto in oRespuesta1.List)
                {
                    if(id == producto.Destino)
                    {
                        list.Add(producto);
                        
                    }
                    
                }
                oRespuesta1.List = list;
            }
            catch (Exception ex)
            {
                oRespuesta1.Mensaje = ex.Message;
                
            }
            return oRespuesta1;
        }
    }
}
