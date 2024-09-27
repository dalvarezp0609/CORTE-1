using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Registro
    {
        public Registro() { }
        public List <Persona> Persona { get; set; } = new List<Persona>(); 
        public void AgregarPersona(Persona persona)
        {
            Persona.Add(persona);
        }

        public string MostrarPersonas()
        {
            string listaPersonas
        }
    }
}
