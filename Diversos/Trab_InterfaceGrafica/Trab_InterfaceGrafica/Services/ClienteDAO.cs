using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trab_InterfaceGrafica.Objetos;
using System.Xml;
using Trab_InterfaceGrafica.Interface;
using System.Data;

namespace Trab_InterfaceGrafica.Services
{
  class ClienteDAO : IRead
  {
    public void Criar(Cliente Cliente, string strPathFile)
    {
      try
      {
        ValidaCliente(Cliente);
        AddClienteXML(Cliente, strPathFile);

        MessageBox.Show("Cliente criado com sucesso!");      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }
    
    private void ValidaCliente(Cliente Cliente)
    {
      if (Cliente.Nome.Trim().Length < 1)
        throw new Exception("Favor Inserir o Nome do cliente.");

      if (Cliente.Email.Trim().Length < 1)
        throw new Exception("Favor Inserir o Email do cliente.");
    }

    private void AddClienteXML(Cliente Cliente, string strPathFile)
    {

      XmlDocument doc = new XmlDocument();
      doc.Load(strPathFile);

      XmlNode Clientes = doc.DocumentElement;

      XmlElement novoCliente = doc.CreateElement("Cliente");
      XmlElement Nome = doc.CreateElement("Nome");
      Nome.InnerText = Cliente.Nome;
      XmlElement Email = doc.CreateElement("Email");
      Email.InnerText = Cliente.Email;
      novoCliente.AppendChild(Nome);
      novoCliente.AppendChild(Email);
      Clientes.AppendChild(novoCliente);
      doc.Save(strPathFile);
    }

    public void LerDadosCadastrados(string path)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(path);

      XmlNode Clientes = doc.DocumentElement;
      XmlNodeList listClientes = Clientes.ChildNodes;
      StringBuilder result = new StringBuilder();
      result.AppendLine("Clientes Cadastrados: ");
      foreach (XmlNode cliente in listClientes)
      {
        XmlNodeList listPropriedades = cliente.ChildNodes;
        foreach (XmlNode item in listPropriedades)
          if (item.Name.Equals("Nome"))
            result.AppendLine(item.InnerText);

      }

      MessageBox.Show(result.ToString());
    }

  }
}
