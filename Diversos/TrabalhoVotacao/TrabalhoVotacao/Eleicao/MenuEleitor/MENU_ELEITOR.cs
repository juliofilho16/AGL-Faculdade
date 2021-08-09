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
using TrabalhoVotacao.Services;
using static TrabalhoVotacao.Models.Enums;

namespace TrabalhoVotacao.Eleicao.MenuEleitor
{
  public partial class MENU_ELEITOR : Form
  {
    private Eleitor eleitor;
    private CandidatosServices CandidatosServices;
    private List<Candidato> listCandidatos;
    private LoginEleitorService LoginEleitorService;
    private EleitorServices EleitorServices;
    private TipoEleicaoEnum EnumTipoEleicao;
    public MENU_ELEITOR()
    {
      InitializeComponent();
    }

    public MENU_ELEITOR(Eleitor Eleitor, TipoEleicaoEnum TipoEleicao)
    {
      InitializeComponent();
      eleitor = Eleitor;
      EnumTipoEleicao = TipoEleicao;
      labelNome.Text = eleitor.Nome;
      labelSecao.Text = eleitor.Secao;
      labelZona.Text = eleitor.Zona;
      Init();
      CandidatosServices = new CandidatosServices();
      listCandidatos = CandidatosServices.GetListCandidatos();
      LoginEleitorService = new LoginEleitorService();
      EleitorServices = new EleitorServices();
    }

    private void btnPresidente_Click(object sender, EventArgs e)
    {
      if (eleitor.VotouPresidente)
        MessageBox.Show("Voto para presidente já foi realizado", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
      {
        List<Candidato> lista = listCandidatos.Where(a => a.TipoCandidato1.Id1 == (int)TipoCandidatosEnum.Presidente).ToList();
        if (lista.Count == 0)
          MessageBox.Show("Nenhum Prefeito foi cadastrado", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
          eleitor.VotouPresidente = true;
          EleitorServices.Edit(eleitor);
          AtualizaEleitor();
          Urna.Urna URNA = new Urna.Urna(lista, TipoCandidatosEnum.Presidente);
          URNA.ShowDialog();
        }
      }
    }

    private void btnPrefeito_Click(object sender, EventArgs e)
    {
      if (eleitor.VotouPrefeito)
        MessageBox.Show("Voto para prefeito já foi realizado", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
      {
        List<Candidato> lista = listCandidatos.Where(a => a.TipoCandidato1.Id1 == (int)TipoCandidatosEnum.Prefeito).ToList();
        if (lista.Count == 0)
          MessageBox.Show("Nenhum Prefeito foi cadastrado", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
          eleitor.VotouPrefeito = true;
          EleitorServices.Edit(eleitor);
          AtualizaEleitor();
          Urna.Urna URNA = new Urna.Urna(lista, TipoCandidatosEnum.Prefeito);
          URNA.ShowDialog();
        }

      }
    }

    private void btnVereador_Click(object sender, EventArgs e)
    {
      if (eleitor.VotouVereador)
        MessageBox.Show("Voto para vereador já foi realizado", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
      {
        List<Candidato> lista = listCandidatos.Where(a => a.TipoCandidato1.Id1 == (int)TipoCandidatosEnum.Vereador).ToList();
        if (lista.Count == 0)
          MessageBox.Show("Nenhum vereador foi cadastrado", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
          eleitor.VotouVereador = true;
          EleitorServices.Edit(eleitor);
          AtualizaEleitor();
          Urna.Urna URNA = new Urna.Urna(lista, TipoCandidatosEnum.Vereador);
          URNA.ShowDialog();
        }
      }
    }

    private void AtualizaEleitor()
    {
      eleitor = LoginEleitorService.Login(eleitor.TituloEleitor);
    }

    private void MENU_ELEITOR_Load(object sender, EventArgs e)
    {

    }

    private void btnFinaly_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Init()
    {
      switch (EnumTipoEleicao)
      {
        case TipoEleicaoEnum.Municipais:
          btnPresidente.Visible = false;
          btnPrefeito.Visible = true;
          btnVereador.Visible = true;
          break;
        case TipoEleicaoEnum.Federais:
          btnPresidente.Visible = true;
          btnPrefeito.Visible = false;
          btnVereador.Visible = false;
          break;
        default:
          break;
      }
    }
  }
}
