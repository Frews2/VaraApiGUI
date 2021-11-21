﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaraApiGUI.Modelos
{
    class VaramientoJSON
    {
        public class Paginacion
        {
            public int total { get; set; }
            public int salto { get; set; }
            public int limite { get; set; }
        }

        public class Varamientos
        {
            public List<Item> items { get; set; }
        }

        public class Item
        {
            public string uuid { get; set; }
            public bool finalizado { get; set; }
            public string nombreInformante { get; set; }
            public string telefonoInformante { get; set; }
            public string direccionInformante { get; set; }
            public string ordenAnimal { get; set; }
            public string condicionAnimal { get; set; }
            public int numeroAnimales { get; set; }
            public string observaciones { get; set; }
            public bool facilAcceso { get; set; }
            public bool acantilado { get; set; }
            public string sustrato { get; set; }
            public string primeraVezVisto { get; set; }
            public string fechaAvistamiento { get; set; }
            public string pais { get; set; }
            public string estado { get; set; }
            public string ciudad { get; set; }
            public string localidad { get; set; }
            public string informacionAdicionalUbicacion { get; set; }
            public string latitud { get; set; }
            public string longitud { get; set; }
        }

        public class VaramientoResultados
        {
            public Varamientos varamientos { get; set; }
        }
    }
}
