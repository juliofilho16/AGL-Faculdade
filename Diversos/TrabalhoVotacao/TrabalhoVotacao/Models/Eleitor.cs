using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoVotacao.Models
{
  public class Eleitor
  {
    private bool votouPresidente = false;
    private bool votouVereador = false;
    private bool votouPrefeito = false;
    private string nome;
    private string tituloEleitor;
    private string zona;
    private string secao;

    public bool VotouPresidente
    {
      get
      {
        return votouPresidente;
      }

      set
      {
        votouPresidente = value;
      }
    }

    public string Nome
    {
      get
      {
        return nome;
      }

      set
      {
        nome = value;
      }
    }

    public string TituloEleitor
    {
      get
      {
        return tituloEleitor;
      }

      set
      {
        tituloEleitor = value;
      }
    }

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

    public bool VotouVereador
    {
      get
      {
        return votouVereador;
      }

      set
      {
        votouVereador = value;
      }
    }

    public bool VotouPrefeito
    {
      get
      {
        return votouPrefeito;
      }

      set
      {
        votouPrefeito = value;
      }
    }

    public Eleitor() { }
    public Eleitor(bool votou, string nome, string tituloEleitor, string zona, string secao)
    {
      this.VotouPrefeito = votou;
      this.Nome = nome;
      this.TituloEleitor = tituloEleitor;
      this.Zona = zona;
      this.Secao = secao;
    }
  }
}
