using System;
using System.ComponentModel.DataAnnotations;
using API_Folha.Validations;

namespace API.Models
{
    public class Funcionariohoras
    {
        public Funcionario funcionarioId {get; set; }

        public string valorhora {get; set; }

        public string quantidadedehoras {get; set; }
    }
}