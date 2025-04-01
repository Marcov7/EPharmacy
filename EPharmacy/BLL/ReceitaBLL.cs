using BLL;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace EPharmacy.BLL
{
    public class ReceitaBLL
    {
        private readonly EPharmacyContext _context;

        public ReceitaBLL()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
        }

        /*
        public IQueryable<BaseCadastral> GetReceitasUltimos6Meses()
        {
            // Data limite para 6 meses atrás
            var dataLimite = DateTime.Now.AddMonths(-6);

            // Consulta com join para obter todas as informações relacionadas
            var query = from receita in _context.Set<Receita>()
                        join paciente in _context.Set<Paciente>() on receita.PacienteId equals paciente.Id
                        join convenio in _context.Set<Convenio>() on receita.ConvenioId equals convenio.Id
                        join clinica in _context.Set<Clinica>() on receita.ClinicaId equals clinica.Id
                        join medico in _context.Set<Medico>() on receita.MedicoId equals medico.Id
                        join tipoEntrega in _context.Set<TipoEntrega>() on receita.TipoEntregaId equals tipoEntrega.Id
                        join receitaItem in _context.Set<ReceitaItens>() on receita.Id equals receitaItem.ReceitaId
                        join medicamento in _context.Set<Medicamento>() on receitaItem.MedicamentoId equals medicamento.Id
                        join medicamentoPreco in _context.Set<MedicamentoPreco>() on medicamento.Id  equals medicamentoPreco.MedicamentoId
                        join classeTerapeutica in _context.Set<ClasseTerapeutica>() on medicamento.ClasseTerapeuticaId equals classeTerapeutica.Id
                        join tipoReceita in _context.Set<TipoReceita>() on medicamento.TipoReceitaId equals tipoReceita.Id
                        join fabricante in _context.Set<Fabricante>() on medicamento.FabricanteId equals fabricante.Id
                        join substancia in _context.Set<Substancia>() on medicamento.SubstanciaId equals substancia.Id
                        join periodicidadeRefil in _context.Set<PeriodicidadeRefil>() on receitaItem.PeriodicidadeRefilId equals periodicidadeRefil.Id
                        join status in _context.Set<Status>() on receitaItem.StatusId equals status.Id
                        where receita.DataReceita >= dataLimite
                        select new
                        {
                            ReceitaId = receita.Id,
                            Receita = receita.Descricao,
                            Paciente = paciente.Nome,
                            CPF = paciente.CPF,
                            Convenio = convenio.Descricao,
                            Clinica = clinica.Descricao,
                            MedicoNome = medico.Nome,
                            TipoEntrega = tipoEntrega.Descricao,
                            Produto = medicamento.Produto,
                            EAN = medicamento.EAN,
                            MedicamentoPreco = medicamentoPreco.PrecoAcordado,
                            ClasseTerapeutica = classeTerapeutica.Descricao,
                            TipoReceita = tipoReceita.Descricao,
                            Fabricante = fabricante.Descricao,
                            Substancia = substancia.Descricao,
                            PeriodicidadeRefil = periodicidadeRefil.Descricao,
                            Status = status.Descricao,
                            DataReceita = receita.DataReceita,
                            DataUltimaReceita = receita.DataUltimaReceita
                        };

            return query;

        }
        */


        public IQueryable ListarReceitasOld()
        {
            // Definindo o filtro de 6 meses
            var dataLimite = DateTime.Now.AddMonths(-6);

            // Realizando a consulta com filtro de DataReceita nos últimos 6 meses
            var consulta = from receita in _context.Receita
                           join paciente in _context.Paciente on receita.PacienteId equals paciente.Id
                           join convenio in _context.Convenio on paciente.ConvenioId equals convenio.Id
                           join clinica in _context.Clinica on receita.ClinicaId equals clinica.Id
                           join medico in _context.Medico on receita.MedicoId equals medico.Id
                           join tipoEntrega in _context.TipoEntrega on paciente.TipoEntregaId equals tipoEntrega.Id
                           where receita.DataReceita >= dataLimite
                           select new
                           {
                               // Campos da entidade Receita
                               receita.Id,
                               receita.Descricao,
                               receita.DataReceita,
                               //receita.DataReceitaAnterior,
                               // Campos das entidades associadas
                               PacienteNome = paciente.Nome,
                               PacienteCpf = paciente.CPF,
                               //ConvenioDescricao = convenio.Descricao,
                               ClinicaDescricao = clinica.Descricao,
                               MedicoNome = medico.Nome,
                               TipoEntregaDescricao = tipoEntrega.Descricao
                           };

            // Você pode retornar ou exibir os resultados conforme necessário
            //var resultado = consulta; //.ToList();
            return consulta;
            //foreach (var item in resultado)
            //{
            //    Console.WriteLine($"Receita ID: {item.Id}, Paciente: {item.PacienteNome}, Convenio: {item.ConvenioDescricao}, Data Receita: {item.DataReceita}");
            //}
        }


        public IList<MedicamentoPrecoViewModel> GetMedicamentosParaProximos6Meses(DateTime? dataComparacao, string EAN, int? MedicamentoId, int? ConvenioId, string CPF, string Matricula, int? PacienteId, int? StatusId, string Bairro, string Zona, int? tipoReceitaId)
        {

            int Mes = 0;
            int Ano = 0;

            if (dataComparacao != null)
            {
                Mes = dataComparacao.Value.Month;
                Ano = dataComparacao.Value.Year;
            }

            var dataLimite = DateTime.Now.AddMonths(-6);  // Calculando a data para 6 meses a partir de hoje

            // Query para pegar os medicamentos e seus preços, incluindo as tabelas relacionadas
            IList<MedicamentoPrecoViewModel> medicamentos = (
                                      from re in _context.Receita
                                      join ri in _context.ReceitaItens on re.Id equals ri.ReceitaId
                                      join m in _context.Medicamento on ri.MedicamentoId equals m.Id
                                      join mp in _context.MedicamentoPreco on m.Id equals mp.MedicamentoId
                                      join ct in _context.ClasseTerapeutica on m.ClasseTerapeuticaId equals ct.Id
                                      join tr in _context.TipoReceita on m.TipoReceitaId equals tr.Id
                                      join fa in _context.Fabricante on m.FabricanteId equals fa.Id
                                      join sb in _context.Substancia on m.SubstanciaId equals sb.Id
                                      join pc in _context.Paciente on re.PacienteId equals pc.Id
                                      join cv in _context.Convenio on pc.ConvenioId equals cv.Id
                                      join st in _context.Status on ri.StatusId equals st.Id
                                      join pe in _context.PeriodicidadeRefil on ri.PeriodicidadeRefilId equals pe.Id
                                      join te in _context.TipoEntrega on pc.TipoEntregaId equals te.Id
                                      join md in _context.Modalidade on pc.ModalidadeEntregaId equals md.Id

                                      where //re.DataReceita >= dataLimite &&
                                         ((ri.Refil1.Value.Month == Mes && ri.Refil1.Value.Year == Ano) ||
                                          (ri.Refil2.Value.Month == Mes && ri.Refil2.Value.Year == Ano) ||
                                          (ri.Refil3.Value.Month == Mes && ri.Refil3.Value.Year == Ano) ||
                                          (ri.Refil4.Value.Month == Mes && ri.Refil4.Value.Year == Ano) ||
                                          (ri.Refil5.Value.Month == Mes && ri.Refil5.Value.Year == Ano) ||
                                          (ri.Refil6.Value.Month == Mes && ri.Refil6.Value.Year == Ano) ||
                                          (ri.RefilExtra.Value.Month == Mes && ri.RefilExtra.Value.Year == Ano) || dataComparacao == null)
                                      && (m.EAN == EAN || EAN.IsNullOrEmpty())
                                      && (pc.Matricula == Matricula || Matricula.IsNullOrEmpty())
                                      && (pc.CPF == CPF || CPF.IsNullOrEmpty())
                                      && (pc.ConvenioId == ConvenioId || ConvenioId == null)
                                      && (pc.Id == PacienteId || PacienteId == null)
                                      && (m.Id == MedicamentoId || MedicamentoId == null)
                                      && (ri.StatusId == StatusId || StatusId == null)
                                      && (pc.Bairro == Bairro || Bairro.IsNullOrEmpty())
                                      && (pc.Zona == Zona || Zona.IsNullOrEmpty())
                                      && (m.TipoReceitaId == tipoReceitaId || tipoReceitaId == null)

                                      orderby ri.Id, m.Id
                                      select new MedicamentoPrecoViewModel
                                      {
                                          ReceitaItensId = ri.Id,
                                          PacienteId = pc.Id,
                                          Matricula = pc.Matricula,
                                          ConvenioId = pc.ConvenioId.Value,
                                          Convenio = cv.Descricao,
                                          CPF = pc.CPF,
                                          Nome = pc.Nome,
                                          StatusId = ri.StatusId,
                                          Status = st.Descricao,
                                          DataInclusaoConvenio = DateTime.Now.Date,
                                          MedicamentoId = m.Id,
                                          EAN = m.EAN,
                                          Produto = m.Produto,
                                          Qtdd = ri.Qtdd,
                                          /*ClasseTerapeuticaId = m.ClasseTerapeuticaId,
                 
                                          FabricanteId = m.FabricanteId,
                                          SubstanciaId = m.SubstanciaId,
                                          MedicamentoPrecoId = mp.Id,*/
                                          PrecoAcordado = mp.PrecoAcordado,
                                          //Total = ri.Qtdd.Value* mp.PrecoAcordado,
                                          //Total = Math.Round(ri.Qtdd.Value * mp.PrecoAcordado, 2),
                                          Total = $"{ri.Qtdd.Value * mp.PrecoAcordado:F2}",
                                          ReceitaId = re.Id,
                                          ReceitaDescricao = re.Descricao,
                                          DataReceitaAnterior = ri.DataReceitaAnterior,
                                          DataReceita = re.DataReceita,

                                          PeriodicidadeId = ri.PeriodicidadeRefilId,
                                          Periodicidade = pe.Descricao,
                                          Refil1 = ri.Refil1.Value,
                                          Refil2 = ri.Refil2.Value,
                                          Refil3 = ri.Refil3.Value,
                                          Refil4 = ri.Refil4.Value,
                                          Refil5 = ri.Refil5.Value,
                                          Refil6 = ri.Refil6.Value,
                                          RefilExtra = ri.RefilExtra.Value,

                                          TipoReceitaId = m.TipoReceitaId,
                                          TipoReceita = tr.Descricao,
                                          Obs = ri.Obs,
                                          Celular = pc.Celular,
                                          Telefone = pc.Telefone,

                                          Logradouro = pc.Logradouro,
                                          Numero = pc.Numero,
                                          Bairro = pc.Bairro,
                                          CEP = pc.CEP,
                                          Zona = pc.Zona,
                                          Modalidade = md.Descricao,
                                          TipoEntrega = te.Descricao,
                                          Autorizacao = pc.Autorizacao,
                                          // Incluindo as tabelas relacionadas
                                          ClasseTerapeutica = ct.Descricao,

                                          Fabricante = fa.Descricao,
                                          Substancia = sb.Descricao

                                      })
                                      .ToList();

            return medicamentos;
        }


        public IList<PedidoViewModel> GetMedicamentosParaProximos6MesesPedido(DateTime? dataComparacao, string EAN, int? MedicamentoId, int? ConvenioId, string CPF, string Matricula, int? PacienteId, int? StatusId, string Bairro, string Zona, int? tipoReceitaId)
        {

            int Mes = 0;
            int Ano = 0;

            if (dataComparacao != null)
            {
                Mes = dataComparacao.Value.Month;
                Ano = dataComparacao.Value.Year;
            }

            var dataLimite = DateTime.Now.AddMonths(-6);  // Calculando a data para 6 meses a partir de hoje

            // Query para pegar os medicamentos e seus preços, incluindo as tabelas relacionadas
            IList<PedidoViewModel> medicamentos = (
                                      from re in _context.Receita
                                      join ri in _context.ReceitaItens on re.Id equals ri.ReceitaId  
                                      join m in _context.Medicamento on ri.MedicamentoId equals m.Id
                                      join mp in _context.MedicamentoPreco on m.Id equals mp.MedicamentoId
                                      join ct in _context.ClasseTerapeutica on m.ClasseTerapeuticaId equals ct.Id
                                      join tr in _context.TipoReceita on m.TipoReceitaId equals tr.Id
                                      join fa in _context.Fabricante on m.FabricanteId equals fa.Id
                                      join sb in _context.Substancia on m.SubstanciaId equals sb.Id
                                      join pc in _context.Paciente on re.PacienteId equals pc.Id
                                      join cv in _context.Convenio on pc.ConvenioId equals cv.Id
                                      join st in _context.Status on ri.StatusId equals st.Id
                                      join pe in _context.PeriodicidadeRefil on ri.PeriodicidadeRefilId equals pe.Id
                                      join te in _context.TipoEntrega on pc.TipoEntregaId equals te.Id
                                      join md in _context.Modalidade on pc.ModalidadeEntregaId equals md.Id

                                      join receitaItemEntrega in _context.ReceitaItensEntrega on ri.Id equals receitaItemEntrega.ReceitaItensId 
     
                                      join refi in _context.Refil on receitaItemEntrega.RefilId equals refi.Id
                                      join sen in _context.StatusEntrega on receitaItemEntrega.StatusEntregaId equals sen.Id

                                      where re.DataReceita >= dataLimite

                                      && ((receitaItemEntrega.DataRefil.Value.Month == Mes && receitaItemEntrega.DataRefil.Value.Year == Ano) ||
                                           (receitaItemEntrega.DataRefil.Value.Month == null || receitaItemEntrega.DataRefil.Value.Year == null) || dataComparacao == null)

                                      && (ri.StatusId == 2)
                                      /*&& ((ri.Refil1.Value.Month == Mes && ri.Refil1.Value.Year == Ano) ||
                                          (ri.Refil2.Value.Month == Mes && ri.Refil2.Value.Year == Ano) ||
                                          (ri.Refil3.Value.Month == Mes && ri.Refil3.Value.Year == Ano) ||
                                          (ri.Refil4.Value.Month == Mes && ri.Refil4.Value.Year == Ano) ||
                                          (ri.Refil5.Value.Month == Mes && ri.Refil5.Value.Year == Ano) ||
                                          (ri.Refil6.Value.Month == Mes && ri.Refil6.Value.Year == Ano) ||
                                          (ri.RefilExtra.Value.Month == Mes && ri.RefilExtra.Value.Year == Ano) || dataComparacao == null)*/
                                      && (m.EAN == EAN || EAN.IsNullOrEmpty())
                                      && (pc.Matricula == Matricula || Matricula.IsNullOrEmpty())
                                      && (pc.CPF == CPF || CPF.IsNullOrEmpty())
                                      && (pc.ConvenioId == ConvenioId || ConvenioId == null)
                                      && (pc.Id == PacienteId || PacienteId == null)
                                      && (m.Id == MedicamentoId || MedicamentoId == null)
                                      && (ri.StatusId == StatusId || StatusId == null)
                                      && (pc.Bairro == Bairro || Bairro.IsNullOrEmpty())
                                      && (pc.Zona == Zona || Zona.IsNullOrEmpty())
                                      && (m.TipoReceitaId == tipoReceitaId || tipoReceitaId == null)

                                      orderby receitaItemEntrega.DataRefil, ri.Id, m.Id
                                      select new PedidoViewModel
                                      {

                                          ReceitaId = re.Id,
                                          ReceitaItensId = ri.Id,
                                          ReceitaItensEntregaId = receitaItemEntrega.Id != null ? receitaItemEntrega.Id : (int?)null,
                                                                             
                                          DataEntrega = receitaItemEntrega.DataRefil != null ? receitaItemEntrega.DataRefil : (DateTime?)null,
                                          Zona = pc.Zona,
                                          PacienteId = pc.Id,
                                          Matricula = pc.Matricula,
                                          ConvenioId = pc.ConvenioId.Value,
                                          Convenio = cv.Descricao,
                                          CPF = pc.CPF,
                                          Nome = pc.Nome,
                                          MedicamentoId = m.Id,
                                          EAN = m.EAN,
                                          Produto = m.Produto,
                                          Qtdd = ri.Qtdd,
                                          Real = receitaItemEntrega.Real.Value != null ? receitaItemEntrega.Real.Value : (int?)null,
    
                                          NotaFiscal = receitaItemEntrega.NumNotaFiscal,             
                                          StatusEntregaId = receitaItemEntrega.StatusEntregaId != null ? receitaItemEntrega.StatusEntregaId : (int?)null,
                                          StatusEntrega = sen.Descricao,     
                                          Lote = receitaItemEntrega.NumLote,
                                          Obs = ri.Obs,
                                          PeriodicidadeId = ri.PeriodicidadeRefilId,
                                          Periodicidade = pe.Descricao,
                                          TipoReceitaId = m.TipoReceitaId,
                                          TipoReceita = tr.Descricao,
                                          Celular = pc.Celular,
                                          Telefone = pc.Telefone,
                                          Logradouro = pc.Logradouro,
                                          Numero = pc.Numero,
                                          Bairro = pc.Bairro,
                                          CEP = pc.CEP,

                                          RefilId = refi.Id != null ? refi.Id : (int?)null,
                                          Refil = refi.Descricao,
     
                                          StatusId = ri.StatusId,
                                          Status = st.Descricao,
                                          DataInclusaoConvenio = DateTime.Now.Date,

                                          /*ClasseTerapeuticaId = m.ClasseTerapeuticaId,
                 
                                          FabricanteId = m.FabricanteId,
                                          SubstanciaId = m.SubstanciaId,
                                          MedicamentoPrecoId = mp.Id,*/
                                          PrecoAcordado = mp.PrecoAcordado,
                                          //Total = ri.Qtdd.Value* mp.PrecoAcordado,
                                          //Total = Math.Round(ri.Qtdd.Value * mp.PrecoAcordado, 2),
                                          Total = $"{ri.Qtdd.Value * mp.PrecoAcordado:F2}",
                                   
                                          ReceitaDescricao = re.Descricao,
                                          DataReceitaAnterior = ri.DataReceitaAnterior,
                                          DataReceita = re.DataReceita,


                                          Refil1 = ri.Refil1.Value,
                                          Refil2 = ri.Refil2.Value,
                                          Refil3 = ri.Refil3.Value,
                                          Refil4 = ri.Refil4.Value,
                                          Refil5 = ri.Refil5.Value,
                                          Refil6 = ri.Refil6.Value,
                                          RefilExtra = ri.RefilExtra.Value,
     
                                          Modalidade = md.Descricao,
                                          TipoEntrega = te.Descricao,
                                          Autorizacao = pc.Autorizacao,
                                          // Incluindo as tabelas relacionadas
                                          ClasseTerapeutica = ct.Descricao,

                                          Fabricante = fa.Descricao,
                                          Substancia = sb.Descricao

                                      })
                                      .ToList();

            return medicamentos;
        }


        public void AdicionaRegitrosEmPedido(ReceitaItens entityUpdate)
        {
            string retorno = "";

            //if (UtilitariosBLL.limpaString2(entityUpdate.Refil1).IsNullOrEmpty())
            //{
            //    retorno += "Preencha o campo Id da Receita Itens\n";
            //}

            //if (UtilitariosBLL.limpaString2(txtNotaFiscal.Text).IsNullOrEmpty())
            //{
            //    retorno += "Preencha o campo Nota Fiscal\n";
            //}

            //if (!retorno.IsNullOrEmpty())
            //{
            //    MessageBox.Show(retorno, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            int receitaItensId = Convert.ToInt32(entityUpdate.Id);
            //string? Refil = "Refil1";
            DateTime? Refil1 = entityUpdate.Refil1;
            DateTime? Refil2 = entityUpdate.Refil2;
            DateTime? Refil3 = entityUpdate.Refil3;
            DateTime? Refil4 = entityUpdate.Refil4;
            DateTime? Refil5 = entityUpdate.Refil5;
            DateTime? Refil6 = entityUpdate.Refil6;
            DateTime? RefilExtra = null;
            if (entityUpdate.RefilExtra.HasValue)
            {
                RefilExtra = entityUpdate.RefilExtra;
            }





            //var receitaItensEntrega = _context.ReceitaItensEntrega.FirstOrDefault(b => b.ReceitaItensId == receitaItensId);
            //EPharmacyContext _contextx;
            //var optionsBuilderx = new DbContextOptionsBuilder<EPharmacyContext>();
            //optionsBuilderx.UseSqlServer(Program.StrConn());
            //_contextx = new EPharmacyContext(optionsBuilderx.Options);
            //_contextx.ReceitaItensEntrega.Remove(receitaItensEntrega);
            //_contextx.SaveChangesAsync();


            //var receitaItensEntrega = _context.ReceitaItensEntrega.FirstOrDefault(b => b.ReceitaItensId == receitaItensId);
            var entityNew = new ReceitaItensEntrega();
            entityNew.ReceitaItensId = receitaItensId;
            EPharmacyContext _contextx;
            var optionsBuilderx = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilderx.UseSqlServer(Program.StrConn());
            _contextx = new EPharmacyContext(optionsBuilderx.Options);
            var registrosParaRemover = _context.ReceitaItensEntrega.Where(r => r.ReceitaItensId == receitaItensId).ToList();
            _contextx.ReceitaItensEntrega.RemoveRange(registrosParaRemover);
            _contextx.SaveChanges();


            if (Refil1 != null)
            {
                entityNew = new ReceitaItensEntrega
                {
                    ReceitaItensId = receitaItensId,
                    DataRefil = Refil1,
                    RefilId = 1,
                    StatusEntregaId = 8,
                    DataCadastro = DateTime.Now,
                    Usuario = GlobalVariables.LoginId

                };
                _context.ReceitaItensEntrega.Add(entityNew);
                _context.SaveChanges();
            }


            if (Refil2 != null)
            {
                entityNew = new ReceitaItensEntrega
                {
                    ReceitaItensId = receitaItensId,
                    DataRefil = Refil2,
                    RefilId = 2,
                    StatusEntregaId = 8,
                    DataCadastro = DateTime.Now,
                    Usuario = GlobalVariables.LoginId

                };
                _context.ReceitaItensEntrega.Add(entityNew);
                _context.SaveChanges();
            }


            if (Refil3 != null)
            {
                entityNew = new ReceitaItensEntrega
                {
                    ReceitaItensId = receitaItensId,
                    DataRefil = Refil3,
                    RefilId = 3,
                    StatusEntregaId = 8,
                    DataCadastro = DateTime.Now,
                    Usuario = GlobalVariables.LoginId

                };
                _context.ReceitaItensEntrega.Add(entityNew);
                _context.SaveChanges();
            }


            if (Refil4 != null)
            {
                entityNew = new ReceitaItensEntrega
                {
                    ReceitaItensId = receitaItensId,
                    DataRefil = Refil4,
                    RefilId = 4,
                    StatusEntregaId = 8,
                    DataCadastro = DateTime.Now,
                    Usuario = GlobalVariables.LoginId

                };
                _context.ReceitaItensEntrega.Add(entityNew);
                _context.SaveChanges();
            }


            if (Refil5 != null)
            {
                entityNew = new ReceitaItensEntrega
                {
                    ReceitaItensId = receitaItensId,
                    DataRefil = Refil5,
                    RefilId = 5,
                    StatusEntregaId = 8,
                    DataCadastro = DateTime.Now,
                    Usuario = GlobalVariables.LoginId

                };
                _context.ReceitaItensEntrega.Add(entityNew);
                _context.SaveChanges();
            }


            if (Refil6 != null)
            {
                entityNew = new ReceitaItensEntrega
                {
                    ReceitaItensId = receitaItensId,
                    DataRefil = Refil6,
                    RefilId = 6,
                    StatusEntregaId = 8,
                    DataCadastro = DateTime.Now,
                    Usuario = GlobalVariables.LoginId

                };
                _context.ReceitaItensEntrega.Add(entityNew);
                _context.SaveChanges();
            }


            if (RefilExtra != null)
            {
                entityNew = new ReceitaItensEntrega
                {
                    ReceitaItensId = receitaItensId,
                    DataRefil = RefilExtra,
                    RefilId = 7,
                    StatusEntregaId = 8,
                    DataCadastro = DateTime.Now,
                    Usuario = GlobalVariables.LoginId

                };
                _context.ReceitaItensEntrega.Add(entityNew);
                _context.SaveChanges();
            }
        }


        // Não usado. Usa COM e acho q é antigo.
        public string ExportaXlsOld(DataGridView dgv)
        {
            string Data = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            string Tempo = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();

            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook pasta = app.Workbooks.Add();
                Excel.Worksheet plan;
                plan = pasta.Worksheets.Add();
                plan.Name = "BC" + DateTime.Now.ToString();

                plan.Range["A1"].Value = "Base Cadastral: " + DateTime.Now.ToString();

                plan.Range["A3"].Value = "Matricula";
                plan.Range["B3"].Value = "Convênio";
                plan.Range["C3"].Value = "CPF";
                plan.Range["D3"].Value = "Nome";
                plan.Range["E3"].Value = "Status";
                plan.Range["F3"].Value = "Inclusão Convênio";
                plan.Range["G3"].Value = "EAN";

                plan.Range["H3"].Value = "Produto";
                plan.Range["I3"].Value = "Qtdd";
                plan.Range["J3"].Value = "Preço Acordado";
                plan.Range["K3"].Value = "Total";

                plan.Range["L3"].Value = "Receita Anterior";
                plan.Range["M3"].Value = "Data Receita";
                plan.Range["N3"].Value = "Periocidade";
                plan.Range["O3"].Value = "Refil1";
                plan.Range["P3"].Value = "Refil2";
                plan.Range["Q3"].Value = "Refil3";
                plan.Range["R3"].Value = "Refil4";
                plan.Range["S3"].Value = "Refil5";
                plan.Range["T3"].Value = "Refil6";
                plan.Range["U3"].Value = "Refil Extra";
                plan.Range["V3"].Value = "Refil Extra";
                plan.Range["W3"].Value = "Refil Extra";
                plan.Range["X3"].Value = "Refil Extra";
                plan.Range["Y3"].Value = "Refil Extra";
                plan.Range["Z3"].Value = "Refil Extra";


                pasta.SaveAs(@"C:\Users\marcov\OneDrive\Documents\BC" + Data + "-" + Tempo);
                pasta.Close();
                app.Quit();

                return "Planilha gerada com sucesso.";
            }
            catch
            {
                return "Planilha não gerada";
            }
        }

    }

}
