using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TrabalhoVotacao.Arquivos;

namespace TrabalhoVotacao.Models
{
  class UrnaEletronica
  {
    private string zona;
    private string secao;

    public string Zona
    {
      get
      {
        return zona;
      }

      set
      {
        zona = value;
      }
    }

    public string Secao
    {
      get
      {
        return secao;
      }

      set
      {
        secao = value;
      }
    }

    public UrnaEletronica() { }
    public UrnaEletronica(string zona, string secao)
    {
      this.Zona = zona;
      this.Secao = secao;
    }

    public List<UrnaEletronica> GetUrnaEletronica()
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(PathsToSaveAndRead.GETPATH_FILE_URNAS);

      XmlNode UrnaEletronica = doc.DocumentElement;
      XmlNodeList listUrnaEletronica = UrnaEletronica.ChildNodes;
      List<UrnaEletronica> ListaUrnaEletronica = new List<UrnaEletronica>();
      foreach (XmlNode urna in listUrnaEletronica)
      {
        UrnaEletronica U = new UrnaEletronica();
        XmlNodeList listPropriedades = urna.ChildNodes;

        foreach (XmlNode item in listPropriedades)
          if (item.Name.Equals("Zona"))
            U.Zona = item.InnerText;
          else 
            U.Secao = item.InnerText;

        ListaUrnaEletronica.Add(U);
      }
      return ListaUrnaEletronica;
    }
  }
}
