using System;
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir una nueva excepcion.

    OCP: No se aplica.

    LSP: Esta clase cumple LSP ya que al ser del tipo Exeption puede ser, por ejemplo, contenida en una lista que alvergue Objetos del tipo Exeption.

    DIP: No se aplica.
*/
namespace Library
{
    [Serializable]
    public class IsNotAvailableException : Exception
    {
    }
}