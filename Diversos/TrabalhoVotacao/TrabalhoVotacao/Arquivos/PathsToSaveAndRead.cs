using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrabalhoVotacao.Arquivos
{
  static class PathsToSaveAndRead
  {
    private const string PATH_FILE_SYSTEM = @"C:\Users\Julio Cesar\Documents\Julio.C\arquivos\Facul\2 Periodo\POO Pratica\Projestos&Exercicios\TrabalhoVotacao\PATHS\";
    private static string PATH_FILE_ELEITORES = @"Eleitores.xml";
    private static string PATH_FILE_PARTIDOS = @"Partidos.xml";
    private static string PATH_FILE_CANDIDATOS = @"Candidatos.xml";
    private static string PATH_FILE_URNAS = @"Urnas.xml";
    private static string PATH_FILE_VOTOS = @"Votos.xml";

    public static string GET_PATH_FILE_ELEITORES
    {
      get
      {
        return PATH_FILE_SYSTEM + PATH_FILE_ELEITORES;
      }
    }

    public static string GET_PATH_FILE_PARTIDOS
    {
      get
      {
        return PATH_FILE_SYSTEM + PATH_FILE_PARTIDOS;
      }
    }

    public static string GET_PATH_FILE_CANDIDATOS
    {
      get
      {
        return PATH_FILE_SYSTEM + PATH_FILE_CANDIDATOS;
      }
    }

    public static string GETPATH_FILE_URNAS { get { return PATH_FILE_SYSTEM + PATH_FILE_URNAS; } }

    public static string GET_PATH_FILE_VOTOS
    {
      get
      {
        return PATH_FILE_SYSTEM + PATH_FILE_VOTOS;
      }
    }
  }
}
