﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O primeiro nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo permitido é de {1} caracteres")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatório")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo permitido é de {1} caracteres")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "O número de telefone é obrigatório")]
        [MaxLength(15, ErrorMessage = "O tamanho máximo permitido é de {1} caracteres")]
        public string PhoneNumber { get; set; }

        [MaxLength(150, ErrorMessage = "O tamanho máximo permitido é de {1} caracteres")]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
