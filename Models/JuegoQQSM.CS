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
using Dapper;

namespace TP7QQSM.Models;

public static class JuegoQQSM
{
    private int PreguntaActual;
    private char RespuestaCorrectaActual;
    private int PosicionPozo;
    private int PozoAcumuladoSeguro;
    private int PozoAcumulado;
    private bool ComodinDobleChance;
    private bool Comodin5050;
    private bool ComodinSaltearPregunta;
    private List<Pozo> ListaPozo;
    private Jugador Player;
    private static string _connectionString = @"Server=A-PHZ2-CIDI-03\SQLEXPRESS;DataBase=JuegoQQSM;Trusted_Connection=True;";
 
 public static void IniciarJuego(string Nombre)
 {
    DateTime FechaHora = DateTime.Now;
    PreguntaActual = 1;
    RespuestaCorrectaActual = " ";
    PosicionPozo = 0;
    PozoAcumuladoSeguro = 0;
    PozoAcumulado = 0;
    ComodinDobleChance = true;
    Comodin5050 = true;
    ComodinSaltearPregunta = true;
    ListaPozo.Add(new Pozo(2000,false))
    ListaPozo.Add(new Pozo(5000,false))
    ListaPozo.Add(new Pozo(10000,true))
    ListaPozo.Add(new Pozo(20000,false))
    ListaPozo.Add(new Pozo(50000,false))
    ListaPozo.Add(new Pozo(100000,true))
    ListaPozo.Add(new Pozo(250000,false))
    ListaPozo.Add(new Pozo(400000,false))
    ListaPozo.Add(new Pozo(500000,false))
    ListaPozo.Add(new Pozo(1000000,true))
    ListaPozo.Add(new Pozo(1250000,false))
    ListaPozo.Add(new Pozo(1500000,false))
    ListaPozo.Add(new Pozo(1750000,false))
    ListaPozo.Add(new Pozo(2000000,true))
    ListaPozo.Add(new Pozo(2500000,false))
    ListaPozo.Add(new Pozo(3000000,true))

    using (SQLConnection db = new SQLConnection(_connectionString)){ 
    string SQL = "INSERT INTO Jugadores(Nombre,FechaHora,PozoGanado,ComodinDobleChance,Comodin5050,ComodinSaltear) VALUES(@pNombre,@pFechaHora,@pPozoGanado,p@ComodinDobleChance,p@Comodin5050,p@ComodinSaltear)";
     db.Execute(SQL)
    }
 }

}
