﻿using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void GetDataNovo()
        {

            using (var context = new DbContext())
            {
                var sixMonthsAgo = DateTime.Now.AddMonths(-6);

                var result = context.Ccc
                    .Where(c => c.Data >= sixMonthsAgo)
                    .Join(context.Aaa, c => c.AaaId, a => a.Id, (c, a) => new { c, a })
                    .Join(context.Bbb, ca => ca.c.BbbId, b => b.Id, (ca, b) => new
                    {
                        CccId = ca.c.Id,
                        CccDescricao = ca.c.Descricao,
                        CccData = ca.c.Data,
                        AaaDescricao = ca.a.Descricao,
                        BbbDescricao = b.Descricao,
                        BbbValor = b.Valor
                    })
                    .ToList();

                foreach (var item in result)
                {
                    Console.WriteLine($"CccId: {item.CccId}, CccDescricao: {item.CccDescricao}, CccData: {item.CccData}, " +
                                      $"AaaDescricao: {item.AaaDescricao}, BbbDescricao: {item.BbbDescricao}, BbbValor: {item.BbbValor}");
                }
            }
        }
        */


        /*
        public void GetData()
        {

                var sixMonthsAgo = DateTime.Now.AddMonths(-6);

                var result = _context.Receita
                    .Where(c => c.DataReceita >= sixMonthsAgo)
                    .Join(_context.Medicamento, c => c.Id, a => a.Id, (c, a) => new { c, a })
                    .Join(_context.Paciente, ca => ca.c.Id, b => b.Id, (ca, b) => new
                    {
                        CccId = ca.c.Id,
                        CccDescricao = ca.c.Descricao,
                        CccData = ca.c.Data,
                        AaaDescricao = ca.a.Descricao,
                        BbbDescricao = b.Descricao,
                        BbbValor = b.Valor
                    })
                    .ToList();

                foreach (var item in result)
                {
                    Console.WriteLine($"CccId: {item.CccId}, CccDescricao: {item.CccDescricao}, CccData: {item.CccData}, " +
                                      $"AaaDescricao: {item.AaaDescricao}, BbbDescricao: {item.BbbDescricao}, BbbValor: {item.BbbValor}");
                }
        }
        */


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


        public  IList<MedicamentoPrecoViewModel> GetMedicamentosParaProximos6Meses()
        {
            var dataLimite = DateTime.Now.AddMonths(-6);  // Calculando a data para 6 meses a partir de hoje

            // Query para pegar os medicamentos e seus preços, incluindo as tabelas relacionadas
            IList<MedicamentoPrecoViewModel> medicamentos =  (
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
                                      join te in  _context.TipoEntrega on pc.TipoEntregaId equals te.Id
                                      join md in _context.Modalidade on pc.ModalidadeEntregaId equals md.Id

                                      where re.DataReceita >= dataLimite
                                      orderby re.Id, pc.Id
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
                                          TipoReceitaId = m.TipoReceitaId,
                                          FabricanteId = m.FabricanteId,
                                          SubstanciaId = m.SubstanciaId,
                                          MedicamentoPrecoId = mp.Id,*/
                                          PrecoAcordado = mp.PrecoAcordado,
                                          //Total = ri.Qtdd.Value* mp.PrecoAcordado,
                                          //Total = Math.Round(ri.Qtdd.Value * mp.PrecoAcordado, 2),
                                          Total = $"{ri.Qtdd.Value * mp.PrecoAcordado:F2}"   ,
                                          /*ReceitaId = re.Id,
                                          ReceitaDescricao = re.Descricao,*/
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




    }

}
