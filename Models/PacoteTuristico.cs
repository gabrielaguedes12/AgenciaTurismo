using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Models
{
    public class PacoteTuristico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A data é obrigatória")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Capacidade obrigatória")]
        [Range(1, 1000, ErrorMessage = "Capacidade deve ser maior que 0")]
        public int CapacidadeMaxima { get; set; }

        [Required(ErrorMessage = "Preço obrigatório")]
        [Range(0.01, 100000, ErrorMessage = "Preço deve ser maior que zero")]
        public decimal Preco { get; set; }

        // RELACIONAMENTO
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();

        // (opcional mas bom pra nota)
        public bool IsDeleted { get; set; } = false;
    }
}