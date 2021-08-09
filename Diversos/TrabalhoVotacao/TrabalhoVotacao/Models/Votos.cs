using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoVotacao.Models
{
  class Votos
  {
    private int quantidadeVotos;
    private int tipoCandidato_Id;
    private string candidato_CPF;
    private bool VotoNulo;
    private bool VotoBranco;

    public Votos() { }
    public Votos(int quantidadeVotos, int tipoCandidato_Id, string candidato_CPF)
    {
      this.quantidadeVotos = quantidadeVotos;
      this.tipoCandidato_Id = tipoCandidato_Id;
      this.candidato_CPF = candidato_CPF;
    }

    public int QuantidadeVotos
    {
      get
      {
        return quantidadeVotos;
      }

      set
      {
        quantidadeVotos = value;
      }
    }

    public int TipoCandidato_Id
    {
      get
      {
        return tipoCandidato_Id;
      }

      set
      {
        tipoCandidato_Id = value;
      }
    }

    public string Candidato_CPF
    {
      get
      {
        return candidato_CPF;
      }

      set
      {
        candidato_CPF = value;
      }
    }

    public bool VotoNulo1
    {
      get
      {
        return VotoNulo;
      }

      set
      {
        VotoNulo = value;
      }
    }

    public bool VotoBranco1
    {
      get
      {
        return VotoBranco;
      }

      set
      {
        VotoBranco = value;
      }
    }
  }
}
