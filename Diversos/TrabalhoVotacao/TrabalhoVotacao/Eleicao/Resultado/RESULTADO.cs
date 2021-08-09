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
using TrabalhoVotacao.Models.Candidatos;
using TrabalhoVotos.Services;

namespace TrabalhoVotacao.Eleicao.Resultado
{
  public partial class RESULTADO : Form
  {
    private Candidato GanhadorPresidente;
    private Candidato GanhadorPrefeito;
    private Candidato GanhadorVereador;
    private int QtdVotosNulosExecutivo;
    private int QtdVotosNulosLegislativo;
    private int QtdVotosBrancosExecutivo;
    private int QtdVotosBrancosLegislativo;
    private int VotosValidosExecutivo;
    private int VotosValidosLegislativo;

    private VotosServices votosServices;

    public RESULTADO()
    {
      InitializeComponent();
      votosServices = new VotosServices();
      QtdVotosNulosExecutivo = votosServices.VotosNulosExecutivo();
      QtdVotosNulosLegislativo = votosServices.VotosNulosLegislativo();
      QtdVotosBrancosExecutivo = votosServices.VotosBrancosExecutivo();
      QtdVotosBrancosLegislativo = votosServices.VotosBrancosLegislativo();
      VotosValidosExecutivo = votosServices.VotosValidosExecutivo();
      VotosValidosLegislativo = votosServices.VotosValidosLegislativo();
      GanhadorPresidente = votosServices.GetPresidenteVencedor();
      GanhadorPrefeito = votosServices.GetPrefeitoVencedor();
      GanhadorVereador = votosServices.GetVereadorVencedor();
      MostraVencedores();
    }

    private void MostraVencedores()
    {
      try
      {
        labelNulosExecutivo.Text = QtdVotosNulosExecutivo.ToString();
        labelNulosLegis.Text = QtdVotosNulosLegislativo.ToString();
        labelBrancosExec.Text = QtdVotosBrancosExecutivo.ToString();
        labelBrancosLegis.Text = QtdVotosBrancosLegislativo.ToString();
        if (GanhadorPresidente == null)
          LabelPresidente.Text = "Não houve resultado para presidente";
        else
          LabelPresidente.Text = string.Format("{0} -- {1}", GanhadorPresidente.Nome1, GanhadorPresidente.Partido1.Nome1);

        if (GanhadorPrefeito == null)
          LabelPrefeito.Text = "Não houve resultado para prefeito";
        else
          LabelPrefeito.Text = string.Format("{0} -- {1}", GanhadorPrefeito.Nome1, GanhadorPrefeito.Partido1.Nome1);

        if (GanhadorVereador == null)
          LabelVereador.Text = "Não houve resultado para vereadores";
        else
          LabelVereador.Text = string.Format("{0} -- {1}", GanhadorVereador.Nome1, GanhadorVereador.Partido1.Nome1);

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
