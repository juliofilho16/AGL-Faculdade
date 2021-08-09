using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoVotacao.Models;
using TrabalhoVotacao.Services;

namespace TrabalhoVotacao.FormsAdiministrador.Eleitor
{
  public partial class ELEITORCRUD : Form
  {
    private TrabalhoVotacao.Models.Eleitor eleitor;
    private EleitorServices EleitorServices;

    public ELEITORCRUD()
    {
      InitializeComponent();

      EleitorServices = new EleitorServices();
      eleitor = new TrabalhoVotacao.Models.Eleitor();

      comboBoxSecao.Items.Clear();
      comboBoxSecao.Items.AddRange(new UrnaEletronica().GetUrnaEletronica().Select(a => a.Secao).ToArray());

      comboBoxZona.Items.Clear();
      comboBoxZona.Items.AddRange(new UrnaEletronica().GetUrnaEletronica().Select(a => a.Zona).ToArray());
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        eleitor.Nome = textBoxNome.Text;
        eleitor.Secao = comboBoxSecao.Text;
        eleitor.Zona = comboBoxZona.Text;
        eleitor.TituloEleitor = textBoxTituloEleitor.Text;
        EleitorServices.SetEleitor = eleitor;
        EleitorServices.Create();

        MessageBox.Show("Eleitor cadastrado com sucesso!");        this.Close();
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

  }
}
