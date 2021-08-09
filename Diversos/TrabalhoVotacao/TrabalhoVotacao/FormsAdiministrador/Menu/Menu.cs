using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoVotacao.FormsAdiministrador.Candidatos;
using TrabalhoVotacao.FormsAdiministrador.Eleitor;
using TrabalhoVotacao.FormsAdiministrador.Partido;
using TrabalhoVotacao.FormsAdiministrador.Urna;

namespace TrabalhoVotacao.FormsAdiministrador.Menu
{
  public partial class Menu : Form
  {
    public Menu()
    {
      InitializeComponent();
    }

    private void CadastrarPartidos_Click(object sender, EventArgs e)
    {
      PARTIDO_CRUD PARTIDO_CRUD = new PARTIDO_CRUD();
      PARTIDO_CRUD.ShowDialog();
    }

    private void CadastrarCandidatos_Click(object sender, EventArgs e)
    {
      CANDIDATO_CRUD CANDIDATO_CRUD = new CANDIDATO_CRUD();
      CANDIDATO_CRUD.ShowDialog();
    }

    private void Menu_Load(object sender, EventArgs e)
    {

    }

    private void CadastrarUrna_Click(object sender, EventArgs e)
    {
      URNACRUD URNACRUD = new URNACRUD();
      URNACRUD.ShowDialog();
    }

    private void CadastrarEleitor_Click(object sender, EventArgs e)
    {
      ELEITORCRUD ELEITORCRUD = new ELEITORCRUD();
      ELEITORCRUD.ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
