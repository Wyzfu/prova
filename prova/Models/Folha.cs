using System;

namespace API.Models
{
    public class Folha
    {
        public int folhaid {get; set; }

        public string valorhora {get; set;}

        public string quantidadedehoras {get; set; }

        public string salariobruto {get; set; }

        public double impostorenda {get; set; }

        public double impostoinss {get; set; }

        public double impostofgts {get; set; }

        public double salarioliquido {get; set; }

        public Funcionario funcionario {get; set; }
 
    }
}