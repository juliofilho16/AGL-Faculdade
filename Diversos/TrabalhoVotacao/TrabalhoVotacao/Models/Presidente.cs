using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoVotacao.Models;
using TrabalhoVotacao.Models.Candidatos;

namespace TrabalhoVotacao.Candidatos.Executivo
{
  public class Presidente:Candidato
  {
    public Presidente(string nome, string CPF, int numLegenda, Partido partido, TipoCandidato tipoCandidato) : base(nome, CPF, numLegenda, partido, tipoCandidato) { }

  }
}
