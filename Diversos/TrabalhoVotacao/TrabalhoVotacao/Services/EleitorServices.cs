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
  class EleitorServices : ICadastro
  {

    private Eleitor Eleitor;
    public Eleitor SetEleitor
    {
      set
      {
        Eleitor = value;
      }
    }

    public void Create()
    {
      ValidaEleitor(Eleitor);
      AddInXML(Eleitor, PathsToSaveAndRead.GET_PATH_FILE_ELEITORES);
    }

    private void ValidaEleitor(Eleitor Eleitor)
    {
      if (Eleitor.Nome.Trim().Length < 1)
        throw new ArgumentException("Favor Inserir o Nome do Eleitor.");

      if (Eleitor.TituloEleitor.Trim().Length < 1)
        throw new ArgumentException("Favor Inserir o título eleitoral do Eleitor.");

      if (Eleitor.Secao.Trim().Length < 1)
        throw new ArgumentException("Favor Inserir o título eleitoral do Eleitor.");

      if (Eleitor.Zona.Trim().Length < 1)
        throw new ArgumentException("Favor Inserir o título eleitoral do Eleitor.");

    }

    private void AddInXML(Eleitor Eleitor, string strPathFile)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(strPathFile);

      XmlNode Eleitors = doc.DocumentElement;
      XmlElement novoEleitor = doc.CreateElement("Eleitor");

      XmlElement Nome = doc.CreateElement("Nome");
      Nome.InnerText = Eleitor.Nome;

      XmlElement TituloEleitor = doc.CreateElement("TituloEleitor");
      TituloEleitor.InnerText = Eleitor.TituloEleitor;

      XmlElement Zona = doc.CreateElement("Zona");
      Zona.InnerText = Eleitor.Zona;

      XmlElement Secao = doc.CreateElement("Secao");
      Secao.InnerText = Eleitor.Secao;

      XmlAttribute attrId = doc.CreateAttribute("Id");
      attrId.InnerText = Eleitor.TituloEleitor;

      XmlAttribute attrVotouPresidente = doc.CreateAttribute("VotouPresidente");
      attrVotouPresidente.InnerText = Eleitor.VotouPresidente.ToString();

      XmlAttribute attrVotouPrefeito = doc.CreateAttribute("VotouPrefeito");
      attrVotouPrefeito.InnerText = Eleitor.VotouPrefeito.ToString();

      XmlAttribute attrVotouVereador = doc.CreateAttribute("VotouVereador");
      attrVotouVereador.InnerText = Eleitor.VotouVereador.ToString();

      novoEleitor.AppendChild(Nome);
      novoEleitor.AppendChild(TituloEleitor);
      novoEleitor.AppendChild(Zona);
      novoEleitor.AppendChild(Secao);
      novoEleitor.Attributes.Append(attrId);
      novoEleitor.Attributes.Append(attrVotouPresidente);
      novoEleitor.Attributes.Append(attrVotouPrefeito);
      novoEleitor.Attributes.Append(attrVotouVereador);

      Eleitors.AppendChild(novoEleitor);
      doc.Save(strPathFile);
    }

    public void Edit(Eleitor EleitorObj)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(PathsToSaveAndRead.GET_PATH_FILE_ELEITORES);

      XmlNode Eleitors = doc.DocumentElement;
      XmlNodeList listEleitors = Eleitors.ChildNodes;

      foreach (XmlNode eleitor in listEleitors)
      {
        XmlNode Attr = eleitor.Attributes.GetNamedItem("Id");

        if (Attr != null && Attr.Value.Equals(EleitorObj.TituloEleitor))
        {
          XmlNodeList listPropriedades = eleitor.ChildNodes;
          eleitor.Attributes.GetNamedItem("VotouPresidente").Value = EleitorObj.VotouPresidente.ToString();
          eleitor.Attributes.GetNamedItem("VotouPrefeito").Value = EleitorObj.VotouPrefeito.ToString();
          eleitor.Attributes.GetNamedItem("VotouVereador").Value = EleitorObj.VotouVereador.ToString();
        }
      }
      doc.Save(PathsToSaveAndRead.GET_PATH_FILE_ELEITORES);

    }
  }
}
