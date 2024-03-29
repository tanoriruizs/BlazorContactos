﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorContactos.Shared.DTOs.MediosContactos
{
    public class MedioContactoDTO
    {
        public int Id { get; set; }

        public string? Email { get; set; }
        public string? Telefono { get; set; }

        [Required]
        public string? Celular { get; set; }
        public int ContactoId { get; set; }

    }
}
