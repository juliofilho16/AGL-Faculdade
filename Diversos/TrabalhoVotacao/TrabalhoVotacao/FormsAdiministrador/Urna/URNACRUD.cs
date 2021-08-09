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

namespace TrabalhoVotacao.FormsAdiministrador.Urna
{
  public partial class URNACRUD : Form
  {
    private UrnaEletronica urnaEletronica;
    private UrnaEletronicaServices UrnaEletronicaServices;
    public URNACRUD()
    {
      InitializeComponent();
      urnaEletronica = new UrnaEletronica();
      UrnaEletronicaServices = new UrnaEletronicaServices();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        urnaEletronica.Secao = textBoxSecao.Text;
        urnaEletronica.Zona= textBoxZona.Text;
        UrnaEletronicaServices.Create(urnaEletronica);
        MessageBox.Show("UrnaEletronica criado com sucesso!");        this.Close();
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
