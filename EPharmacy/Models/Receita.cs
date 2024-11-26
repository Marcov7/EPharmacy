﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.Models
{
    public class Receita
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int PacienteId { get; set; }
        public DateTime DataUltimaReceita { get; set; }
        public DateTime DataReceita { get; set; }
        public int TipoEntregaId { get; set; }
        public int ConvenioId { get; set; }
        public int ClinicaId { get; set; }
        public int MedicoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}



/*
Id, Descricao, PacienteId, DataReceita, Tipo_EntregaId, PeriodicidadeRefilId, 
    ConvenioId, ClinicaId, MedicoId, DataCadastro, Usuario*/