using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System;

public static class JuegoQQSM
{
    private int PreguntaActual
    private char RespuestaCorrectaActual
    private int PosicionPozo
    private int PozoAcumuladoSeguro
    private int PozoAcumulado
    private bool Comodin5050
    private bool ComodinDobleChance
    private bool ComodinSaltearPregunta
    private List<Pozo> ListaPozo  
}

public JuegoQQSM(int PreguntaActual, char RespuestaCorrectaActual, int PosicionPozo, int PozoAcumuladoSeguro, int PozoAcumulado , bool Comodin5050, bool ComodinDobleChance, bool ComodinSaltearPregunta,list<Pozo> ListaPozo )
{
    _PreguntaActual = PreguntaActual;
    _RespuestaCorrectaActual = RespuestaCorrectaActual;
    _PosicionPozo = PosicionPozo;
    _PozoAcumuladoSeguro = PozoAcumuladoSeguro;
    _PozoAcumulado = PozoAcumulado;
    _Comodin5050 = Comodin5050;
    _ComodinDobleChance = ComodinDobleChance;
    _ComodinSaltearPregunta = ComodinSaltearPregunta;
}

private int PreguntaActual{
    get{return _PreguntaActual;}
}

private char RespuestaCorrectaActual{
    get{return _RespuestaCorrectaActual;}
}

private int PosicionPozo{
    get{return _PosicionPozo;}
}

private int PozoAcumuladoSeguro{
    get{return _PozoAcumuladoSeguro;}
}

private int PozoAcumulado{
    get{return _PozoAcumulado;}
}

private bool Comodin5050{
    get{return _Comodin5050;}
}
private bool ComodinDobleChance{
    get{return _ComodinDobleChance;}
}
private bool ComodinSaltearPregunta{
    get{return _ComodinSaltearPregunta;}
}

