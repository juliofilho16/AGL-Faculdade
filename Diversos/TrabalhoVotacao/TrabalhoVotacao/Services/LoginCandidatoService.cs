using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TrabalhoVotacao.Arquivos;
using TrabalhoVotacao.Models;
using TrabalhoVotacao.Interfaces;
namespace TrabalhoVotacao.Services
{
  class LoginEleitorService : ILogin
  {
    public Eleitor Login(string titulo)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(PathsToSaveAndRead.GET_PATH_FILE_ELEITORES);

      XmlNode Eleitors = doc.DocumentElement;
      XmlNodeList listEleitors = Eleitors.ChildNodes;

      Eleitor EleitorObj = null;

      foreach (XmlNode eleitor in listEleitors)
      {
        XmlNode Attr = eleitor.Attributes.GetNamedItem("Id");

        if (Attr != null && Attr.Value.Equals(titulo))
        {
          EleitorObj = new Eleitor();
          XmlNodeList listPropriedades = eleitor.ChildNodes;
          XmlNode AttrVotPresidente = eleitor.Attributes.GetNamedItem("VotouPresidente");
          XmlNode AttrVotPrefeito = eleitor.Attributes.GetNamedItem("VotouPrefeito");
          XmlNode AttrVotVereador = eleitor.Attributes.GetNamedItem("VotouVereador");

          EleitorObj.VotouPresidente = bool.Parse(AttrVotPresidente.Value);
          EleitorObj.VotouPrefeito = bool.Parse(AttrVotPrefeito.Value);
          EleitorObj.VotouVereador= bool.Parse(AttrVotVereador.Value);

          foreach (XmlNode item in listPropriedades)
          {
            if (item.Name.Equals("Nome"))
              EleitorObj.Nome = item.InnerText;
            else if (item.Name.Equals("Secao"))
              EleitorObj.Secao = item.InnerText;
            else if (item.Name.Equals("Zona"))
              EleitorObj.Zona = item.InnerText;
            else
              EleitorObj.TituloEleitor = item.InnerText;
          }
        }
      }
      return EleitorObj;
    }
  }
}
