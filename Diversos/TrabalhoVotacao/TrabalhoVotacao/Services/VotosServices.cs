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
using TrabalhoVotacao.Services;
using static TrabalhoVotacao.Models.Enums;

namespace TrabalhoVotos.Services
{
  class VotosServices
  {
    private string strPathFile = PathsToSaveAndRead.GET_PATH_FILE_VOTOS;
    private List<Candidato> listCandidatos = new CandidatosServices().GetListCandidatos();


    public void ControladorVotos(Candidato candidatoVotado)
    {
      ProcessaValidacao(candidatoVotado);
    }
    public void AddVotoNull(TipoCandidatosEnum TipoCandidatosEnum)
    {
      Votos Votos = new Votos();
      Votos.VotoNulo1 = true;
      Votos.TipoCandidato_Id = (int)TipoCandidatosEnum;
      ProcessaNulosANDBrancos(Votos);
    }
    public void AddVotoBranco(TipoCandidatosEnum TipoCandidatosEnum)
    {
      Votos Votos = new Votos();
      Votos.VotoBranco1 = true;
      Votos.TipoCandidato_Id = (int)TipoCandidatosEnum;
      ProcessaNulosANDBrancos(Votos);
    }

    private void AddInXML(Votos Votos)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(strPathFile);

      XmlNode Votoss = doc.DocumentElement;
      XmlElement novoVotos = doc.CreateElement("Candidato");

      XmlAttribute attrIdCandidato = doc.CreateAttribute("TIPOCANDIDATO");
      attrIdCandidato.InnerText = Votos.TipoCandidato_Id.ToString();

      XmlAttribute attrCANDIDATO = doc.CreateAttribute("CANDIDATO");
      attrCANDIDATO.InnerText = Votos.Candidato_CPF;

      XmlAttribute attrVotos = doc.CreateAttribute("VOTOSRECEBIDOS");
      attrVotos.InnerText = Votos.QuantidadeVotos.ToString();

      XmlAttribute attrVotoNulo = doc.CreateAttribute("VOTONULO");
      attrVotoNulo.InnerText = Votos.VotoNulo1.ToString();

      XmlAttribute attrVotoBranco = doc.CreateAttribute("VOTOBRANCO");
      attrVotoBranco.InnerText = Votos.VotoBranco1.ToString();

      novoVotos.Attributes.Append(attrIdCandidato);
      novoVotos.Attributes.Append(attrCANDIDATO);
      novoVotos.Attributes.Append(attrVotos);
      novoVotos.Attributes.Append(attrVotoNulo);
      novoVotos.Attributes.Append(attrVotoBranco);

      Votoss.AppendChild(novoVotos);
      doc.Save(strPathFile);
    }

    private void ProcessaValidacao(Candidato candidato)
    {
      Votos VotosObj = new Votos();
      VotosObj.Candidato_CPF = candidato.CPF1;
      VotosObj.TipoCandidato_Id = candidato.TipoCandidato1.Id1;
      VotosObj.VotoBranco1 = false;
      VotosObj.VotoNulo1 = false;

      XmlDocument doc = new XmlDocument();
      doc.Load(PathsToSaveAndRead.GET_PATH_FILE_VOTOS);

      XmlNode Votoss = doc.DocumentElement;
      XmlNodeList listVotoss = Votoss.ChildNodes;

      List<Votos> VotosExistentes = GetListVotos();

      if (Votoss.ChildNodes.Count == 0 || VotosExistentes.Where(a => a.Candidato_CPF.Equals(candidato.CPF1)).Count() == 0)
      {
        VotosObj.QuantidadeVotos = 1;
        AddInXML(VotosObj);
      }
      else
      {
        foreach (XmlNode voto in listVotoss)
        {
          string AttrCPF = voto.Attributes.GetNamedItem("CANDIDATO").Value;
          int AttrVotos = int.Parse(voto.Attributes.GetNamedItem("VOTOSRECEBIDOS").Value);

          if (AttrCPF != null && AttrCPF.Equals(VotosObj.Candidato_CPF))
          {
            AttrVotos += 1;
            voto.Attributes.GetNamedItem("VOTOSRECEBIDOS").Value = AttrVotos.ToString();
            doc.Save(strPathFile);
          }
        }
      }
    }

    private void ProcessaNulosANDBrancos(Votos VotosObj)
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(PathsToSaveAndRead.GET_PATH_FILE_VOTOS);

      XmlNode Votoss = doc.DocumentElement;
      XmlNodeList listVotoss = Votoss.ChildNodes;

      List<Votos> VotosExistentes = GetListVotos();

      if (Votoss.ChildNodes.Count == 0 || (VotosObj.VotoBranco1 && VotosExistentes.Where(a => a.VotoBranco1 && a.TipoCandidato_Id == VotosObj.TipoCandidato_Id).Count() == 0)
        || (VotosObj.VotoNulo1 && VotosExistentes.Where(a => a.VotoNulo1 && a.TipoCandidato_Id == VotosObj.TipoCandidato_Id).Count() == 0))
      {
        VotosObj.QuantidadeVotos = 1;
        AddInXML(VotosObj);
      }
      else
      {
        foreach (XmlNode voto in listVotoss)
        {
          bool AttrVOTONULO = bool.Parse(voto.Attributes.GetNamedItem("VOTONULO").Value);
          bool AttrVOTOBRANCO = bool.Parse(voto.Attributes.GetNamedItem("VOTOBRANCO").Value);
          int AttrVotos = int.Parse(voto.Attributes.GetNamedItem("VOTOSRECEBIDOS").Value);

          if (AttrVOTOBRANCO && VotosObj.VotoBranco1)
          {
            AttrVotos += 1;
            voto.Attributes.GetNamedItem("VOTOSRECEBIDOS").Value = AttrVotos.ToString();
          }

          if (AttrVOTONULO && VotosObj.VotoNulo1)
          {
            AttrVotos += 1;
            voto.Attributes.GetNamedItem("VOTOSRECEBIDOS").Value = AttrVotos.ToString();
          }

          doc.Save(strPathFile);
        }
      }
    }

    private List<Votos> GetListVotos()
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(PathsToSaveAndRead.GET_PATH_FILE_VOTOS);

      XmlNode Votos = doc.DocumentElement;
      XmlNodeList listVotos = Votos.ChildNodes;

      List<Votos> ListaVotos = new List<Votos>(); ;

      foreach (XmlNode votos in listVotos)
      {
        XmlNodeList listPropriedades = votos.ChildNodes;

        Votos votoObj = new Votos();

        XmlNode AttrCPF = votos.Attributes.GetNamedItem("CANDIDATO");
        XmlNode AttrVotos = votos.Attributes.GetNamedItem("VOTOSRECEBIDOS");
        XmlNode AttrTIPOCANDIDATO = votos.Attributes.GetNamedItem("TIPOCANDIDATO");
        XmlNode AttrVotoNulo = votos.Attributes.GetNamedItem("VOTONULO");
        XmlNode AttrVotoBranco = votos.Attributes.GetNamedItem("VOTOBRANCO");
        votoObj.Candidato_CPF = AttrCPF.Value;
        votoObj.QuantidadeVotos = int.Parse(AttrVotos.Value);
        votoObj.TipoCandidato_Id = int.Parse(AttrTIPOCANDIDATO.Value);
        votoObj.VotoNulo1 = bool.Parse(AttrVotoNulo.Value);
        votoObj.VotoBranco1 = bool.Parse(AttrVotoBranco.Value);

        ListaVotos.Add(votoObj);
      }
      return ListaVotos;
    }

    private List<Votos> GetVotosPrefeito()
    {
      List<Votos> votos = GetListVotos();
      return votos.Where(a => a.TipoCandidato_Id == (int)TipoCandidatosEnum.Prefeito).ToList();
    }

    public int VotosValidosExecutivo()
    {
      List<Votos> votos = GetListVotos();
      return votos.Where(a => a.TipoCandidato_Id == (int)TipoCandidatosEnum.Presidente && (!a.VotoNulo1 && !a.VotoBranco1)).Count();
    }

    public int VotosValidosLegislativo()
    {
      List<Votos> votos = GetListVotos();
      return votos.Where(a => !a.VotoNulo1 && !a.VotoBranco1 && (a.TipoCandidato_Id == (int)TipoCandidatosEnum.Vereador || a.TipoCandidato_Id == (int)TipoCandidatosEnum.Presidente)).Count();
    }


    public int VotosNulosExecutivo()
    {
      List<Votos> votos = GetListVotos();
      return votos.Where(a => a.TipoCandidato_Id == (int)TipoCandidatosEnum.Presidente && a.VotoNulo1).Count();
    }

    public int VotosNulosLegislativo()
    {
      List<Votos> votos = GetListVotos();
      return votos.Where(a => a.VotoNulo1 && (a.TipoCandidato_Id == (int)TipoCandidatosEnum.Vereador || a.TipoCandidato_Id == (int)TipoCandidatosEnum.Presidente)).Count();
    }

    public int VotosBrancosExecutivo()
    {
      List<Votos> votos = GetListVotos();
      return votos.Where(a => a.TipoCandidato_Id == (int)TipoCandidatosEnum.Presidente && a.VotoBranco1).Count();
    }

    public int VotosBrancosLegislativo()
    {
      List<Votos> votos = GetListVotos();
      return votos.Where(a => a.VotoBranco1 && (a.TipoCandidato_Id == (int)TipoCandidatosEnum.Vereador || a.TipoCandidato_Id == (int)TipoCandidatosEnum.Presidente)).Count();
    }


    private List<Votos> GetVotosPresidente()
    {
      List<Votos> votos = GetListVotos();
      return votos.Where(a => a.TipoCandidato_Id == (int)TipoCandidatosEnum.Presidente).ToList();
    }

    private List<Votos> GetVotosVereadores()
    {
      List<Votos> votos = GetListVotos();
      return votos.Where(a => a.TipoCandidato_Id == (int)TipoCandidatosEnum.Vereador).ToList();
    }

    public Candidato GetPresidenteVencedor()
    {
      List<Votos> votosPresidente = GetVotosPresidente();

      if (votosPresidente == null || votosPresidente.Count() == 0)
        return null;

      Votos VotoGanhador = new Votos();
      int totalVotos = 0;
      foreach (Votos item in votosPresidente)
      {
        totalVotos += item.QuantidadeVotos;

        if (VotoGanhador == null || VotoGanhador.Candidato_CPF == null)
          VotoGanhador = item;

        if (item.QuantidadeVotos > VotoGanhador.QuantidadeVotos)
          VotoGanhador = item;
      }

      Candidato vencedor = listCandidatos.Where(a => a.CPF1.Equals(VotoGanhador.Candidato_CPF)).FirstOrDefault();
      return vencedor;
    }

    public Candidato GetPrefeitoVencedor()
    {
      List<Votos> votosPrefeito = GetVotosPrefeito();

      if (votosPrefeito == null || votosPrefeito.Count() == 0)
        return null;

      Votos VotoGanhador = new Votos();
      int totalVotos = 0;
      foreach (Votos item in votosPrefeito)
      {
        totalVotos += item.QuantidadeVotos;

        if (VotoGanhador == null || VotoGanhador.Candidato_CPF == null)
          VotoGanhador = item;

        if (item.QuantidadeVotos > VotoGanhador.QuantidadeVotos)
          VotoGanhador = item;
      }

      Candidato vencedor = listCandidatos.Where(a => a.CPF1.Equals(VotoGanhador.Candidato_CPF)).FirstOrDefault();
      return vencedor;
    }

    public Candidato GetVereadorVencedor()
    {
      List<Votos> votosVereador = GetVotosVereadores();

      if (votosVereador == null || votosVereador.Count() == 0)
        return null;

      Votos VotoGanhador = new Votos();
      int totalVotos = 0;
      foreach (Votos item in votosVereador)
      {
        totalVotos += item.QuantidadeVotos;

        if (VotoGanhador == null || VotoGanhador.Candidato_CPF == null)
          VotoGanhador = item;

        if (item.QuantidadeVotos > VotoGanhador.QuantidadeVotos)
          VotoGanhador = item;
      }


      Candidato vencedor = listCandidatos.Where(a => a.CPF1.Equals(VotoGanhador.Candidato_CPF)).FirstOrDefault();
      return vencedor;
    }

  }
}
