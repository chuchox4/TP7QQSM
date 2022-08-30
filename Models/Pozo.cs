using System.Security.Cryptography.X509Certificates;
using System;

public class Pozo
{
    private int _Importe;
    private bool _ValorSeguro;

public Pozo(int Importe,bool ValorSeguro)
{
  _Importe = Importe;
  _ValorSeguro = ValorSeguro;
}
public Pozo()
{

}

public int Importe
{
    set{_Importe = value;}
}

public bool ValorSeguro
{
    set{_ValorSeguro = value;}
}

}

