using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoVotacao.Candidatos.Executivo;
using TrabalhoVotacao.Candidatos.Legislativo;
using TrabalhoVotacao.Models;
using TrabalhoVotacao.Models.Candidatos;
using TrabalhoVotos.Services;
using static TrabalhoVotacao.Models.Enums;

namespace TrabalhoVotacao.Urna
{
  public partial class Urna : Form
  {
    private TipoCandidatosEnum TipoVotacao;
    private List<Candidato> listaCandidatos;
    private VotosServices VotosServices;

    public Urna()
    {
      InitializeComponent();
    }

    public Urna(List<Candidato> candidatos, TipoCandidatosEnum TipoCandidatosEnum)
    {
      InitializeComponent();
      TipoVotacao = TipoCandidatosEnum;
      listaCandidatos = candidatos;
      textBox1.Enabled = false;
      boxListCandidatos.Enabled = false;

      foreach (var item in candidatos)
        boxListCandidatos.Items.Add(item);

      VotosServices = new VotosServices();
    }

    private void Urna_Load(object sender, EventArgs e)
    {

    }

    private void Confirmar_Click(object sender, EventArgs e)
    {
      try
      {
        if (listaCandidatos.Count() == 0)
          throw new IndexOutOfRangeException("Nenhum candidato cadastrado");

        Candidato candidato = listaCandidatos.Where(a => a.NumLegenda1.Equals(int.Parse(textBox1.Text))).FirstOrDefault();

        if (candidato == null)
          VotosServices.AddVotoNull(TipoVotacao);
        else
          VotosServices.ControladorVotos(candidato);

        MessageBox.Show("Voto realizado com sucesso!", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
      }
      catch (ArgumentException ex)
      {
        MessageBox.Show(ex.Message, "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (IndexOutOfRangeException ex)
      {
        MessageBox.Show(ex.Message, "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (Exception ex)
      {

      }
    }

    private void btn1_Click(object sender, EventArgs e)
    {
      SetValue("1");
    }

    private void btn2_Click(object sender, EventArgs e)
    {
      SetValue("2");
    }

    private void btn3_Click(object sender, EventArgs e)
    {
      SetValue("3");
    }

    private void btn4_Click(object sender, EventArgs e)
    {
      SetValue("4");
    }

    private void btn5_Click(object sender, EventArgs e)
    {
      SetValue("5");
    }

    private void btn6_Click(object sender, EventArgs e)
    {
      SetValue("6");
    }

    private void btn7_Click(object sender, EventArgs e)
    {
      SetValue("7");
    }

    private void btn8_Click(object sender, EventArgs e)
    {
      SetValue("8");
    }

    private void btn9_Click(object sender, EventArgs e)
    {
      SetValue("9");
    }

    private void btn0_Click(object sender, EventArgs e)
    {
      SetValue("0");
    }

    private void SetValue(string value)
    {
      if (textBox1.Text.Length == 0)
        textBox1.Text = value;
      else
        textBox1.Text += value;
    }

    private void Limpar_Click(object sender, EventArgs e)
    {
      if (textBox1.Text.Length == 1)
        textBox1.Text = textBox1.Text.Remove(0);
      else if (textBox1.Text.Length > 1)
        textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);

    }

    private void btnBranco_Click(object sender, EventArgs e)
    {
      VotosServices.AddVotoBranco(TipoVotacao);
      MessageBox.Show("Voto realizado com sucesso!", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Information);
      this.Close();
    }
  }
}
