using System;
using System.Web.Mvc;
using Laboratorio3.Models;

namespace Laboratorio3.Controllers
{
    public class CalculadoraIMCController : Controller
    {

        public ActionResult ResultadoIMC()
        {
            PersonaModel persona = new PersonaModel(1, "Cristiano Ronaldo", 84.0, 1.87);
            double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
            ViewBag.IMC = IMC;
            ViewBag.persona = persona;
            return View();
        }

        public ActionResult ResultadosAleatoriosIMC()
        {
            for (int i = 0; i < 30; ++i)
            {
                PersonaModel persona = new PersonaModel(1, "Pepe", GetRandomNumber(20, 150), GetRandomNumber(1, 2));
                double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
                ViewBag.IMC = IMC;
                ViewBag.persona = persona;
            }       
            return View();
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}