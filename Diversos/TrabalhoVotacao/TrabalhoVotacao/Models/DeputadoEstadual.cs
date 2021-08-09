using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoVotacao.Models.Candidatos;

namespace TrabalhoVotacao.Models.Candidatos
{
  class DeputadoEstadual:Candidato
  {
    public DeputadoEstadual(string nome, string CPF, int numLegenda, Partido partido, TipoCandidato tipoCandidato) : base(nome, CPF, numLegenda, partido, tipoCandidato) { }
  }
}
