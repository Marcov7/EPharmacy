﻿namespace EPharmacy.Models
{
    public class UsuarioSistema
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}