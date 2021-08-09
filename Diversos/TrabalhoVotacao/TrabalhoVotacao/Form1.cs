using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoVotacao.Eleicao.LoginEleitor;
using TrabalhoVotacao.Eleicao.Resultado;

namespace TrabalhoVotacao
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btn1_Click(object sender, EventArgs e)
    {

    }

    private void Cadastros_Click(object sender, EventArgs e)
    {
      TrabalhoVotacao.FormsAdiministrador.Menu.Menu menu = new TrabalhoVotacao.FormsAdiministrador.Menu.Menu();
      menu.ShowDialog();
    }

    private void eleicao_Click(object sender, EventArgs e)
    {
      LOGIN_ELEITOR LOGIN_ELEITOR = new LOGIN_ELEITOR();
      LOGIN_ELEITOR.ShowDialog();
    }

    private void btnResult_Click(object sender, EventArgs e)
    {
      RESULTADO RESULTADO = new RESULTADO();
      RESULTADO.ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
