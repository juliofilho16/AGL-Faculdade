using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TrabalhoVotacao.Arquivos;
using TrabalhoVotacao.Interfaces;
using TrabalhoVotacao.Models;

namespace TrabalhoVotacao.Services
{
  class UrnaEletronicaServices 
  {
    public void Create(UrnaEletronica UrnaEletronica)
    {
        ValidaUrnaEletronica(UrnaEletronica);
        AddInXML(UrnaEletronica, PathsToSaveAndRead.GETPATH_FILE_URNAS);
    }

    private void ValidaUrnaEletronica(UrnaEletronica UrnaEletronica)
    {
      if (UrnaEletronica.Secao.Trim().Length < 1)
        throw new ArgumentException("Zona informada incorretamente.");

      if (UrnaEletronica.Secao.Trim().Length < 1)
        throw new ArgumentException("Seção informada incorretamente.");
    }

    private void AddInXML(UrnaEletronica UrnaEletronica, string strPathFile)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(strPathFile);

      XmlNode UrnaEletronicas = doc.DocumentElement;
      XmlElement novoUrnaEletronica = doc.CreateElement("UrnaEletronica");

      XmlElement Zona = doc.CreateElement("Zona");
      Zona.InnerText = UrnaEletronica.Zona;

      XmlElement Secao = doc.CreateElement("Secao");
      Secao.InnerText = UrnaEletronica.Secao;

      XmlAttribute attr = doc.CreateAttribute("Id");
      attr.InnerText = UrnaEletronica.Zona;

      novoUrnaEletronica.AppendChild(Zona);
      novoUrnaEletronica.AppendChild(Secao);
      novoUrnaEletronica.Attributes.Append(attr);

      UrnaEletronicas.AppendChild(novoUrnaEletronica);
      doc.Save(strPathFile);
    }

  }
}
