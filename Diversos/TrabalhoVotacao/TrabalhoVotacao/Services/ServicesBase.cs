using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoVotacao.Services
{
  public abstract class ServicesBase
  {
    public abstract void Create(); 
    protected abstract void ValidaModel(); 
    protected abstract void AddInXML();
  }
}
