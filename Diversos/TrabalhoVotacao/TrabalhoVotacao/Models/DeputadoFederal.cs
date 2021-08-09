using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoVotacao.Models.Candidatos
{
  class DeputadoFederal:Candidato
  {
    public DeputadoFederal(string nome, string CPF, int numLegenda, Partido partido, TipoCandidato tipoCandidato) : base(nome, CPF, numLegenda, partido, tipoCandidato) { }
  }
}
