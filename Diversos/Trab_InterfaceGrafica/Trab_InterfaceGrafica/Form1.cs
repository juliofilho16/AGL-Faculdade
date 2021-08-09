using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trab_InterfaceGrafica.Objetos;
using Trab_InterfaceGrafica.Services;

namespace Trab_InterfaceGrafica
{
  public partial class Form1 : Form
  {

    private string strPathFile = @"C:\Users\Julio Cesar\Documents\Julio.C\arquivos\Facul\2 Periodo\POO Pratica\Projestos&Exercicios\Trab_InterfaceGrafica\ArquivoExemplo.xml";
    private Cliente Cliente;
    private ClienteDAO Cliente_Services;

    public Form1()
    {
      InitializeComponent();
      Cliente = new Cliente();
      Cliente_Services = new ClienteDAO();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      Cliente.Nome = textBoxNome.Text;
      Cliente.Email = textBoxEmail.Text;
      Cliente_Services.Criar(Cliente, strPathFile);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnExibir_Click(object sender, EventArgs e)
    {
      Cliente_Services.LerDadosCadastrados( strPathFile);
    }
  }
}
