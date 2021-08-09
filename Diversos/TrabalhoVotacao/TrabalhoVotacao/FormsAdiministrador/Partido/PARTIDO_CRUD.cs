using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoVotacao.Services;

namespace TrabalhoVotacao.FormsAdiministrador.Partido
{
  public partial class PARTIDO_CRUD : Form
  {
    private TrabalhoVotacao.Models.Partido partido;
    private PartidoServices PartidoServices;
    public PARTIDO_CRUD()
    {
      InitializeComponent();
      partido = new TrabalhoVotacao.Models.Partido();
      PartidoServices = new PartidoServices();
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void SavePartido_Click(object sender, EventArgs e)
    {
      try
      {
        partido.Nome1 = textBoxNome.Text;
        partido.NumLegenda1 = int.Parse(textBoxNumero.Text);
        partido.Sigla1 = textBoxSigla.Text;
        PartidoServices.SetPartido = partido;
        PartidoServices.Create();

        MessageBox.Show("Partido criado com sucesso!");        this.Close();
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

    private void CancelarPartido_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
