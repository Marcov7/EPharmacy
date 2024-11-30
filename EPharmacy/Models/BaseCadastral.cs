using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EPharmacy.Models
{


    public class BaseCadastral
    {
        public int Id { get; set; } 
        public int PacienteId { get; set; }    
        public string Matricula { get; set; }     
        public string ConvenioId { get; set; }      
        public string CPF { get; set; }
        public string Nome { get; set; }
        public int Status { get; set; }
        public DateTime DataInclusao { get; set; }
        public int MedicamentoId { get; set; }
        public string EAN { get; set; }
        //public string MedicamentoId { get; set; }
        public string Produto { get; set; }
        public int Qtdd { get; set; }
        public int MedicamentoPrecoId { get; set; }
        public decimal PrecoAcordado { get; set; }     //PRICE    
        public decimal Total { get; set; }
        public int ReceitaId { get; set; }
        public DateTime DataRecVenc { get; set; } 
        public DateTime DataReceita { get; set; }      
        public string PeriodicidadeRefilId { get; set; }
        public string Refil1 { get; set; }
        public string Refil2 { get; set; }
        public string Refil3 { get; set; }
        public string Refil4 { get; set; }  
        public string Refil5 { get; set; }
        public string Refil6 { get; set; }
        public string RefilExtra { get; set; } 
        public string TipoReceitaId { get; set; }       //RECEITA
        public string Obs { get; set; }     
        public string Celular { get; set; }      
        public string Logradouro { get; set; }      //ENDEREÇO 
        public string Bairro { get; set; }      
        public string Localidade { get; set; }      
        public string CEP { get; set; }
        public string ModalidadeId { get; set; }     //MODALIDADE
        public string TipoEntregaId { get; set; }       //ENTREGA
        public string Zona { get; set; } 
        public string Autorizacao { get; set; }          
        public string Generico { get; set; }
        public Int64 Soma { get; set; }
        public string TUSS { get; set; }
        
    }



}
