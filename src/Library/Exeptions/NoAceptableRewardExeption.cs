using System;
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir una nueva excepcion.

    OCP: No se aplica.

    LSP: Esta clase cumple LSP ya que al ser del tipo Exeption puede ser, por ejemplo, contenida en una lista que alvergue Objetos del tipo Exeption.

    ISP: No se aplica.
    
    DIP: No se aplica.

    EXPERT: No se aplica.

    POLYMORPHISM: No se aplica.

    CREATOR: No se aplica. 

    LEY DE DEMETER: No se aplica.

    COHESION: La cohesion de esta clase es ALTA ya que solo existe para definir un tipo de excepcion-
*/

namespace Library
{
    [Serializable]
    public class NoAceptableRewardExeption : Exception
    {
    }
}