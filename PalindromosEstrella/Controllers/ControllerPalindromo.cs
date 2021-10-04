using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*
Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Oreintada a Servicios
Nombre del Maestro: Joel Ivan Chuc Uc
Nombre de la actividad: API PALIMDROMOS
Nombre del alumno o Alumnos: Jesus Ivan Estrella Yah
Cuatrimestre: 4to Cuatrimestre
Grupo: 4B
Parcial: 1er Parcial
 */

namespace PalindromosEstrella.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerPalindromo : ControllerBase
    {
        [HttpGet]
        public IActionResult Palindromo(string frase)
        {
            
            var oraciones = new Oraciones();
            oraciones.palindromo = frase;
            var contadorFinal = string.Empty;
            var contador = frase;
            int i = contador.Length;
            var palindromoFinal = "";

            for (int j = i - 1; j >= 0; j--)
            {
                contadorFinal = contadorFinal + contador[j];
            }
            if (contadorFinal.ToLower().Replace(" ", string.Empty) == contador.ToLower().Replace(" ", string.Empty))
            {
                palindromoFinal = (contador + " es palindrome");
            }
            else
            {
                palindromoFinal = (contador + " no es palindrome");
            }

            int ContadorPalabras = contadorFinal.Length - contadorFinal.Replace(" ", string.Empty).Count() + 1;
            var ResultadoInvert = ("La palabra ingresada: " + palindromoFinal.ToLower() + " La palabra investida es: " + contadorFinal.ToLower() + " y el numero de palabras es: " + ContadorPalabras);
            return Ok(ResultadoInvert.ToLower());
        }
    }
}
