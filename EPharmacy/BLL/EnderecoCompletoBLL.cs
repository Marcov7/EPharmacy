using EPharmacy;
using EPharmacy.Models;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EPharmacy.Data;


namespace BLL
{
    public class ViaCepService
    {
        private readonly EPharmacyContext _context;
       
        public ViaCepService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
        }

        public async Task<Endereco> BuscarEnderecoPorCepAsync(string cep)
        {
            // Criação do HttpClient para fazer a requisição HTTP
            using (HttpClient client = new HttpClient())
            {
                Endereco endereco = new Endereco();

                try
                {
                    // URL da API com o CEP passado como parâmetro
                    // string url = $"https://viacep.com.br/ws/{cep}/json/";

                    string url = Program.StrLinkEndereco(cep);

                    // Fazendo a requisição GET
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Verificando se a requisição foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Lendo o conteúdo da resposta como string
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // Deserializando o JSON para um objeto Endereco
                        endereco = JsonSerializer.Deserialize<Endereco>(jsonResponse);

                        endereco.retorno = "Sucesso";

                    }
                    else
                    {
                        endereco.retorno = "Não foi possível buscar o endereço. Verifique o CEP.";
                    }

                }
                catch (Exception ex)
                {
                    endereco.retorno = $"Erro: {ex.Message}";
                }

                return endereco;
            }
        }


        private readonly HttpClient client = new HttpClient();

        // Método para buscar o endereço pelo CEP
        public async Task<Endereco> BuscarEnderecoAsync(string cep)
        {
            Endereco endereco = new Endereco();
            try
            {
                // URL da API do ViaCEP
                string url = $"https://viacep.com.br/ws/{cep}/json/";

                // Fazendo a requisição GET para a API
                HttpResponseMessage response = await client.GetAsync(url);

                // Verificando se a requisição foi bem-sucedida
                if (response.IsSuccessStatusCode)
                {
                    // Lendo o conteúdo da resposta como string
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Deserializando o JSON para um objeto Endereco
                    // Endereco endereco = JsonSerializer.Deserialize<Endereco>(jsonResponse);
                    endereco = JsonSerializer.Deserialize<Endereco>(jsonResponse);

                    string zona = BuscaZona(endereco.bairro, endereco.localidade);
                    endereco.zona = zona;
                    endereco.retorno = "Sucesso";
                    return endereco;
                }
                else
                {
                    // Caso a requisição falhe, retornamos null
                    endereco.retorno = "Caso a requisição falhe, retornamos null";
                    return endereco;
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, podemos retornar null e exibir a mensagem de erro
                endereco.retorno = "Erro ao consumir a API ViaCEP";
                //throw new Exception("Erro ao consumir a API ViaCEP", ex);
            }
                      
            return endereco;
        }

        private string BuscaZona(string bairro, string localidade)
        {
            string zona = "";

            string bairro_ = bairro;
            string localidade_ = localidade;

            var entidade = _context.BairroZona.AsQueryable();

            if (localidade_ == "Rio de Janeiro" && !string.IsNullOrEmpty(bairro_))
            {
                entidade = entidade.Where(p => p.Bairro.Contains(bairro_));
            }
            else
            {
                if (!string.IsNullOrEmpty(localidade_))
                    entidade = entidade.Where(p => p.Municipio.Contains(localidade_));
                
                //return "";
            }


            var entidadex = entidade.ToList();

            if (entidadex != null)
            {
                zona = entidadex[0].Zona;
            }
            return zona;
        }
    }

}

