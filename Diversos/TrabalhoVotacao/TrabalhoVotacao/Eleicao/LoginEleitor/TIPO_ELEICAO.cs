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
using TrabalhoVotacao.Eleicao.MenuEleitor;
using static TrabalhoVotacao.Models.Enums;

namespace TrabalhoVotacao.Eleicao.LoginEleitor
{
  public partial class TIPO_ELEICAO : Form
  {
    private Eleitor EleitorObj;
    public TIPO_ELEICAO()
    {
      InitializeComponent();
    }
    public TIPO_ELEICAO(Eleitor Eleitor)
    {
      InitializeComponent();
      this.EleitorObj = Eleitor;
    }

    private void btnMunicipais_Click(object sender, EventArgs e)
    {
      MENU_ELEITOR MENU_ELEITOR = new MENU_ELEITOR(EleitorObj, TipoEleicaoEnum.Municipais);
      MENU_ELEITOR.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      MENU_ELEITOR MENU_ELEITOR = new MENU_ELEITOR(EleitorObj, TipoEleicaoEnum.Federais);
      MENU_ELEITOR.ShowDialog();
    }
  }
}
