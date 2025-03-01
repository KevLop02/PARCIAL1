using Microsoft.AspNetCore.Mvc;
using Parcial1.Models;

    public class caidaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Calcular(CaidaDadoModel model)
        {
            // Verifica si el modelo es válido
            if (ModelState.IsValid)
            {
                // Realiza el cálculo de la caída del dato
                double porcentajeCaida = 0.1;  // 10% de la caída (puedes cambiar este valor)

                // Calcular la caída en base al dato inicial
                model.Caida = model.DatoInicial * porcentajeCaida;

                // Calcular el dato final restando la caída
                model.DatoFinal = model.DatoInicial - model.Caida;

                // Genera un número aleatorio entre 1 y 100
                model.GenerarNumeroAleatorio();

            // Pasar el modelo con los resultados a la vista "Resultado"
            return View("~/Views/Index.cshtml", model);
        }

                // Si el modelo no es válido, vuelve a mostrar el formulario
                return View();
        }
     }
    
