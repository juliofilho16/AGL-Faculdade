using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoVotacao.Candidatos.Executivo;
using TrabalhoVotacao.Models;
using TrabalhoVotacao.Models.Candidatos;
using TrabalhoVotacao.Services;
using TrabalhoVotacao.Candidatos.Legislativo;
using static TrabalhoVotacao.Models.Enums;

namespace TrabalhoVotacao.FormsAdiministrador.Candidatos
{

  public partial class CANDIDATO_CRUD : Form
  {
    private TipoCandidato TipoCandidato;
    private TrabalhoVotacao.Models.Partido partidoSelected;
    private Candidato Candidato;
    private CandidatosServices CandidatosServices;

    public CANDIDATO_CRUD()
    {
      InitializeComponent();

      Candidato = new Candidato();
      CandidatosServices = new CandidatosServices();

      comboBoxPartidos.Items.Clear();
      comboBoxPartidos.Items.AddRange(new TrabalhoVotacao.Models.Partido().GetPartidos().ToArray());

      comboBoxTipoCandidato.Items.Clear();
      comboBoxTipoCandidato.Items.AddRange(new TrabalhoVotacao.Models.TipoCandidato().listaTipoCandidatos.ToArray());

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        TipoCandidato = (TipoCandidato)comboBoxTipoCandidato.SelectedItem;
        partidoSelected = (TrabalhoVotacao.Models.Partido)comboBoxPartidos.SelectedItem;

        int numLegenda = partidoSelected.NumLegenda1;

        if (TipoCandidato.Id1 == (int)TipoCandidatosEnum.Presidente)
          CandidatosServices.SetCandidato = new Presidente(textBoxNome.Text, textBoxCPF.Text, numLegenda, partidoSelected, TipoCandidato);
        else if (TipoCandidato.Id1 == (int)TipoCandidatosEnum.Prefeito)
          CandidatosServices.SetCandidato = new Prefeito(textBoxNome.Text, textBoxCPF.Text, numLegenda, partidoSelected, TipoCandidato);
        else if (TipoCandidato.Id1 == (int)TipoCandidatosEnum.Vereador)
          CandidatosServices.SetCandidato = new Vereador(textBoxNome.Text, textBoxCPF.Text, numLegenda, partidoSelected, TipoCandidato);

        CandidatosServices.Create();
        MessageBox.Show("Candidato cadastrado com sucesso!");        this.Close();
      }
      catch (ArgumentException ex)
      {
        MessageBox.Show(ex.Message);
      }
      catch (NullReferenceException ex)
      {
        MessageBox.Show(ex.Message);
      }
      catch (FormatException ex)
      {
        MessageBox.Show("O valor informado não é um número, favor tentar novamente.");
      }
      catch (Exception erro)
      {
        MessageBox.Show(
                        erro.GetType().ToString() + "\r\n" +
                        erro.GetType().BaseType.ToString() + "\r\n" +
                        erro.GetType().BaseType.BaseType.ToString() + "\r\n" +
                        erro.GetType().BaseType.BaseType.BaseType.ToString() + "\r\n" +
                        erro.GetType().BaseType.BaseType.BaseType.BaseType.ToString()
                        );
      }
    }

    private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
