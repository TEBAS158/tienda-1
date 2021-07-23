using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tienda.Models;


namespace tienda.Controllers
{
    public class HomeController : Controller
    {
        Operacion lista = new Operacion();

        private readonly ILogger<HomeController> _logger;

            //private Nodo referencia2;
            //private Nodo cabecera;

        public HomeController(ILogger<HomeController> logger)
        {
           
            _logger = logger;
        }

        public IActionResult  Index()
        {
            

            
            return View();
        }

        public  RedirectResult buscar(string busqueda)
        {
            Nodo encontrado = lista.Buscar(busqueda);
            if(encontrado != null){
                if(busqueda.Equals("iphone 10")){
                    return Redirect("https://localhost:5001/HOME/IPHONE10");
                }
                if(busqueda.Equals("iphone 11")){
                    return Redirect("https://localhost:5001/HOME/IPHONE11");
                }
                else return Redirect("https://localhost:5001/HOME/IPHONE12");
            }
            Console.WriteLine(encontrado);
            return Redirect("https://localhost:5001/HOME/SINRESULTADO/");
        }

        public RedirectResult NUEVO(string marca, string url, string precio, string c)
        {
            lista.Agregar(marca);
            lista.Agregar(url);
            lista.Agregar(precio);
                       Console.WriteLine(marca);
                       Console.WriteLine(url);
                       Console.WriteLine(precio);
                       TempData["marca"] =marca;
                       TempData["url"] =url;
                       TempData["precio"] =precio;
                       
                       Console.WriteLine("\n");
                      lista.Mostrar();
                       
           return Redirect("https://localhost:5001");

           
        }
        




         public IActionResult IPHONE11()
        {
            return View();
        }
         public IActionResult ELIMINAR(string marca)
        {
            lista.Borrar(marca);
            lista.Mostrar();


            return View();
        }

                 public IActionResult SINRESULTADO()
        {
            return View();
        }



         public IActionResult IPHONE10()
        {
            return View();
        }

        
         public IActionResult IPHONE12()
        {
            return View();
        }
        public IActionResult COMPRAR11()
        {
            return View();
        }
        public IActionResult AGREGAR()
        {


            return View();
        }

         public IActionResult CORREO()
        {

            
            return View();
        }
       
       public IActionResult  HOLA()
        {
            

            
            return View();
        }
public IActionResult BORRARNUEVO()
        {
            return View();
        }
        public IActionResult INICIOVECT()
        {
            return View();
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}





