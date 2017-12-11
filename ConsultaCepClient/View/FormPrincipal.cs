using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using ConsultaCepClient.Controller;
using ConsultaCepClient.Model;
using System.Text.RegularExpressions;

namespace ConsultaCepClient
{
    public partial class FromPrincipal : Form
    {
        public FromPrincipal()
        {
            InitializeComponent();
        }
        ResultadoCepController consultaCepController = new ResultadoCepController();
        
        //BOTÃO CONSULTAR CEP
        private void button1_Click(object sender, EventArgs e)
        {
            if (!maskCep.MaskCompleted)//Se a máscara não for completada
            {
                MessageBox.Show("Cep inválido !");
            }
            else
            {
                try
                {
                    var resultadoCep = new ResultadoCep();
                    resultadoCep = consultaCepController.ConsultaCep(maskCep.Text);

                    if (resultadoCep.Cep != null)
                    {
                        MessageBox.Show("Resultado:\n" + resultadoCep);
                    }
                    else
                    {
                        MessageBox.Show("Cep não encontrado !");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message);

                }
            }
        }
    }
}
