using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoVotacao.Eleicao.MenuEleitor;
using TrabalhoVotacao.Models;
using TrabalhoVotacao.Services;

namespace TrabalhoVotacao.Eleicao.LoginEleitor
{
  public partial class LOGIN_ELEITOR : Form
  {
    private LoginEleitorService LoginEleitorService;
    public LOGIN_ELEITOR()
    {
      InitializeComponent();
      LoginEleitorService = new LoginEleitorService();
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
      try
      {
        Eleitor EleitorObj =  LoginEleitorService.Login(textBoxTituloEleitoral.Text);

        if (EleitorObj == null)
          MessageBox.Show("Título de eleitor não cadastrado", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else {
          TIPO_ELEICAO TIPO_ELEICAO = new TIPO_ELEICAO(EleitorObj);
          TIPO_ELEICAO.ShowDialog();
        }

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

    private void btnVoltar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
