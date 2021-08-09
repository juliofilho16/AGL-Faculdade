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
using TrabalhoVotacao.Models.Candidatos;

namespace TrabalhoVotacao.Services
{
  class CandidatosServices: ICadastro
  {
    private Candidato Candidato;
    public Candidato SetCandidato
    {
      set
      {
        Candidato = value;
      }
    }

    public void Create()
    {
      ValidaModel();
      AddInXML(Candidato, PathsToSaveAndRead.GET_PATH_FILE_CANDIDATOS);
    }

    private void ValidaModel()
    {
      if (Candidato.Nome1.Trim().Length < 1)
        throw new ArgumentException("Favor Inserir o Nome do Partido.");

      if (Candidato.CPF1.Trim().Length < 1)
        throw new ArgumentException("Favor Inserir a sigla do Partido.");

      if (Candidato.NumLegenda1 < 1)
        throw new ArgumentException("Favor inserir um número válido para o Partido.");

    }

    private void AddInXML(Candidato Candidato, string strPathFile)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(strPathFile);

      XmlNode Candidatos = doc.DocumentElement;

      XmlElement novoCandidato = doc.CreateElement("Candidato");

      XmlAttribute attr = doc.CreateAttribute("Id");
      attr.InnerText = Candidato.CPF1;

      XmlAttribute attrTipo = doc.CreateAttribute("TipoCandidato_Id");
      attrTipo.InnerText = Candidato.TipoCandidato1.Id1.ToString();

      XmlElement Nome = doc.CreateElement("Nome");
      Nome.InnerText = Candidato.Nome1;

      XmlElement NumLegenda = doc.CreateElement("NumLegenda");
      NumLegenda.InnerText = Candidato.NumLegenda1.ToString();

      XmlElement CPF = doc.CreateElement("CPF");
      CPF.InnerText = Candidato.CPF1;

      XmlElement novoPartido = doc.CreateElement("Partido");
      XmlElement NomePartido = doc.CreateElement("Nome");
      NomePartido.InnerText = Candidato.Partido1.Nome1;
      XmlElement NumLegendaPartido = doc.CreateElement("NumLegenda");
      NumLegendaPartido.InnerText = Candidato.Partido1.NumLegenda1.ToString();
      XmlElement Sigla = doc.CreateElement("Sigla");
      Sigla.InnerText = Candidato.Partido1.Sigla1;

      XmlElement novoTipoCandidato = doc.CreateElement("TipoCandidato");
      XmlElement IdTipoCandidato = doc.CreateElement("Id");
      IdTipoCandidato.InnerText = Candidato.TipoCandidato1.Id1.ToString();
      XmlElement Descricao = doc.CreateElement("Descricao");
      Descricao.InnerText = Candidato.TipoCandidato1.Descricao1;

      novoCandidato.AppendChild(Nome);
      novoCandidato.AppendChild(NumLegenda);
      novoCandidato.AppendChild(CPF);
      novoCandidato.Attributes.Append(attr);
      novoCandidato.Attributes.Append(attrTipo);

      novoPartido.AppendChild(NomePartido);
      novoPartido.AppendChild(NumLegendaPartido);
      novoPartido.AppendChild(Sigla);

      novoTipoCandidato.AppendChild(IdTipoCandidato);
      novoTipoCandidato.AppendChild(Descricao);

      novoCandidato.AppendChild(novoPartido);
      novoCandidato.AppendChild(novoTipoCandidato);
      Candidatos.AppendChild(novoCandidato);
      doc.Save(strPathFile);
    }

    public List<Candidato> GetListCandidatos()
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(PathsToSaveAndRead.GET_PATH_FILE_CANDIDATOS);

      XmlNode Candidatos = doc.DocumentElement;
      XmlNodeList listCandidatos = Candidatos.ChildNodes;

      List<Candidato> ListaCandidatos = new List<Candidato>(); ;
      Candidato CandidatoObj = null;
    
      foreach (XmlNode Candidato in listCandidatos)
      {
        CandidatoObj = new Candidato();
        XmlNodeList listPropriedades = Candidato.ChildNodes;

        foreach (XmlNode item in listPropriedades)
        {
          Partido partidoObj = new Partido();
          TipoCandidato TipoCandidato = new TipoCandidato();
          if (item.Name.Equals("Nome"))
            CandidatoObj.Nome1 = item.InnerText;
          else if (item.Name.Equals("NumLegenda"))
            CandidatoObj.NumLegenda1 = int.Parse(item.InnerText);
          else if (item.Name.Equals("CPF"))
            CandidatoObj.CPF1 = item.InnerText;
          else if (item.Name.Equals("Partido"))
          {
            XmlNodeList PropsPartido = item.ChildNodes;
            foreach (XmlNode partido in PropsPartido)
              if (partido.Name.Equals("Nome"))
                partidoObj.Nome1 = partido.InnerText;
              else if (partido.Name.Equals("NumLegenda"))
                partidoObj.NumLegenda1 = int.Parse(partido.InnerText);
              else if (partido.Name.Equals("Sigla"))
                partidoObj.Sigla1 = partido.InnerText;

            CandidatoObj.Partido1 = partidoObj;
          }
          else if (item.Name.Equals("TipoCandidato"))
          {
            XmlNodeList PropsTipoCand = item.ChildNodes;
            foreach (XmlNode tipo in PropsTipoCand)
              if (tipo.Name.Equals("Id"))
                TipoCandidato.Id1 = int.Parse(tipo.InnerText);
              else
                TipoCandidato.Descricao1 = tipo.InnerText;

            CandidatoObj.TipoCandidato1 = TipoCandidato;
          }
        }
         
        ListaCandidatos.Add(CandidatoObj);
      }
      return ListaCandidatos;
    }

  }
}
