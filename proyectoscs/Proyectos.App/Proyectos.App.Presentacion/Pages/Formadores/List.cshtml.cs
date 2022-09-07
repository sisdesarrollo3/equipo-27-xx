using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

using Proyectos.App.Dominio.Entidades;

namespace Proyectos.App.Presentacion.Pages.Formadores
{
    public class ListModel : PageModel
    {  
        public IEnumerable<Formador> formadores { get; set; }
        public ListModel(){
            formadores = new List<Formador>()
            {
                new Formador{id=1, identificacion="102030", nombre="Jhon Jairo Orozco", mail="xx@xx", movil="cel1", vigente=true},
                new Formador{id=2, identificacion="304050", nombre="Luz Dary Martinez", mail="xx@xx", movil="cel2", vigente=true},
                new Formador{id=3, identificacion="607080", nombre="Mateo Orozco", mail="xx@xx", movil="cel3", vigente=true},
                new Formador{id=4, identificacion="901020", nombre="Mario Enrique Montoya", mail="xx@xx", movil="cel4", vigente=true}
            };
        }

        public void OnGet()
        {
        }
    }
}


