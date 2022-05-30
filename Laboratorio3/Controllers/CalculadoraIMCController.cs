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

        PersonaModel[] personas;
        double[] imcs;
        Random random = new Random();
        public ActionResult ResultadosAleatoriosIMC()
        {
            
            personas = new PersonaModel[30];
            imcs = new double[30];
            for (int i = 0; i < 30; ++i)
            {
                PersonaModel persona = new PersonaModel(i, "Pepe", GetRandomNumber(20, 150), GetRandomNumber(1, 2));
                double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
                personas[i] = persona;
                imcs[i] = IMC;
            }
            ViewBag.personas = personas;
            ViewBag.imcs = imcs;
            return View();
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}