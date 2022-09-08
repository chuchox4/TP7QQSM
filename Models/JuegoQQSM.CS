using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System;
using TP7QQSM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace TP7QQSM.Models;

public static class JuegoQQSM
{
    private static int PreguntaActual;
    private static char RespuestaCorrectaActual;
    private static int PosicionPozo;
    private static int PozoAcumuladoSeguro;
    private static int PozoAcumulado;
    private static bool ComodinDobleChance;
    private static bool Comodin5050;
    private static bool ComodinSaltear;
    private static List<Pozo> ListaPozo;
    private static Jugador Player;
    private static string _connectionString = @"Server=A-PHZ2-CIDI-031\SQLEXPRESS;DataBase=JuegoQQSM;Trusted_Connection=True;";
 
 public static void IniciarJuego(string Nombre)
 {
    DateTime FechaHora = DateTime.Now;
    PreguntaActual = 1;
    RespuestaCorrectaActual = '\0';
    PosicionPozo = 0;
    PozoAcumuladoSeguro = 0;
    PozoAcumulado = 0;
    ComodinDobleChance = true;
    Comodin5050 = true;
    ComodinSaltear = true;
    ListaPozo.Add(new Pozo(2000,false));
    ListaPozo.Add(new Pozo(5000,false));
    ListaPozo.Add(new Pozo(10000,true));
    ListaPozo.Add(new Pozo(20000,false));
    ListaPozo.Add(new Pozo(50000,false));
    ListaPozo.Add(new Pozo(100000,true));
    ListaPozo.Add(new Pozo(250000,false));
    ListaPozo.Add(new Pozo(400000,false));
    ListaPozo.Add(new Pozo(500000,false));
    ListaPozo.Add(new Pozo(1000000,true));
    ListaPozo.Add(new Pozo(1250000,false));
    ListaPozo.Add(new Pozo(1500000,false));
    ListaPozo.Add(new Pozo(1750000,false));
    ListaPozo.Add(new Pozo(2000000,true));
    ListaPozo.Add(new Pozo(2500000,false));
    ListaPozo.Add(new Pozo(3000000,true));

    using (SqlConnection db = new SqlConnection(_connectionString)){ 
    string sql = "INSERT INTO Jugadores(Nombre,FechaHora,PozoGanado,ComodinDobleChance,Comodin5050,ComodinSaltear) VALUES(@Nombre,@FechaHora,@PozoGanado,@ComodinDobleChance,@Comodin5050,@ComodinSaltear)";
     db.Execute(sql,new {@Nombre = Nombre,@FechaHora = FechaHora, @PozoGanado = PozoAcumulado ,@ComodinDobleChance = ComodinDobleChance, @Comodin5050 = Comodin5050, @ComodinSaltear = ComodinSaltear });
     Player = new Jugador(0,Nombre,FechaHora,PozoAcumulado,ComodinDobleChance,Comodin5050,ComodinSaltear);
    }
 }
  public static Pregunta ObtenerProximaPregunta()
   {
      PreguntaActual++;
      Pregunta PreguntaAhora = new Pregunta();
      using(SqlConnection db = new SqlConnection(_connectionString)){
         string sql = "SELECT * FROM Preguntas WHERE idPregunta = @PreguntaActual";
         PreguntaAhora = db.QueryFirstOrDefault<Pregunta>(sql, new {@PreguntaActual = PreguntaAhora});
      }
      return PreguntaAhora;
   }
   public static List<Respuesta> ObtenerRespuestas(){
   List<Respuesta> _listaRespuesta = new List<Respuesta>(); 
   using  (SqlConnection db = new SqlConnection(_connectionString)){
      string sql = "SELECT * FROM Respuestas WHERE fkPregunta = @PreguntaActual";
    _listaRespuesta = db.Query<Respuesta>(sql, new{@PreguntaActual = PreguntaActual}).ToList();
   if (_listaRespuesta[PreguntaActual].Correcto == true)
   {
      RespuestaCorrectaActual = _listaRespuesta[PreguntaActual].Correcto;
   }
   }
   return _listaRespuesta;
   }

   public static bool RespuestaUsuario(char Opcion, char OpcionComodin =' ')
   { 
      bool continuar = false;
      if (OpcionComodin != ' ')
      {
         using (SqlConnection db = new SqlConnection(_connectionString)){ 
            string sql = "UPDATE Jugadores SET ComodinDobleChance = false WHERE idJugador = @idJugador";
            db.Execute(sql,new{@idJugador = idJugador});
         }
      }
      if (Opcion == RespuestaCorrectaActual || OpcionComodin == RespuestaCorrectaActual)
      {
         if (ListaPozo[PosicioPozo].ValorSeguro == true)
         {
            PozoAcumuladoSeguro = ListaPozo[PosicionPozo].Importe;
         }
         PosicionPozo ++;
         continuar = true;
      }
      return continuar;
   }
   
   public static List<Pozo> ListarPozo()
   {
      return ListaPozo;
   }

   public static int DevolverPosicionPozo()
   {
      return PosicionPozo;
   }

   public static bool Descartar5050()
   {
      char[] dobleIncorrecta = new char;
      if (Comodin5050 == false)
      {
         using (SqlConnection db = new SqlConnection(_connectionString)){ 
            string sql = "UPDATE Jugadores SET Comodin5050 = false WHERE idJugador = @idJugador";
            db.Execute(sql,new{@idJugador = idJugador});
            string sql = "SELECT TOP 2 OpcionRespuesta FROM Respuestas WHERE Correcto = false"
            dobleIncorrecta.db.Query<Jugador>(sql,new)
      }
   }
}
