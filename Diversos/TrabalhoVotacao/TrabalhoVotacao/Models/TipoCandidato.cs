using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TrabalhoVotacao.Models
{
  public class TipoCandidato
  {
    public List<TipoCandidato> listaTipoCandidatos;
    private int Id;
    private string Descricao;

    public int Id1
    {
      get
      {
        return Id;
      }
      set
      {
        Id = value;
      }
    }

    public string Descricao1
    {
      get
      {
        return Descricao;
      }
      set
      {
        Descricao = value;
      }
    }

    public TipoCandidato() { GetTipoCandidato(); }
    public TipoCandidato(int id, string descricao)
    {
      Id = id;
      Descricao = descricao;
    }

    public void GetTipoCandidato()
    {
      listaTipoCandidatos = new List<TipoCandidato>();
      listaTipoCandidatos.Add(new TipoCandidato(1, "Presidente"));
      listaTipoCandidatos.Add(new TipoCandidato(2, "Prefeito"));
      listaTipoCandidatos.Add(new TipoCandidato(3, "Vereador"));
    }
    public override string ToString()
    {
      return Descricao1;
    }
  }
}
