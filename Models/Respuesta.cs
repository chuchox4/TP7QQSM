using System.Reflection.Metadata;
using System;

public class Respuesta{
    private int _fkPregunta;

    private char _OpcionRespuesta;

    private string _TextoRespuesta;

    private bool _Correcto;

public Respuesta (int fkPregunta, char OpcionRespuesta, string TextoRespuesta, bool Correcto){
    _fkPregunta = fkPregunta;
    _OpcionRespuesta = OpcionRespuesta;
    _TextoRespuesta = TextoRespuesta;
    _Correcto = Correcto;
}
   public Respuesta()
    {

    }
    public int fkPregunta
    {
        set{_fkPregunta = value;}
    }
     public char OpcionRespuesta
    {
        get{return _OpcionRespuesta;}
    }
     public string TextoRespuesta
    {
        set{_TextoRespuesta = value;}
    }
     public bool Correcto
    {
        get{return _Correcto;}
        set{_Correcto = value;}
    }

} 


 