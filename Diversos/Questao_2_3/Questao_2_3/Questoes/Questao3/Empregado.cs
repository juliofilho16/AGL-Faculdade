using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01.Questoes.Questao3
{
  class Empregado : Colaborador
  {
    private string funcao;
    private double salario;
    private string carteira_trabalho;
    private string setor;

    public Empregado(string funcao, double salario, string carteira_trabalho, string setor, string nome, string endereco, string data_inicio, string tele) : base(nome, endereco, data_inicio, tele)
    {
      this.funcao = funcao;
      this.salario = salario;
      this.carteira_trabalho = carteira_trabalho;
      this.setor = setor;
    }

    public double Salario { get { return salario; } set { this.salario = value; } }
    public string Funcao { get { return funcao; } set { this.funcao = value; } }
    public string Carteira_trabalho { get { return carteira_trabalho; } set { this.carteira_trabalho = value; } }
    public string Setor { get { return setor; } set { this.setor = value; } }


    protected override string Data_inicio
    {
      get
      {
        return data_inicio;
      }
    }

    public override void Alocar(string setor, int tipo)
    {
      if ((TipoAlocacao)tipo == TipoAlocacao.setor)
        this.setor = setor;
    }

    public override string ToString()
    {
      return string.Format("Nome: {4} - Endereco {5} - Data_inicio: {6} - Telefone:{7}--- funcao: {0} - salario: {1} - carteira trabalho: {2} - setor {3}",
      funcao,
      salario,
      carteira_trabalho,
      setor
      , Nome
      , Endereco
      , Data_inicio
      , Telefone
      );
    }
  }
}
