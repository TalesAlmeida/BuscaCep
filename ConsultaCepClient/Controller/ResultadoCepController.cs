using ConsultaCepClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsultaCepClient.Controller
{
    public class ResultadoCepController
    {
        HttpClient client = null;
        ResultadoCep resultadoCep = null;
        string viaCep = "https://viacep.com.br/ws/";//Api Via Cep


        //METODO CONSULTA CEP
        public ResultadoCep ConsultaCep(string cep)
        {
            try
            {
                using (client = new HttpClient())
                {
                    HttpResponseMessage resposta = client.GetAsync(viaCep+cep+"/json/").Result;

                    if (resposta.IsSuccessStatusCode)
                    {
                        resultadoCep = new ResultadoCep();
                        resultadoCep =  resposta.Content.ReadAsAsync<ResultadoCep>().Result;
                    }
                    else
                    {
                        resultadoCep = null;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return resultadoCep;
        }

    }
}
