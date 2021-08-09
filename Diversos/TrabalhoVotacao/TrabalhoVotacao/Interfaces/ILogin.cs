using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoVotacao.Models;

namespace TrabalhoVotacao.Interfaces
{
  interface ILogin
  {
    Eleitor Login(string titulo);
  }
}
