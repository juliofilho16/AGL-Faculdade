using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrabalhoVotacao.Models.Candidatos
{
  public class Candidato
  {
    private string Nome;
    private string CPF;
    private int NumLegenda;
    private TipoCandidato TipoCandidato;
    private Partido Partido;

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

    public string CPF1
    {
      get
      {
        return CPF;
      }

      set
      {
        CPF = value;
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

    internal Partido Partido1
    {
      get
      {
        return this.Partido;
      }

      set
      {
        this.Partido = value;
      }
    }

    internal TipoCandidato TipoCandidato1
    {
      get
      {
        return this.TipoCandidato;
      }
      set
      {
        this.TipoCandidato = value;
      }
    }

    public Candidato() { }

    public Candidato(string nome, string cPF, int numLegenda, Partido partido, TipoCandidato tipoCandidato)
    {
      this.Nome = nome;
      this.CPF = cPF;
      this.NumLegenda = numLegenda;
      this.Partido = partido;
      this.TipoCandidato = tipoCandidato;
    }

    public override string ToString()
    {
      return Nome + " - " + NumLegenda + " - " + Partido.Nome1;
    }
  }
}
