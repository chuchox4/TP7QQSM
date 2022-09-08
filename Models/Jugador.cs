using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System;

public class Jugador
{
    public int _idJugador{get; set;}
    public string _Nombre{get; set;}
    public DateTime _FechaHora{get; set;}
    public int _PozoGanado{get; set;}
    public bool _ComodinDobleChance{get; set;}
    public bool _Comodin5050{get; set;}
    public bool _ComodinSaltear{get; set;}


public Jugador(int idJugador, string Nombre, DateTime FechaHora, int PozoGanado, bool ComodinDobleChance, bool Comodin5050, bool ComodinSaltear)
{
  _idJugador = idJugador;
  _Nombre = Nombre;
  _FechaHora = FechaHora;
  _PozoGanado = PozoGanado;
  _ComodinDobleChance = ComodinDobleChance;
  _Comodin5050 = Comodin5050;
  _ComodinSaltear = ComodinSaltear;
}
public Jugador()
{

}
}
