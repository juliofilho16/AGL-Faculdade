using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01.Questoes.Questao3
{
  enum TipoAlocacao { tarefa = 1, setor = 2 }

  public abstract class Colaborador
  {

    protected string data_inicio;
    protected Contato contato;

    protected Colaborador(string nome, string endereco, string data_inicio, string telefone)
    {
      this.data_inicio = data_inicio;
      this.contato = new Contato(nome, endereco, telefone);
    }

    protected string Nome { get { return contato.Nome; } }
    protected string Endereco { get { return contato.Endereco; } }
    protected string Telefone { get { return contato.Telefone; } }

    //Metodos de leitura
    protected abstract string Data_inicio { get; }

    public abstract void Alocar(string valor, int TipoAlocacao);

  }
}
