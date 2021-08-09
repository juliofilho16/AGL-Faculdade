using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TrabalhoVotacao.Arquivos;
using TrabalhoVotacao.Interfaces;
using TrabalhoVotacao.Models;
namespace TrabalhoVotacao.Services
{
  class PartidoServices : ICadastro
  {
    private Partido Partido;
    public Partido SetPartido
    {
      set
      {
        Partido = value;
      }
    }

    public void Create()
    {
      ValidaPartido(Partido);
      AddInXML(Partido, PathsToSaveAndRead.GET_PATH_FILE_PARTIDOS);
    }

    private void ValidaPartido(Partido Partido)
    {
      if (Partido.Nome1.Trim().Length < 1)
        throw new ArgumentException("Favor Inserir o Nome do Partido.");

      if (Partido.Sigla1.Trim().Length < 1)
        throw new ArgumentException("Favor Inserir a sigla do Partido.");

      if (Partido.NumLegenda1 == 0 || Partido.NumLegenda1 == null)
        throw new ArgumentException("Favor inserir um número válido para o Partido.");

    }

    private void AddInXML(Partido Partido, string strPathFile)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(strPathFile);

      XmlNode Partidos = doc.DocumentElement;
      XmlElement novoPartido = doc.CreateElement("Partido");

      XmlElement Nome = doc.CreateElement("Nome");
      Nome.InnerText = Partido.Nome1;

      XmlElement NumLegenda = doc.CreateElement("NumLegenda");
      NumLegenda.InnerText = Partido.NumLegenda1.ToString();

      XmlElement Sigla = doc.CreateElement("Sigla");
      Sigla.InnerText = Partido.Sigla1;

      XmlAttribute attr = doc.CreateAttribute("Id");
      attr.InnerText = Partido.NumLegenda1.ToString();

      novoPartido.AppendChild(Nome);
      novoPartido.AppendChild(NumLegenda);
      novoPartido.AppendChild(Sigla);
      novoPartido.Attributes.Append(attr);

      Partidos.AppendChild(novoPartido);
      doc.Save(strPathFile);
    }

  }
}
