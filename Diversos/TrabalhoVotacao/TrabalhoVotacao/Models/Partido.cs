using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TrabalhoVotacao.Arquivos;

namespace TrabalhoVotacao.Models
{
 public class Partido
  {
    
    private string Nome;
    private int NumLegenda;
    private string Sigla;

    public Partido() {  }
    public Partido(string nome, int numLegenda, string sigla)
    {
      Nome1 = nome;
      NumLegenda1 = numLegenda;
      Sigla1 = sigla;
    }

    public string Nome1
    {
      get
      {
        return Nome;
      }

      set
      {
        Nome = value;
      }
    }

    public int NumLegenda1
    {
      get
      {
        return NumLegenda;
      }

      set
      {
        NumLegenda = value;
      }
    }

    public string Sigla1
    {
      get
      {
        return Sigla;
      }
      set
      {
        Sigla = value;
      }
    }

    public List<Partido> GetPartidos()
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(PathsToSaveAndRead.GET_PATH_FILE_PARTIDOS);

      XmlNode Partidos = doc.DocumentElement;
      XmlNodeList listPartidos = Partidos.ChildNodes;
      List<Partido> ListaPartidos = new List<Partido>();
      foreach (XmlNode partido in listPartidos)
      {
        Partido P = new Partido();
        XmlNodeList listPropriedades = partido.ChildNodes;

        foreach (XmlNode item in listPropriedades)
          if (item.Name.Equals("Nome"))
            P.Nome = item.InnerText;
          else if (item.Name.Equals("Sigla"))
            P.Sigla = item.InnerText;
          else
            P.NumLegenda = int.Parse(item.InnerText);

        ListaPartidos.Add(P);
      }
      return ListaPartidos;
    }

    public override string ToString()
    {
      return Nome + " - " +Sigla;
    }
  }
}
