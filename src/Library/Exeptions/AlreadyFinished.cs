using System;
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir una nueva excepcion.

    OCP: No se aplica.

    DIP: No se aplica.
*/
namespace Library
{
    [Serializable]
    public class AlreadyFinishedException : Exception
    {
    }
}