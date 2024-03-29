﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

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
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido, tente outro formato")]
        public string Email { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Formato de data inválido, tente outro formato")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? BirthDate { get; set; }

        public DateTime CreationDate { get; set; }

        public Contact()
        {
            CreationDate = DateTime.Now;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public bool IsValidPhoneNumber()
        {
            return Regex.IsMatch(PhoneNumber, "\\([0-9]{2}\\)[0-9]{4,5}-[0-9]{4}");
        }
    }
}
