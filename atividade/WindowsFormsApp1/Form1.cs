using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

// Evento disparado com o click do botão calcular
    private void BtnCalcular_Click(object sender, EventArgs e) {
            // Cria um novo objeto da classe cl_Calculo
            cl_Calculo Calculo = new cl_Calculo(); 
            
            // Pega o valor digitado pelo usuario na TextBox e converte para double
            double preco_inicial = double.Parse(txtValorInicial.Text); 
            
            // Variavel para armazenarar o tipo de produto selecionado
            int tipo_Produto = 0; 
            
            // Verifica qual RadioButton foi selecionado e define o tipo do produto
            if (radioButton1.Checked) 
                tipo_Produto = 1; 

            else if (radioButton2.Checked) 
                tipo_Produto = 2; 

            else if (radioButton3.Checked) 
                tipo_Produto = 3; 

            else if (radioButton4.Checked) 
                tipo_Produto = 4; 

            else if (radioButton5.Checked) 
                tipo_Produto = 5; 
            
            // Chama o metodo da classe cl_Calculo e passa valor inicial e o tipo de produto
            double resultado = Calculo.CalculaPrecoFinal(preco_inicial, tipo_Produto); 

            // Exibe o resultado do calculo para o usuario
            lblResultado.Text = resultado.ToString(); 
        } 
    } 
}