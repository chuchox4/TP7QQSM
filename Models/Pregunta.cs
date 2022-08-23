using System.Security.Cryptography.X509Certificates;
using System;

public class Pregunta
{
    private int _IdRespuesta;
    private string _pregunta;

    private int _nivelDificultad;


public Pregunta(int IdRespuesta,string pregunta, int nivelDificultad)
{
  _IdRespuesta = IdRespuesta;
  _pregunta = pregunta;
  _nivelDificultad = nivelDificultad;
}
public Pregunta()
{

}
public int IdRespuesta
{
    set{_IdRespuesta = value;}
}
public string pregunta
{
    set{ _pregunta = value;}
}
public int nivelDificultad
{
    set{ _nivelDificultad = value;}
}
}



