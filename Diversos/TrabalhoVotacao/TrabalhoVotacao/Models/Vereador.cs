using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoVotacao.Models.Candidatos;
using TrabalhoVotacao.Models;

namespace TrabalhoVotacao.Candidatos.Legislativo
{
 public class Vereador : Candidato
  {
    public Vereador(string nome, string CPF, int numLegenda, Partido partido, TipoCandidato tipoCandidato) : base(nome, CPF, numLegenda, partido, tipoCandidato) { }
  }
}
